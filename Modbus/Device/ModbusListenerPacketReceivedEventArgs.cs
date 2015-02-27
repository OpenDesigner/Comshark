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

        internal ModbusListenerPacketReceivedEventArgs(IModbusMessage message, byte[] frame)
		{
			mMessage = message;
            mFrame = frame;
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
	}
}
