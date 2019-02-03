﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Voxo.GoIpSmsServer
{
    /// <summary>
    /// GoIP device messages generator
    /// </summary>
    public static class ACKPacketFactory
    {
        public static string ACK_MESSAGE(long req, int status)
        {
            return string.Format(@"req:{0};status:{1};", req.ToString(), status.ToString());
        }

        public static string BULK_SMS_REQUEST(string sendid, string content)
        {
            string cont = content;
            if (cont.Length > 3000)
            {
                cont = cont.Substring(0, 3000);
            }


            return  string.Format(@"MSG {0} {1} {2}", sendid, cont.Length.ToString(), cont);
        }

        public static string AUTHENTICATION_REQUEST(string sendid, string password)
        {
            return string.Format(@"PASSWORD {0} {1}\n", sendid, password);
        }

        public static string SUBMIT_NUMBER_REQUEST(string sendid, int telid, string telephoneNumber)
        {
            return string.Format(@"SEND {0} {1} {2}", sendid, telid.ToString(), telephoneNumber);
        }

        public static string END_REQUEST(string sendid)
        {
            return string.Format(@"DONE {0}\n", sendid);
        }

        public static string RECEIVE_SMS_ACK(string receiveid, string errorMsg = "")
        {
            if (string.IsNullOrEmpty(errorMsg))
            {
                return string.Format(@"RECEIVE {0} OK\n", receiveid);
            }
            else
            {
                return string.Format(@"RECEIVE {0} ERROR {1}\n", receiveid, errorMsg);
            }
        }

        public static string DELIVER_ACK(string receiveid, string errorMsg = "")
        {
            if (string.IsNullOrEmpty(errorMsg))
            {
                return string.Format(@"DELIVER {0} OK\n", receiveid);
            }
            else
            {
                return string.Format(@"DELIVER {0} ERROR {1}\n", receiveid, errorMsg);
            }
        }

        public static string STATE_ACK(string receiveid, string errorMsg = "")
        {
            if (string.IsNullOrEmpty(errorMsg))
            {
                return string.Format(@"STATE {0} OK\n", receiveid);
            }
            else
            {
                return string.Format(@"STATE {0} ERROR {1}\n", receiveid, errorMsg);
            }
        }

        public static string REMAIN_ACK(string receiveid, string errorMsg = "")
        {
            if (string.IsNullOrEmpty(errorMsg))
            {
                return string.Format(@"REMAIN {0} OK\n", receiveid);
            }
            else
            {
                return string.Format(@"REMAIN {0} ERROR {1}\n", receiveid, errorMsg);
            }
        }

        public static string RECORD_ACK(string receiveid, string errorMsg = "")
        {
            if (string.IsNullOrEmpty(errorMsg))
            {
                return string.Format(@"RECORD {0} OK\n", receiveid);
            }
            else
            {
                return string.Format(@"RECORD {0} ERROR {1}\n", receiveid, errorMsg);
            }
        }

        public static string CELLS_ACK(string receiveid, string errorMsg = "")
        {
            if (string.IsNullOrEmpty(errorMsg))
            {
                return string.Format(@"CELLS {0} OK\n", receiveid);
            }
            else
            {
                return string.Format(@"CELLS {0} ERROR {1}\n", receiveid, errorMsg);
            }
        }
    }
}
