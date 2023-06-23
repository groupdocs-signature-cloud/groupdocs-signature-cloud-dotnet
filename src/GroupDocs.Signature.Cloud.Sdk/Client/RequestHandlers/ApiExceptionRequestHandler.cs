// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ApiExceptionRequestHandler.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Signature.Cloud.Sdk.Client.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;

    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        private string method;

        public string ProcessUrl(string url)
        {
            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            this.method = request.Method;
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (this.method == "DELETE" && response.StatusCode == HttpStatusCode.NoContent)
            {
                return;
            }

            if (this.method == "POST" && response.StatusCode == HttpStatusCode.Created)
            {
                return;
            }

            if (this.method == "PUT" && response.StatusCode == HttpStatusCode.Created)
            {
                return;
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                this.ThrowApiException(response, resultStream);
            }
        }

        private void ThrowApiException(HttpWebResponse webResponse, Stream resultStream)
        {
            int statusCode = (int)webResponse.StatusCode;

            try
            {
                resultStream.Position = 0;
                using (var responseReader = new StreamReader(resultStream))
                {
                    var responseData = responseReader.ReadToEnd();

                    if (SerializationHelper
                        .Deserialize(responseData, typeof(AuthErrorResponse)) is AuthErrorResponse authErrorResponse && authErrorResponse.ErrorMessage != null)
                    {
                        throw new ApiException(statusCode, authErrorResponse.ErrorMessage);
                    }
                    
                    if (SerializationHelper
                        .Deserialize(responseData, typeof(ApiErrorResponse)) is ApiErrorResponse apiErrorResponse && apiErrorResponse.Error != null)
                    {
                        throw new ApiException(statusCode, apiErrorResponse.Error.Message);
                    }

                    if (SerializationHelper
                        .Deserialize(responseData, typeof(Error)) is Error apiError)
                    {
                        throw new ApiException(statusCode, apiError.Message);
                    }
                }

                throw new ApiException(statusCode, webResponse.StatusDescription);
            }
            finally
            {
                webResponse.Close();
            }
        }
    }
}