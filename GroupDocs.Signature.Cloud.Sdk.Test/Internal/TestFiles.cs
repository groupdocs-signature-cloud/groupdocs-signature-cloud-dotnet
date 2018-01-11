namespace GroupDocs.Signature.Cloud.Sdk.Test.Internal
{
    public static class TestFiles
    {
        public static readonly TestFile Pdf01 = new TestFile("01_pages.pdf", "storage");
        public static readonly TestFile Pdf02 = new TestFile("02_pages.pdf", "storage");
        public static readonly TestFile PdfPwd = new TestFile("01_pages_pwd.pdf", "storage", "1234567890");

        public static readonly TestFile Words01 = new TestFile("01_pages.docx", "storage");
        public static readonly TestFile Words02 = new TestFile("02_pages.docx", "storage");

        public static readonly TestFile Image01 = new TestFile("01_pages.img", "storage");
        public static readonly TestFile Image02 = new TestFile("01_pages.png", "storage");

        public static readonly TestFile Slides01 = new TestFile("01_pages.pptx", "storage");
        public static readonly TestFile Slides02 = new TestFile("02_pages.pptx", "storage");

        public static readonly TestFile Cells01 = new TestFile("01_pages.xlsx", "storage");
        

        public static readonly TestFile WordsUrl = new TestFile("one-page.docx")
        {
            Url = "https://www.dropbox.com/s/bzx1xm68zd0c910/PieChart.docx?dl=1"
        };

        public static readonly TestFile SlidesUrl = new TestFile("with-notes.pptx")
        {
            Url = "https://www.dropbox.com/s/r2eioe2atushqcf/with-notes.pptx?dl=1"
        };

        public static readonly TestFile SignedBarcode_Words01 = new TestFile("Signed_BarCode.docx", "signed");
        public static readonly TestFile SignedBarcode_Pdf01 = new TestFile("Signed_BarCode.pdf", "signed");
        public static readonly TestFile SignedBarcode_Slides01 = new TestFile("Signed_BarCode.pptx", "signed");
        public static readonly TestFile SignedBarcode_Cells01 = new TestFile("Signed_BarCode.xls", "signed");

        public static readonly TestFile SignedDigital_Words01 = new TestFile("Signed_Digital.docx", "signed");
        public static readonly TestFile SignedDigital_Pdf01 = new TestFile("Signed_Digital.pdf", "signed");
        public static readonly TestFile SignedDigital_Cells01 = new TestFile("Signed_Digital.xls", "signed");

        public static readonly TestFile SignedQRCode_Words01 = new TestFile("Signed_QRCode.docx", "signed");
        public static readonly TestFile SignedQRCode_Pdf01 = new TestFile("Signed_QRCode.pdf", "signed");
        public static readonly TestFile SignedQRCode_Slides01 = new TestFile("Signed_QRCode.pptx", "signed");
        public static readonly TestFile SignedQRCode_Cells01 = new TestFile("Signed_QRCode.xls", "signed");

        public static readonly TestFile SignedTextStamp_Words01 = new TestFile("Signed_TextStamp.docx", "signed");
        public static readonly TestFile SignedTextStamp_Pdf01 = new TestFile("Signed_TextStamp.pdf", "signed");
        public static readonly TestFile SignedTextStamp_Pdf02 = new TestFile("Signed_TextSticket.pdf", "signed");
        public static readonly TestFile SignedTextStamp_Slides01 = new TestFile("Signed_TextStamp.pps", "signed");
        public static readonly TestFile SignedTextStamp_Cells01 = new TestFile("Signed_TextStamp.xls", "signed");

        public static readonly TestFile WrongFile01 = new TestFile("01_pagesA1.pdf", "storage");
    }
}