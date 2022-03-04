using System;
using System.Diagnostics;
using System.IO;

namespace BasicWebServer
{
    internal class MyMethods
    {
        // Interne
        // URL: http://localhost:8080/Method1?param1=test&param2=test2
        public string Method1(string param1, string param2)
        {
            return $"<html><body> Hello {param1} et {param2} </body></html>";
        }

        // Interne
        // URL: http://localhost:8080/Method2?param1=test&param2=test2
        public string Method2(string param1, string param2)
        {
            return $"<html><body> Not hello {param1} et {param2} </body></html>";
        }

        /*// Question 3
        // URL: http://localhost:8080/Incr?param1=5
        public string Incr(string param1)
        {
            int val = int.Parse(param1);
            string str = "{ \"orignal_value\": " + val + ", \"incr_value\": "+ ++val + "}";
            return $"<html><body> Incr OK : {str} </body></html>";
        }*/

        // Externe
        // URL: http://localhost:8080/MethodExternal?param1=test&param2=test2
        public string MethodExternal(string param1, string param2)
        {
            //
            // Set up the process with the ProcessStartInfo class.
            // https://www.dotnetperls.com/process
            //
            ProcessStartInfo start = new ProcessStartInfo();

            start.FileName = @"..\..\..\ExecTest\bin\Debug\ExecTest.exe"; // Specify exe name.
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
