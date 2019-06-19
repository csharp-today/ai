using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace EasyCloud.WindowsOnly
{
    public static class WindowsExtensions
    {
        public static async Task PlayWavAsync(this Task<byte[]> wavTask) => await (await wavTask).PlayWavAsync();

        public static async Task PlayWavAsync(this byte[] wavData)
        {
            var tempFileName = await SaveAsTemporaryFileAsync(wavData);

            var process = new Process
            {
                StartInfo =
                {
                    FileName = "powershell",
                    Arguments = $"-c (New-Object Media.SoundPlayer '{tempFileName}').PlaySync();"
                },
                EnableRaisingEvents = true
            };

            var tcs = new TaskCompletionSource<int>();
            process.Exited += (_, __) =>
            {
                tcs.SetResult(process.ExitCode);
                process.Dispose();
            };

            process.Start();
            await tcs.Task;

            DeleteFile(tempFileName);
        }

        private static void DeleteFile(string fileName)
        {
            // No async way to remove a file, but the following might be a bit faster than File.Delete
            // Source: https://stackoverflow.com/questions/10606328/why-isnt-there-an-asynchronous-file-delete-in-net
            using var file = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, 4096, FileOptions.DeleteOnClose | FileOptions.Asynchronous);
        }

        private static async Task<string> SaveAsTemporaryFileAsync(byte[] data)
        {
            var tempFile = Path.GetTempFileName();
            using var file = new FileStream(tempFile, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true);
            await file.WriteAsync(data, 0, data.Length);
            return tempFile;
        }
    }
}
