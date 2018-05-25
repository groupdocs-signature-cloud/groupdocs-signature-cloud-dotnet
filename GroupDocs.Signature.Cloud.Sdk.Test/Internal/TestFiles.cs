using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Internal
{
    using NUnit.Framework;

    public static class TestFiles
    {
        const string CommonPassword = "1234567890";

        public static readonly TestFile CellsUrl = new TestFile("test.xlsx")
        {
            Url = "https://www.dropbox.com/s/enuoff7umakf6es/test.xlsx?dl=1"
        };

        public static readonly TestFile ImagesUrl = new TestFile("test.png")
        {
            Url = "https://www.dropbox.com/s/3hbc18wympow0j1/test.png?dl=1"
        };

        public static readonly TestFile PdfUrl = new TestFile("test.pdf")
        {
            Url = "https://www.dropbox.com/s/1ciqpmciqzdp9hu/test.pdf?dl=1"
        };

        public static readonly TestFile WordsUrl = new TestFile("one-page.docx")
        {
            Url = "https://www.dropbox.com/s/bzx1xm68zd0c910/PieChart.docx?dl=1"
        };

        public static readonly TestFile SlidesUrl = new TestFile("with-notes.pptx")
        {
            Url = "https://www.dropbox.com/s/r2eioe2atushqcf/with-notes.pptx?dl=1"
        };


        public static readonly TestFile CellsSignedAllUrl = new TestFile("SignedForVerificationAll.xlsx")
        {
            Url = "https://www.dropbox.com/s/o9k7gweapq8k15l/SignedForVerificationAll.xlsx?dl=1"
        };

        public static readonly TestFile ImagesSignedAllUrl = new TestFile("SignedForVerificationAll.png")
        {
            Url = "https://www.dropbox.com/s/5d7a7ggmvklv1by/SignedForVerificationAll.png?dl=1"
        };

        public static readonly TestFile PdfSignedAllUrl = new TestFile("SignedForVerificationAll.pdf")
        {
            Url = "https://www.dropbox.com/s/7yi03ieximjrh1y/SignedForVerificationAll.pdf?dl=1"
        };

        public static readonly TestFile SlidesSignedAllUrl = new TestFile("SignedForVerificationAll.pptx")
        {
            Url = "https://www.dropbox.com/s/dxb9l68kevytz8e/SignedForVerificationAll.pptx?dl=1"
        };

        public static readonly TestFile WordsSignedAllUrl = new TestFile("SignedForVerificationAll.docx")
        {
            Url = "https://www.dropbox.com/s/zukdkxpuul0p8gm/SignedForVerificationAll.docx?dl=1"
        };



        public static readonly TestFile WrongFile01 = new TestFile("01_pagesA1.pdf", "storage");

        public static List<TestFile> AllFiles { get; private set; }
        public static List<TestFile> AllSigned { get; private set; }

        public static List<TestFile> Certificates { get; private set; }
        public static List<TestFile> DigitalCerts { get; private set; }

        public static List<TestFile> CellsDocs { get; private set; }
        public static List<TestFile> PdfDocs { get; private set; }
        public static List<TestFile> WordsDocs { get; private set; }
        public static List<TestFile> SlidesDocs { get; private set; }
        public static List<TestFile> ImagesDocs { get; private set; }

        public static List<TestFile> SignedCellsDocs { get; private set; }
        public static List<TestFile> SignedPdfDocs { get; private set; }
        public static List<TestFile> SignedWordsDocs { get; private set; }
        public static List<TestFile> SignedSlidesDocs { get; private set; }
        public static List<TestFile> SignedImagesDocs { get; private set; }

        private static List<TestFile> Initialize(string path, string folder, params string[] patterns)
        {
            var result = new List<TestFile>();
            foreach(var pattern in patterns)
            {
                var files = Directory.GetFiles(Path.Combine(path, folder), pattern);
                var temp = files.Select(p => new TestFile() { FileName = Path.GetFileName(p), Folder = folder, Password = p.Contains("_pwd")||folder.Equals("certificates") ? (CommonPassword) : (string.Empty) }).ToList();
                temp = temp.Where(p => !p.FileName.Contains("_pwd")).ToList();
                result.AddRange(temp);
            }
            return result;
        }
        private static List<TestFile> Initialize(string path, string folder)
        {
            return Initialize(path, folder, "*.*");
        }

        public static void Initialize(string path)
        {
            Certificates = Initialize(path, "certificates", "*.cer");
            DigitalCerts = Initialize(path, "certificates", "*.pfx");
            // storage
            CellsDocs = Initialize(path, "storage", "*.xlsx", "*.xls");
            PdfDocs = Initialize(path, "storage", "*.pdf");
            WordsDocs = Initialize(path, "storage", "*.docx");
            SlidesDocs = Initialize(path, "storage", "*.pptx");
            ImagesDocs = Initialize(path, "storage", "*.jpg", "*.png");
            // signed
            SignedCellsDocs  = Initialize(path, "signed", "*.xlsx", "*.xls");
            SignedPdfDocs    = Initialize(path, "signed", "*.pdf");
            SignedWordsDocs  = Initialize(path, "signed", "*.docx");
            SignedSlidesDocs = Initialize(path, "signed", "*.pptx");
            SignedImagesDocs = Initialize(path, "signed", "*.jpg", "*.png");
            AllSigned        = Initialize(path, "signed", "*.*");
            AllFiles = new List<TestFile>();

            AllFiles.AddRange(CellsDocs);
            AllFiles.AddRange(PdfDocs);
            AllFiles.AddRange(WordsDocs);
            AllFiles.AddRange(SlidesDocs);
            AllFiles.AddRange(ImagesDocs);

            Assert.IsTrue(Certificates.Count > 0);
            Assert.IsTrue(DigitalCerts.Count > 0);
            Assert.IsTrue(CellsDocs.Count > 0);
            Assert.IsTrue(PdfDocs.Count > 0);
            Assert.IsTrue(WordsDocs.Count > 0);
            Assert.IsTrue(SlidesDocs.Count > 0);
            Assert.IsTrue(ImagesDocs.Count > 0);
            Assert.IsTrue(SignedCellsDocs.Count > 0);
            Assert.IsTrue(SignedPdfDocs.Count > 0);
            Assert.IsTrue(SignedWordsDocs.Count > 0);
            Assert.IsTrue(SignedSlidesDocs.Count > 0);
            Assert.IsTrue(SignedImagesDocs.Count > 0);
        }
    }
}