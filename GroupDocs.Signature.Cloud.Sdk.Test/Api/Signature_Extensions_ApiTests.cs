using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Extensions_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Signature NullBrush
        /// </summary>
        [Test]
        public void PostSignTest_NullBrushData()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault();

            CellsSignTextOptionsData signOptionsData = new CellsSignTextOptionsData
            {
                Text = CommonText,
                SignatureImplementation = CellsSignTextOptionsData.SignatureImplementationEnum.TextStamp,
                Height = 50,
                Width = 200,
                ForeColor = new Color(Color.DarkSlateBlue.Web),
                Font = new SignatureFontData() { FontSize = 24, Bold = true },
                BackgroundBrush = null
            };

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

        /// <summary>
        /// Test Post Signature SolidBrushData
        /// </summary>
        [Test]
        public void PostSignTest_SolidBrushData()
        {
            var file = TestFiles.PdfDocs.FirstOrDefault();

            PdfSignTextOptionsData signOptionsData = new PdfSignTextOptionsData
            {
                Text = CommonText,
                SignatureImplementation = PdfSignTextOptionsData.SignatureImplementationEnum.Image,
                Height = 50,
                Width = 200,
                ForeColor = new Color(Color.DarkSlateBlue.Web),
                Font = new SignatureFontData() { FontSize = 24, Bold = true },
                BackgroundBrush = new SolidBrushData() { Color = new Color("CornflowerBlue") }
            };

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

        /// <summary>
        /// Test Post Signature LinearGradientBrushData
        /// </summary>
        [Test]
        public void PostSignTest_LinearGradientBrushData()
        {
            var file = TestFiles.ImagesDocs.FirstOrDefault();

            ImagesSignTextOptionsData signOptionsData = new ImagesSignTextOptionsData
            {
                Text = CommonText,
                SignatureImplementation = ImagesSignTextOptionsData.SignatureImplementationEnum.TextAsImage,
                Height = 50,
                Width = 200,
                ForeColor = new Color(Color.DarkSlateBlue.Web),
                Font = new SignatureFontData() { FontSize = 24, Bold = true },
                BackgroundBrush = new LinearGradientBrushData() { StartColor = new Color("CornflowerBlue"), EndColor = new Color("DarkBlue"), Angle = 93.15}
            };

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

        /// <summary>
        /// Test Post Signature TextureBrushData
        /// </summary>
        [Test]
        public void PostSignTest_TextureBrushData()
        {
            var file = TestFiles.SlidesDocs.FirstOrDefault();

            SlidesSignTextOptionsData signOptionsData = new SlidesSignTextOptionsData
            {
                Text = CommonText,
                SignatureImplementation = SlidesSignTextOptionsData.SignatureImplementationEnum.TextStamp,
                Height = 50,
                Width = 200,
                ForeColor = new Color(Color.DarkSlateBlue.Web),
                Font = new SignatureFontData() { FontSize = 24, Bold = true },
                BackgroundBrush = new TextureBrushData() {ImageGuid = CommonImageGuid }
            };

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

        /// <summary>
        /// Test Post Signature RadialGradientBrush
        /// </summary>
        [Test]
        public void PostSignTest_RadialGradientBrush()
        {
            var file = TestFiles.WordsDocs.FirstOrDefault();

            WordsSignTextOptionsData signOptionsData = new WordsSignTextOptionsData
            {
                Text = CommonText,
                SignatureImplementation = WordsSignTextOptionsData.SignatureImplementationEnum.TextStamp,
                Height = 50,
                Width = 200,
                ForeColor = new Color(Color.DarkSlateBlue.Web),
                Font = new SignatureFontData() { FontSize = 24, Bold = true },
                BackgroundBrush = new RadialGradientBrushData() { InnerColor = new Color("CornflowerBlue"), OuterColor = new Color("DarkBlue") }
            };

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
}