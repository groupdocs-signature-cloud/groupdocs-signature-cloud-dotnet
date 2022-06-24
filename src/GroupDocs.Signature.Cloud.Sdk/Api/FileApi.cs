// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="FileApi.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    public class FileApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

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
        /// Initializes a new instance of the <see cref="FileApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public FileApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public void CopyFile(CopyFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/storage/file/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public void DeleteFile(DeleteFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DownloadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public void MoveFile(MoveFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/storage/file/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling UploadFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling UploadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/signature/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);

            if (response != null)
            {
                return (FilesUploadResult)SerializationHelper.Deserialize(response, typeof(FilesUploadResult));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CopyFileRequest.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
