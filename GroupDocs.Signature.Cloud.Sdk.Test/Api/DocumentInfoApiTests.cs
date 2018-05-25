using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;
    using System;

    public class DocumentInfoApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetDocumentInfo
        /// </summary>
        [Test]
        public void DocumentInfoTests()
        {
            var file = TestFiles.WordsDocs.FirstOrDefault();

            var request = new GetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = file.Password,
                Folder = file.Folder,
                Storage = null,
            };

            var response = SignatureApi.GetDocumentInfo(request);

            Assert.AreEqual(file.FileName, response.Name);
            Assert.AreEqual(1, response.Pages.TotalCount);
        }

        /// <summary>
        /// Test GetDocumentInfo with password
        /// </summary>
        [Test]
        public void DocumentInfoTestsPassword()
        {
            var files = new List<TestFile>();
            files.AddRange(TestFiles.PdfDocs.Where(p => !string.IsNullOrEmpty(p.Password)).ToList());
            files.AddRange(TestFiles.WordsDocs.Where(p => !string.IsNullOrEmpty(p.Password)).ToList());
            files.AddRange(TestFiles.CellsDocs.Where(p => !string.IsNullOrEmpty(p.Password)).ToList());
            files.AddRange(TestFiles.SlidesDocs.Where(p => !string.IsNullOrEmpty(p.Password)).ToList());

            foreach (var file in files)
            {
                var request = new GetDocumentInfoRequest
                {
                    FileName = file.FileName,
                    Password = file.Password,
                    Folder = file.Folder,
                    Storage = null,
                };

                var response = SignatureApi.GetDocumentInfo(request);
                Assert.AreEqual(file.FileName, response.Name);
                Assert.IsTrue(response.Pages.TotalCount>0);
            }
        }

        /// <summary>
        /// Test DocumentInfoTests
        /// </summary>
        [Test]
        public void DocumentInfoTestsWrongFile()
        {
            var file = TestFiles.WrongFile01;

            var request = new GetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                Folder = file.Folder,
                Storage = null,
            };

            String exMesage = "";
            try
            {
                var response = SignatureApi.GetDocumentInfo(request);
            }
            catch (Exception ex)
            {
                exMesage = ex.Message;
            }

            Assert.IsTrue(exMesage.Contains("AmazonS3 exception: Error 'The specified key does not exist."));
        }

        /// <summary>
        /// Test DocumentInfoTests
        /// </summary>
        [Test]
        public void DocumentInfoFromUrlTests()
        {
            var request = new GetDocumentInfoFromUrlRequest
            {
                Url = @"https://www.dropbox.com/s/bzx1xm68zd0c910/PieChart.docx?dl=0",
                Password = null,
                Storage = null,
            };

            var response = SignatureApi.GetDocumentInfoFromUrl(request);
            Assert.AreEqual(1, response.Pages.TotalCount);
        }

        /// <summary>
        /// Test GetDocumentInfo
        /// </summary>
        [Test]
        public void DocumentInfoTestsAll()
        {
            StringBuilder result = new StringBuilder();
            int counter = 0;

            foreach (var file in TestFiles.AllFiles)
            {
                if (!file.FileName.Contains("_pwd"))
                {
                    continue;
                }

                var request = new GetDocumentInfoRequest
                {
                    FileName = file.FileName,
                    Password = file.Password,
                    Folder = file.Folder,
                    Storage = null,
                };
                bool error = false;
                try
                {
                    var response = SignatureApi.GetDocumentInfo(request);
                    if (file.FileName != response.Name || response.Pages.TotalCount < 1) { error = true; }
                }
                catch(Exception ex) 
                {
                    error = true; 
                }

                if (error)
                {
                    if (result.Length > 0) { result.Append(", "); }
                    result.Append(counter++ + ". " + file.FileName);
                }

            }

            foreach (var file in TestFiles.AllSigned)
            {
                var request = new GetDocumentInfoRequest
                {
                    FileName = file.FileName,
                    Password = file.Password,
                    Folder = file.Folder,
                    Storage = null,
                };
                bool error = false;
                try
                {
                    var response = SignatureApi.GetDocumentInfo(request);
                    if (file.FileName != response.Name || response.Pages.TotalCount < 1){error = true;}
                }
                catch (Exception ex)
                {
                    error = true;
                }

                if (error)
                {
                    if (result.Length > 0) { result.Append(", "); }
                    result.Append(counter++ + ". " + file.FileName);
                }
            }
            
            Assert.AreEqual(0, result.Length, counter + " from " + (TestFiles.AllFiles.Count + TestFiles.AllSigned.Count) + " failed: " + result.ToString());
        }

    }
}