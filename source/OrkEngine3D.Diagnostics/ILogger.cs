using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkEngine3D.Diagnostics
{
    public interface ILogger
    {
        void Log(ILogMessege logMessage);
    }
}
