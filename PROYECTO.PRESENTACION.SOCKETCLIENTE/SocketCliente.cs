using PROYECTO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.PRESENTACION.SOCKETCLIENTE
{
    public class SocketCliente
    {
        static void Main(string[] args)
        {
        }

        public Persona /*void*/ ExecuteClientObject(Persona persona)
        { 
            try
            {
                // Establish the remote endpoint  
                // for the socket. This example  
                // uses port 11111 on the local  
                // computer. 
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

                // Creation TCP/IP Socket using  
                // Socket Class Costructor 
                Socket sender = new Socket(ipAddr.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);

                try
                {

                    // Connect Socket to the remote  
                    // endpoint using method Connect() 
                    sender.Connect(localEndPoint);

                    // We print EndPoint information  
                    // that we are connected 
                    Console.WriteLine("Socket connected to -> {0} ",
                                  sender.RemoteEndPoint.ToString());

                    // Creation of messagge that 
                    // we will send to Server 

                    int byteSent = sender.Send(persona.Serialize());

                    // Data buffer 
                    byte[] messageReceived = new byte[1024];

                    // We receive the messagge using  
                    // the method Receive(). This  
                    // method returns number of bytes 
                    // received, that we'll use to  
                    // convert them to string 
                    int byteRecv = sender.Receive(messageReceived);

                    //Persona personaCliente = new Persona();
                    //personaCliente = personaCliente.DeSerialize(messageReceived);

                    Persona personaLogin = new Persona();
                    personaLogin = personaLogin.DeSerialize(messageReceived);

                    // Console.WriteLine("Respuesta Server -> {0} ", DireccionCliente.Cedula);
                    // Close Socket using  
                    // the method Close() 
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                    return personaLogin;
                }

                // Manage of Socket's Exceptions 
                catch (ArgumentNullException ane)
                {

                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }

                catch (SocketException se)
                {

                    Console.WriteLine("SocketException : {0}", se.ToString());
                }

                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
            return null;
        }
    }
}
