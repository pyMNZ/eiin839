using System.Diagnostics;
using System.IO;

namespace BasicWebServer
{
    internal class MyMethods
    {
        public string Method1(string param1, string param2)
        {
            return $"<html><body> Hello {param1} et {param2} </body></html>";
        }

        public string Method2(string param1, string param2)
        {
            return $"<html><body> Not hello {param1} et {param2} </body></html>";
        }

        public string MethodExternal(string param1, string param2)
        {
            //
            // Set up the process with the ProcessStartInfo class.
            // https://www.dotnetperls.com/process
            //
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"D:\Polytech\SI4\S8\soc\git\eiin839\TD2\ExecTest\bin\Debug\ExecTest.exe"; // Specify exe name.
            start.Arguments = $"{param1} {param2}"; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
