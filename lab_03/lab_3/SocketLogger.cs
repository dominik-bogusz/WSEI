using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port)
        {
            clientSocket = new ClientSocket(host, port);
        }

        public void Log(params string[] messages)
        {
            foreach (string message in messages)
            {
                using (clientSocket)
                {
                    byte[] requestBytes = Encoding.UTF8.GetBytes(message);
                    clientSocket.Send(requestBytes);
                }
            }
        }
        public void Dispose()
        {
            this.clientSocket.Close();
            GC.SuppressFinalize(this);
        }
    }
}
 