using System;
using Modbus.Message;

namespace Modbus.Device
{
	/// <summary>
	/// Modbus Slave request event args containing information on the message.
	/// </summary>
	public class ModbusListenerPacketReceivedEventArgs : EventArgs
	{
		private readonly IModbusMessage mMessage;
        private readonly byte[] mFrame;
        private readonly ModbusMessageMetadata mMetadata;

        internal ModbusListenerPacketReceivedEventArgs(IModbusMessage message, byte[] frame, ModbusMessageMetadata metadata)
		{
			mMessage = message;
            mFrame = frame;
            mMetadata = metadata;
		}

		/// <summary>
		/// Gets the message.
		/// </summary>
		/// <value>The message.</value>
		public IModbusMessage Message
		{
			get { return mMessage; }
		}

        public byte[] Frame
        {
            get { return mFrame; }
        }

        public ModbusMessageMetadata Metadata
        {
            get { return mMetadata;  }
        }
	}
}
