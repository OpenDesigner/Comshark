using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Threading;

using Modbus.Data;
using Modbus.Device;
using Modbus.Utility;



namespace Comshark
{
    class CommPort : ICommInterface
    {
        SerialPort mSerialPort;
        Thread mInputThread;
        bool mReading;
        ModbusListener modbus;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static readonly CommPort instance = new CommPort();

        /// <summary>
        /// Occurs when a packet is received.
        /// </summary>
        public event EventHandler<CommPacketReceivedEventArgs> CommPacketReceived;

        //public delegate void OnModbusListenerPacketReceived(object sender, ModbusSlaveRequestEventArgs e);
        protected void OnModbusListenerPacketReceived(object sender, ModbusSlaveRequestEventArgs e)
        {
            ICommPacket packet = new CommPacketModbus(this, e.Message);
            CommPacketReceived(this, new CommPacketReceivedEventArgs(packet));
        }

        static CommPort()
        {
        }

        CommPort()
        {
            mSerialPort = new SerialPort();
            mInputThread = null;
            mReading = false;

        }

        public static CommPort Instance
        {
            get { return instance; }
        }

        public override string ToString()
        {
            return mSerialPort.PortName; // +"(" + mSerialPort.ToString() + ")";
        }

        public delegate void EventHandler(string param);
        public EventHandler StatusChanged;
        public EventHandler DataReceived;

        private void ProcessIncoming()
        {
            while (mReading)
            {
                if (mSerialPort.IsOpen)
                {
                    /*
                    byte[] readBuffer = new byte[mSerialPort.ReadBufferSize + 1];
                    try
                    {
                        int count = mSerialPort.Read(readBuffer, 0, mSerialPort.ReadBufferSize);
                        String SerialIn = System.Text.Encoding.ASCII.GetString(readBuffer, 0, count);
                        DataReceived(SerialIn);
                    }
                    catch (TimeoutException) { }
                     * */

                    /*
                    using (SerialPort slavePort = new SerialPort("COM2"))
                    {
                        // configure serial port
                        slavePort.BaudRate = 9600;
                        slavePort.DataBits = 8;
                        slavePort.Parity = Parity.None;
                        slavePort.StopBits = StopBits.One;
                        slavePort.Open();
                    */


                        log.Debug("Starting Modbus Listener...");
                        if (modbus != null)
                            modbus.Listen();
                        else
                            log.Error("Modbus slave not started.");
                    mReading = false;
                    log.Debug("Modbus Listener Stopped.");
                    //}
                }
                else
                {
                    TimeSpan waitTime = new TimeSpan(0, 0, 0, 0, 50);
                    Thread.Sleep(waitTime);
                }
            }
        }

        public void Open()
        {
            Close();
            try
            {

                mSerialPort.PortName = Settings.Instance.PortName;
                mSerialPort.BaudRate = Settings.Instance.BaudRate;
                mSerialPort.Parity = Settings.Instance.Parity;
                mSerialPort.DataBits = Settings.Instance.DataBits;
                mSerialPort.StopBits = Settings.Instance.StopBits;
                mSerialPort.Handshake = Settings.Instance.Handshake;

                mSerialPort.ReadTimeout = 50;
                mSerialPort.WriteTimeout = 50;

                mSerialPort.Open();
                log.Info(String.Format("{0} opened", Settings.Instance.PortName));
            }
            catch(IOException)
            {
                log.Error(String.Format("{0} does not exist", Settings.Instance.PortName));
            }
            catch(UnauthorizedAccessException)
            {
                log.Error(String.Format("{0} already in use", Settings.Instance.PortName));
            }

            try
            {
                byte unitId = 1;
                // create modbus slave
                log.Debug("Creating Modbus object...");
                modbus = ModbusSerialListener.CreateAscii(unitId, mSerialPort);
                
                modbus.ModbusListenerPacketReceived += OnModbusListenerPacketReceived;
                modbus.DataStore = DataStoreFactory.CreateDefaultDataStore();
                Thread slaveThread = new Thread(new ThreadStart(modbus.Listen));
                slaveThread.Start();
            }
            catch(Exception e)
            {
                log.Error(e.Message);
            }
            //StartReading();
            
        }

        public void Close()
        {
            StopReading();
            mSerialPort.Close();
            log.Info(String.Format("{0} connection closed", Settings.Instance.PortName));
        }

        public bool IsOpen
        {
            get
            {
                return mSerialPort.IsOpen;
            }
        }

        static public string[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        public void Send(string data)
        {
            if (IsOpen)
            {
                mSerialPort.Write(data);
            }
        }

        private void StartReading()
        {
            if (!mReading)
            { 
                mReading = true;
                mInputThread = new Thread(ProcessIncoming);
                mInputThread.Start();
                log.Debug("Starting reader thread");
            }
        }

        private void StopReading()
        {
            if(mReading)
            {
                log.Debug("Stopping reader thread");
                mReading = false;
                mInputThread.Join();
                mInputThread = null;
            }
        }
    }
}
