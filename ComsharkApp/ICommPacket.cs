using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

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

        XElement DetailedInformation { get; set; }

        byte[] Frame { get; set; }

    }


    public class CommPacketReceivedEventArgs : EventArgs
    {

        private readonly ICommPacket _packet;

        internal CommPacketReceivedEventArgs(ICommPacket packet)
        {
            _packet = packet;
        }

        /// <summary>
        /// Gets the packet.
        /// </summary>
        /// <value>The packet.</value>
        public ICommPacket Packet
        {
            get { return _packet; }
        }
    }

}

