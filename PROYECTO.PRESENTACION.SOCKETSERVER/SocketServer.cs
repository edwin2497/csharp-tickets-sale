﻿using PRESENTACION.LOGICA;
using PROYECTO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.PRESENTACION.SOCKETSERVER
{
   public class SocketServer
    {
        static void Main(string[] args)
        {
            ExecuteServerObject();
        }

        public static void ExecuteServerObject()
        {
            // Establish the local endpoint  
            // for the socket. Dns.GetHostName 
            // returns the name of the host  
            // running the application. 
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

            // Creation TCP/IP Socket using  
            // Socket Class Costructor 
            Socket listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            Persona personaRecibida = new Persona();
            Operaciones op = new Operaciones();

            try
            {

                // Using Bind() method we associate a 
                // network address to the Server Socket 
                // All client that will connect to this  
                // Server Socket must know this network 
                // Address 
                listener.Bind(localEndPoint);

                // Using Listen() method we create  
                // the Client list that will want 
                // to connect to Server 
                listener.Listen(10);

                while (true)
                {

                    Console.WriteLine("Waiting connection ... ");

                    // Suspend while waiting for 
                    // incoming connection Using  
                    // Accept() method the server  
                    // will accept connection of client 
                    Socket clientSocket = listener.Accept();

                    // Data buffer 
                    byte[] bytes = new Byte[1024 * 8];

                    int numByte = clientSocket.Receive(bytes);

                    personaRecibida = personaRecibida.DeSerialize(bytes);

                    //while (true)
                    //{

                    //    int numByte = clientSocket.Receive(bytes);

                    //    data += Encoding.ASCII.GetString(bytes,
                    //                               0, numByte);

                    //    if (data.IndexOf("<EOF>") > -1)
                    //        break;
                    //}

                    // Console.WriteLine("Text received -> {0} ", DireccionRecibida.Id);
                    Persona personaLogin = new Persona();
                    personaLogin =  op.Login(new Persona(personaRecibida.Id, personaRecibida.Nombre, personaRecibida.Apellido, personaRecibida.Cedula, personaRecibida.Email, personaRecibida.TipoUsuario, personaRecibida.Password));

                    byte[] message = Encoding.ASCII.GetBytes("Test Server");

                    
                    // Send a message to Client  
                    // using Send() method 
                    if(personaLogin != null)
                    {
                        clientSocket.Send(personaLogin.Serialize());
                    }
                    else
                    {
                        personaLogin = new Persona(0, null, null, null, null, null, null);
                        clientSocket.Send(personaLogin.Serialize());
                    }
                    

                    // Close client Socket using the 
                    // Close() method. After closing, 
                    // we can use the closed Socket  
                    // for a new Client Connection 
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}