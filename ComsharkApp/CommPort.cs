using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Threading;


namespace Comshark
{
    class CommPort
    {
        SerialPort mSerialPort;
        Thread mInputThread;
        bool mReading;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static readonly CommPort instance = new CommPort();

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


        public delegate void EventHandler(string param);
        public EventHandler StatusChanged;
        public EventHandler DataReceived;

        private void ProcessIncoming()
        {
            while (mReading)
            {
                if (mSerialPort.IsOpen)
                {
                    byte[] readBuffer = new byte[mSerialPort.ReadBufferSize + 1];
                    try
                    {
                        int count = mSerialPort.Read(readBuffer, 0, mSerialPort.ReadBufferSize);
                        String SerialIn = System.Text.Encoding.ASCII.GetString(readBuffer, 0, count);
                        DataReceived(SerialIn);
                    }
                    catch (TimeoutException) { }
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
                StartReading();
            }
            catch(IOException)
            {
                log.Error(String.Format("{0} does not exist", Settings.Instance.PortName));
            }
            catch(UnauthorizedAccessException)
            {
                log.Error(String.Format("{0} already in use", Settings.Instance.PortName));
            }
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

        public string[] GetAvailablePorts()
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
            }
        }

        private void StopReading()
        {
            if(mReading)
            {
                mReading = false;
                mInputThread.Join();
                mInputThread = null;
            }
        }
    }
}
