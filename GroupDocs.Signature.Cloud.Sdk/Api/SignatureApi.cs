// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignatureApi.cs">
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

namespace GroupDocs.Signature.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Internal;
    using GroupDocs.Signature.Cloud.Sdk.Internal.RequestHandlers;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Signature for Cloud API.
    /// </summary>
    public class SignatureApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public SignatureApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public SignatureApi(Configuration configuration)
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
        /// Retrieves list of supported Barcode type names. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodesRequest" /></param>
        /// <returns><see cref="BarcodeCollection"/></returns>
        public BarcodeCollection GetBarcodes(GetBarcodesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/barcodes";
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
                return (BarcodeCollection)SerializationHelper.Deserialize(response, typeof(BarcodeCollection));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentInfoRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo GetDocumentInfo(GetDocumentInfoRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling GetDocumentInfo");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{fileName}/document/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentInfoFromUrlRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo GetDocumentInfoFromUrl(GetDocumentInfoFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling GetDocumentInfoFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/document/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves list of supported QR-Code type names. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetQRCodesRequest" /></param>
        /// <returns><see cref="QRCodeCollection"/></returns>
        public QRCodeCollection GetQRCodes(GetQRCodesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/qrcodes";
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
                return (QRCodeCollection)SerializationHelper.Deserialize(response, typeof(QRCodeCollection));
            }

            return null;
        }

        /// <summary>
        /// Lists supported file formats. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSupportedFormatsRequest" /></param>
        /// <returns><see cref="FormatCollection"/></returns>
        public FormatCollection GetSupportedFormats(GetSupportedFormatsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/formats";
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
                return (FormatCollection)SerializationHelper.Deserialize(response, typeof(FormatCollection));
            }

            return null;
        }

        /// <summary>
        /// Insert Barcode Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostBarcodeRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostBarcode(PostBarcodeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostBarcode");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/barcode";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Barcode Signature into the Document provided by URL 
        /// </summary>
        /// <param name="request">Request. <see cref="PostBarcodeFromUrlRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostBarcodeFromUrl(PostBarcodeFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostBarcodeFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/barcode";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCollectionRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostCollection(PostCollectionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCollection");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/collection";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsCollectionData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Stamp Signature into the Document provided by URL 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCollectionFromUrlRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostCollectionFromUrl(PostCollectionFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostCollectionFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/collection";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsCollectionData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Digital Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDigitalRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostDigital(PostDigitalRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDigital");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/digital";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "certificateFile", request.CertificateFile);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageFile", request.ImageFile);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Digital Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDigitalFromUrlRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostDigitalFromUrl(PostDigitalFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostDigitalFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/digital";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "certificateFile", request.CertificateFile);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageFile", request.ImageFile);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Image Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostImage(PostImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "image", request.Image);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Image Signature into the Document provided by URL 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageFromUrlRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostImageFromUrl(PostImageFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostImageFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "image", request.Image);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert QRCode Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostQRCodeRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostQRCode(PostQRCodeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostQRCode");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/qrcode";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert QRCode Signature into the Document provided by URL 
        /// </summary>
        /// <param name="request">Request. <see cref="PostQRCodeFromUrlRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostQRCodeFromUrl(PostQRCodeFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostQRCodeFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/qrcode";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Search the Document with Barcode Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchBarcodeRequest" /></param>
        /// <returns><see cref="SearchDocumentResponse"/></returns>
        public SearchDocumentResponse PostSearchBarcode(PostSearchBarcodeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSearchBarcode");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/barcode/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SearchOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchDocumentResponse)SerializationHelper.Deserialize(response, typeof(SearchDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Search the url based Document with Barcode Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchBarcodeFromUrlRequest" /></param>
        /// <returns><see cref="SearchDocumentResponse"/></returns>
        public SearchDocumentResponse PostSearchBarcodeFromUrl(PostSearchBarcodeFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostSearchBarcodeFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/barcode/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SearchOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchDocumentResponse)SerializationHelper.Deserialize(response, typeof(SearchDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Search the Document. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchCollectionRequest" /></param>
        /// <returns><see cref="SearchDocumentResponse"/></returns>
        public SearchDocumentResponse PostSearchCollection(PostSearchCollectionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSearchCollection");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/collection/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SearchOptionsCollectionData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchDocumentResponse)SerializationHelper.Deserialize(response, typeof(SearchDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Search the Document provided by URL. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchCollectionFromUrlRequest" /></param>
        /// <returns><see cref="SearchDocumentResponse"/></returns>
        public SearchDocumentResponse PostSearchCollectionFromUrl(PostSearchCollectionFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostSearchCollectionFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/collection/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SearchOptionsCollectionData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchDocumentResponse)SerializationHelper.Deserialize(response, typeof(SearchDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Search the Document with Digital Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchDigitalRequest" /></param>
        /// <returns><see cref="SearchDocumentResponse"/></returns>
        public SearchDocumentResponse PostSearchDigital(PostSearchDigitalRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSearchDigital");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/digital/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SearchOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchDocumentResponse)SerializationHelper.Deserialize(response, typeof(SearchDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Search the Document from url with Digital Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchDigitalFromUrlRequest" /></param>
        /// <returns><see cref="SearchDocumentResponse"/></returns>
        public SearchDocumentResponse PostSearchDigitalFromUrl(PostSearchDigitalFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostSearchDigitalFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/digital/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SearchOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchDocumentResponse)SerializationHelper.Deserialize(response, typeof(SearchDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Search the Document with QRCode Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchQRCodeRequest" /></param>
        /// <returns><see cref="SearchDocumentResponse"/></returns>
        public SearchDocumentResponse PostSearchQRCode(PostSearchQRCodeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSearchQRCode");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/qrcode/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SearchOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchDocumentResponse)SerializationHelper.Deserialize(response, typeof(SearchDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Search the url based Document with QRCode Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchQRCodeFromUrlRequest" /></param>
        /// <returns><see cref="SearchDocumentResponse"/></returns>
        public SearchDocumentResponse PostSearchQRCodeFromUrl(PostSearchQRCodeFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostSearchQRCodeFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/qrcode/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SearchOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchDocumentResponse)SerializationHelper.Deserialize(response, typeof(SearchDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Stamp Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostStampRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostStamp(PostStampRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostStamp");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/stamp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Stamp Signature into the Document provided by URL 
        /// </summary>
        /// <param name="request">Request. <see cref="PostStampFromUrlRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostStampFromUrl(PostStampFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostStampFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/stamp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Text Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostTextRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostText(PostTextRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostText");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/text";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Insert Text Signature into the Document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostTextFromUrlRequest" /></param>
        /// <returns><see cref="SignatureDocumentResponse"/></returns>
        public SignatureDocumentResponse PostTextFromUrl(PostTextFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostTextFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/text";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.SignOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignatureDocumentResponse)SerializationHelper.Deserialize(response, typeof(SignatureDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the Document with Barcode Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationBarcodeRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationBarcode(PostVerificationBarcodeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostVerificationBarcode");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/barcode/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the url based Document with Barcode Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationBarcodeFromUrlRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationBarcodeFromUrl(PostVerificationBarcodeFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostVerificationBarcodeFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/barcode/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the Document. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationCollectionRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationCollection(PostVerificationCollectionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostVerificationCollection");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/collection/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsCollectionData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the Document provided by URL. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationCollectionFromUrlRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationCollectionFromUrl(PostVerificationCollectionFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostVerificationCollectionFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/collection/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsCollectionData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the Document with Digital Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationDigitalRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationDigital(PostVerificationDigitalRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostVerificationDigital");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/digital/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "certificateGuid", request.CertificateGuid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the Document from url with Digital Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationDigitalFromUrlRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationDigitalFromUrl(PostVerificationDigitalFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostVerificationDigitalFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/digital/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "certificateGuid", request.CertificateGuid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the Document with QRCode Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationQRCodeRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationQRCode(PostVerificationQRCodeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostVerificationQRCode");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/qrcode/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the url based Document with QRCode Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationQRCodeFromUrlRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationQRCodeFromUrl(PostVerificationQRCodeFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostVerificationQRCodeFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/qrcode/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the Document with Text Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationTextRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationText(PostVerificationTextRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostVerificationText");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/{name}/text/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }

        /// <summary>
        /// Verify the Document provided by url with Text Signatures 
        /// </summary>
        /// <param name="request">Request. <see cref="PostVerificationTextFromUrlRequest" /></param>
        /// <returns><see cref="VerifiedDocumentResponse"/></returns>
        public VerifiedDocumentResponse PostVerificationTextFromUrl(PostVerificationTextFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling PostVerificationTextFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/signature/text/verification";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.VerifyOptionsData); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifiedDocumentResponse)SerializationHelper.Deserialize(response, typeof(VerifiedDocumentResponse));
            }

            return null;
        }
    }
}
