// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostVerificationQRCodeFromUrlRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
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
  /// Request model for <see cref="GroupDocs.Signature.Cloud.Sdk.Api.SignatureApi.PostVerificationQRCodeFromUrl" /> operation.
  /// </summary>  
  public class PostVerificationQRCodeFromUrlRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostVerificationQRCodeFromUrlRequest"/> class.
        /// </summary>        
        public PostVerificationQRCodeFromUrlRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostVerificationQRCodeFromUrlRequest"/> class.
        /// </summary>
        /// <param name="url">The url of document.</param>
        /// <param name="verifyOptionsData">Verification Options</param>
        /// <param name="password">Document password if required.</param>
        /// <param name="storage">The file storage which have to be used.</param>
        public PostVerificationQRCodeFromUrlRequest(string url, VerifyOptionsData verifyOptionsData = null, string password = null, string storage = null)             
        {
            this.Url = url;
            this.VerifyOptionsData = verifyOptionsData;
            this.Password = password;
            this.Storage = storage;
        }

        /// <summary>
        /// The url of document.
        /// </summary>  
        public string Url { get; set; }

        /// <summary>
        /// Verification Options
        /// </summary>  
        public VerifyOptionsData VerifyOptionsData { get; set; }

        /// <summary>
        /// Document password if required.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// The file storage which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }
}
