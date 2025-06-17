// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoApi.cs">
//  Copyright (c) Aspose Pty Ltd
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
    using System.Text.RegularExpressions;
    using System.IO;
    using GroupDocs.Signature.Cloud.Sdk.Client;
    using GroupDocs.Signature.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Signature.Cloud.Sdk API.
    /// </summary>
    public class InfoApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public InfoApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public InfoApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <param name="request">Request. <see cref="GetInfoRequest" /></param>
        /// <returns><see cref="InfoResult"/></returns>
        public InfoResult GetInfo(GetInfoRequest request)
        {
            // verify the required parameter 'infoSettings' is set
            if (request.infoSettings == null) 
            {
                throw new ApiException(400, "Missing required parameter 'infoSettings' when calling GetInfo");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.infoSettings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (InfoResult)SerializationHelper.Deserialize(response, typeof(InfoResult));
            }

            return null;
        }

        /// <summary>
        /// Retrieves supported Barcodes list 
        /// </summary>
        /// <returns><see cref="BarcodesResult"/></returns>
        public BarcodesResult GetSupportedBarcodes()
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/barcodes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (BarcodesResult)SerializationHelper.Deserialize(response, typeof(BarcodesResult));
            }

            return null;
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <returns><see cref="FormatsResult"/></returns>
        public FormatsResult GetSupportedFileFormats()
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (FormatsResult)SerializationHelper.Deserialize(response, typeof(FormatsResult));
            }

            return null;
        }

        /// <summary>
        /// Retrieves supported QR-codes list 
        /// </summary>
        /// <returns><see cref="QRCodesResult"/></returns>
        public QRCodesResult GetSupportedQRCodes()
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/qrcodes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (QRCodesResult)SerializationHelper.Deserialize(response, typeof(QRCodesResult));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetInfoRequest.cs">
//  Copyright (c) Aspose Pty Ltd
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

namespace GroupDocs.Signature.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Signature.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.InfoApi.GetInfo" /> operation.
    /// </summary>  
    public class GetInfoRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetInfoRequest"/> class.
          /// </summary>        
          public GetInfoRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetInfoRequest"/> class.
          /// </summary>
          /// <param name="infoSettings">Settings required for obtaining document info</param>
          public GetInfoRequest(InfoSettings infoSettings)             
          {
              this.infoSettings = infoSettings;
          }
          
          /// <summary>
          /// Settings required for obtaining document info
          /// </summary>  
          public InfoSettings infoSettings { get; set; }
    }
}
