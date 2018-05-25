// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostDigitalFromUrlRequest.cs">
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
  /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.SignatureApi.PostDigitalFromUrl" /> operation.
  /// </summary>  
  public class PostDigitalFromUrlRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDigitalFromUrlRequest"/> class.
        /// </summary>        
        public PostDigitalFromUrlRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDigitalFromUrlRequest"/> class.
        /// </summary>
        /// <param name="url">The URL to retrieve document.</param>
        /// <param name="signOptionsData">Digital Signature Options for corresponding Document Type</param>
        /// <param name="password">Document password if required.</param>
        /// <param name="certificateFile">Digital certificate file name.</param>
        /// <param name="imageFile">Image file.</param>
        /// <param name="storage">The file storage which have to be used.</param>
        public PostDigitalFromUrlRequest(string url, SignOptionsData signOptionsData = null, string password = null, string certificateFile = null, string imageFile = null, string storage = null)             
        {
            this.Url = url;
            this.SignOptionsData = signOptionsData;
            this.Password = password;
            this.CertificateFile = certificateFile;
            this.ImageFile = imageFile;
            this.Storage = storage;
        }

        /// <summary>
        /// The URL to retrieve document.
        /// </summary>  
        public string Url { get; set; }

        /// <summary>
        /// Digital Signature Options for corresponding Document Type
        /// </summary>  
        public SignOptionsData SignOptionsData { get; set; }

        /// <summary>
        /// Document password if required.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Digital certificate file name.
        /// </summary>  
        public string CertificateFile { get; set; }

        /// <summary>
        /// Image file.
        /// </summary>  
        public string ImageFile { get; set; }

        /// <summary>
        /// The file storage which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }
}
