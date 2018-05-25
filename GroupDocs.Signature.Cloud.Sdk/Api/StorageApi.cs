// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="StorageApi.cs">
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

namespace GroupDocs.Signature.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using GroupDocs.Signature.Cloud.Sdk.Internal;
    using GroupDocs.Signature.Cloud.Sdk.Internal.RequestHandlers;
    using GroupDocs.Signature.Cloud.Sdk.Model.Responses;

    /// <summary>
    /// Storage API
    /// </summary>
    public class StorageApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public StorageApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public StorageApi(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }

        /// <summary>
        /// Creates file.
        /// </summary>        
        /// <param name="fileName">The file name.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="bytes">Bytes.</param>
        /// <returns>The response message.</returns>
        public ResponseMessage CreateFile(string fileName, string folder, byte[] bytes)
        {
            var resourcePath = string.IsNullOrEmpty(folder) ?
              string.Format("{0}/storage/file/{1}", this.configuration.GetApiRootUrl(), fileName) :
              string.Format("{0}/storage/file/{1}/{2}", this.configuration.GetApiRootUrl(), folder, fileName);

            var formParams = new Dictionary<string, object>();

            formParams.Add("file", bytes);

            var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    null,
                    null,
                    formParams);

            try
            {
                if (response != null)
                {
                    return (ResponseMessage)SerializationHelper.Deserialize(response, typeof(ResponseMessage));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Creates folder.
        /// </summary>
        /// <param name="folder">Folder.</param>
        /// <returns>Message</returns>
        public ResponseMessage CreateFolder(string folder)
        {
            var resourcePath = string.Format(
                "{0}/storage/folder/{1}", this.configuration.GetApiRootUrl(), folder);

            var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    null,
                    null,
                    null);

            try
            {
                if (response != null)
                {
                    return (ResponseMessage)SerializationHelper.Deserialize(response, typeof(ResponseMessage));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Removes folder.
        /// </summary>
        /// <param name="folder">Folder.</param>
        /// <returns>Message</returns>
        public ResponseMessage DeleteFolder(string folder)
        {
            var resourcePath = string.Format(
                "{0}/storage/folder/{1}?recursive=true", this.configuration.GetApiRootUrl(), folder);

            var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);

            try
            {
                if (response != null)
                {
                    return (ResponseMessage)SerializationHelper.Deserialize(response, typeof(ResponseMessage));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Checks is file exists
        /// </summary>
        /// <param name="path">Path.</param>
        /// <returns>Message</returns>
        public FileExistResponse IsExist(string path)
        {
            var resourcePath = string.Format(
                "{0}/storage/exist/{1}", this.configuration.GetApiRootUrl(), path);

            var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);

            try
            {
                if (response != null)
                {
                    return (FileExistResponse)SerializationHelper.Deserialize(response, typeof(FileExistResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }
    }
}