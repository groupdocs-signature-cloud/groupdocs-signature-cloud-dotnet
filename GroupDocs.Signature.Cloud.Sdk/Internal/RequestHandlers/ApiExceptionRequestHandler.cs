// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ApiExceptionRequestHandler.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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

namespace GroupDocs.Signature.Cloud.Sdk.Internal.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;
    using GroupDocs.Signature.Cloud.Sdk.Api;

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
            Exception resutException;
            try
            {
                resultStream.Position = 0;
                using (var responseReader = new StreamReader(resultStream))
                {
                    var responseData = responseReader.ReadToEnd();
                    var errorResponse = (ApiErrorResponse)SerializationHelper.Deserialize(responseData, typeof(ApiErrorResponse));
                    if (errorResponse == null)
                    {
                        errorResponse = new ApiErrorResponse { Error = new Error() };
                    }

                    if (errorResponse.Error == null)
                    {
                        errorResponse.Error = new Error();
                    }

                    if (string.IsNullOrEmpty(errorResponse.Error.Message))
                    {
                        errorResponse.Error.Message = responseData;
                    }

                    resutException = new ApiException((int)webResponse.StatusCode, errorResponse.Error.Message);
                }
            }
            catch (Exception ex)
            {
                throw new ApiException((int)webResponse.StatusCode, webResponse.StatusDescription);
            }

            throw resutException;
        }
    }
}