using SycomplaWebAppClientCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGAuthenticationServer
{
    class AuthenticationServerService
    {
        public void AuthenticationRequestService(string server, string serverKey, string fbToken, string checkData)
        {

            new Ac4yRestServiceClient(server, serverKey).POST("", "{\r\n \"to\" : \"" + fbToken + "\",\r\n\r\n \"data\" : {\r\n \"body\" : \"" + checkData + "\"\r\n } \r\n}");

        }
    }
}
