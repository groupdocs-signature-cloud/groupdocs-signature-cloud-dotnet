using System;
using Newtonsoft.Json.Linq;

namespace GroupDocs.Signature.Cloud.Sdk
{
    using GroupDocs.Signature.Cloud.Sdk.Model;
    

    internal class SearchSignatureJsonConverter : JsonCreationConverter<Signature>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <param name="jObject"></param>
        /// <returns></returns>
        protected override Signature Create(Type objectType, JObject jObject)
        {
            var signatureType = GetSignatureType(jObject);
            if (signatureType == Signature.SignatureTypeEnum.Barcode)
                return new BarcodeSignature();

            if (signatureType == Signature.SignatureTypeEnum.QRCode)
                return new QRCodeSignature();

            if (signatureType == Signature.SignatureTypeEnum.Digital)
                return new DigitalSignature();

            if (signatureType == Signature.SignatureTypeEnum.Text)
                return new TextSignature();

            if (signatureType == Signature.SignatureTypeEnum.Image)
                return new ImageSignature();

            return new Signature();
        }

        protected Signature.SignatureTypeEnum GetSignatureType(JObject jObject)
        {
            Signature.SignatureTypeEnum result = Signature.SignatureTypeEnum.None;
            string type = jObject["SignatureType"]?.ToString();
            if (String.IsNullOrEmpty(type))
            {
                type = jObject["signatureType"]?.ToString();
            }
            if (!string.IsNullOrEmpty(type))
            {
                try
                {
                    result = (Signature.SignatureTypeEnum)Enum.Parse(typeof(Signature.SignatureTypeEnum), type);
                }
                catch (Exception)
                {
                    result = Signature.SignatureTypeEnum.None;
                }
            }
            return result;
        }
    }
}
