// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Configuration.cs">
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

namespace GroupDocs.Signature.Cloud.Sdk.Client
{
    /// <summary>
    /// Represents a set of configuration settings.
    /// </summary>
    public class Configuration
    {
        private string _apiVersion = "/v2.0";
        private string _apiBaseUrl = "https://api.groupdocs.cloud";

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Server URL, default value is https://api.groupdocs.cloud
        /// </summary>
        public string ApiBaseUrl
        {
            get
            {
                return this._apiBaseUrl;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this._apiBaseUrl = value.TrimEnd('/');
                }

                this._apiBaseUrl = value;
            }
        }
        
        /// <summary>
        /// Application identifier (App SID)
        /// </summary>
        public string AppSid { get; set; }

        /// <summary>
        /// Application private key (App Key)
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public Configuration(string appSid, string appKey)
        {
            if (string.IsNullOrEmpty(appSid))
            {
                throw new ArgumentNullException("appSid",
                    "Get your App SID and App Key at https://dashboard.groupdocs.cloud");
            }

            if (string.IsNullOrEmpty(appKey))
            {
                throw new ArgumentNullException("appKey",
                    "Get your App SID and App Key at https://dashboard.groupdocs.cloud");
            }

            this.AppSid = appSid;
            this.AppKey = appKey;

            Timeout = 1000 * 100;
        }

        /// <summary>
        /// Retrieves server URL e.g. https://api.groupdocs.cloud/v2.0
        /// </summary>
        /// <returns>Server URL</returns>
        internal string GetServerUrl()
        {
            return _apiBaseUrl.TrimEnd('/') + _apiVersion;
        }
    }
}
