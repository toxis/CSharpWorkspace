using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaseTests.Asynchronous
{
    [TestFixture]
    public class AsyncAwaitTest
    {
        private string _tempFolder;
        const string FileToDownload = "https://raw.githubusercontent.com/HE-Arc/MyFM/master/README.md";
        const string Md5Hash = "4073F37A14641571DC0669983B78FFF2";

        [Test]
        public async Task DownloadTest()
        {
            string destination = Path.Combine(_tempFolder, "README.md");
            await DownloadFileAsync(FileToDownload, destination);
            Assert.That(File.Exists(destination));
            Assert.AreEqual(ComputeMD5File(destination), Md5Hash);
        }

        [Test]
        public async Task LongComputation()
        {
            long test = 99999999;
            var result1 = await Compute(test);
            var result2 = await Compute(test);
            Assert.AreEqual(result1, test);
            Assert.AreEqual(result2, test);
        }

        private async Task<long> Compute(long counter)
        {
            long result = 0;
            for (long i = 0; i < counter; i++)
            {
                result++;
            }
            await Task.Delay(100);
            return result;
        }

        private async Task DownloadFileAsync(string source, string destination)
        {
            using (var client = new WebClient())
            {
                await client.DownloadFileTaskAsync(new Uri(source), destination);
            }
        }

        private string ComputeMD5File(string file)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }

        [SetUp]
        public void CreateTempFolder()
        {
            _tempFolder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(_tempFolder);
        }

        [TearDown]
        public void DeleteTempFolder()
        {
            Directory.Delete(_tempFolder, true);
        }
    }
}
