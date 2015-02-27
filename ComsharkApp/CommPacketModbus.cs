using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using Modbus;
using Modbus.Message;
using System.Xml.Linq;
using Modbus.Utility;
using Unme.Common;


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
        XElement mDetailedInformation;
        byte[] mFrame;
        
        
        public CommPacketModbus(ICommInterface iface, byte[] frame, IModbusMessage message)
        {
            mTimestamp = DateTime.Now;
            mProtocol = "Modbus/ASCII";
            mInterface = iface;
            mFrame = frame;

            if (message != null)
            {
                mMessage = message;
                //mLength = message.MessageFrame.Length;
                mLength = message.ProtocolDataUnit.Length;

                mSource = mMessage.SlaveAddress.ToString();
                mDestination = mMessage.SlaveAddress.ToString();
                

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

                mInfo = mFunctionCodeString + " - " + mMessage.ToString();
            }
            else
            {
                mSource = "Unknown";
                mDestination = "Unknown";
                mFunctionCodeString = "Unsupported function type";
                mInfo = mFunctionCodeString;

            }

            CompileDetailedInformation();
        }

        public void CompileDetailedInformation()
        {
            byte[] asciiBytes = ModbusUtility.GetAsciiBytes(mFrame);
            string asciiString = System.Text.Encoding.ASCII.GetString(asciiBytes);

            string checkStr;
            switch(mValid)
            {
                case 0:
                    checkStr = "[Failed]";
                    break;
                case 1:
                    checkStr = "[Passed]";
                    break;
                default:
                    checkStr = "[validation disabled]";
                    break;
            }
            mDetailedInformation = new XElement("root", new XAttribute("content", "Packet Details"), 
                            new XElement("frame_parent", new XAttribute("content", "Frame"),
                                new XElement("interface", new XAttribute("content", "Interface: " + mInterface.Name())),
                                new XElement("interface_settings", new XAttribute("content", mInterface.GetSettingsSummary())),
                                new XElement("arrival_time", new XAttribute("content", "[Arrival Time: " + mTimestamp.ToString() + "]")),
                                new XElement("epoch_time", new XAttribute("content", "[Epoch Time: " + Comshark.ComsharkUtility.ConvertToUnixTimestamp(mTimestamp).ToString() + "]")) //,
                                //new XElement("time_delta_previous", new XAttribute("content", "[Time delta from previous captured frame: " + "]")),
                                //new XElement("time_delta_reference", new XAttribute("content", "[Time since reference or first frame: " + "]"))
                                ),
                            new XElement("protocol_parent", new XAttribute("content", "Protocol:"),
                                new XElement("protocol", new XAttribute("content", "Protocol: " + mProtocol)),
                                new XElement("station_address", new XAttribute("content", "Station Address: " + mMessage.SlaveAddress.ToString("X2") + " (" + mMessage.SlaveAddress.ToString() + ")")),
                                new XElement("function_code", new XAttribute("content", "Function Code: 0x" + mMessage.FunctionCode.ToString("X2") + " (" + mMessage.FunctionCode.ToString() + ") " + mFunctionCodeString )),
                                new XElement("data_ascii_char", new XAttribute("content", "Data ASCII: \"" + asciiString + "\"" )),
                                new XElement("data_ascii_decimal", new XAttribute("content", "Data ASCII (dec): " + asciiBytes.Join(" "))),
                                new XElement("data_ascii_hex", new XAttribute("content", "Data ASCII (hex): " + BitConverter.ToString(asciiBytes).Replace("-", " "))),
                                new XElement("data_ascii_hex", new XAttribute("content", "Data (dec): " + mFrame.Join(" "))),
                                new XElement("data_ascii_hex", new XAttribute("content", "Data (hex): " + BitConverter.ToString(mFrame).Replace("-", " "))),
                                new XElement("lrc", new XAttribute("content", "LRC: 0x" +  mFrame.Last().ToString("X2") + " " + checkStr)),
                                //new XElement("data_ascii_hex", new XAttribute("content", "Line Ending: ")),
                                //new XElement("data_ascii_hex", new XAttribute("content", "[Padding Since Last Packet: ]")),
                                new XElement("frame_length", new XAttribute("content", "Frame Length: " + mFrame.Length.ToString())),
                                new XElement("frame_length", new XAttribute("content", "Message Frame Length: " + mMessage.MessageFrame.Length.ToString())),
                                new XElement("data_unit_length", new XAttribute("content", "Protocol Data Unit Length: " + mMessage.ProtocolDataUnit.Length.ToString())),
                                new XElement("transaction_id", new XAttribute("content", "Transaction Id: " + mMessage.TransactionId.ToString()))
                                ),
                            new XElement("analysis_parent", new XAttribute("content", "Analysis")//,
                                //new XElement("transaction_id", new XAttribute("content", "Data (hex): "))
                                ),
                            new XElement("payload_parent", new XAttribute("content", "Payload")//,
                                //new XElement("transaction_id", new XAttribute("content", "Data (hex): "))
                                )
                            );
        }
        /*
        _logger.InfoFormat("RX (ASCII-CHAR) length={0}: '{1}'", frameHex.Length-1, frameHex);
            byte[] frameASCIIbytes = System.Text.Encoding.ASCII.GetBytes(frameHex);
            _logger.InfoFormat("RX (ASCII-HEX): {0:X}", frameASCIIbytes.Join(" "));
            _logger.InfoFormat("RX (ASCII-DEC): {0}", frameASCIIbytes.Join(" "));
			_logger.InfoFormat("RX (Decimal), length={0}: {1}", frame.Length, frame.Join(", "));
        */
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

        public XElement DetailedInformation
        { 
            get
            {
                return mDetailedInformation;
            }
            set
            {

            }
        }

        public byte[] Frame
        {
            get
            {
                return mFrame;
            }

            set
            {
                mFrame = value;
            }
        }

    }

}

