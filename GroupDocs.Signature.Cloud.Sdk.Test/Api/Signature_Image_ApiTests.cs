using System.Linq;
namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;
    using System.Collections.Generic;

    public class Signature_Image_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Signature Image - Cells
        /// </summary>
        [Test]
        public void PostSignImageTest_Cells()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault();
            var signOptionsData = new CellsSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
                SheetNumber = 1,
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
                SizeMeasureType = CellsSignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                RowNumber = 2,
                ColumnNumber = 2,
                LocationMeasureType = CellsSignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostImage(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image - Images
        /// </summary>
        [Test]
        public void PostSignImageTest_Images()
        {
            var file = TestFiles.ImagesDocs.FirstOrDefault();
            var signOptionsData = new ImagesSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
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
                SizeMeasureType = SignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostImage(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image - PDF
        /// </summary>
        [Test]
        public void PostSignImageTest_Pdf()
        {
            var file = TestFiles.PdfDocs.FirstOrDefault();
            var signOptionsData = new PdfSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
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
                SizeMeasureType = SignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostImage(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image - Slides
        /// </summary>
        [Test]
        public void PostSignImageTest_Slides()
        {
            var file = TestFiles.SlidesDocs.FirstOrDefault();
            var signOptionsData = new SlidesSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
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
                SizeMeasureType = SignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostImage(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image - Words
        /// </summary>
        [Test]
        public void PostSignImageTest_Words()
        {
            var file = TestFiles.WordsDocs.FirstOrDefault();
            var signOptionsData = new WordsSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
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
                SizeMeasureType = SignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostImage(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image from Url - Cells
        /// </summary>
        [Test]
        public void PostSignImageTest_Cells_URL()
        {
            var signOptionsData = new CellsSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
                SheetNumber = 1,
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
                SizeMeasureType = CellsSignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                RowNumber = 2,
                ColumnNumber = 2,
                LocationMeasureType = CellsSignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageFromUrlRequest
            {
                Url = TestFiles.CellsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostImageFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image from Url - Images
        /// </summary>
        [Test]
        public void PostSignImageTest_Images_URL()
        {
            var signOptionsData = new ImagesSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
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
                SizeMeasureType = SignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageFromUrlRequest
            {
                Url = TestFiles.ImagesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostImageFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image from Url - PDF
        /// </summary>
        [Test]
        public void PostSignImageTest_Pdf_URL()
        {
            var signOptionsData = new PdfSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
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
                SizeMeasureType = SignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageFromUrlRequest
            {
                Url = TestFiles.PdfUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostImageFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image from Url - Slides
        /// </summary>
        [Test]
        public void PostSignImageTest_Slides_URL()
        {
            var signOptionsData = new SlidesSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
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
                SizeMeasureType = SignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageFromUrlRequest
            {
                Url = TestFiles.SlidesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostImageFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Image from Url - Words
        /// </summary>
        [Test]
        public void PostSignImageTest_Words_URL()
        {
            var signOptionsData = new WordsSignImageOptionsData()
            {
                ImageGuid = CommonImageGuid,
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
                SizeMeasureType = SignImageOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostImageFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostImageFromUrl(request);
            AssertResponse(response);
        }
    }
}