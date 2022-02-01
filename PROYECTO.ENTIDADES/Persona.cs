using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.ENTIDADES
{
    [Serializable]
    public class Persona
    {
        #region Propiedades
        private int id;
        private string nombre;
        private string apellido;
        private string cedula;
        private string email;
        private string tipoUsuario;
        private string password;
        #endregion

        #region Getters / Setters
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Email { get => email; set => email = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string Password { get => password; set => password = value; }

        #endregion

        #region Constructores
        public Persona(int id, string nombre, string apellido, string cedula, string email, string tipoUsuario, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.email = email;
            this.tipoUsuario = tipoUsuario;
            this.password = password;
        }

        public Persona()
        {
        }

        #endregion

        #region Serialize / Deserialize
        public byte[] Serialize() //Me permite serializar el objeto
        {
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            bin.Serialize(mem, this);
            return mem.GetBuffer();
        }

        public Persona DeSerialize(byte[] TransmissionBuffer) //Deserializa el los datos que recibe para usarse como un objeto
        {
            byte[] dataBuffer = TransmissionBuffer.ToArray();
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            mem.Write(dataBuffer, 0, dataBuffer.Length);
            mem.Seek(0, 0);

            return (Persona)bin.Deserialize(mem);
        }
        #endregion

    }
}
