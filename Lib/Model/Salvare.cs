using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Lib.Model
{
    public abstract class Salvare
    {
        public abstract void SalvareCartiFiltrate(List<Carte> lista);

        protected string getPath(string filename)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var test_json = Path.Combine(outPutDirectory, filename);
            string path = new Uri(test_json).LocalPath;
            if (File.Exists(path))
                File.Delete(path);

            return path;
        }
    }
}
