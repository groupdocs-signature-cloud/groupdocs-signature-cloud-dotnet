// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignApi.cs">
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
    public interface ISignApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signSettings">Document sign settings</param>
        /// <returns>SignResult</returns>
        SignResult CreateSignatures(CreateSignaturesRequest request);

        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signSettings">Document sign settings</param>
        /// <returns>ApiResponse of SignResult</returns>
        ApiResponse<SignResult> CreateSignaturesWithHttpInfo (CreateSignaturesRequest request);
        /// <summary>
        /// Searches for signatures applied to the document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchSettings">Signatures search settings</param>
        /// <returns>SearchResult</returns>
        SearchResult SearchSignatures(SearchSignaturesRequest request);

        /// <summary>
        /// Searches for signatures applied to the document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchSettings">Signatures search settings</param>
        /// <returns>ApiResponse of SearchResult</returns>
        ApiResponse<SearchResult> SearchSignaturesWithHttpInfo (SearchSignaturesRequest request);
        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
        /// <returns>VerifyResult</returns>
        VerifyResult VerifySignatures(VerifySignaturesRequest request);

        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
        /// <returns>ApiResponse of VerifyResult</returns>
        ApiResponse<VerifyResult> VerifySignaturesWithHttpInfo (VerifySignaturesRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signSettings">Document sign settings</param>
        /// <returns>Task of SignResult</returns>
        System.Threading.Tasks.Task<SignResult> CreateSignaturesAsync(CreateSignaturesRequest request);

        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signSettings">Document sign settings</param>
        /// <returns>Task of ApiResponse (SignResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SignResult>> CreateSignaturesAsyncWithHttpInfo(CreateSignaturesRequest request);
        /// <summary>
        /// Searches for signatures applied to the document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchSettings">Signatures search settings</param>
        /// <returns>Task of SearchResult</returns>
        System.Threading.Tasks.Task<SearchResult> SearchSignaturesAsync(SearchSignaturesRequest request);

        /// <summary>
        /// Searches for signatures applied to the document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchSettings">Signatures search settings</param>
        /// <returns>Task of ApiResponse (SearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SearchResult>> SearchSignaturesAsyncWithHttpInfo(SearchSignaturesRequest request);
        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
        /// <returns>Task of VerifyResult</returns>
        System.Threading.Tasks.Task<VerifyResult> VerifySignaturesAsync(VerifySignaturesRequest request);

        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
        /// <returns>Task of ApiResponse (VerifyResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<VerifyResult>> VerifySignaturesAsyncWithHttpInfo(VerifySignaturesRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SignApi : ISignApi
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
        /// Initializes a new instance of the <see cref="SignApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public SignApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SignApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder  
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signSettings">Document sign settings</param>
        /// <returns>SignResult</returns>
        public SignResult CreateSignatures(CreateSignaturesRequest request)
        {
             ApiResponse<SignResult> localVarResponse = CreateSignaturesWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder  
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signSettings">Document sign settings</param>
        /// <returns>ApiResponse of SignResult</returns>
        public ApiResponse<SignResult> CreateSignaturesWithHttpInfo(CreateSignaturesRequest request)
        {
            // verify the required parameter 'CreateSignatures.signSettings' is set
            if (request.signSettings == null)
                throw new ApiException(400, "Missing required parameter 'CreateSignatures.signSettings' when calling SignApi->CreateSignatures");

            var localVarPath = "./signature/create";
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

            if (request.signSettings != null && request.signSettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.signSettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.signSettings; // byte array
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
                Exception exception = _exceptionFactory("CreateSignatures", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<SignResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SignResult) _apiClient.Deserialize(localVarResponse, typeof(SignResult)));
        }

        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder  
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signSettings">Document sign settings</param>
        /// <returns>Task of SignResult</returns>
        public async System.Threading.Tasks.Task<SignResult> CreateSignaturesAsync(CreateSignaturesRequest request)
        {
             ApiResponse<SignResult> localVarResponse = await CreateSignaturesAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder  
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signSettings">Document sign settings</param>
        /// <returns>Task of ApiResponse (SignResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SignResult>> CreateSignaturesAsyncWithHttpInfo(CreateSignaturesRequest request)
        {
            // verify the required parameter 'CreateSignatures.signSettings' is set
            if (request.signSettings == null)
                throw new ApiException(400, "Missing required parameter 'CreateSignatures.signSettings' when calling SignApi->CreateSignatures");

            var localVarPath = "./signature/create";
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

            if (request.signSettings != null && request.signSettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.signSettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.signSettings; // byte array
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
                Exception exception = _exceptionFactory("CreateSignatures", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<SignResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SignResult) _apiClient.Deserialize(localVarResponse, typeof(SignResult)));
        }

        /// <summary>
        /// Searches for signatures applied to the document 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchSettings">Signatures search settings</param>
        /// <returns>SearchResult</returns>
        public SearchResult SearchSignatures(SearchSignaturesRequest request)
        {
             ApiResponse<SearchResult> localVarResponse = SearchSignaturesWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Searches for signatures applied to the document 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchSettings">Signatures search settings</param>
        /// <returns>ApiResponse of SearchResult</returns>
        public ApiResponse<SearchResult> SearchSignaturesWithHttpInfo(SearchSignaturesRequest request)
        {
            // verify the required parameter 'SearchSignatures.searchSettings' is set
            if (request.searchSettings == null)
                throw new ApiException(400, "Missing required parameter 'SearchSignatures.searchSettings' when calling SignApi->SearchSignatures");

            var localVarPath = "./signature/search";
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

            if (request.searchSettings != null && request.searchSettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.searchSettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.searchSettings; // byte array
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
                Exception exception = _exceptionFactory("SearchSignatures", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<SearchResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SearchResult) _apiClient.Deserialize(localVarResponse, typeof(SearchResult)));
        }

        /// <summary>
        /// Searches for signatures applied to the document 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchSettings">Signatures search settings</param>
        /// <returns>Task of SearchResult</returns>
        public async System.Threading.Tasks.Task<SearchResult> SearchSignaturesAsync(SearchSignaturesRequest request)
        {
             ApiResponse<SearchResult> localVarResponse = await SearchSignaturesAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Searches for signatures applied to the document 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchSettings">Signatures search settings</param>
        /// <returns>Task of ApiResponse (SearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchResult>> SearchSignaturesAsyncWithHttpInfo(SearchSignaturesRequest request)
        {
            // verify the required parameter 'SearchSignatures.searchSettings' is set
            if (request.searchSettings == null)
                throw new ApiException(400, "Missing required parameter 'SearchSignatures.searchSettings' when calling SignApi->SearchSignatures");

            var localVarPath = "./signature/search";
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

            if (request.searchSettings != null && request.searchSettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.searchSettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.searchSettings; // byte array
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
                Exception exception = _exceptionFactory("SearchSignatures", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<SearchResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SearchResult) _apiClient.Deserialize(localVarResponse, typeof(SearchResult)));
        }

        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
        /// <returns>VerifyResult</returns>
        public VerifyResult VerifySignatures(VerifySignaturesRequest request)
        {
             ApiResponse<VerifyResult> localVarResponse = VerifySignaturesWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
        /// <returns>ApiResponse of VerifyResult</returns>
        public ApiResponse<VerifyResult> VerifySignaturesWithHttpInfo(VerifySignaturesRequest request)
        {
            // verify the required parameter 'VerifySignatures.verifySettings' is set
            if (request.verifySettings == null)
                throw new ApiException(400, "Missing required parameter 'VerifySignatures.verifySettings' when calling SignApi->VerifySignatures");

            var localVarPath = "./signature/verify";
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

            if (request.verifySettings != null && request.verifySettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.verifySettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.verifySettings; // byte array
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
                Exception exception = _exceptionFactory("VerifySignatures", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<VerifyResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (VerifyResult) _apiClient.Deserialize(localVarResponse, typeof(VerifyResult)));
        }

        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
        /// <returns>Task of VerifyResult</returns>
        public async System.Threading.Tasks.Task<VerifyResult> VerifySignaturesAsync(VerifySignaturesRequest request)
        {
             ApiResponse<VerifyResult> localVarResponse = await VerifySignaturesAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria 
        /// </summary>
        /// <exception cref="GroupDocs.Signature.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
        /// <returns>Task of ApiResponse (VerifyResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VerifyResult>> VerifySignaturesAsyncWithHttpInfo(VerifySignaturesRequest request)
        {
            // verify the required parameter 'VerifySignatures.verifySettings' is set
            if (request.verifySettings == null)
                throw new ApiException(400, "Missing required parameter 'VerifySignatures.verifySettings' when calling SignApi->VerifySignatures");

            var localVarPath = "./signature/verify";
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

            if (request.verifySettings != null && request.verifySettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.verifySettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.verifySettings; // byte array
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
                Exception exception = _exceptionFactory("VerifySignatures", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<VerifyResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (VerifyResult) _apiClient.Deserialize(localVarResponse, typeof(VerifyResult)));
        }

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CreateSignaturesRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.SignApi.CreateSignatures" /> operation.
    /// </summary>  
    public class CreateSignaturesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="CreateSignaturesRequest"/> class.
          /// </summary>        
          public CreateSignaturesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="CreateSignaturesRequest"/> class.
          /// </summary>
          /// <param name="signSettings">Document sign settings</param>
          public CreateSignaturesRequest(SignSettings signSettings)             
          {
              this.signSettings = signSettings;
          }

          /// <summary>
          /// Document sign settings
          /// </summary>  
          public SignSettings signSettings { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SearchSignaturesRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.SignApi.SearchSignatures" /> operation.
    /// </summary>  
    public class SearchSignaturesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="SearchSignaturesRequest"/> class.
          /// </summary>        
          public SearchSignaturesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="SearchSignaturesRequest"/> class.
          /// </summary>
          /// <param name="searchSettings">Signatures search settings</param>
          public SearchSignaturesRequest(SearchSettings searchSettings)             
          {
              this.searchSettings = searchSettings;
          }

          /// <summary>
          /// Signatures search settings
          /// </summary>  
          public SearchSettings searchSettings { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="VerifySignaturesRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.SignApi.VerifySignatures" /> operation.
    /// </summary>  
    public class VerifySignaturesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="VerifySignaturesRequest"/> class.
          /// </summary>        
          public VerifySignaturesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="VerifySignaturesRequest"/> class.
          /// </summary>
          /// <param name="verifySettings">Settings that includes different criteria to verify document signatures</param>
          public VerifySignaturesRequest(VerifySettings verifySettings)             
          {
              this.verifySettings = verifySettings;
          }

          /// <summary>
          /// Settings that includes different criteria to verify document signatures
          /// </summary>  
          public VerifySettings verifySettings { get; set; }
    }
}
