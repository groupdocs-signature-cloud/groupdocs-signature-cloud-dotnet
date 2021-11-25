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

            if (signatureType == Signature.SignatureTypeEnum.FormField)
            {
                var formFieldType = GetFormFieldType(jObject);

                if (formFieldType == FormFieldSignature.TypeEnum.Checkbox)
                    return new CheckboxFormFieldSignature();

                if (formFieldType == FormFieldSignature.TypeEnum.Text)
                    return new TextFormFieldSignature();

                if (formFieldType == FormFieldSignature.TypeEnum.Combobox)
                    return new ComboboxFormFieldSignature();

                if (formFieldType == FormFieldSignature.TypeEnum.DigitalSignature)
                    return new DigitalFormFieldSignature();

                if (formFieldType == FormFieldSignature.TypeEnum.Radio)
                    return new RadioButtonFormFieldSignature();

                return new FormFieldSignature();
            }

            return new Signature();
        }

        protected Signature.SignatureTypeEnum GetSignatureType(JObject jObject)
        {
            var result = Signature.SignatureTypeEnum.None;
            var type = jObject["SignatureType"]?.ToString();
            if (string.IsNullOrEmpty(type))
            {
                type = jObject["signatureType"]?.ToString();
            }

            if (string.IsNullOrEmpty(type)) return result;

            try
            {
                result = (Signature.SignatureTypeEnum)Enum.Parse(typeof(Signature.SignatureTypeEnum), type);
            }
            catch (Exception)
            {
                result = Signature.SignatureTypeEnum.None;
            }
            return result;
        }

        protected FormFieldSignature.TypeEnum GetFormFieldType(JObject jObject)
        {
            var result = FormFieldSignature.TypeEnum.None;
            var type = jObject["Type"]?.ToString();
            if (string.IsNullOrEmpty(type))
            {
                type = jObject["type"]?.ToString();
            }

            if (string.IsNullOrEmpty(type)) return result;
            try
            {
                result = (FormFieldSignature.TypeEnum)Enum.Parse(typeof(FormFieldSignature.TypeEnum), type);
            }
            catch (Exception)
            {
                result = FormFieldSignature.TypeEnum.None;
            }
            return result;
        }
    }
}
