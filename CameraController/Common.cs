using System;
using System.Collections.Generic;
using System.Text;

namespace CameraController
{
    class Common
    {
        public static string StripSpaces(string inputString)
        {
            string strReturn = inputString.Replace(" ", "");
            return strReturn;
        }

        public static string SendCameraCommand(System.IO.Ports.SerialPort srlCapture, byte[] command)
        {
            StringBuilder output = new StringBuilder();
            foreach (var item in command)
            {
                output.Append(string.Format("{0:x2}", item));
                output.Append(" ");
            }


            srlCapture.Write(command, 0, command.Length);

            return output.ToString();
        }



        internal static void InitializeCameras(System.IO.Ports.SerialPort _srlCapture)
        {
            byte[] command = new byte[4];

            //  AddressSet  88 30 01 FF
            //  IF_Clear  88 01 00 01 FF

            command[0] = 0x88;
            command[1] = 0x30;
            command[2] = 0x01;
            command[3] = 0xFF;
            SendCameraCommand(_srlCapture, command);

            command = new byte[5];
            command[0] = 0x88;
            command[1] = 0x01;
            command[2] = 0x00;
            command[3] = 0x01;
            command[4] = 0xFF;
            SendCameraCommand(_srlCapture, command);



        }
    }
}
