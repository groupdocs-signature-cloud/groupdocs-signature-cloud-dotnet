// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DocumentResponse.cs">
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

namespace GroupDocs.Signature.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Base class for all responses.
  /// </summary>  
  public class DocumentResponse 
  {                       
        /// <summary>
        /// Response status code.
        /// </summary>
        /// <value>Response status code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        { 
            /// <summary>
            /// Enum Continue for "Continue"
            /// </summary>            
            Continue,
            
            /// <summary>
            /// Enum SwitchingProtocols for "SwitchingProtocols"
            /// </summary>            
            SwitchingProtocols,
            
            /// <summary>
            /// Enum OK for "OK"
            /// </summary>            
            OK,
            
            /// <summary>
            /// Enum Created for "Created"
            /// </summary>            
            Created,
            
            /// <summary>
            /// Enum Accepted for "Accepted"
            /// </summary>            
            Accepted,
            
            /// <summary>
            /// Enum NonAuthoritativeInformation for "NonAuthoritativeInformation"
            /// </summary>            
            NonAuthoritativeInformation,
            
            /// <summary>
            /// Enum NoContent for "NoContent"
            /// </summary>            
            NoContent,
            
            /// <summary>
            /// Enum ResetContent for "ResetContent"
            /// </summary>            
            ResetContent,
            
            /// <summary>
            /// Enum PartialContent for "PartialContent"
            /// </summary>            
            PartialContent,
            
            /// <summary>
            /// Enum MultipleChoices for "MultipleChoices"
            /// </summary>            
            MultipleChoices,
            
            /// <summary>
            /// Enum Ambiguous for "Ambiguous"
            /// </summary>            
            Ambiguous,
            
            /// <summary>
            /// Enum MovedPermanently for "MovedPermanently"
            /// </summary>            
            MovedPermanently,
            
            /// <summary>
            /// Enum Moved for "Moved"
            /// </summary>            
            Moved,
            
            /// <summary>
            /// Enum Found for "Found"
            /// </summary>            
            Found,
            
            /// <summary>
            /// Enum Redirect for "Redirect"
            /// </summary>            
            Redirect,
            
            /// <summary>
            /// Enum SeeOther for "SeeOther"
            /// </summary>            
            SeeOther,
            
            /// <summary>
            /// Enum RedirectMethod for "RedirectMethod"
            /// </summary>            
            RedirectMethod,
            
            /// <summary>
            /// Enum NotModified for "NotModified"
            /// </summary>            
            NotModified,
            
            /// <summary>
            /// Enum UseProxy for "UseProxy"
            /// </summary>            
            UseProxy,
            
            /// <summary>
            /// Enum Unused for "Unused"
            /// </summary>            
            Unused,
            
            /// <summary>
            /// Enum TemporaryRedirect for "TemporaryRedirect"
            /// </summary>            
            TemporaryRedirect,
            
            /// <summary>
            /// Enum RedirectKeepVerb for "RedirectKeepVerb"
            /// </summary>            
            RedirectKeepVerb,
            
            /// <summary>
            /// Enum BadRequest for "BadRequest"
            /// </summary>            
            BadRequest,
            
            /// <summary>
            /// Enum Unauthorized for "Unauthorized"
            /// </summary>            
            Unauthorized,
            
            /// <summary>
            /// Enum PaymentRequired for "PaymentRequired"
            /// </summary>            
            PaymentRequired,
            
            /// <summary>
            /// Enum Forbidden for "Forbidden"
            /// </summary>            
            Forbidden,
            
            /// <summary>
            /// Enum NotFound for "NotFound"
            /// </summary>            
            NotFound,
            
            /// <summary>
            /// Enum MethodNotAllowed for "MethodNotAllowed"
            /// </summary>            
            MethodNotAllowed,
            
            /// <summary>
            /// Enum NotAcceptable for "NotAcceptable"
            /// </summary>            
            NotAcceptable,
            
            /// <summary>
            /// Enum ProxyAuthenticationRequired for "ProxyAuthenticationRequired"
            /// </summary>            
            ProxyAuthenticationRequired,
            
            /// <summary>
            /// Enum RequestTimeout for "RequestTimeout"
            /// </summary>            
            RequestTimeout,
            
            /// <summary>
            /// Enum Conflict for "Conflict"
            /// </summary>            
            Conflict,
            
            /// <summary>
            /// Enum Gone for "Gone"
            /// </summary>            
            Gone,
            
            /// <summary>
            /// Enum LengthRequired for "LengthRequired"
            /// </summary>            
            LengthRequired,
            
            /// <summary>
            /// Enum PreconditionFailed for "PreconditionFailed"
            /// </summary>            
            PreconditionFailed,
            
            /// <summary>
            /// Enum RequestEntityTooLarge for "RequestEntityTooLarge"
            /// </summary>            
            RequestEntityTooLarge,
            
            /// <summary>
            /// Enum RequestUriTooLong for "RequestUriTooLong"
            /// </summary>            
            RequestUriTooLong,
            
            /// <summary>
            /// Enum UnsupportedMediaType for "UnsupportedMediaType"
            /// </summary>            
            UnsupportedMediaType,
            
            /// <summary>
            /// Enum RequestedRangeNotSatisfiable for "RequestedRangeNotSatisfiable"
            /// </summary>            
            RequestedRangeNotSatisfiable,
            
            /// <summary>
            /// Enum ExpectationFailed for "ExpectationFailed"
            /// </summary>            
            ExpectationFailed,
            
            /// <summary>
            /// Enum UpgradeRequired for "UpgradeRequired"
            /// </summary>            
            UpgradeRequired,
            
            /// <summary>
            /// Enum InternalServerError for "InternalServerError"
            /// </summary>            
            InternalServerError,
            
            /// <summary>
            /// Enum NotImplemented for "NotImplemented"
            /// </summary>            
            NotImplemented,
            
            /// <summary>
            /// Enum BadGateway for "BadGateway"
            /// </summary>            
            BadGateway,
            
            /// <summary>
            /// Enum ServiceUnavailable for "ServiceUnavailable"
            /// </summary>            
            ServiceUnavailable,
            
            /// <summary>
            /// Enum GatewayTimeout for "GatewayTimeout"
            /// </summary>            
            GatewayTimeout,
            
            /// <summary>
            /// Enum HttpVersionNotSupported for "HttpVersionNotSupported"
            /// </summary>            
            HttpVersionNotSupported            
        }

        /// <summary>
        /// Response status code.
        /// </summary>
        public CodeEnum? Code { get; set; }

        /// <summary>
        /// Output File Name.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// Output folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Response status.
        /// </summary>  
        public string Status { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentResponse {\n");
          sb.Append("  FileName: ").Append(this.FileName).Append("\n");
          sb.Append("  Folder: ").Append(this.Folder).Append("\n");
          sb.Append("  Code: ").Append(this.Code).Append("\n");
          sb.Append("  Status: ").Append(this.Status).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
