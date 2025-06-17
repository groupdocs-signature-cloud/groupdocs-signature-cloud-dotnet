// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignApi.cs">
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
    public class SignApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

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
        /// Initializes a new instance of the <see cref="SignApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public SignApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Creates new signatures in the document and saves resultant document into &#39;Output&#39; folder  
        /// </summary>
        /// <param name="request">Request. <see cref="CreateSignaturesRequest" /></param>
        /// <returns><see cref="SignResult"/></returns>
        public SignResult CreateSignatures(CreateSignaturesRequest request)
        {
            // verify the required parameter 'signSettings' is set
            if (request.signSettings == null) 
            {
                throw new ApiException(400, "Missing required parameter 'signSettings' when calling CreateSignatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/create";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.signSettings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SignResult)SerializationHelper.Deserialize(response, typeof(SignResult));
            }

            return null;
        }

        /// <summary>
        /// Deletes signatures in the document 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSignaturesRequest" /></param>
        /// <returns><see cref="DeleteResult"/></returns>
        public DeleteResult DeleteSignatures(DeleteSignaturesRequest request)
        {
            // verify the required parameter 'deleteSettings' is set
            if (request.deleteSettings == null) 
            {
                throw new ApiException(400, "Missing required parameter 'deleteSettings' when calling DeleteSignatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/delete";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.deleteSettings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DeleteResult)SerializationHelper.Deserialize(response, typeof(DeleteResult));
            }

            return null;
        }

        /// <summary>
        /// Searches for signatures applied to the document 
        /// </summary>
        /// <param name="request">Request. <see cref="SearchSignaturesRequest" /></param>
        /// <returns><see cref="SearchResult"/></returns>
        public SearchResult SearchSignatures(SearchSignaturesRequest request)
        {
            // verify the required parameter 'searchSettings' is set
            if (request.searchSettings == null) 
            {
                throw new ApiException(400, "Missing required parameter 'searchSettings' when calling SearchSignatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.searchSettings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchResult)SerializationHelper.Deserialize(response, typeof(SearchResult));
            }

            return null;
        }

        /// <summary>
        /// Updates signatures in the document 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSignaturesRequest" /></param>
        /// <returns><see cref="UpdateResult"/></returns>
        public UpdateResult UpdateSignatures(UpdateSignaturesRequest request)
        {
            // verify the required parameter 'updateSettings' is set
            if (request.updateSettings == null) 
            {
                throw new ApiException(400, "Missing required parameter 'updateSettings' when calling UpdateSignatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/update";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.updateSettings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (UpdateResult)SerializationHelper.Deserialize(response, typeof(UpdateResult));
            }

            return null;
        }

        /// <summary>
        /// Verifies whether document contains signatures that meet the specified criteria 
        /// </summary>
        /// <param name="request">Request. <see cref="VerifySignaturesRequest" /></param>
        /// <returns><see cref="VerifyResult"/></returns>
        public VerifyResult VerifySignatures(VerifySignaturesRequest request)
        {
            // verify the required parameter 'verifySettings' is set
            if (request.verifySettings == null) 
            {
                throw new ApiException(400, "Missing required parameter 'verifySettings' when calling VerifySignatures");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/verify";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.verifySettings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (VerifyResult)SerializationHelper.Deserialize(response, typeof(VerifyResult));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CreateSignaturesRequest.cs">
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
// <copyright company="Aspose Pty Ltd" file="DeleteSignaturesRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.SignApi.DeleteSignatures" /> operation.
    /// </summary>  
    public class DeleteSignaturesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteSignaturesRequest"/> class.
          /// </summary>        
          public DeleteSignaturesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteSignaturesRequest"/> class.
          /// </summary>
          /// <param name="deleteSettings">Delete signatures settings</param>
          public DeleteSignaturesRequest(DeleteSettings deleteSettings)             
          {
              this.deleteSettings = deleteSettings;
          }
          
          /// <summary>
          /// Delete signatures settings
          /// </summary>  
          public DeleteSettings deleteSettings { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SearchSignaturesRequest.cs">
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
// <copyright company="Aspose Pty Ltd" file="UpdateSignaturesRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.SignApi.UpdateSignatures" /> operation.
    /// </summary>  
    public class UpdateSignaturesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="UpdateSignaturesRequest"/> class.
          /// </summary>        
          public UpdateSignaturesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="UpdateSignaturesRequest"/> class.
          /// </summary>
          /// <param name="updateSettings">Update signatures settings</param>
          public UpdateSignaturesRequest(UpdateSettings updateSettings)             
          {
              this.updateSettings = updateSettings;
          }
          
          /// <summary>
          /// Update signatures settings
          /// </summary>  
          public UpdateSettings updateSettings { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="VerifySignaturesRequest.cs">
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
