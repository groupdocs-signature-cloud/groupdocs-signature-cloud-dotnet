// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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


using GroupDocs.Signature.Cloud.Sdk.Model;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    public class TestFile
    {
        public string Path { get; private set; }

        public string Extension { get; set; }

        public string FileFormat { get; set; }

        public int MaxPageHeight { get; set; }

        public int MaxPageWidth { get; set; }

        public int PagesCount { get; set; }

        public int Size { get; set; }

        public string Password { get; set; }

        public string Name
        {
            get { return System.IO.Path.GetFileName(Path); }
        }

        public string Folder
        {
            get { return System.IO.Path.GetDirectoryName(Path); }
        }

        public TestFile(string path)
        {
            Path = path;
        }

        public FileInfo GetFileInfo()
        {
            FileInfo result = new FileInfo();

            result.FilePath = this.Path;
            result.Password = this.Password;

            return result;
        }
    }
}