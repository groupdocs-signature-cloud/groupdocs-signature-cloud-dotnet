using System;
using System.IO;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    [TestFixture]
    public class TestFileTests
    {
        [TestCase(@"SpreadSheets\01_pages.xlsx", "SpreadSheets", "01_pages.xlsx")]
        [TestCase("Pdf/01_pages.pdf", "Pdf", "01_pages.pdf")]
        public void FilePaths_ArePortableAcrossOperatingSystems(string path, string folder, string name)
        {
            var testFile = new TestFile(path);
            var rootPath = Path.Combine("TestData", "root");

            Assert.AreEqual(name, testFile.Name);
            Assert.AreEqual(folder, testFile.Folder);
            Assert.AreEqual(Path.Combine(rootPath, folder, name), testFile.GetLocalPath(rootPath));
        }

        [Test]
        public void AllTestFiles_ExistInOutputDirectory()
        {
            var rootPath = Path.Combine(AppContext.BaseDirectory, "TestData");

            foreach (var testFile in TestFiles.AllFiles)
            {
                Assert.That(File.Exists(testFile.GetLocalPath(rootPath)), Is.True, testFile.Path);
            }
        }
    }
}
