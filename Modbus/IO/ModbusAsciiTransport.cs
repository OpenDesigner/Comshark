using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using log4net;
using Modbus.Device;
using Modbus.Message;
using Modbus.Utility;
using Unme.Common;

namespace Modbus.IO
{
	/// <summary>	
	/// Refined Abstraction - http://en.wikipedia.org/wiki/Bridge_Pattern
	/// </summary>
	internal class ModbusAsciiTransport : ModbusSerialTransport
	{
		private static readonly ILog _logger = LogManager.GetLogger(typeof(ModbusAsciiTransport));
        
		internal ModbusAsciiTransport(IStreamResource streamResource)
			: base(streamResource)
		{
			Debug.Assert(streamResource != null, "Argument streamResource cannot be null.");
		}		

		internal override byte[] BuildMessageFrame(IModbusMessage message)
		{
			var frame = new List<byte>();
			frame.Add((byte)':');
			frame.AddRange(ModbusUtility.GetAsciiBytes(message.SlaveAddress));
			frame.AddRange(ModbusUtility.GetAsciiBytes(message.ProtocolDataUnit));
			frame.AddRange(ModbusUtility.GetAsciiBytes(ModbusUtility.CalculateLrc(message.MessageFrame)));
			frame.AddRange(Encoding.ASCII.GetBytes(Modbus.NewLine.ToCharArray()));

            return frame.ToArray();
		}

		internal override bool ChecksumsMatch(IModbusMessage message, byte[] messageFrame)
		{
			return ModbusUtility.CalculateLrc(message.MessageFrame) == messageFrame[messageFrame.Length - 1];
		}

		internal override byte[] ReadRequest(ModbusSlave slave)
		{
			return ReadRequestResponse();
		}

		internal override IModbusMessage ReadResponse<T>()
		{
			return CreateResponse<T>(ReadRequestResponse());
		}

		internal byte[] ReadRequestResponse()
		{
            // read message frame
            string frameHex = StreamResourceUtility.ReadLine(StreamResource);
            //string frameHex = StreamResourceUtility.ReadLine(StreamResource);

            // convert hex to bytes, removing frame start ':'
            byte[] frame = ModbusUtility.HexToBytes(frameHex.Substring(1)); 
            _logger.InfoFormat("RX (ASCII-CHAR) length={0}: '{1}'", frameHex.Length-1, frameHex);
            byte[] frameASCIIbytes = System.Text.Encoding.ASCII.GetBytes(frameHex);
            _logger.InfoFormat("RX (ASCII-HEX): {0:X}", frameASCIIbytes.Join(" "));
            _logger.InfoFormat("RX (ASCII-DEC): {0}", frameASCIIbytes.Join(" "));
			_logger.InfoFormat("RX (Decimal), length={0}: {1}", frame.Length, frame.Join(", "));

			if (frame.Length < 3)
				throw new IOException("Premature end of stream, message truncated.");

			return frame;
		}
	}
}
