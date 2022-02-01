using PROYECTO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.ACCESO_DATOS
{
    public class OperacionesPersonas : IOperaciones<Persona>
    {

        Conexion conexion = new Conexion();
        public void Insertar(Persona item)
        {
            string Sqlstring = string.Format("INSERT INTO[dbo].[Personas]([NOMBRE],[APELLIDO],[CEDULA],[EMAIL],[TIPO],[PASSWORD]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", item.Nombre, item.Apellido, item.Cedula, item.Email, item.TipoUsuario,item.Password);
            conexion.nonQueryUsing(Sqlstring);
        }

        public void Modificar(Persona item)
        {
            string Sqlstring = string.Format("UPDATE[dbo].[Personas] SET [NOMBRE]='{0}',[APELLIDO] ='{1}',[CEDULA] ='{2}',[EMAIL] ='{3}',[TIPO] ='{4}',[PASSWORD] ='{5}' WHERE ID={6}", item.Nombre, item.Apellido, item.Cedula, item.Email, item.TipoUsuario,item.Password, item.Id);
            conexion.nonQueryUsing(Sqlstring);
        }

        public void Eliminar(Persona item)
        {
            string Sqlstring = string.Format("DELETE from Personas where ID={0}", item.Id);
            conexion.nonQueryUsing(Sqlstring);
        }

        public SqlDataReader BuscarDataGrid(int id)
        {
            string Sqlstring = string.Format("SELECT * from Personas where ID={0}", id);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);
            return SQLTemporal;
        }

        public SqlDataReader BuscarDataGrid(string nombre)
        {
            string Sqlstring = string.Format("SELECT * from Personas where NOMBRE like '{0}' ", nombre);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);
            return SQLTemporal;
        }

        public Persona Buscar(int id)
        {
            string Sqlstring = string.Format("SELECT * from Personas where ID={0}", id);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);

            if (SQLTemporal != null && SQLTemporal.HasRows)
            {
                while (SQLTemporal.Read())
                {
                    return new Persona(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetString(3).Trim(), SQLTemporal.GetString(4).Trim(), SQLTemporal.GetString(5).Trim(), SQLTemporal.GetString(6).Trim());
                }
            }
            return null;
        }

        public Persona Buscar(string nombre)
        {
            string Sqlstring = string.Format("SELECT * from Personas where NOMBRE like '{0}' ", nombre);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);

            if (SQLTemporal != null && SQLTemporal.HasRows)
            {
                while (SQLTemporal.Read())
                {
                    return new Persona(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetString(3).Trim(), SQLTemporal.GetString(4).Trim(), SQLTemporal.GetString(5).Trim(), SQLTemporal.GetString(6).Trim());
                }
            }
            return null;
        }

        public Persona Login(Persona item)
        {
            string Sqlstring = string.Format("SELECT * from Personas where EMAIL like '{0}' AND PASSWORD like '{1}' ", item.Email, item.Password);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);

            if (SQLTemporal != null && SQLTemporal.HasRows)
            {
                while (SQLTemporal.Read())
                {
                    return new Persona(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetString(3).Trim(), SQLTemporal.GetString(4).Trim(), SQLTemporal.GetString(5).Trim(), SQLTemporal.GetString(6).Trim());
                }
            }
            return null;
        }

        public SqlDataReader CargarDatos()
        {
            string Sqlstring = string.Format("SELECT * from [dbo].[Personas] ");
            SqlDataReader dt = conexion.QueryUsing(Sqlstring);
            return dt;
        }
    }
}
