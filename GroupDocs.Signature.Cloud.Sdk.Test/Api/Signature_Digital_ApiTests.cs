using System.Collections.Generic;
using System.Linq;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Digital_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Signature Digital - Cells
        /// </summary>
        [Test]
        public void PostSignDigitalTest_Cells()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault();
            var signOptionsData = new CellsSignDigitalOptionsData()
            {
                CertificateGuid = CommonCertificateGuid,
                Password = CommonPassword,
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SheetNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() {1}
                },
                // Size properties
                Width = 200,
                Height = 100,
                SizeMeasureType = CellsSignDigitalOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                RowNumber = 2,
                Left = 2,
                ColumnNumber = 2,
                LocationMeasureType = CellsSignDigitalOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignDigitalOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignDigitalOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData {All = 5},
                MarginMeasureType = CellsSignDigitalOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };
            
            var request = new PostDigitalRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            //var response = SignatureApi.PostDigital(request);
            //AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Digital from Url - Cells
        /// </summary>
        [Test]
        public void PostSignDigitalTest_Cells_URL()
        {
            var signOptionsData = new CellsSignDigitalOptionsData()
            {
                CertificateGuid = CommonCertificateGuid,
                Password = CommonPassword,
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
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
                SizeMeasureType = CellsSignDigitalOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                RowNumber = 2,
                Left = 2,
                ColumnNumber = 2,
                LocationMeasureType = CellsSignDigitalOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignDigitalOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignDigitalOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignDigitalOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostDigitalFromUrlRequest
            {
                Url = TestFiles.CellsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            //var response = SignatureApi.PostDigitalFromUrl(request);
            //AssertResponse(response);
        }

        /// <summary>
        /// Test Sign Post Digital - Cells Collection
        /// </summary>
        [Test]
        public void PostSignDigitalTest_Cells_Collection()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault(p => p.FileName.Contains("02_pages"));

            SignOptionsCollectionData collection = new SignOptionsCollectionData();
            collection.Items = new List<SignOptionsData>();
            var signOptionsData = new CellsSignDigitalOptionsData()
            {
                CertificateGuid = CommonCertificateGuid,
                Password = CommonPassword,
                ImageGuid = CommonImageGuid,
                SheetNumber = 1,
                SignAllPages = false,
            };

            collection.Items.Add(signOptionsData);

            signOptionsData = new CellsSignDigitalOptionsData()
            {
                CertificateGuid = CommonCertificateGuid,
                Password = CommonPassword,
                ImageGuid = CommonImageGuid,
                SheetNumber = 2,
                SignAllPages = false,
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
        /// Test Post Signature Digital - PDF
        /// </summary>
        [Test]
        public void PostSignDigitalTest_Pdf()
        {
            var file = TestFiles.PdfDocs.FirstOrDefault();
            var signOptionsData = new PdfSignDigitalOptionsData()
            {
                CertificateGuid = CommonCertificateGuid,
                Password = CommonPassword,
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
                SizeMeasureType = PdfSignDigitalOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = PdfSignDigitalOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignDigitalOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignDigitalOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = PdfSignDigitalOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostDigitalRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostDigital(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Digital from Url - PDF
        /// </summary>
        [Test]
        public void PostSignDigitalTest_Pdf_URL()
        {
            var signOptionsData = new PdfSignDigitalOptionsData()
            {
                CertificateGuid = CommonCertificateGuid,
                Password = CommonPassword,
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
                SizeMeasureType = PdfSignDigitalOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = PdfSignDigitalOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignDigitalOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignDigitalOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = PdfSignDigitalOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostDigitalFromUrlRequest
            {
                Url = TestFiles.PdfUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostDigitalFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Digital - Words
        /// </summary>
        [Test]
        public void PostSignDigitalTest_Words()
        {
            var file = TestFiles.WordsDocs.FirstOrDefault();
            var signOptionsData = new WordsSignDigitalOptionsData()
            {
                CertificateGuid = CommonCertificateGuid,
                Password = CommonPassword,
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
                SizeMeasureType = WordsSignDigitalOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = PdfSignDigitalOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignDigitalOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignDigitalOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = WordsSignDigitalOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostDigitalRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            //var response = SignatureApi.PostDigital(request);
            //AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Digital from Url - Words
        /// </summary>
        [Test]
        public void PostSignDigitalTest_Words_URL()
        {
            var signOptionsData = new WordsSignDigitalOptionsData()
            {
                CertificateGuid = CommonCertificateGuid,
                Password = CommonPassword,
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
                SizeMeasureType = WordsSignDigitalOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = PdfSignDigitalOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignDigitalOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignDigitalOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = WordsSignDigitalOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9
            };

            var request = new PostDigitalFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            //var response = SignatureApi.PostDigitalFromUrl(request);
            //AssertResponse(response);
        }
    }
}