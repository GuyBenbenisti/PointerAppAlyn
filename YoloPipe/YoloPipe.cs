using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace YoloPipe
{
    public class YoloPipe
    {
        private string _exeName = "cmd.exe";
        private string _arguments = "/c dir";
        private readonly string _workingFolder;
        private Process _process;
        private StreamReader _reader;

        public YoloPipe(string exe, string args, string workingFolder = null)
        {
            _exeName = exe;
            _arguments = args;
            _workingFolder = workingFolder;
        }

        public async void Start()
        {
            var pi = new ProcessStartInfo(_exeName, _arguments);
            pi.WorkingDirectory = _workingFolder;
            pi.UseShellExecute = false;
            pi.RedirectStandardOutput = true;
            pi.CreateNoWindow = true;
            _process = Process.Start(pi);
            _process.Exited += Process_Exited;
            _reader = _process.StandardOutput;
            /*_reader.ReadLine()*/;
            Debug.WriteLine(_reader.ReadLine());
        }

        private void Process_Exited(object sender, EventArgs e)
        {
        }

        // Returns the next string, or null if done.
        public async Task<string> ReadNext()
        {
            var st = await _reader.ReadLineAsync();
            return st;
        }
    }
}
