namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;

    public class BarcodesApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetFonts
        /// </summary>
        [Test]
        public void GetFontsTest()
        {
            var request = new GetBarcodesRequest();

            var response = SignatureApi.GetBarcodes(request);

            Assert.IsTrue(response.BarcodeTypes.Count > 0);
            foreach (var entry in response.BarcodeTypes)
                Assert.IsNotEmpty(entry.Name);
        }
    }
}