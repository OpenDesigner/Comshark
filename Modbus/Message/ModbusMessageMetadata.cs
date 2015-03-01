using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus.Message
{
    public class ModbusMessageMetadata
    {
        byte mCalculatedRedundancyCheckByte;
        byte mFrameRedundancyCheckByte;
        bool mPassedFrameCheck;
        bool mFailedFrameCheck;
        bool mResponse;
        bool mRequest;

        public ModbusMessageMetadata()
        {
            mPassedFrameCheck = false;
            mFailedFrameCheck = false;
        }

        public bool Request
        {
            get
            {
                return mRequest;
            }
            set
            {
                mRequest = value;
            }
        }

        public bool Response
        {
            get
            {
                return mResponse;
            }
            set
            {
                mResponse = value;
            }
        }

        public byte CalculatedRedundancyCheck
        {
            get
            {
                return mCalculatedRedundancyCheckByte;
            }
            set
            {
                mCalculatedRedundancyCheckByte = value;
            }
        }

        public byte FrameRedundancyCheck
        {
            get
            {
                return mFrameRedundancyCheckByte;
            }
            set
            {
                mFrameRedundancyCheckByte = value;
            }
        }

        public bool CheckedFrame
        {
            get
            {
                return mPassedFrameCheck | mFailedFrameCheck;
            }
        }
        public bool PassedFrameCheck
        {
            get
            {
                return mPassedFrameCheck;
            }

            set
            {
                mPassedFrameCheck = value;
            }
        }

        public bool FailedFrameCheck
        {
            get
            {
                return mFailedFrameCheck;
            }

            set
            {
                mFailedFrameCheck = value;
            }
        }


    }
}
