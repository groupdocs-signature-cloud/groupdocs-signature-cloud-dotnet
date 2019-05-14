// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="FolderApi.cs">
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
    public interface IFolderApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Copy folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns></returns>
        void CopyFolder(CopyFolderRequest request);

        /// <summary>
        /// Copy folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CopyFolderWithHttpInfo (CopyFolderRequest request);
        /// <summary>
        /// Create the folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns></returns>
        void CreateFolder(CreateFolderRequest request);

        /// <summary>
        /// Create the folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateFolderWithHttpInfo (CreateFolderRequest request);
        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files (optional, default to false)</param>
        /// <returns></returns>
        void DeleteFolder(DeleteFolderRequest request);

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFolderWithHttpInfo (DeleteFolderRequest request);
        /// <summary>
        /// Get all files and folders within a folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>FilesList</returns>
        FilesList GetFilesList(GetFilesListRequest request);

        /// <summary>
        /// Get all files and folders within a folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of FilesList</returns>
        ApiResponse<FilesList> GetFilesListWithHttpInfo (GetFilesListRequest request);
        /// <summary>
        /// Move folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns></returns>
        void MoveFolder(MoveFolderRequest request);

        /// <summary>
        /// Move folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MoveFolderWithHttpInfo (MoveFolderRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Copy folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CopyFolderAsync(CopyFolderRequest request);

        /// <summary>
        /// Copy folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CopyFolderAsyncWithHttpInfo(CopyFolderRequest request);
        /// <summary>
        /// Create the folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateFolderAsync(CreateFolderRequest request);

        /// <summary>
        /// Create the folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateFolderAsyncWithHttpInfo(CreateFolderRequest request);
        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files (optional, default to false)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFolderAsync(DeleteFolderRequest request);

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFolderAsyncWithHttpInfo(DeleteFolderRequest request);
        /// <summary>
        /// Get all files and folders within a folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of FilesList</returns>
        System.Threading.Tasks.Task<FilesList> GetFilesListAsync(GetFilesListRequest request);

        /// <summary>
        /// Get all files and folders within a folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse (FilesList)</returns>
        System.Threading.Tasks.Task<ApiResponse<FilesList>> GetFilesListAsyncWithHttpInfo(GetFilesListRequest request);
        /// <summary>
        /// Move folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MoveFolderAsync(MoveFolderRequest request);

        /// <summary>
        /// Move folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MoveFolderAsyncWithHttpInfo(MoveFolderRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FolderApi : IFolderApi
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
        /// Initializes a new instance of the <see cref="FolderApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public FolderApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FolderApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns></returns>
        public void CopyFolder(CopyFolderRequest request)
        {
             CopyFolderWithHttpInfo(request);
        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CopyFolderWithHttpInfo(CopyFolderRequest request)
        {
            // verify the required parameter 'CopyFolder.srcPath' is set
            if (request.srcPath == null)
                throw new ApiException(400, "Missing required parameter 'CopyFolder.srcPath' when calling FolderApi->CopyFolder");
            // verify the required parameter 'CopyFolder.destPath' is set
            if (request.destPath == null)
                throw new ApiException(400, "Missing required parameter 'CopyFolder.destPath' when calling FolderApi->CopyFolder");

            var localVarPath = "./signature/storage/folder/copy/{srcPath}";
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

            if (request.srcPath != null) localVarPathParams.Add("srcPath", _apiClient.ParameterToString(request.srcPath)); // path parameter
            if (request.destPath != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "destPath", request.destPath)); // query parameter
            if (request.srcStorageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "srcStorageName", request.srcStorageName)); // query parameter
            if (request.destStorageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "destStorageName", request.destStorageName)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("CopyFolder", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CopyFolderAsync(CopyFolderRequest request)
        {
             await CopyFolderAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CopyFolderAsyncWithHttpInfo(CopyFolderRequest request)
        {
            // verify the required parameter 'CopyFolder.srcPath' is set
            if (request.srcPath == null)
                throw new ApiException(400, "Missing required parameter 'CopyFolder.srcPath' when calling FolderApi->CopyFolder");
            // verify the required parameter 'CopyFolder.destPath' is set
            if (request.destPath == null)
                throw new ApiException(400, "Missing required parameter 'CopyFolder.destPath' when calling FolderApi->CopyFolder");

            var localVarPath = "./signature/storage/folder/copy/{srcPath}";
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

            if (request.srcPath != null) localVarPathParams.Add("srcPath", _apiClient.ParameterToString(request.srcPath)); // path parameter
            if (request.destPath != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "destPath", request.destPath)); // query parameter
            if (request.srcStorageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "srcStorageName", request.srcStorageName)); // query parameter
            if (request.destStorageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "destStorageName", request.destStorageName)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("CopyFolder", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns></returns>
        public void CreateFolder(CreateFolderRequest request)
        {
             CreateFolderWithHttpInfo(request);
        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateFolderWithHttpInfo(CreateFolderRequest request)
        {
            // verify the required parameter 'CreateFolder.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'CreateFolder.path' when calling FolderApi->CreateFolder");

            var localVarPath = "./signature/storage/folder/{path}";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("CreateFolder", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateFolderAsync(CreateFolderRequest request)
        {
             await CreateFolderAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateFolderAsyncWithHttpInfo(CreateFolderRequest request)
        {
            // verify the required parameter 'CreateFolder.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'CreateFolder.path' when calling FolderApi->CreateFolder");

            var localVarPath = "./signature/storage/folder/{path}";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("CreateFolder", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files (optional, default to false)</param>
        /// <returns></returns>
        public void DeleteFolder(DeleteFolderRequest request)
        {
             DeleteFolderWithHttpInfo(request);
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFolderWithHttpInfo(DeleteFolderRequest request)
        {
            // verify the required parameter 'DeleteFolder.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'DeleteFolder.path' when calling FolderApi->DeleteFolder");

            var localVarPath = "./signature/storage/folder/{path}";
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
            if (request.recursive != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "recursive", request.recursive)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("DeleteFolder", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files (optional, default to false)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFolderAsync(DeleteFolderRequest request)
        {
             await DeleteFolderAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFolderAsyncWithHttpInfo(DeleteFolderRequest request)
        {
            // verify the required parameter 'DeleteFolder.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'DeleteFolder.path' when calling FolderApi->DeleteFolder");

            var localVarPath = "./signature/storage/folder/{path}";
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
            if (request.recursive != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "recursive", request.recursive)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("DeleteFolder", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>FilesList</returns>
        public FilesList GetFilesList(GetFilesListRequest request)
        {
             ApiResponse<FilesList> localVarResponse = GetFilesListWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of FilesList</returns>
        public ApiResponse<FilesList> GetFilesListWithHttpInfo(GetFilesListRequest request)
        {
            // verify the required parameter 'GetFilesList.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'GetFilesList.path' when calling FolderApi->GetFilesList");

            var localVarPath = "./signature/storage/folder/{path}";
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
                Exception exception = _exceptionFactory("GetFilesList", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FilesList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FilesList) _apiClient.Deserialize(localVarResponse, typeof(FilesList)));
        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of FilesList</returns>
        public async System.Threading.Tasks.Task<FilesList> GetFilesListAsync(GetFilesListRequest request)
        {
             ApiResponse<FilesList> localVarResponse = await GetFilesListAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse (FilesList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FilesList>> GetFilesListAsyncWithHttpInfo(GetFilesListRequest request)
        {
            // verify the required parameter 'GetFilesList.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'GetFilesList.path' when calling FolderApi->GetFilesList");

            var localVarPath = "./signature/storage/folder/{path}";
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
                Exception exception = _exceptionFactory("GetFilesList", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FilesList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FilesList) _apiClient.Deserialize(localVarResponse, typeof(FilesList)));
        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns></returns>
        public void MoveFolder(MoveFolderRequest request)
        {
             MoveFolderWithHttpInfo(request);
        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> MoveFolderWithHttpInfo(MoveFolderRequest request)
        {
            // verify the required parameter 'MoveFolder.srcPath' is set
            if (request.srcPath == null)
                throw new ApiException(400, "Missing required parameter 'MoveFolder.srcPath' when calling FolderApi->MoveFolder");
            // verify the required parameter 'MoveFolder.destPath' is set
            if (request.destPath == null)
                throw new ApiException(400, "Missing required parameter 'MoveFolder.destPath' when calling FolderApi->MoveFolder");

            var localVarPath = "./signature/storage/folder/move/{srcPath}";
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

            if (request.srcPath != null) localVarPathParams.Add("srcPath", _apiClient.ParameterToString(request.srcPath)); // path parameter
            if (request.destPath != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "destPath", request.destPath)); // query parameter
            if (request.srcStorageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "srcStorageName", request.srcStorageName)); // query parameter
            if (request.destStorageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "destStorageName", request.destStorageName)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("MoveFolder", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MoveFolderAsync(MoveFolderRequest request)
        {
             await MoveFolderAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> MoveFolderAsyncWithHttpInfo(MoveFolderRequest request)
        {
            // verify the required parameter 'MoveFolder.srcPath' is set
            if (request.srcPath == null)
                throw new ApiException(400, "Missing required parameter 'MoveFolder.srcPath' when calling FolderApi->MoveFolder");
            // verify the required parameter 'MoveFolder.destPath' is set
            if (request.destPath == null)
                throw new ApiException(400, "Missing required parameter 'MoveFolder.destPath' when calling FolderApi->MoveFolder");

            var localVarPath = "./signature/storage/folder/move/{srcPath}";
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

            if (request.srcPath != null) localVarPathParams.Add("srcPath", _apiClient.ParameterToString(request.srcPath)); // path parameter
            if (request.destPath != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "destPath", request.destPath)); // query parameter
            if (request.srcStorageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "srcStorageName", request.srcStorageName)); // query parameter
            if (request.destStorageName != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "destStorageName", request.destStorageName)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("MoveFolder", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CopyFolderRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FolderApi.CopyFolder" /> operation.
    /// </summary>  
    public class CopyFolderRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
          /// </summary>        
          public CopyFolderRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
          /// </summary>
          /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
          /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
          /// <param name="srcStorageName">Source storage name</param>
          /// <param name="destStorageName">Destination storage name</param>
          public CopyFolderRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)             
          {
              this.srcPath = srcPath;
              this.destPath = destPath;
              this.srcStorageName = srcStorageName;
              this.destStorageName = destStorageName;
          }

          /// <summary>
          /// Source folder path e.g. '/src'
          /// </summary>  
          public string srcPath { get; set; }
          
          /// <summary>
          /// Destination folder path e.g. '/dst'
          /// </summary>  
          public string destPath { get; set; }
          
          /// <summary>
          /// Source storage name
          /// </summary>  
          public string srcStorageName { get; set; }
          
          /// <summary>
          /// Destination storage name
          /// </summary>  
          public string destStorageName { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CreateFolderRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FolderApi.CreateFolder" /> operation.
    /// </summary>  
    public class CreateFolderRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="CreateFolderRequest"/> class.
          /// </summary>        
          public CreateFolderRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="CreateFolderRequest"/> class.
          /// </summary>
          /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
          /// <param name="storageName">Storage name</param>
          public CreateFolderRequest(string path, string storageName = null)             
          {
              this.path = path;
              this.storageName = storageName;
          }

          /// <summary>
          /// Folder path to create e.g. 'folder_1/folder_2/'
          /// </summary>  
          public string path { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DeleteFolderRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FolderApi.DeleteFolder" /> operation.
    /// </summary>  
    public class DeleteFolderRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteFolderRequest"/> class.
          /// </summary>        
          public DeleteFolderRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteFolderRequest"/> class.
          /// </summary>
          /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
          /// <param name="storageName">Storage name</param>
          /// <param name="recursive">Enable to delete folders, subfolders and files</param>
          public DeleteFolderRequest(string path, string storageName = null, bool? recursive = null)             
          {
              this.path = path;
              this.storageName = storageName;
              this.recursive = recursive;
          }

          /// <summary>
          /// Folder path e.g. '/folder'
          /// </summary>  
          public string path { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
          
          /// <summary>
          /// Enable to delete folders, subfolders and files
          /// </summary>  
          public bool? recursive { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetFilesListRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FolderApi.GetFilesList" /> operation.
    /// </summary>  
    public class GetFilesListRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetFilesListRequest"/> class.
          /// </summary>        
          public GetFilesListRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetFilesListRequest"/> class.
          /// </summary>
          /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
          /// <param name="storageName">Storage name</param>
          public GetFilesListRequest(string path, string storageName = null)             
          {
              this.path = path;
              this.storageName = storageName;
          }

          /// <summary>
          /// Folder path e.g. '/folder'
          /// </summary>  
          public string path { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="MoveFolderRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FolderApi.MoveFolder" /> operation.
    /// </summary>  
    public class MoveFolderRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="MoveFolderRequest"/> class.
          /// </summary>        
          public MoveFolderRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="MoveFolderRequest"/> class.
          /// </summary>
          /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
          /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
          /// <param name="srcStorageName">Source storage name</param>
          /// <param name="destStorageName">Destination storage name</param>
          public MoveFolderRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)             
          {
              this.srcPath = srcPath;
              this.destPath = destPath;
              this.srcStorageName = srcStorageName;
              this.destStorageName = destStorageName;
          }

          /// <summary>
          /// Folder path to move e.g. '/folder'
          /// </summary>  
          public string srcPath { get; set; }
          
          /// <summary>
          /// Destination folder path to move to e.g '/dst'
          /// </summary>  
          public string destPath { get; set; }
          
          /// <summary>
          /// Source storage name
          /// </summary>  
          public string srcStorageName { get; set; }
          
          /// <summary>
          /// Destination storage name
          /// </summary>  
          public string destStorageName { get; set; }
    }
}
