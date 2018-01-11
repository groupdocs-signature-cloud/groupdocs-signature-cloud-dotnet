// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ResponseMessage.cs">
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

namespace GroupDocs.Signature.Cloud.Sdk.Model.Responses
{
    using System.Text;

    /// <summary>
    /// Response message.
    /// </summary>
    public class ResponseMessage
    {
        /// <summary>
        /// ctor.
        /// </summary>
        public ResponseMessage()
        {
        }

        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="responseStream">The response stream.</param>
        /// <param name="code">The code.</param>
        /// <param name="status">The status.</param>
        public ResponseMessage(byte[] responseStream, int code, string status)
        {
            this.Code = code;
            this.Status = status;
            this.ResponseStream = responseStream;
        }

        /// <summary>
        /// The code.
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// The status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The response stream.
        /// </summary>
        public byte[] ResponseStream { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("class ResponseMessage {\n");
            stringBuilder.Append("  Code: ").Append(this.Code).Append("\n");
            stringBuilder.Append("  Message: ").Append(this.Message).Append("\n");
            stringBuilder.Append("}\n");
            return stringBuilder.ToString();
        }
    }
}