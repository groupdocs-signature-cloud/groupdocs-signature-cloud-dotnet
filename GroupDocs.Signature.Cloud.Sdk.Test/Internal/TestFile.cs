namespace GroupDocs.Signature.Cloud.Sdk.Test.Internal
{
    public class TestFile
    {
        public string FileName { get; set; }

        public string Folder { get; set; }

        public string Password { get; set; }

        public string Url { get; set; }

        public TestFile()
        {
        }
        public TestFile(string fileName)
        {
            FileName = fileName;
        }

        public TestFile(string fileName, string folder, string password = null)
        {
            FileName = fileName;
            Folder = folder;
            Password = password;
        }
    }
}