using System.Diagnostics;
using System.IO;

namespace Updater
{
    internal class Program
    {
        static string destFolder = @"C:\Katon App\App Files\";
        static void Main(string[] args) {
            Console.WriteLine("Updating the Katon App");

            string[] newVersionFiles = Directory.GetFiles(@"Z:\Zeta\Katon App\App Files\");
            List<string> newVersionFileNames = new();
            foreach(var x in newVersionFiles) {
                newVersionFileNames.Add(Path.GetFileName(x));
            }

            // list of files currently in the App Files folder
            List<string> currentFiles = Directory.GetFiles(destFolder).ToList();
            List<string> currentFileNames = new();
            foreach (var x in currentFiles) {
                currentFileNames.Add(Path.GetFileName(x));
            }

            List<string> filesToCopy = new(); // we'll make a list of files to copy to the C: drive
            foreach (var x in newVersionFileNames) {
                bool alreadyExists = currentFileNames.Contains(x);

                if (!alreadyExists) { // file exists in the shared drive but not in the C: drive
                    filesToCopy.Add(x);
                }
                else if (!x.Contains(".dll")) { // dlls wont change so dont copy them every time
                    // copy other types of files every time, because they likely changed
                    filesToCopy.Add(x);
                }
            }

            int i = 0;
            Console.WriteLine("Updating " + filesToCopy.Count + " files");
            foreach (var x in filesToCopy) {
                i++;
                string percent = ((float)i * 100 / filesToCopy.Count).ToString("F0");
                Console.WriteLine(percent + "%");
                string dest = destFolder + x;
                File.Copy(@"Z:\Zeta\Katon App\App Files\" + x, dest, overwrite: true);
            }


            Process.Start(@"C:\Katon App\Katon App\KatonApp.exe"); // starts the program again
        }
    }
}
