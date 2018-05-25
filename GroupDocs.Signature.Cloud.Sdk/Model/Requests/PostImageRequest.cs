// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostImageRequest.cs">
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

namespace GroupDocs.Signature.Cloud.Sdk.Model.Requests 
{
  using GroupDocs.Signature.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.SignatureApi.PostImage" /> operation.
  /// </summary>  
  public class PostImageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageRequest"/> class.
        /// </summary>        
        public PostImageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageRequest"/> class.
        /// </summary>
        /// <param name="name">The document name</param>
        /// <param name="signOptionsData">Image Signature Options for corresponding Document Type</param>
        /// <param name="password">Document password if required.</param>
        /// <param name="folder">The folder name</param>
        /// <param name="image">The Image name</param>
        /// <param name="storage">The file storage which have to be used.</param>
        public PostImageRequest(string name, SignOptionsData signOptionsData = null, string password = null, string folder = null, string image = null, string storage = null)             
        {
            this.Name = name;
            this.SignOptionsData = signOptionsData;
            this.Password = password;
            this.Folder = folder;
            this.Image = image;
            this.Storage = storage;
        }

        /// <summary>
        /// The document name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Image Signature Options for corresponding Document Type
        /// </summary>  
        public SignOptionsData SignOptionsData { get; set; }

        /// <summary>
        /// Document password if required.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// The folder name
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The Image name
        /// </summary>  
        public string Image { get; set; }

        /// <summary>
        /// The file storage which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }
}
