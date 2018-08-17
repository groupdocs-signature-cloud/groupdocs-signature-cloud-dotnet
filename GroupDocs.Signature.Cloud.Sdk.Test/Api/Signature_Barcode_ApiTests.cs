using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Barcode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Signature Barcode - Cells
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Cells()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault();
            var signOptionsData = new CellsSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = CellsSignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = CellsSignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData {All = 5},
                MarginMeasureType = CellsSignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Barcode from Url - Cells
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Cells_URL()
        {
            var signOptionsData = new CellsSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = CellsSignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = CellsSignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeFromUrlRequest
            {
                Url = TestFiles.CellsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Sign Post Barcode - Cells Collection
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Cells_Collection()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault(p => p.FileName.Contains("02_pages"));

            SignOptionsCollectionData collection = new SignOptionsCollectionData();
            collection.Items = new List<SignOptionsData>();
            var signOptionsData = new CellsSignBarcodeOptionsData()
            {
                BarcodeTypeName = CommonBarcodeTypeName,
                Text = "12345678",
                SheetNumber = 1,
                SignAllPages = false
            };

            collection.Items.Add(signOptionsData);

            signOptionsData = new CellsSignBarcodeOptionsData()
            {
                BarcodeTypeName = CommonBarcodeTypeName,
                Text = "1234",
                SheetNumber = 2,
                SignAllPages = false
            };

            collection.Items.Add(signOptionsData);

            var request = new PostCollectionRequest()
            {
                Name = file.FileName,
                SignOptionsCollectionData = collection,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostCollection(request);
            AssertResponse(response);
        }
        
        /// <summary>
        /// Test Post Signature Barcode - Images
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Images()
        {
            var file = TestFiles.ImagesDocs.FirstOrDefault();
            var signOptionsData = new ImagesSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = SignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Barcode from Url - Images
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Images_URL()
        {
            var signOptionsData = new ImagesSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = SignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeFromUrlRequest
            {
                Url = TestFiles.ImagesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Barcode - PDF
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Pdf()
        {
            var file = TestFiles.PdfDocs.FirstOrDefault();
            var signOptionsData = new PdfSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = SignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData {All = 5},
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Barcode from Url - PDF
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Pdf_URL()
        {
            var signOptionsData = new PdfSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = SignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeFromUrlRequest
            {
                Url = TestFiles.PdfUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostBarcodeFromUrl(request);
            AssertResponse(response);
        }
        
        /// <summary>
        /// Test Post Signature Barcode - Slides
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Slides()
        {
            var file = TestFiles.SlidesDocs.FirstOrDefault();
            var signOptionsData = new SlidesSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = SignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData {All = 5},
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Barcode from Url - Slides
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Slides_URL()
        {
            var signOptionsData = new SlidesSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = SignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeFromUrlRequest
            {
                Url = TestFiles.SlidesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Barcode - Words
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Words()
        {
            var file = TestFiles.WordsDocs.FirstOrDefault();
            var signOptionsData = new WordsSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = SignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData {All = 5},
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Barcode from Url - Words
        /// </summary>
        [Test]
        public void PostSignBarcodeTest_Words_URL()
        {
            var signOptionsData = new WordsSignBarcodeOptionsData()
            {
                Text = CommonBarCodeText,
                BarcodeTypeName = CommonBarcodeTypeName,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = SignBarcodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignBarcodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignBarcodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostBarcodeFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostBarcodeFromUrl(request);
            AssertResponse(response);
        }
    }
}