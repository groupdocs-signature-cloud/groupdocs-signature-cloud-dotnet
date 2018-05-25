using System.Collections.Generic;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    [Category("Pdf_Signatures_API_Tests")]
    public class PdfSignaturesProvider_ApiTests : SignaturesProviderApiTest
    {
        #region Barcode Signatures API Tests

        protected override SignBarcodeOptionsData GetSignBarcodeOptionsData()
        {
            var result = new PdfSignBarcodeOptionsData()
            {
                
            };
            return result;
        }
        /// <summary>
        /// Test Signature Post Barcode
        /// </summary>
        [Test]
        public void PostBarcodeTest() => AssertPostBarcode(TestFiles.PdfDocs);

        /// <summary>
        /// Test Signature Post Barcode from Url
        /// </summary>
        [Test]
        public void PostBarcodeTestUrl()
        {
            var files = new List<TestFile>();
            files.Add(TestFiles.PdfUrl);
            AssertPostBarcodeUrl(files);
        }
        #endregion
    }
}