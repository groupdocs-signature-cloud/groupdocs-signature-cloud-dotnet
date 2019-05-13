// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="FileApi.cs">
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
    public interface IFileApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Copy file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to copy (optional)</param>
        /// <returns></returns>
        void CopyFile(CopyFileRequest request);

        /// <summary>
        /// Copy file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to copy (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CopyFileWithHttpInfo (CopyFileRequest request);
        /// <summary>
        /// Delete file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to delete (optional)</param>
        /// <returns></returns>
        void DeleteFile(DeleteFileRequest request);

        /// <summary>
        /// Delete file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to delete (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFileWithHttpInfo (DeleteFileRequest request);
        /// <summary>
        /// Download file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to download (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream DownloadFile(DownloadFileRequest request);

        /// <summary>
        /// Download file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to download (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> DownloadFileWithHttpInfo (DownloadFileRequest request);
        /// <summary>
        /// Move file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to move (optional)</param>
        /// <returns></returns>
        void MoveFile(MoveFileRequest request);

        /// <summary>
        /// Move file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to move (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MoveFileWithHttpInfo (MoveFileRequest request);
        /// <summary>
        /// Upload file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
        /// <param name="file">File to upload</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>FilesUploadResult</returns>
        FilesUploadResult UploadFile(UploadFileRequest request);

        /// <summary>
        /// Upload file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
        /// <param name="file">File to upload</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of FilesUploadResult</returns>
        ApiResponse<FilesUploadResult> UploadFileWithHttpInfo (UploadFileRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Copy file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to copy (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CopyFileAsync(CopyFileRequest request);

        /// <summary>
        /// Copy file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to copy (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CopyFileAsyncWithHttpInfo(CopyFileRequest request);
        /// <summary>
        /// Delete file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to delete (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFileAsync(DeleteFileRequest request);

        /// <summary>
        /// Delete file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to delete (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFileAsyncWithHttpInfo(DeleteFileRequest request);
        /// <summary>
        /// Download file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to download (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> DownloadFileAsync(DownloadFileRequest request);

        /// <summary>
        /// Download file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to download (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> DownloadFileAsyncWithHttpInfo(DownloadFileRequest request);
        /// <summary>
        /// Move file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to move (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MoveFileAsync(MoveFileRequest request);

        /// <summary>
        /// Move file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to move (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MoveFileAsyncWithHttpInfo(MoveFileRequest request);
        /// <summary>
        /// Upload file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
        /// <param name="file">File to upload</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of FilesUploadResult</returns>
        System.Threading.Tasks.Task<FilesUploadResult> UploadFileAsync(UploadFileRequest request);

        /// <summary>
        /// Upload file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
        /// <param name="file">File to upload</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse (FilesUploadResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<FilesUploadResult>> UploadFileAsyncWithHttpInfo(UploadFileRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FileApi : IFileApi
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
        /// Initializes a new instance of the <see cref="FileApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public FileApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FileApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to copy (optional)</param>
        /// <returns></returns>
        public void CopyFile(CopyFileRequest request)
        {
             CopyFileWithHttpInfo(request);
        }

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to copy (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CopyFileWithHttpInfo(CopyFileRequest request)
        {
            // verify the required parameter 'CopyFile.srcPath' is set
            if (request.srcPath == null)
                throw new ApiException(400, "Missing required parameter 'CopyFile.srcPath' when calling FileApi->CopyFile");
            // verify the required parameter 'CopyFile.destPath' is set
            if (request.destPath == null)
                throw new ApiException(400, "Missing required parameter 'CopyFile.destPath' when calling FileApi->CopyFile");

            var localVarPath = "./signature/storage/file/copy/{srcPath}";
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
            if (request.versionId != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "versionId", request.versionId)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("CopyFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to copy (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CopyFileAsync(CopyFileRequest request)
        {
             await CopyFileAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="destPath">Destination file path</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to copy (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CopyFileAsyncWithHttpInfo(CopyFileRequest request)
        {
            // verify the required parameter 'CopyFile.srcPath' is set
            if (request.srcPath == null)
                throw new ApiException(400, "Missing required parameter 'CopyFile.srcPath' when calling FileApi->CopyFile");
            // verify the required parameter 'CopyFile.destPath' is set
            if (request.destPath == null)
                throw new ApiException(400, "Missing required parameter 'CopyFile.destPath' when calling FileApi->CopyFile");

            var localVarPath = "./signature/storage/file/copy/{srcPath}";
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
            if (request.versionId != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "versionId", request.versionId)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("CopyFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to delete (optional)</param>
        /// <returns></returns>
        public void DeleteFile(DeleteFileRequest request)
        {
             DeleteFileWithHttpInfo(request);
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to delete (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFileWithHttpInfo(DeleteFileRequest request)
        {
            // verify the required parameter 'DeleteFile.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'DeleteFile.path' when calling FileApi->DeleteFile");

            var localVarPath = "./signature/storage/file/{path}";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("DeleteFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to delete (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFileAsync(DeleteFileRequest request)
        {
             await DeleteFileAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to delete (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFileAsyncWithHttpInfo(DeleteFileRequest request)
        {
            // verify the required parameter 'DeleteFile.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'DeleteFile.path' when calling FileApi->DeleteFile");

            var localVarPath = "./signature/storage/file/{path}";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("DeleteFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to download (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
             ApiResponse<System.IO.Stream> localVarResponse = DownloadFileWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to download (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse<System.IO.Stream> DownloadFileWithHttpInfo(DownloadFileRequest request)
        {
            // verify the required parameter 'DownloadFile.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'DownloadFile.path' when calling FileApi->DownloadFile");

            var localVarPath = "./signature/storage/file/{path}";
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
                "multipart/form-data"
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
                Exception exception = _exceptionFactory("DownloadFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (System.IO.Stream) _apiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to download (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> DownloadFileAsync(DownloadFileRequest request)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await DownloadFileAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <param name="versionId">File version ID to download (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> DownloadFileAsyncWithHttpInfo(DownloadFileRequest request)
        {
            // verify the required parameter 'DownloadFile.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'DownloadFile.path' when calling FileApi->DownloadFile");

            var localVarPath = "./signature/storage/file/{path}";
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
                "multipart/form-data"
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
                Exception exception = _exceptionFactory("DownloadFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (System.IO.Stream) _apiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to move (optional)</param>
        /// <returns></returns>
        public void MoveFile(MoveFileRequest request)
        {
             MoveFileWithHttpInfo(request);
        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to move (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> MoveFileWithHttpInfo(MoveFileRequest request)
        {
            // verify the required parameter 'MoveFile.srcPath' is set
            if (request.srcPath == null)
                throw new ApiException(400, "Missing required parameter 'MoveFile.srcPath' when calling FileApi->MoveFile");
            // verify the required parameter 'MoveFile.destPath' is set
            if (request.destPath == null)
                throw new ApiException(400, "Missing required parameter 'MoveFile.destPath' when calling FileApi->MoveFile");

            var localVarPath = "./signature/storage/file/move/{srcPath}";
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
            if (request.versionId != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "versionId", request.versionId)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("MoveFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to move (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MoveFileAsync(MoveFileRequest request)
        {
             await MoveFileAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name (optional)</param>
        /// <param name="destStorageName">Destination storage name (optional)</param>
        /// <param name="versionId">File version ID to move (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> MoveFileAsyncWithHttpInfo(MoveFileRequest request)
        {
            // verify the required parameter 'MoveFile.srcPath' is set
            if (request.srcPath == null)
                throw new ApiException(400, "Missing required parameter 'MoveFile.srcPath' when calling FileApi->MoveFile");
            // verify the required parameter 'MoveFile.destPath' is set
            if (request.destPath == null)
                throw new ApiException(400, "Missing required parameter 'MoveFile.destPath' when calling FileApi->MoveFile");

            var localVarPath = "./signature/storage/file/move/{srcPath}";
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
            if (request.versionId != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "versionId", request.versionId)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("MoveFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
        /// <param name="file">File to upload</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>FilesUploadResult</returns>
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
             ApiResponse<FilesUploadResult> localVarResponse = UploadFileWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
        /// <param name="file">File to upload</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>ApiResponse of FilesUploadResult</returns>
        public ApiResponse<FilesUploadResult> UploadFileWithHttpInfo(UploadFileRequest request)
        {
            // verify the required parameter 'UploadFile.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'UploadFile.path' when calling FileApi->UploadFile");
            // verify the required parameter 'UploadFile.File' is set
            if (request.File == null)
                throw new ApiException(400, "Missing required parameter 'UploadFile.File' when calling FileApi->UploadFile");

            var localVarPath = "./signature/storage/file/{path}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
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
            if (request.File != null) localVarFileParams.Add("file", _apiClient.ParameterToFile("file", request.File));
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("UploadFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FilesUploadResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FilesUploadResult) _apiClient.Deserialize(localVarResponse, typeof(FilesUploadResult)));
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
        /// <param name="file">File to upload</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of FilesUploadResult</returns>
        public async System.Threading.Tasks.Task<FilesUploadResult> UploadFileAsync(UploadFileRequest request)
        {
             ApiResponse<FilesUploadResult> localVarResponse = await UploadFileAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
        /// <param name="file">File to upload</param>
        /// <param name="storageName">Storage name (optional)</param>
        /// <returns>Task of ApiResponse (FilesUploadResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FilesUploadResult>> UploadFileAsyncWithHttpInfo(UploadFileRequest request)
        {
            // verify the required parameter 'UploadFile.path' is set
            if (request.path == null)
                throw new ApiException(400, "Missing required parameter 'UploadFile.path' when calling FileApi->UploadFile");
            // verify the required parameter 'UploadFile.File' is set
            if (request.File == null)
                throw new ApiException(400, "Missing required parameter 'UploadFile.File' when calling FileApi->UploadFile");

            var localVarPath = "./signature/storage/file/{path}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
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
            if (request.File != null) localVarFileParams.Add("file", _apiClient.ParameterToFile("file", request.File));
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("UploadFile", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FilesUploadResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FilesUploadResult) _apiClient.Deserialize(localVarResponse, typeof(FilesUploadResult)));
        }

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CopyFileRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FileApi.CopyFile" /> operation.
    /// </summary>  
    public class CopyFileRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
          /// </summary>        
          public CopyFileRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
          /// </summary>
          /// <param name="srcPath">Source file path e.g. &#39;/folder/file.ext&#39;</param>
          /// <param name="destPath">Destination file path</param>
          /// <param name="srcStorageName">Source storage name</param>
          /// <param name="destStorageName">Destination storage name</param>
          /// <param name="versionId">File version ID to copy</param>
          public CopyFileRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)             
          {
              this.srcPath = srcPath;
              this.destPath = destPath;
              this.srcStorageName = srcStorageName;
              this.destStorageName = destStorageName;
              this.versionId = versionId;
          }

          /// <summary>
          /// Source file path e.g. '/folder/file.ext'
          /// </summary>  
          public string srcPath { get; set; }
          
          /// <summary>
          /// Destination file path
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
          
          /// <summary>
          /// File version ID to copy
          /// </summary>  
          public string versionId { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DeleteFileRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FileApi.DeleteFile" /> operation.
    /// </summary>  
    public class DeleteFileRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteFileRequest"/> class.
          /// </summary>        
          public DeleteFileRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteFileRequest"/> class.
          /// </summary>
          /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
          /// <param name="storageName">Storage name</param>
          /// <param name="versionId">File version ID to delete</param>
          public DeleteFileRequest(string path, string storageName = null, string versionId = null)             
          {
              this.path = path;
              this.storageName = storageName;
              this.versionId = versionId;
          }

          /// <summary>
          /// File path e.g. '/folder/file.ext'
          /// </summary>  
          public string path { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
          
          /// <summary>
          /// File version ID to delete
          /// </summary>  
          public string versionId { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DownloadFileRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FileApi.DownloadFile" /> operation.
    /// </summary>  
    public class DownloadFileRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="DownloadFileRequest"/> class.
          /// </summary>        
          public DownloadFileRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="DownloadFileRequest"/> class.
          /// </summary>
          /// <param name="path">File path e.g. &#39;/folder/file.ext&#39;</param>
          /// <param name="storageName">Storage name</param>
          /// <param name="versionId">File version ID to download</param>
          public DownloadFileRequest(string path, string storageName = null, string versionId = null)             
          {
              this.path = path;
              this.storageName = storageName;
              this.versionId = versionId;
          }

          /// <summary>
          /// File path e.g. '/folder/file.ext'
          /// </summary>  
          public string path { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
          
          /// <summary>
          /// File version ID to download
          /// </summary>  
          public string versionId { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="MoveFileRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FileApi.MoveFile" /> operation.
    /// </summary>  
    public class MoveFileRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="MoveFileRequest"/> class.
          /// </summary>        
          public MoveFileRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="MoveFileRequest"/> class.
          /// </summary>
          /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
          /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
          /// <param name="srcStorageName">Source storage name</param>
          /// <param name="destStorageName">Destination storage name</param>
          /// <param name="versionId">File version ID to move</param>
          public MoveFileRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)             
          {
              this.srcPath = srcPath;
              this.destPath = destPath;
              this.srcStorageName = srcStorageName;
              this.destStorageName = destStorageName;
              this.versionId = versionId;
          }

          /// <summary>
          /// Source file path e.g. '/src.ext'
          /// </summary>  
          public string srcPath { get; set; }
          
          /// <summary>
          /// Destination file path e.g. '/dest.ext'
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
          
          /// <summary>
          /// File version ID to move
          /// </summary>  
          public string versionId { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="UploadFileRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.FileApi.UploadFile" /> operation.
    /// </summary>  
    public class UploadFileRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="UploadFileRequest"/> class.
          /// </summary>        
          public UploadFileRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="UploadFileRequest"/> class.
          /// </summary>
          /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param>
          /// <param name="file">File to upload</param>
          /// <param name="storageName">Storage name</param>
          public UploadFileRequest(string path, System.IO.Stream file, string storageName = null)             
          {
              this.path = path;
              this.File = file;
              this.storageName = storageName;
          }

          /// <summary>
          /// Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             
          /// </summary>  
          public string path { get; set; }
          
          /// <summary>
          /// File to upload
          /// </summary>  
          public System.IO.Stream File { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
    }
}
