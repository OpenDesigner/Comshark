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
            }

            ModbusListenerPacketReceived.Raise(this, new ModbusSlaveRequestEventArgs(message));

            return response;
        }
	}
}
