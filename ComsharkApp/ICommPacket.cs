using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Comshark
{
    public interface ICommPacket
    {
        DateTime Timestamp { get; set; }

        ICommInterface Interface { get; set; }

        string Source { get; set; }

        string Destination { get; set; }

        string Protocol { get; set; }

        int Length { get; set; }

        string Info { get; set; }

        int Valid { get; set; }

    }

}

