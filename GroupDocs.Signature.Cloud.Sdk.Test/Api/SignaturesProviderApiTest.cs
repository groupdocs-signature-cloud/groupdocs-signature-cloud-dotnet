using System.Linq;
using System.Collections.Generic;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class SignaturesProviderApiTest : BaseApiTest
    {
        #region Text Signatue
        protected void AssertPostText(List<TestFile> files, SignTextOptionsData signOptionsData)
        {
            Assert.NotNull(files);
            Assert.IsTrue(files.Count > 0);
            Assert.NotNull(signOptionsData);
            foreach (var file in files)
            {
                var request = new PostTextRequest
                {
                    Name = file.FileName,
                    SignOptionsData = signOptionsData,
                    Password = null,
                    Folder = file.Folder
                };
                var response = SignatureApi.PostText(request);
                AssertResponse(response);
            }
        }

        protected void AssertPostTextUrl(List<TestFile> files, SignTextOptionsData signOptionsData)
        {
            Assert.NotNull(files);
            Assert.IsTrue(files.Count > 0);
            Assert.NotNull(signOptionsData);
            foreach (var file in files)
            {
                var request = new PostTextFromUrlRequest
                {
                    Url = TestFiles.WordsUrl.Url,
                    Password = null,
                    SignOptionsData = signOptionsData
                };

                var response = SignatureApi.PostTextFromUrl(request);
                AssertResponse(response);
            }
        }
        #endregion

        #region Barcode Signature

        protected virtual SignBarcodeOptionsData GetSignBarcodeOptionsData()
        {
            return null;
        }
        private SignBarcodeOptionsData ComposeBarcodeOptionsData()
        {
            var signOptionsData = GetSignBarcodeOptionsData();
            if (signOptionsData != null)
            {
                signOptionsData.Text = CommonBarCodeText;
                signOptionsData.BarcodeTypeName = CommonBarcodeTypeName;
                signOptionsData.BackgroundColor = new Color() { Web = "#fcfcfc" };
                signOptionsData.BorderColor = new Color() { Web = "#364E6F" };
                signOptionsData.DocumentPageNumber = 1;
                signOptionsData.Font = new SignatureFontData() { Bold = true, FontFamily = "Arial", FontSize = 12, Italic = true, Underline = false };
                signOptionsData.ForeColor = new Color() { Web = "#364E6F" };
                signOptionsData.Height = 80;
                signOptionsData.HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Right;
                signOptionsData.Left = 10;
                signOptionsData.LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels;
                signOptionsData.Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 };
                signOptionsData.MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels;
                signOptionsData.Opacity = 0.5;
                signOptionsData.SignAllPages = false;
                signOptionsData.Top = 100;
                signOptionsData.VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center;
                signOptionsData.Width = 100;
                signOptionsData.PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                };
            }
            return signOptionsData;
        }
        protected void AssertPostBarcode(List<TestFile> files)
        {
            var signOptionsData = ComposeBarcodeOptionsData();
            foreach (var file in files)
            {
                var request = new PostBarcodeRequest
                {
                    Name = file.FileName,
                    SignOptionsData = signOptionsData,
                    Password = file.Password,
                    Folder = file.Folder
                };
                var response = SignatureApi.PostBarcode(request);
                AssertResponse(response);
            }
        }

        public void AssertPostBarcodeUrl(List<TestFile> files)
        {
            var signOptionsData = ComposeBarcodeOptionsData();
            foreach (var file in files)
            {
                var request = new PostBarcodeFromUrlRequest
                {
                    Url = file.Url,
                    Password = file.Password,
                    SignOptionsData = signOptionsData
                };
                var response = SignatureApi.PostBarcodeFromUrl(request);
                AssertResponse(response);
            }
        }
        #endregion

        #region QRCode Signature

        protected void AssertPostQRCode(List<TestFile> files, SignOptionsData signOptionsData)
        {
            foreach (var file in files)
            {
                var request = new PostQRCodeRequest
                {
                    Name = file.FileName,
                    SignOptionsData = signOptionsData,
                    Password = file.Password,
                    Folder = file.Folder
                };
                var response = SignatureApi.PostQRCode(request);
                AssertResponse(response);
            }
        }

        public void AssertPostQRCodeUrl(List<TestFile> files, SignOptionsData signOptionsData)
        {
            foreach (var file in files)
            {
                var request = new PostQRCodeFromUrlRequest
                {
                    Url = file.Url,
                    Password = file.Password,
                    SignOptionsData = signOptionsData
                };
                var response = SignatureApi.PostQRCodeFromUrl(request);
                AssertResponse(response);
            }
        }
        #endregion
    }
}