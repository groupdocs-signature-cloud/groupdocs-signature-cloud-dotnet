// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AuthWithSignatureRequestHandler.cs">
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

namespace GroupDocs.Signature.Cloud.Sdk.Internal.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;
    using System.Security.Cryptography;
    using System.Text;
    using GroupDocs.Signature.Cloud.Sdk.Api;

    internal class AuthWithSignatureRequestHandler : IRequestHandler
    {
        private readonly Configuration configuration;

        public AuthWithSignatureRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public string ProcessUrl(string url)
        {
            if (this.configuration.AuthType != AuthType.RequestSignature)
            {
                return url;
            }

            url = UrlHelper.AddQueryParameterToUrl(url, "appsid", this.configuration.AppSid);
            url = this.Sign(url);

            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
        }

        private string Sign(string url)
        {
            var signature = this.GetSignature(url, this.configuration.AppKey);
            var signedUrl = string.Format("{0}&signature={1}", url, signature);

            return signedUrl;
        }

        private string GetSignature(string url, string key)
        {
            var encoding = new ASCIIEncoding();

            var usablePrivateKey = key.Replace("-", "+").Replace("_", "/");
            var privateKeyBytes = Convert.FromBase64String(usablePrivateKey);

            var uri = new Uri(url);
            var encodedPathAndQueryBytes = encoding.GetBytes(uri.LocalPath + uri.Query);

            var algorithm = new HMACSHA1(privateKeyBytes);
            var hash = algorithm.ComputeHash(encodedPathAndQueryBytes);

            var result = Convert.ToBase64String(hash).Replace("+", "-").Replace("/", "_");
            return result;
        }
    }
}