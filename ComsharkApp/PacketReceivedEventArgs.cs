using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comshark
{
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
