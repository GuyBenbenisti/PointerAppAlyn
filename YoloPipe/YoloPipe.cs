using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoloPipe
{
    public class YoloPipe
    {
        private string _exeName = "cmd.exe";
        private string _arguments = "/c dir";
        private Process _process;
        private StreamReader _reader;

        public YoloPipe(string exe, string args)
        {
            _exeName = exe;
            _arguments = args;
        }

        public void Start()
        {

            var pi = new ProcessStartInfo(_exeName, _arguments);
            pi.UseShellExecute = false;
            pi.RedirectStandardOutput = true;
            _process = Process.Start(pi);
            _reader = _process.StandardOutput;
        }

        // Returns the next string, or null if done.
        public async Task<string> ReadNext()
        {
            var st = await _reader.ReadLineAsync();
            return st;
        }
    }
}
