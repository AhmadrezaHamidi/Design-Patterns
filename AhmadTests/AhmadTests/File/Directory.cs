using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descorator.File
{
    internal class Directory : IfileService
    {
        public List<File> Files { get; set; }
        public int Zise { get; set; }

        public int GetSize()
        {
            var filesSize = Files.Sum(x => x.GetSize()) + Zise;
            return filesSize;
        }
    }
}
