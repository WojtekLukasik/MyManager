using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyManager.DataModels
{
    public class MyFile: MyDiscElement
    {
        public MyFile(string path): base(path)
        {
            this.extension = path.Split('.').Last();
        }
    }
}
