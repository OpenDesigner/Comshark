using System.Linq;
using System.Text;
using log4net;

namespace Modbus.IO
{
	internal static class StreamResourceUtility
	{
        private static readonly ILog _logger = LogManager.GetLogger(typeof(StreamResourceUtility));

		internal static string ReadLine(IStreamResource stream)
		{
			var result = new StringBuilder();
			var singleByteBuffer = new byte[1];
            bool start = false;
            char inByte = '\0';
			do
			{
				stream.Read(singleByteBuffer, 0, 1);
                inByte = Encoding.ASCII.GetChars(singleByteBuffer).First();
                if (!start)
                {
                    if(inByte == ':') //Dont start until we find the start character :)
                    {
                        start = true;
                        result.Append(Encoding.ASCII.GetChars(singleByteBuffer).First());
                    }
                }
                else
                {
                    
                    if(inByte != '\0')
                    { 
                        result.Append(inByte);
                    }
                    else
                    {
                        _logger.Debug("Found null character within packet frame - ignoring!");
                    }
                    if(result.ToString().EndsWith(":"))
                    {
                        _logger.Debug("Received start of packet before the end of the current one");
                        break;
                    }
                }
            } while (!result.ToString().EndsWith(Modbus.NewLine)); //!result.ToString().EndsWith("\0") ||


			return result.ToString().Substring(0, result.Length - Modbus.NewLine.Length);
		}		
	}
}
