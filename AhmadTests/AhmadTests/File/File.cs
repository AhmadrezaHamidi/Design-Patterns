using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descorator.File;

public interface IfileService
{
    int GetSize();
}



internal class File : IfileService
{
    public int GetSize()
    {
        return 0;
    }
}
