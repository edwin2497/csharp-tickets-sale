using PROYECTO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.ACCESO_DATOS
{
    public class OperacionesAsientos : IOperaciones<Asientos>
    {
        Conexion conexion = new Conexion();
        public Asientos Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public Asientos Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Asientos item)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Asientos item)
        {
            string Sqlstring = string.Format("INSERT INTO[dbo].[Asientos]([IdEvento],[TipoAsiento],[NumeroAsiento])" + " VALUES ('{0}','{1}','{2}')", item.IdEvento, item.TipoAsiento, item.NumeroAsiento);
            conexion.nonQueryUsing(Sqlstring);
        }

        public void Modificar(Asientos item)
        {
            throw new NotImplementedException();
        }

        public List<Asientos> BuscarTodos(int id)
        {
            List<Asientos> listaAsientosComprados = new List<Asientos>();

            try
            {
                string Sqlstring = string.Format("SELECT * from Asientos where IdEvento={0}", id);

                SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);

                if (SQLTemporal != null && SQLTemporal.HasRows)
                {
                    while (SQLTemporal.Read())
                    {
                        Asientos asientosComprados = new Asientos(SQLTemporal.GetInt32(0), SQLTemporal.GetInt32(1), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetInt32(3));
                        listaAsientosComprados.Add(asientosComprados);
                    }
                }
                return listaAsientosComprados;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
