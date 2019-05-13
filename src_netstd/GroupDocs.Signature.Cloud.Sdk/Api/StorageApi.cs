// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="StorageApi.cs">
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
    public interface IStorageApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get disc usage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>DiscUsage</returns>
        DiscUsage GetDiscUsage(GetDiscUsageRequest request);

        /// <summary>
        /// Get disc usage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of DiscUsage</returns>
        ApiResponse<DiscUsage> GetDiscUsageWithHttpInfo (GetDiscUsageRequest request);
        /// <summary>
        /// Get file versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>FileVersions</returns>
        FileVersions GetFileVersions(GetFileVersionsRequest request);

        /// <summary>
        /// Get file versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of FileVersions</returns>
        ApiResponse<FileVersions> GetFileVersionsWithHttpInfo (GetFileVersionsRequest request);
        /// <summary>
        /// Check if file or folder exists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID (optional)</param>
        /// <returns>ObjectExist</returns>
        ObjectExist ObjectExists(ObjectExistsRequest request);

        /// <summary>
        /// Check if file or folder exists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID (optional)</param>
        /// <returns>ApiResponse of ObjectExist</returns>
        ApiResponse<ObjectExist> ObjectExistsWithHttpInfo (ObjectExistsRequest request);
        /// <summary>
        /// Check if storage exists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name</param>
        /// <returns>StorageExist</returns>
        StorageExist StorageExists(StorageExistsRequest request);

        /// <summary>
        /// Check if storage exists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name</param>
        /// <returns>ApiResponse of StorageExist</returns>
        ApiResponse<StorageExist> StorageExistsWithHttpInfo (StorageExistsRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get disc usage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of DiscUsage</returns>
        System.Threading.Tasks.Task<DiscUsage> GetDiscUsageAsync(GetDiscUsageRequest request);

        /// <summary>
        /// Get disc usage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse (DiscUsage)</returns>
        System.Threading.Tasks.Task<ApiResponse<DiscUsage>> GetDiscUsageAsyncWithHttpInfo(GetDiscUsageRequest request);
        /// <summary>
        /// Get file versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of FileVersions</returns>
        System.Threading.Tasks.Task<FileVersions> GetFileVersionsAsync(GetFileVersionsRequest request);

        /// <summary>
        /// Get file versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse (FileVersions)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileVersions>> GetFileVersionsAsyncWithHttpInfo(GetFileVersionsRequest request);
        /// <summary>
        /// Check if file or folder exists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID (optional)</param>
        /// <returns>Task of ObjectExist</returns>
        System.Threading.Tasks.Task<ObjectExist> ObjectExistsAsync(ObjectExistsRequest request);

        /// <summary>
        /// Check if file or folder exists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID (optional)</param>
        /// <returns>Task of ApiResponse (ObjectExist)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectExist>> ObjectExistsAsyncWithHttpInfo(ObjectExistsRequest request);
        /// <summary>
        /// Check if storage exists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name</param>
        /// <returns>Task of StorageExist</returns>
        System.Threading.Tasks.Task<StorageExist> StorageExistsAsync(StorageExistsRequest request);

        /// <summary>
        /// Check if storage exists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name</param>
        /// <returns>Task of ApiResponse (StorageExist)</returns>
        System.Threading.Tasks.Task<ApiResponse<StorageExist>> StorageExistsAsyncWithHttpInfo(StorageExistsRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StorageApi : IStorageApi
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
                Value = "18.11.0"
            }
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public StorageApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StorageApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>DiscUsage</returns>
        public DiscUsage GetDiscUsage(GetDiscUsageRequest request)
        {
             ApiResponse<DiscUsage> localVarResponse = GetDiscUsageWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of DiscUsage</returns>
        public ApiResponse<DiscUsage> GetDiscUsageWithHttpInfo(GetDiscUsageRequest request)
        {

            var localVarPath = "./signature/storage/disc";
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

            if (request.storageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "storageName", request.storageName)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetDiscUsage", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<DiscUsage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DiscUsage) _apiClient.Deserialize(localVarResponse, typeof(DiscUsage)));
        }

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of DiscUsage</returns>
        public async System.Threading.Tasks.Task<DiscUsage> GetDiscUsageAsync(GetDiscUsageRequest request)
        {
             ApiResponse<DiscUsage> localVarResponse = await GetDiscUsageAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse (DiscUsage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DiscUsage>> GetDiscUsageAsyncWithHttpInfo(GetDiscUsageRequest request)
        {

            var localVarPath = "./signature/storage/disc";
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

            if (request.storageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "storageName", request.storageName)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetDiscUsage", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<DiscUsage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DiscUsage) _apiClient.Deserialize(localVarResponse, typeof(DiscUsage)));
        }

        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>FileVersions</returns>
        public FileVersions GetFileVersions(GetFileVersionsRequest request)
        {
             ApiResponse<FileVersions> localVarResponse = GetFileVersionsWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of FileVersions</returns>
        public ApiResponse<FileVersions> GetFileVersionsWithHttpInfo(GetFileVersionsRequest request)
        {
            // verify the required parameter 'GetFileVersions.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'GetFileVersions.path' when calling StorageApi->GetFileVersions");

            var localVarPath = "./signature/storage/version/{path}";
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

            if (request.path != null) localVarPathParams.Add("path", _apiClient.ParameterToString(request.path)); // path parameter
            if (request.storageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "storageName", request.storageName)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetFileVersions", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FileVersions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FileVersions) _apiClient.Deserialize(localVarResponse, typeof(FileVersions)));
        }

        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of FileVersions</returns>
        public async System.Threading.Tasks.Task<FileVersions> GetFileVersionsAsync(GetFileVersionsRequest request)
        {
             ApiResponse<FileVersions> localVarResponse = await GetFileVersionsAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse (FileVersions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileVersions>> GetFileVersionsAsyncWithHttpInfo(GetFileVersionsRequest request)
        {
            // verify the required parameter 'GetFileVersions.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'GetFileVersions.path' when calling StorageApi->GetFileVersions");

            var localVarPath = "./signature/storage/version/{path}";
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

            if (request.path != null) localVarPathParams.Add("path", _apiClient.ParameterToString(request.path)); // path parameter
            if (request.storageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "storageName", request.storageName)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetFileVersions", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FileVersions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FileVersions) _apiClient.Deserialize(localVarResponse, typeof(FileVersions)));
        }

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID (optional)</param>
        /// <returns>ObjectExist</returns>
        public ObjectExist ObjectExists(ObjectExistsRequest request)
        {
             ApiResponse<ObjectExist> localVarResponse = ObjectExistsWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID (optional)</param>
        /// <returns>ApiResponse of ObjectExist</returns>
        public ApiResponse<ObjectExist> ObjectExistsWithHttpInfo(ObjectExistsRequest request)
        {
            // verify the required parameter 'ObjectExists.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'ObjectExists.path' when calling StorageApi->ObjectExists");

            var localVarPath = "./signature/storage/exist/{path}";
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

            if (request.path != null) localVarPathParams.Add("path", _apiClient.ParameterToString(request.path)); // path parameter
            if (request.storageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "storageName", request.storageName)); // query parameter
            if (request.versionId != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "versionId", request.versionId)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("ObjectExists", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<ObjectExist>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ObjectExist) _apiClient.Deserialize(localVarResponse, typeof(ObjectExist)));
        }

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID (optional)</param>
        /// <returns>Task of ObjectExist</returns>
        public async System.Threading.Tasks.Task<ObjectExist> ObjectExistsAsync(ObjectExistsRequest request)
        {
             ApiResponse<ObjectExist> localVarResponse = await ObjectExistsAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID (optional)</param>
        /// <returns>Task of ApiResponse (ObjectExist)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectExist>> ObjectExistsAsyncWithHttpInfo(ObjectExistsRequest request)
        {
            // verify the required parameter 'ObjectExists.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'ObjectExists.path' when calling StorageApi->ObjectExists");

            var localVarPath = "./signature/storage/exist/{path}";
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

            if (request.path != null) localVarPathParams.Add("path", _apiClient.ParameterToString(request.path)); // path parameter
            if (request.storageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "storageName", request.storageName)); // query parameter
            if (request.versionId != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "versionId", request.versionId)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("ObjectExists", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<ObjectExist>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ObjectExist) _apiClient.Deserialize(localVarResponse, typeof(ObjectExist)));
        }

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name</param>
        /// <returns>StorageExist</returns>
        public StorageExist StorageExists(StorageExistsRequest request)
        {
             ApiResponse<StorageExist> localVarResponse = StorageExistsWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name</param>
        /// <returns>ApiResponse of StorageExist</returns>
        public ApiResponse<StorageExist> StorageExistsWithHttpInfo(StorageExistsRequest request)
        {
            // verify the required parameter 'StorageExists.storageName' is set
            if (request.storageName == null)
                throw new ApiException(400, "Missing required parameter 'StorageExists.storageName' when calling StorageApi->StorageExists");

            var localVarPath = "./signature/storage/{storageName}/exist";
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

            if (request.storageName != null) localVarPathParams.Add("storageName", _apiClient.ParameterToString(request.storageName)); // path parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("StorageExists", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<StorageExist>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (StorageExist) _apiClient.Deserialize(localVarResponse, typeof(StorageExist)));
        }

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name</param>
        /// <returns>Task of StorageExist</returns>
        public async System.Threading.Tasks.Task<StorageExist> StorageExistsAsync(StorageExistsRequest request)
        {
             ApiResponse<StorageExist> localVarResponse = await StorageExistsAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageName">Storage name</param>
        /// <returns>Task of ApiResponse (StorageExist)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StorageExist>> StorageExistsAsyncWithHttpInfo(StorageExistsRequest request)
        {
            // verify the required parameter 'StorageExists.storageName' is set
            if (request.storageName == null)
                throw new ApiException(400, "Missing required parameter 'StorageExists.storageName' when calling StorageApi->StorageExists");

            var localVarPath = "./signature/storage/{storageName}/exist";
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

            if (request.storageName != null) localVarPathParams.Add("storageName", _apiClient.ParameterToString(request.storageName)); // path parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("StorageExists", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<StorageExist>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (StorageExist) _apiClient.Deserialize(localVarResponse, typeof(StorageExist)));
        }

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetDiscUsageRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.StorageApi.GetDiscUsage" /> operation.
    /// </summary>  
    public class GetDiscUsageRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetDiscUsageRequest"/> class.
          /// </summary>        
          public GetDiscUsageRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetDiscUsageRequest"/> class.
          /// </summary>
          /// <param name="storageName">Storage name</param>
          public GetDiscUsageRequest(string storageName = null)             
          {
              this.storageName = storageName;
          }

          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetFileVersionsRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.StorageApi.GetFileVersions" /> operation.
    /// </summary>  
    public class GetFileVersionsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetFileVersionsRequest"/> class.
          /// </summary>        
          public GetFileVersionsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetFileVersionsRequest"/> class.
          /// </summary>
          /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
          /// <param name="storageName">Storage name</param>
          public GetFileVersionsRequest(string path, string storageName = null)             
          {
              this.path = path;
              this.storageName = storageName;
          }

          /// <summary>
          /// File path e.g. '/file.ext'
          /// </summary>  
          public string path { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ObjectExistsRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.StorageApi.ObjectExists" /> operation.
    /// </summary>  
    public class ObjectExistsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ObjectExistsRequest"/> class.
          /// </summary>        
          public ObjectExistsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ObjectExistsRequest"/> class.
          /// </summary>
          /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
          /// <param name="storageName">Storage name</param>
          /// <param name="versionId">File version ID</param>
          public ObjectExistsRequest(string path, string storageName = null, string versionId = null)             
          {
              this.path = path;
              this.storageName = storageName;
              this.versionId = versionId;
          }

          /// <summary>
          /// File or folder path e.g. '/file.ext' or '/folder'
          /// </summary>  
          public string path { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
          
          /// <summary>
          /// File version ID
          /// </summary>  
          public string versionId { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="StorageExistsRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.StorageApi.StorageExists" /> operation.
    /// </summary>  
    public class StorageExistsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="StorageExistsRequest"/> class.
          /// </summary>        
          public StorageExistsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="StorageExistsRequest"/> class.
          /// </summary>
          /// <param name="storageName">Storage name</param>
          public StorageExistsRequest(string storageName)             
          {
              this.storageName = storageName;
          }

          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
    }
}
