using Modul.Final.Class;
using SycomplaWebAppClientCore;
using System;

namespace CSGIGAuthenticationServer
{
    public class AuthenticationServerObjectService
    {
        public string Server { get; set; }
        public string ServerKey { get; set; }

        public AuthenticationServerObjectService() { }

        public AuthenticationServerObjectService(string server, string serverKey)
        {
            Server = server;
            ServerKey = serverKey;
        }

        public AuthenticationRequestResponse AuthenticationRequest(AuthenticationRequestRequest request)
        {
            AuthenticationRequestResponse response = new AuthenticationRequestResponse();

            try
            {
                new AuthenticationServerService().AuthenticationRequestService(Server, ServerKey, request.fbToken, request.CheckData);

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

    }
}
