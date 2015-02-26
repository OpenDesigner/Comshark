using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using Modbus;
using Modbus.Message;


namespace Comshark
{
    public class CommPacketModbus : ICommPacket
    {
        IModbusMessage mMessage;
        int mValid = 0;
        ICommInterface mInterface;
        string mSource;
        string mDestination;
        string mInfo;
        DateTime mTimestamp;
        string mProtocol;
        int mLength;
        string mFunctionCodeString;
        
        
        public CommPacketModbus(ICommInterface iface, IModbusMessage message)
        {
            mTimestamp = DateTime.Now;
            mProtocol = "Modbus/ASCII";
            mInterface = iface;

            if (message != null)
            {
                mMessage = message;
                //mLength = message.MessageFrame.Length;
                mLength = message.ProtocolDataUnit.Length;

                mSource = mMessage.SlaveAddress.ToString();
                mDestination = mMessage.SlaveAddress.ToString();
                mInfo = mFunctionCodeString + " - " + mMessage.ToString();

                switch (mMessage.FunctionCode)
                {

                    case Modbus.Modbus.ReadCoils:
                        mFunctionCodeString = "[ReadCoils]";
                        break;
                    case Modbus.Modbus.ReadInputs:
                        mFunctionCodeString = "[ReadInputs]";
                        break;
                    case Modbus.Modbus.ReadHoldingRegisters:
                        mFunctionCodeString = "[ReadHoldingRegisters]";
                        break;
                    case Modbus.Modbus.ReadInputRegisters:
                        mFunctionCodeString = "[ReadInputRegisters]";
                        break;
                    case Modbus.Modbus.Diagnostics:
                        mFunctionCodeString = "[Diagnostics]";
                        break;
                    case Modbus.Modbus.WriteSingleCoil:
                        mFunctionCodeString = "[WriteSingleCoil]";
                        break;
                    case Modbus.Modbus.WriteSingleRegister:
                        mFunctionCodeString = "[WriteSingleRegister]";
                        break;
                    case Modbus.Modbus.WriteMultipleCoils:
                        mFunctionCodeString = "[WriteMultipleCoils]";
                        break;
                    case Modbus.Modbus.WriteMultipleRegisters:
                        mFunctionCodeString = "[WriteMultipleRegisters]";
                        break;
                    case Modbus.Modbus.ReadWriteMultipleRegisters:
                        mFunctionCodeString = "[ReadWriteMUltipleRegisters]";
                        break;
                    default:
                        mFunctionCodeString = String.Format("Unsupported function code {0}", message.FunctionCode);
                        break;
                }
            }
            else
            {
                mSource = "Unknown";
                mDestination = "Unknown";
                mFunctionCodeString = "Unsupported function type";
                mInfo = mFunctionCodeString;

            }

        }

        public DateTime Timestamp
        {
            get
            {
                return mTimestamp;
            }

            set
            {
                mTimestamp = value;
            }
        }

        public ICommInterface Interface
        { 
            get
            {
                return mInterface;
            }

            set
            {
                mInterface = value;
            }
        }

        public string Source
        { 
            get
            {
                return mSource;
            }
            set
            {

            }
        }

        public string Destination
        { 
            get
            {
                return mDestination;
            }
            set
            {

            }
        }

        public string Protocol
        {
            get
            {
                return mProtocol;
            }

            set
            {
                mProtocol = value;
            }
        }

        public int Length
        {
            get
            {
                return mLength;
            }
            set
            {
                mLength = value;
            }
        }

        public string Info
        {
            get
            {
                return mInfo;
            }
            set
            {

            }
        }

        public int Valid
        {
            get
            {
                return mValid;
            }

            set
            {
                mValid = value;
            }
        }

    }

}

