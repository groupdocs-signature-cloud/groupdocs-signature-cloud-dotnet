using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Signature result = null;
            Signature.SignatureTypeEnum signatureType = GetSignatureType(jObject);
            // check SignatureType
            // check for barcode options
            if (result == null && signatureType == Signature.SignatureTypeEnum.Barcode)
            {
                result = new BarcodeSignature();
            }
            // check for qrcode options
            if (result == null && signatureType == Signature.SignatureTypeEnum.QRCode)
            {
                result = new QRCodeSignature();
            }
            // check for digital options
            if (result == null && signatureType == Signature.SignatureTypeEnum.Digital)
            {
                result = new DigitalSignature();
            }

            return result;
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
                if (!Enum.TryParse<Signature.SignatureTypeEnum>(type, out result))
                {
                    result = Signature.SignatureTypeEnum.None;
                }
            }
            return result;
        }
    }
}
