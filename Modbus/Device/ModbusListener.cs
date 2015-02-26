using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using log4net;
using Modbus.Data;
using Modbus.IO;
using Modbus.Message;
using Unme.Common;

namespace Modbus.Device
{
	/// <summary>
	/// Modbus slave device.
	/// </summary>
	public abstract class ModbusListener : ModbusSlave
	{	
		private static readonly ILog _logger = LogManager.GetLogger(typeof(ModbusListener));
		private readonly Dictionary<byte, CustomMessageInfo> _customMessages = new Dictionary<byte, CustomMessageInfo>();

		private Func<Type, MethodInfo> _createModbusMessageCache = FunctionalUtility.Memoize((Type type) =>
		{
			MethodInfo method = typeof(ModbusMessageFactory).GetMethod("CreateModbusMessage");
			return method.MakeGenericMethod(type);
		});

		internal ModbusListener(byte unitId, ModbusTransport transport)
			: base(unitId, transport)
		{
			DataStore = DataStoreFactory.CreateDefaultDataStore();
			UnitId = unitId;
		}

		/// <summary>
		/// Occurs when a modbus slave receives a request.
		/// </summary>
		public event EventHandler<ModbusSlaveRequestEventArgs> ModbusListenerPacketReceived;


        [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Justification = "Cast is not unneccessary.")]
        internal IModbusMessage ApplyRequest(IModbusMessage message)
        {
            if (message == null)
                throw new ArgumentNullException("request");

            _logger.Debug(message.ToString());
            IModbusMessage response;


            // allow custom function override
            if (!TryApplyCustomMessage(message, DataStore, out response))
            {
                // default implementation
                switch (message.FunctionCode)
                {
                    case Modbus.ReadCoils:
                        _logger.Info("ReadCoils"); //response = ReadDiscretes((ReadCoilsInputsRequest)request, DataStore, DataStore.CoilDiscretes);
                        break;
                    case Modbus.ReadInputs:
                        _logger.Info("ReadInputs"); //response = ReadDiscretes((ReadCoilsInputsRequest)request, DataStore, DataStore.InputDiscretes);
                        break;
                    case Modbus.ReadHoldingRegisters:
                        _logger.Info("ReadHoldingRegisters"); //response = ReadRegisters((ReadHoldingInputRegistersRequest)request, DataStore, DataStore.HoldingRegisters);
                        break;
                    case Modbus.ReadInputRegisters:
                        _logger.Info("ReadInputRegisters"); //response = ReadRegisters((ReadHoldingInputRegistersRequest)request, DataStore, DataStore.InputRegisters);
                        break;
                    case Modbus.Diagnostics:
                        _logger.Info("Diagnostics"); //response = request;
                        break;
                    case Modbus.WriteSingleCoil:
                        _logger.Info("WriteSingleCoil"); //response = WriteSingleCoil((WriteSingleCoilRequestResponse)request, DataStore, DataStore.CoilDiscretes);
                        break;
                    case Modbus.WriteSingleRegister:
                        _logger.Info("WriteSingleRegister"); //response = WriteSingleRegister((WriteSingleRegisterRequestResponse)request, DataStore, DataStore.HoldingRegisters);
                        break;
                    case Modbus.WriteMultipleCoils:
                        _logger.Info("WriteMultipleCoils"); //response = WriteMultipleCoils((WriteMultipleCoilsRequest)request, DataStore, DataStore.CoilDiscretes);
                        break;
                    case Modbus.WriteMultipleRegisters:
                        _logger.Info("WriteMultipleRegisters"); //response = WriteMultipleRegisters((WriteMultipleRegistersRequest)request, DataStore, DataStore.HoldingRegisters);
                        break;
                    case Modbus.ReadWriteMultipleRegisters:
                        _logger.Info("ReadWriteMultipleRegisters");
                        //ReadWriteMultipleRegistersRequest readWriteRequest = (ReadWriteMultipleRegistersRequest)request;
                        //WriteMultipleRegisters(readWriteRequest.WriteRequest, DataStore, DataStore.HoldingRegisters);
                        //response = ReadRegisters(readWriteRequest.ReadRequest, DataStore, DataStore.HoldingRegisters);
                        break;
                    default:
                        _logger.Info(String.Format("Unsupported function code {0}", message.FunctionCode));
                        //string errorMessage = String.Format(CultureInfo.InvariantCulture, "Unsupported function code {0}", request.FunctionCode);
                        //_logger.Error(errorMessage);
                        //throw new ArgumentException(errorMessage, "request");
                        break;
                }
            }

            ModbusListenerPacketReceived.Raise(this, new ModbusSlaveRequestEventArgs(message));

            return response;
        }

        public void ProcessMessage(IModbusMessage message)
        {
            ModbusListenerPacketReceived.Raise(this, new ModbusSlaveRequestEventArgs(message));
        }
	}
}
