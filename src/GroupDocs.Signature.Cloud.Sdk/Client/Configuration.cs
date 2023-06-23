// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Configuration.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
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

namespace GroupDocs.Signature.Cloud.Sdk.Client
{
    using System;

    /// <summary>
    /// Represents a set of configuration settings.
    /// </summary>
    public class Configuration
    {
        private const string ApiVersion = "/v2.0";
        private string _apiBaseUrl = "https://api.groupdocs.cloud";

        /// <summary>
        /// Request timeout, default value is 100000 ms 
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public Configuration(string appSid, string appKey)
        {
            if (string.IsNullOrEmpty(appSid))
            {
                throw new ArgumentNullException(nameof(appSid),
                    "Get your App SID and App Key at https://dashboard.groupdocs.cloud");
            }

            if (string.IsNullOrEmpty(appKey))
            {
                throw new ArgumentNullException(nameof(appKey),
                    "Get your App SID and App Key at https://dashboard.groupdocs.cloud");
            }

            AppSid = appSid;
            AppKey = appKey;
            Timeout = 100000;
        }

        /// <summary>
        /// Server URL, default value is https://api.groupdocs.cloud
        /// </summary>
        public string ApiBaseUrl
        {
            get => _apiBaseUrl;

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _apiBaseUrl = value.TrimEnd('/');
                }

                _apiBaseUrl = value;
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
        /// Enables printing out additional information about each request
        /// </summary>
        public bool DebugMode { get; set; }

        /// <summary>
        /// Retrieves server URL e.g. https://api.groupdocs.cloud/v1
        /// </summary>
        /// <returns>Server URL</returns>
        internal string GetServerUrl()
        {
            return _apiBaseUrl.TrimEnd('/') + ApiVersion;
        }
    }
}
