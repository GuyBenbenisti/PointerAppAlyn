using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoloPipe
{
    public class YoloJsonPipe
    {
        private YoloPipe _pipe;

        public YoloJsonPipe(string exe, string arguments)
        {
            _pipe = new YoloPipe(exe, arguments);

        }

        public void Start()
        {
            _pipe.Start();
        }

        public async Task<string> ReadJsonObjextAsync()
        {
            StringBuilder b = new StringBuilder();
            string line;
            do
            {
                line = await _pipe.ReadNext();
                if (line != "#")
                {
                    b.Append(line);
                }
            } while (line != "#" && line != null);

            var result = b.ToString();
            if (result == "")
            {
                result = null;
            }

            return result;
        }
    }
}
