using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Modbus;
using Modbus.Message;
using System.Xml.Linq;
using Modbus.Utility;
using Unme.Common;
using System.Drawing;


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
        string mFraming;
        int mLength;
        string mFunctionCodeString;
        XElement mDetailedInformation;
        byte[] mFrame;
        ModbusMessageMetadata mMetadata;
        Color mTextColour;
        Color mBackgroundColour;
        
        
        public CommPacketModbus(ICommInterface iface, byte[] frame, IModbusMessage message, ModbusMessageMetadata metadata)
        {
            mTimestamp = DateTime.Now;
            mProtocol = "Modbus";
            mFraming = "ASCII";
            mInterface = iface;
            mFrame = frame;
            mMetadata = metadata;
            mTextColour = Color.Empty;
            mBackgroundColour = Color.Empty;
            mValid = (mMetadata.CheckedFrame && mMetadata.PassedFrameCheck) ? 1 : 0;




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
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.LightGreen;
                            mBackgroundColour = Color.DarkGray;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = ColorTranslator.FromHtml("#E4FFC7");
                        }
                        break;
                    case Modbus.Modbus.ReadInputs:
                        mFunctionCodeString = "[ReadInputs]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.LightGreen;
                            mBackgroundColour = Color.DarkGray;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = ColorTranslator.FromHtml("#E4FFC7");
                        }
                        break;
                    case Modbus.Modbus.ReadHoldingRegisters:
                        mFunctionCodeString = "[ReadHoldingRegisters]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.LightGreen;
                            mBackgroundColour = Color.DarkGray;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = ColorTranslator.FromHtml("#E4FFC7");
                        }
                        break;
                    case Modbus.Modbus.ReadInputRegisters:
                        mFunctionCodeString = "[ReadInputRegisters]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.LightGreen;
                            mBackgroundColour = Color.DarkGray;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = ColorTranslator.FromHtml("#E4FFC7");
                        }
                        break;
                    case Modbus.Modbus.Diagnostics:
                        mFunctionCodeString = "[Diagnostics]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightPink;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSalmon;
                        }
                        break;
                    case Modbus.Modbus.WriteSingleCoil:
                        mFunctionCodeString = "[WriteSingleCoil]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSkyBlue;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSteelBlue;
                        }
                        break;
                    case Modbus.Modbus.WriteSingleRegister:
                        mFunctionCodeString = "[WriteSingleRegister]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSkyBlue;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSteelBlue;
                        }
                        break;
                    case Modbus.Modbus.WriteMultipleCoils:
                        mFunctionCodeString = "[WriteMultipleCoils]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSkyBlue;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSteelBlue;
                        }
                        break;
                    case Modbus.Modbus.WriteMultipleRegisters:
                        mFunctionCodeString = "[WriteMultipleRegisters]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSkyBlue;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightSteelBlue;
                        }
                        break;
                    case Modbus.Modbus.ReadWriteMultipleRegisters:
                        mFunctionCodeString = "[ReadWriteMultipleRegisters]";
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightGreen;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.Black;
                            mBackgroundColour = Color.LightCyan;
                        }
                        break;
                    default:
                        mFunctionCodeString = String.Format("[Unknown function code {0}]", message.FunctionCode);
                        if (mMetadata.Response)
                        {
                            mTextColour = Color.LightYellow;
                            mBackgroundColour = Color.Gray;
                        }
                        else if (mMetadata.Request)
                        {
                            mTextColour = Color.LightYellow;
                            mBackgroundColour = Color.DimGray;
                        }
                        break;
                }

                if (mMetadata.Request == true && mMetadata.Response == false)
                    mInfo = "Request:  " + mFunctionCodeString + " - " + mMessage.ToString();
                else if (mMetadata.Request == false && mMetadata.Response == true)
                    mInfo = "Response: " + mFunctionCodeString;
                else
                    mInfo = mFunctionCodeString;

            }
            else
            {
                mSource = "Unknown";
                mDestination = "Unknown";
                mFunctionCodeString = "Unsupported function type";
                mInfo = mFunctionCodeString;

            }



            if (mMetadata.CheckedFrame && mMetadata.FailedFrameCheck)
            {
                mTextColour = Color.White;
                mBackgroundColour = Color.Red;
            }
            else if (!mMetadata.CheckedFrame)
            {
                mTextColour = Color.Black;
                mBackgroundColour = Color.Yellow;
            }
            else
            {
                //mTextColour = Color.White;
                //mBackgroundColour = Color.Green;
            }

            CompileDetailedInformation();
        }

        public void CompileDetailedInformation()
        {
            byte[] asciiBytes = ModbusUtility.GetAsciiBytes(mFrame);
            string asciiString = System.Text.Encoding.ASCII.GetString(asciiBytes);

            string checkStr;
            if(mMetadata.CheckedFrame)
            {
                if(mMetadata.PassedFrameCheck)
                    checkStr = "[Passed]";
                else
                    checkStr = "[Failed]";
            }
            else
            { 
                checkStr = "[validation disabled]";
            }

            mDetailedInformation = new XElement("root", new XAttribute("content", "Packet Details"), 
                            new XElement("frame_parent", new XAttribute("content", "Frame"), new XAttribute("expand", "true"),
                                new XElement("interface", new XAttribute("content", "Interface Name: " + mInterface.Name)),
                                new XElement("interface_type", new XAttribute("content", "Interface Type: [" + mInterface.ToString() + "]")),
                                ((mInterface is CommPort) ?
                                
                                new XElement("interface_settings", new XAttribute("content", "Interface Parameters: " + mInterface.Info),
                                    new XElement("baudrate", new XAttribute("content", "Baud Rate: " + (mInterface as CommPort).SerialPort.BaudRate.ToString())),
                                    new XElement("databits", new XAttribute("content", "Data Bits: " + (mInterface as CommPort).SerialPort.DataBits.ToString())),
                                    new XElement("parity", new XAttribute("content", "Parity: " + (mInterface as CommPort).SerialPort.Parity.ToString())),
                                    new XElement("stop_bits", new XAttribute("content", "Stop Bits: " + (mInterface as CommPort).SerialPort.StopBits.ToString())),
                                    new XElement("handshake", new XAttribute("content", "Handshake: " + (mInterface as CommPort).SerialPort.Handshake.ToString()))

                                    )
                                    
                                    : 
                                    
                                    new XElement("interface_settings", new XAttribute("content", "Interface Parameters: " + mInterface.Info))

                                    ),
                                    
                                new XElement("arrival_time", new XAttribute("content", "[Arrival Time: " + mTimestamp.ToString("yyyy-MM-dd HH:mm:ss.fff") + "]")),
                                new XElement("epoch_time", new XAttribute("content", "[Epoch Time: " + Comshark.ComsharkUtility.ConvertToUnixTimestamp(mTimestamp).ToString() + "]")) //,
                                //new XElement("time_delta_previous", new XAttribute("content", "[Time delta from previous captured frame: " + "]")),
                                //new XElement("time_delta_reference", new XAttribute("content", "[Time since reference or first frame: " + "]"))
                                ),
                                new XElement("protocol_parent", new XAttribute("content", mProtocol + ":"), new XAttribute("expand", "true"),
                                    new XElement("protocol", new XAttribute("content", "[Framing: " + mFraming + "]")),
                                    new XElement("station_address", new XAttribute("content", "Station Address: 0x" + mMessage.SlaveAddress.ToString("X2") + " (" + mMessage.SlaveAddress.ToString() + ")")),
                                    new XElement("function_code", new XAttribute("content", "Function Code: 0x" + mMessage.FunctionCode.ToString("X2") + " (" + mMessage.FunctionCode.ToString() + ") " + mFunctionCodeString )),
                                    new XElement("data_ascii_char", new XAttribute("content", "Data ASCII: \"" + asciiString + "\"" )),
                                    new XElement("data_ascii_decimal", new XAttribute("content", "Data ASCII (dec): " + asciiBytes.Join(" "))),
                                    new XElement("data_ascii_hex", new XAttribute("content", "Data ASCII (hex): " + BitConverter.ToString(asciiBytes).Replace("-", " "))),
                                    new XElement("data_ascii_hex", new XAttribute("content", "Decoded Data (dec): " + mFrame.Join(" "))),
                                    new XElement("data_ascii_hex", new XAttribute("content", "Decoded Data (hex): " + BitConverter.ToString(mFrame).Replace("-", " "))),
                                    /*new XElement("data_ascii_hex", new XAttribute("content", "Data: " + mMessage.ProtocolDataUnit.Join(", "))),*/
                                    new XElement("lrc", new XAttribute("content", "Redundancy Check: 0x" +  mMetadata.FrameRedundancyCheck.ToString("X2") + " " + checkStr),
                                        new XElement("lrc_failed", new XAttribute("content", "[Type: LRC]")),
                                        new XElement("lrc_calculated", new XAttribute("content", "Frame: 0x" + mMetadata.FrameRedundancyCheck.ToString("X2"))),
                                        new XElement("lrc_calculated", new XAttribute("content", "[Calculated: 0x" + mMetadata.CalculatedRedundancyCheck.ToString("X2") + "]")),
                                        new XElement("lrc_passed", new XAttribute("content", "[Passed: " + mMetadata.PassedFrameCheck.ToString() + "]")),
                                        new XElement("lrc_failed", new XAttribute("content", "[Failed: " + mMetadata.FailedFrameCheck.ToString() + "]"))
                                        ),
                                    //new XElement("data_ascii_hex", new XAttribute("content", "Trailer: [present] [abscent]")),
                                    //new XElement("data_ascii_hex", new XAttribute("content", "[Padding Since Last Packet: ]")),
                                    new XElement("frame_length", new XAttribute("content", "[Frame Length: " + mFrame.Length.ToString() + "]")),
                                    new XElement("frame_length", new XAttribute("content", "[Message Frame Length: " + mMessage.MessageFrame.Length.ToString() + "]")),
                                    new XElement("data_unit_length", new XAttribute("content", "Protocol Data Unit Length: " + mMessage.ProtocolDataUnit.Length.ToString())),
                                    new XElement("transaction_id", new XAttribute("content", "[Transaction Id: " + mMessage.TransactionId.ToString() + "]"))
                                    ),
                                new XElement("payload_parent", new XAttribute("content", "Data Payload:"), new XAttribute("expand", "true"),
                                    new XElement("data_ascii_char", new XAttribute("content", "Request: " + (mMetadata.Request ? "True" : "False"))),
                                    new XElement("data_ascii_char", new XAttribute("content", "Response: " + (mMetadata.Response ? "True" : "False"))),
                                    new XElement("info", new XAttribute("content", "[Info: " + mMessage.ToString() + "]"))
                                    //If request
                                    //new XElement("register_address", new XAttribute("content", "Register Address: " + mMetadata.RegisterAddress.ToString())),
                                    //new XElement("register_address", new XAttribute("content", "Number of Registers: " + mMetadata.RegisterCount.ToString())),
                                    //If response
                                    // list out each register value
                                    //new XElement("register_address", new XAttribute("content", "Register X: " + mMetadata.Registers[0].ToString())),
                                //new XElement("transaction_id", new XAttribute("content", "Data (hex): "))
                                )
                            );
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
                return mProtocol + "/" + mFraming;
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

        public Color TextColour
        { 
            get
            {
                return mTextColour;
            }
            
            set
            {
                
            }
        }

        public Color BackgroundColour
        {
            get
            {
                return mBackgroundColour;
            }

            set
            {

            }
        }

    }

}

