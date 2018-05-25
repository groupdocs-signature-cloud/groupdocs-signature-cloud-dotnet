// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="FileExistResponse.cs">
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

namespace GroupDocs.Signature.Cloud.Sdk.Model.Responses
{
    using System.Text;

    /// <summary>
    /// File exist response.
    /// </summary>
    public class FileExistResponse
    {
        /// <summary>
        /// File exists.
        /// </summary>
        public FileExist FileExist { get; set; }

        /// <summary>
        /// The code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("class FileExistResponse {\n");
            stringBuilder.Append("  FileExist: ").Append((object)this.FileExist).Append("\n");
            stringBuilder.Append("  Code: ").Append(this.Code).Append("\n");
            stringBuilder.Append("  Status: ").Append(this.Status).Append("\n");
            stringBuilder.Append("}\n");
            return stringBuilder.ToString();
        }
    }
}