using System;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using log4net;
using Modbus.IO;
using Modbus.Message;
using Unme.Common;

namespace Modbus.Device
{
	/// <summary>
	/// Modbus serial slave device.
	/// </summary>
	public class ModbusSerialListener : ModbusListener
	{
		private static readonly ILog _logger = LogManager.GetLogger(typeof(ModbusSerialListener));

		private ModbusSerialListener(byte unitId, ModbusTransport transport)
			: base(unitId, transport)
		{
		}

		private ModbusSerialTransport SerialTransport
		{
			get
			{
				var transport = Transport as ModbusSerialTransport;

				if (transport == null)
					throw new ObjectDisposedException("SerialTransport");

				return transport;
			}
		}

		/// <summary>
		/// Modbus ASCII slave factory method.
		/// </summary>
		public static ModbusSerialListener CreateAscii(byte unitId, SerialPort serialPort)
		{
			if (serialPort == null)
				throw new ArgumentNullException("serialPort");
			
			return CreateAscii(unitId, new SerialPortAdapter(serialPort));
		}

		/// <summary>
		/// Modbus ASCII slave factory method.
		/// </summary>
		public static ModbusSerialListener CreateAscii(byte unitId, IStreamResource streamResource)
		{
			if (streamResource == null)
				throw new ArgumentNullException("streamResource");
			
			return new ModbusSerialListener(unitId, new ModbusAsciiTransport(streamResource));
		}

		/// <summary>
		/// Modbus RTU slave factory method.
		/// </summary>
		public static ModbusSerialListener CreateRtu(byte unitId, SerialPort serialPort)
		{
			if (serialPort == null)
				throw new ArgumentNullException("serialPort");

			return CreateRtu(unitId, new SerialPortAdapter(serialPort));
		}

		/// <summary>
		/// Modbus RTU slave factory method.
		/// </summary>
		public static ModbusSerialListener CreateRtu(byte unitId, IStreamResource streamResource)
		{
			if (streamResource == null)
				throw new ArgumentNullException("streamResource");

			return new ModbusSerialListener(unitId, new ModbusRtuTransport(streamResource));
		}

		/// <summary>
		/// Start slave listening for requests.
		/// </summary>
		public override void Listen()
		{
			while (true)
			{
				try
				{
					try
					{
						// read request and build message
						byte[] frame = SerialTransport.ReadRequest(this);
						IModbusMessage message = ModbusMessageFactory.CreateModbusRequest(this, frame);

                        if(message != null)
                        { 
                            SerialTransport.CheckFrame = false;
						    if (SerialTransport.CheckFrame && !SerialTransport.ChecksumsMatch(message, frame))
						    {
							    string errorMessage = String.Format(CultureInfo.InvariantCulture, "Checksums failed to match {0} != {1}", message.MessageFrame.Join(", "), frame.Join(", "));
							    _logger.Error(errorMessage);
							    throw new IOException(errorMessage);
						    }

						    // listen to all service requests addressed to any slave
						    if (message.SlaveAddress != UnitId)
						    {
							    //_logger.DebugFormat("NModbus Slave {0} ignoring request intended for NModbus Slave {1}", UnitId, request.SlaveAddress);
						    }
                        }
						// perform action
						//IModbusMessage response = ApplyRequest(message);

                        ProcessMessage(message);


                        
						// write response
						//SerialTransport.Write(response);
					}
					catch (IOException ioe)
					{
						_logger.ErrorFormat("IO Exception encountered while listening for requests - {0}", ioe.Message);
						SerialTransport.DiscardInBuffer();
					}
					catch (TimeoutException te)
					{
						//_logger.ErrorFormat("Timeout Exception encountered while listening for requests - {0}", te.Message);
						SerialTransport.DiscardInBuffer();
					}

					// TODO better exception handling here, missing FormatException, NotImplemented...
				}
				catch (InvalidOperationException)
				{
					// when the underlying transport is disposed
					break;
				}
			}
		}

        
	}
}
