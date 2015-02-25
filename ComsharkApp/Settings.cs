using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO.Ports;
using System.ComponentModel;

namespace Comshark
{
    [SettingsGroupName("ComsharkSettings")]
    [DefaultPropertyAttribute("PortName")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Settings() { }
        public static Settings Instance
        {
            get { return InstanceCreator.settingsInstance; }
        }

        private class InstanceCreator
        {
            static InstanceCreator() {}
            internal static readonly Settings settingsInstance = new Settings();
        }


        [UserScopedSetting()]
        [DefaultSettingValue("COM3")]
        [CategoryAttribute("Port")]
        [DescriptionAttribute("The serial port name to use for this interface")]
        [TypeConverter(typeof(PortNameListConverter))]
        public string PortName
        {
            get
            {
                return ((string)this["PortName"]);
            }
            set
            {
                this["PortName"] = (string)value;
            }

        }

        [UserScopedSetting()]
        [DefaultSettingValue("9600")]
        [CategoryAttribute("Port")]
        [DescriptionAttribute("The baud rate to use for this serial port")]
        [TypeConverter(typeof(BaudRateListConverter))]
        public int BaudRate
        {
            get
            {
                return ((int)this["BaudRate"]);
            }
            set
            {
                this["BaudRate"] = (int)value;
            }
        }


        [UserScopedSetting()]
        [DefaultSettingValue("None")]
        [CategoryAttribute("Port")]
        [DescriptionAttribute("The parity setting for this serial port")]
        public Parity Parity
        {
            get
            {
                return ((Parity)this["Parity"]);
            }
            set
            {
                this["Parity"] = (Parity)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("8")]
        [CategoryAttribute("Port")]
        [DescriptionAttribute("The length of each byte for this serial port")]
        [TypeConverter(typeof(DataBitsListConverter))]
        public int DataBits
        {
            get
            {
                return ((int)this["DataBits"]);
            }
            set
            {
                this["DataBits"] = (int)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("One")]
        [CategoryAttribute("Port")]
        [DescriptionAttribute("The number of stop bits for this serial port")]
        public StopBits StopBits
        {
            get
            {
                return ((StopBits)this["StopBits"]);
            }
            set
            {

                this["StopBits"] = (StopBits)value;
                
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("None")]
        [CategoryAttribute("Port")]
        [DescriptionAttribute("The handshake mode for this serial port")]
        public Handshake Handshake
        {
            get
            {
                return ((Handshake)this["Handshake"]);
            }
            set
            {
                this["Handshake"] = (Handshake)value;
            }
        }


    }

    public class PortNameListConverter : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(CommPort.GetAvailablePorts()); //Return array of available serial ports on the system
        }
    }

    public class BaudRateListConverter : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<int> list = new List<int>();
            list.Add(75);
            list.Add(110);
            list.Add(134);
            list.Add(150);
            list.Add(300);
            list.Add(600);
            list.Add(1200);
            list.Add(1800);
            list.Add(2400);
            list.Add(4800);
            list.Add(7200);
            list.Add(9600);
            list.Add(14400);
            list.Add(19200);
            list.Add(28800);
            list.Add(38400);
            list.Add(56000);
            list.Add(57600);
            list.Add(115200);
            list.Add(128000);
            list.Add(153600);
            list.Add(230400);
            list.Add(256000);
            list.Add(460800);
            list.Add(921600);
            return new StandardValuesCollection(list); //Return list of baud rates
        }
    }

    public class DataBitsListConverter : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(8);
            return new StandardValuesCollection(list); //Return list of data bit options
        }
    }
}
