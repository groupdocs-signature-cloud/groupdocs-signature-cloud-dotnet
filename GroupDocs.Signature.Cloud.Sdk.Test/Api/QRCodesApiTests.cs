namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;

    public class QRCodesApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetFonts
        /// </summary>
        [Test]
        public void GetQRCodesTest()
        {
            var request = new GetQRCodesRequest();

            var response = SignatureApi.GetQRCodes(request);

            Assert.IsTrue(response.QRCodeTypes.Count > 0);
            foreach (var entry in response.QRCodeTypes)
                Assert.IsNotEmpty(entry.Name);
        }
    }
}