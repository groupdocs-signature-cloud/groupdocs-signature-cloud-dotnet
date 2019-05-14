// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoApi.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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

using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Portable;
using GroupDocs.Signature.Cloud.Sdk.Client;
using GroupDocs.Signature.Cloud.Sdk.Model;
using GroupDocs.Signature.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Signature.Cloud.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInfoApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="infoSettings">Settings required for obtaining document info</param>
        /// <returns>InfoResult</returns>
        InfoResult GetInfo(GetInfoRequest request);

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="infoSettings">Settings required for obtaining document info</param>
        /// <returns>ApiResponse of InfoResult</returns>
        ApiResponse<InfoResult> GetInfoWithHttpInfo (GetInfoRequest request);
        /// <summary>
        /// Retrieves supported Barcodes list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>BarcodesResult</returns>
        BarcodesResult GetSupportedBarcodes();

        /// <summary>
        /// Retrieves supported Barcodes list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BarcodesResult</returns>
        ApiResponse<BarcodesResult> GetSupportedBarcodesWithHttpInfo ();
        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FormatsResult</returns>
        FormatsResult GetSupportedFileFormats();

        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FormatsResult</returns>
        ApiResponse<FormatsResult> GetSupportedFileFormatsWithHttpInfo ();
        /// <summary>
        /// Retrieves supported QR-codes list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>QRCodesResult</returns>
        QRCodesResult GetSupportedQRCodes();

        /// <summary>
        /// Retrieves supported QR-codes list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of QRCodesResult</returns>
        ApiResponse<QRCodesResult> GetSupportedQRCodesWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="infoSettings">Settings required for obtaining document info</param>
        /// <returns>Task of InfoResult</returns>
        System.Threading.Tasks.Task<InfoResult> GetInfoAsync(GetInfoRequest request);

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="infoSettings">Settings required for obtaining document info</param>
        /// <returns>Task of ApiResponse (InfoResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfoResult>> GetInfoAsyncWithHttpInfo(GetInfoRequest request);
        /// <summary>
        /// Retrieves supported Barcodes list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of BarcodesResult</returns>
        System.Threading.Tasks.Task<BarcodesResult> GetSupportedBarcodesAsync();

        /// <summary>
        /// Retrieves supported Barcodes list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BarcodesResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<BarcodesResult>> GetSupportedBarcodesAsyncWithHttpInfo();
        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FormatsResult</returns>
        System.Threading.Tasks.Task<FormatsResult> GetSupportedFileFormatsAsync();

        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FormatsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormatsResult>> GetSupportedFileFormatsAsyncWithHttpInfo();
        /// <summary>
        /// Retrieves supported QR-codes list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of QRCodesResult</returns>
        System.Threading.Tasks.Task<QRCodesResult> GetSupportedQRCodesAsync();

        /// <summary>
        /// Retrieves supported QR-codes list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (QRCodesResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<QRCodesResult>> GetSupportedQRCodesAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InfoApi : IInfoApi
    {
        private GroupDocs.Signature.Cloud.Sdk.Client.ExceptionFactoryDelegate _exceptionFactory = GroupDocs.Signature.Cloud.Sdk.Client.ExceptionFactory.Default;
        private GroupDocs.Signature.Cloud.Sdk.Client.Configuration _configuration;
        private GroupDocs.Signature.Cloud.Sdk.Client.ApiClient _apiClient;
        private GroupDocs.Signature.Cloud.Sdk.Client.IAuthorization _authorization;
        private List<Parameter> _defaultParameters = new List<Parameter>
        {
            new Parameter
            {
                Type = ParameterType.HttpHeader,
                Name = "x-groupdocs-client",
                Value = ".net standard sdk"
            },
            new Parameter
            {
                Type = ParameterType.HttpHeader,
                Name = "x-groupdocs-client-version",
                Value = "19.05.0"
            }
        };

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
        /// Initializes a new instance of the <see cref="InfoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InfoApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="infoSettings">Settings required for obtaining document info</param>
        /// <returns>InfoResult</returns>
        public InfoResult GetInfo(GetInfoRequest request)
        {
             ApiResponse<InfoResult> localVarResponse = GetInfoWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="infoSettings">Settings required for obtaining document info</param>
        /// <returns>ApiResponse of InfoResult</returns>
        public ApiResponse<InfoResult> GetInfoWithHttpInfo(GetInfoRequest request)
        {
            // verify the required parameter 'GetInfo.infoSettings' is set
            if (request.infoSettings == null)
                throw new ApiException(400, "Missing required parameter 'GetInfo.infoSettings' when calling InfoApi->GetInfo");

            var localVarPath = "./signature/info";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.infoSettings != null && request.infoSettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.infoSettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.infoSettings; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetInfo", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<InfoResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (InfoResult) _apiClient.Deserialize(localVarResponse, typeof(InfoResult)));
        }

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="infoSettings">Settings required for obtaining document info</param>
        /// <returns>Task of InfoResult</returns>
        public async System.Threading.Tasks.Task<InfoResult> GetInfoAsync(GetInfoRequest request)
        {
             ApiResponse<InfoResult> localVarResponse = await GetInfoAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="infoSettings">Settings required for obtaining document info</param>
        /// <returns>Task of ApiResponse (InfoResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InfoResult>> GetInfoAsyncWithHttpInfo(GetInfoRequest request)
        {
            // verify the required parameter 'GetInfo.infoSettings' is set
            if (request.infoSettings == null)
                throw new ApiException(400, "Missing required parameter 'GetInfo.infoSettings' when calling InfoApi->GetInfo");

            var localVarPath = "./signature/info";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.infoSettings != null && request.infoSettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.infoSettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.infoSettings; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetInfo", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<InfoResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (InfoResult) _apiClient.Deserialize(localVarResponse, typeof(InfoResult)));
        }

        /// <summary>
        /// Retrieves supported Barcodes list 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>BarcodesResult</returns>
        public BarcodesResult GetSupportedBarcodes()
        {
             ApiResponse<BarcodesResult> localVarResponse = GetSupportedBarcodesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves supported Barcodes list 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BarcodesResult</returns>
        public ApiResponse<BarcodesResult> GetSupportedBarcodesWithHttpInfo()
        {

            var localVarPath = "./signature/barcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedBarcodes", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<BarcodesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (BarcodesResult) _apiClient.Deserialize(localVarResponse, typeof(BarcodesResult)));
        }

        /// <summary>
        /// Retrieves supported Barcodes list 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of BarcodesResult</returns>
        public async System.Threading.Tasks.Task<BarcodesResult> GetSupportedBarcodesAsync()
        {
             ApiResponse<BarcodesResult> localVarResponse = await GetSupportedBarcodesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves supported Barcodes list 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BarcodesResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BarcodesResult>> GetSupportedBarcodesAsyncWithHttpInfo()
        {

            var localVarPath = "./signature/barcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedBarcodes", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<BarcodesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (BarcodesResult) _apiClient.Deserialize(localVarResponse, typeof(BarcodesResult)));
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FormatsResult</returns>
        public FormatsResult GetSupportedFileFormats()
        {
             ApiResponse<FormatsResult> localVarResponse = GetSupportedFileFormatsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FormatsResult</returns>
        public ApiResponse<FormatsResult> GetSupportedFileFormatsWithHttpInfo()
        {

            var localVarPath = "./signature/formats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedFileFormats", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FormatsResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FormatsResult) _apiClient.Deserialize(localVarResponse, typeof(FormatsResult)));
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FormatsResult</returns>
        public async System.Threading.Tasks.Task<FormatsResult> GetSupportedFileFormatsAsync()
        {
             ApiResponse<FormatsResult> localVarResponse = await GetSupportedFileFormatsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FormatsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormatsResult>> GetSupportedFileFormatsAsyncWithHttpInfo()
        {

            var localVarPath = "./signature/formats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedFileFormats", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FormatsResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FormatsResult) _apiClient.Deserialize(localVarResponse, typeof(FormatsResult)));
        }

        /// <summary>
        /// Retrieves supported QR-codes list 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>QRCodesResult</returns>
        public QRCodesResult GetSupportedQRCodes()
        {
             ApiResponse<QRCodesResult> localVarResponse = GetSupportedQRCodesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves supported QR-codes list 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of QRCodesResult</returns>
        public ApiResponse<QRCodesResult> GetSupportedQRCodesWithHttpInfo()
        {

            var localVarPath = "./signature/qrcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedQRCodes", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<QRCodesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (QRCodesResult) _apiClient.Deserialize(localVarResponse, typeof(QRCodesResult)));
        }

        /// <summary>
        /// Retrieves supported QR-codes list 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of QRCodesResult</returns>
        public async System.Threading.Tasks.Task<QRCodesResult> GetSupportedQRCodesAsync()
        {
             ApiResponse<QRCodesResult> localVarResponse = await GetSupportedQRCodesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves supported QR-codes list 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (QRCodesResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QRCodesResult>> GetSupportedQRCodesAsyncWithHttpInfo()
        {

            var localVarPath = "./signature/qrcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedQRCodes", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<QRCodesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (QRCodesResult) _apiClient.Deserialize(localVarResponse, typeof(QRCodesResult)));
        }

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetInfoRequest.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
