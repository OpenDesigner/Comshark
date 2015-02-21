using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO.Ports;

namespace Comshark
{
    [SettingsGroupName("ComsharkSettings")]
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
        [DefaultSettingValue("COM1")]
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
        public StopBits StopBits
        {
            get
            {
                return ((StopBits)this["StopBits"]);
                /*
                if (this["StopBits"] == StopBits.None.ToString())
                {
                    return StopBits.None;
                }
                else if (this["StopBits"] == StopBits.One.ToString())
                {
                    return StopBits.One;
                }
                else if (this["StopBits"] == StopBits.OnePointFive.ToString())
                {
                    return StopBits.OnePointFive;
                }
                else if (this["StopBits"] == StopBits.Two.ToString())
                {
                    return StopBits.Two;
                }
                else
                {
                    log.Warn("StopBits setting invalid");
                    return StopBits.None; //Default to None
                }
                 * */
            }
            set
            {

                this["StopBits"] = (StopBits)value;
                
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("None")]
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
}
