using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Comshark
{
    public interface ICommInterface
    {
        string Name { get; }

        string Info { get; }

        //TODO: Connect() Disconnect(), IsConnected... yadda yadda...
    }

}

