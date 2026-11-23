using System.Collections.Generic;
using GroupDocs.Signature.Cloud.Sdk.Client;
using GroupDocs.Signature.Cloud.Sdk.Model;
using SignatureModel = GroupDocs.Signature.Cloud.Sdk.Model.Signature;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test
{
    using static OptionsBase;

    public class TestsImageDigitalModels
    {
        [Test]
        public void SignImageDigitalOptionsSerializeInSignSettings()
        {
            var settings = new SignSettings
            {
                Options = new List<SignOptions>
                {
                    new SignImageDigitalOptions
                    {
                        SignatureType = SignatureTypeEnum.ImageDigital,
                        Password = "signature-password"
                    }
                }
            };

            var json = JObject.Parse(SerializationHelper.Serialize(settings));

            Assert.AreEqual("ImageDigital", (string)json["Options"][0]["SignatureType"]);
            Assert.AreEqual("signature-password", (string)json["Options"][0]["Password"]);
        }

        [Test]
        public void VerifyImageDigitalOptionsSerializeInVerifySettings()
        {
            var settings = new VerifySettings
            {
                Options = new List<VerifyOptions>
                {
                    new VerifyImageDigitalOptions
                    {
                        SignatureType = SignatureTypeEnum.ImageDigital,
                        Password = "signature-password",
                        DetectionThresholdPercent = 85,
                        UseFullDataExtraction = false
                    }
                }
            };

            var json = JObject.Parse(SerializationHelper.Serialize(settings));

            Assert.AreEqual("ImageDigital", (string)json["Options"][0]["SignatureType"]);
            Assert.AreEqual("signature-password", (string)json["Options"][0]["Password"]);
            Assert.AreEqual(85, (int)json["Options"][0]["DetectionThresholdPercent"]);
            Assert.AreEqual(false, (bool)json["Options"][0]["UseFullDataExtraction"]);
        }

        [Test]
        public void ImageDigitalSignatureTypeSerializesAcrossModels()
        {
            var deleteOptions = new DeleteOptions { SignatureType = DeleteOptions.SignatureTypeEnum.ImageDigital };
            var updateOptions = new UpdateOptions { SignatureType = UpdateOptions.SignatureTypeEnum.ImageDigital };
            var signature = new SignatureModel { SignatureType = SignatureModel.SignatureTypeEnum.ImageDigital };

            Assert.AreEqual("ImageDigital", (string)JObject.Parse(SerializationHelper.Serialize(deleteOptions))["SignatureType"]);
            Assert.AreEqual("ImageDigital", (string)JObject.Parse(SerializationHelper.Serialize(updateOptions))["SignatureType"]);
            Assert.AreEqual("ImageDigital", (string)JObject.Parse(SerializationHelper.Serialize(signature))["SignatureType"]);
        }

        [Test]
        public void PdfDigitalSignatureAppearanceSerializesForegroundFlag()
        {
            var appearance = new PdfDigitalSignatureAppearance { IsForegroundImage = false };

            var json = JObject.Parse(SerializationHelper.Serialize(appearance));

            Assert.AreEqual(false, (bool)json["IsForegroundImage"]);
        }
    }
}
