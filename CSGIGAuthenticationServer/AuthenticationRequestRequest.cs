using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGAuthenticationServer
{
    public class AuthenticationRequestRequest : Ac4yServiceRequest
    {
        public string fbToken { get; set; }
        public string CheckData { get; set; }

    }
}
