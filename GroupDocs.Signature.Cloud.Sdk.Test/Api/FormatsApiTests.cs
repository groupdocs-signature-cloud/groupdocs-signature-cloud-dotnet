namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;

    public class FormatsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetSupportedFileFormats
        /// </summary>
        [Test]
        public void GetSupportedFileFormatsTest()
        {
            var request = new GetSupportedFormatsRequest();

            var response = SignatureApi.GetSupportedFormats(request);

            Assert.IsTrue(response.Formats.Count > 0);
            foreach (var entry in response.Formats)
            {
                Assert.IsNotEmpty(entry.Extension);
                Assert.IsNotEmpty(entry.FileFormat);
            }
        }
    }
}