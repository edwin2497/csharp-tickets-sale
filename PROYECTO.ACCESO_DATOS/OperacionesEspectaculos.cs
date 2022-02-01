using PROYECTO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.ACCESO_DATOS
{
    public class OperacionesEspectaculos : IOperaciones<Espectaculos>
    {
        Conexion conexion = new Conexion();

        public void Insertar(Espectaculos item)
        {
            string Sqlstring = string.Format("INSERT INTO[dbo].[Espectaculos]([NombreGrupo],[Descripcion],[CantidadAsientosBajos],[CostoAsientosBajos],[CantidadAsientosMedios],[CostoAsientosMedios],[CantidadAsientosAltos],[CostoAsientosAltos],[CantidadAsientosDiscapacitados],[CostoAsientosDiscapacitados]) " +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", item.NombreGrupo, item.Descripción, item.CantidadAsientosBajos, item.CostoAsientosBajos, item.CantidadAsientosMedios, item.CostoAsientosMedios, item.CantidadAsientosAltos, item.CostoAsientosAltos, item.CantidadAsientosDiscapacitados, item.CostoAsientosDiscapacitados);
            conexion.nonQueryUsing(Sqlstring);
        }

        public void Modificar(Espectaculos item)
        {
            string Sqlstring = string.Format("UPDATE[dbo].[Espectaculos] SET [NombreGrupo]='{0}',[Descripcion] ='{1}',[CantidadAsientosBajos] ='{2}',[CostoAsientosBajos] ='{3}',[CantidadAsientosMedios] ='{4}',[CostoAsientosMedios] ='{5}' ,[CantidadAsientosAltos] ='{6}',[CostoAsientosAltos] ='{7}',[CantidadAsientosDiscapacitados] ='{8}',[CostoAsientosDiscapacitados] ='{9}'" +
                "WHERE Id={10}", item.NombreGrupo, item.Descripción, item.CantidadAsientosBajos, item.CostoAsientosBajos, item.CantidadAsientosMedios, item.CostoAsientosMedios, item.CantidadAsientosAltos, item.CostoAsientosAltos, item.CantidadAsientosDiscapacitados, item.CostoAsientosDiscapacitados, item.IdConcierto);
            conexion.nonQueryUsing(Sqlstring);
        }

        public void Eliminar(Espectaculos item)
        {
            string Sqlstring = string.Format("DELETE from Espectaculos where Id={0}", item.IdConcierto);
            conexion.nonQueryUsing(Sqlstring);
        }

        public Espectaculos Buscar(int id)
        {
            string Sqlstring = string.Format("SELECT * from Espectaculos where Id={0}", id);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);

            if (SQLTemporal != null && SQLTemporal.HasRows)
            {
                while (SQLTemporal.Read())
                {
                    return new Espectaculos(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetInt32(3), SQLTemporal.GetInt32(4), SQLTemporal.GetInt32(5), SQLTemporal.GetInt32(6), SQLTemporal.GetInt32(7), SQLTemporal.GetInt32(8), SQLTemporal.GetInt32(9), SQLTemporal.GetInt32(10));
                }
            }
            return null;
        }

        public Espectaculos Buscar(string nombre)
        {
            string Sqlstring = string.Format("SELECT * from Espectaculos where NombreGrupo like '{0}' ", nombre);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);

            if (SQLTemporal != null && SQLTemporal.HasRows)
            {
                while (SQLTemporal.Read())
                {
                    return new Espectaculos(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetInt32(3), SQLTemporal.GetInt32(4), SQLTemporal.GetInt32(5), SQLTemporal.GetInt32(6), SQLTemporal.GetInt32(7), SQLTemporal.GetInt32(8), SQLTemporal.GetInt32(9), SQLTemporal.GetInt32(10));
                }
            }
            return null;
        }

        public SqlDataReader CargarDatos()
        {
            string Sqlstring = string.Format("SELECT * from [dbo].[Espectaculos] ");
            SqlDataReader dt = conexion.QueryUsing(Sqlstring);
            return dt;
        }

        public List<string> CargarDatosCliente()
        {
            List<string> listaEspectaculos = new List<string>();

            try
            {
                string Sqlstring = string.Format("SELECT * from [dbo].[Espectaculos] ");

                SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);

                if (SQLTemporal != null && SQLTemporal.HasRows)
                {
                    while (SQLTemporal.Read())
                    {
                        Espectaculos espectaculo = new Espectaculos(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetInt32(3), SQLTemporal.GetInt32(4), SQLTemporal.GetInt32(5), SQLTemporal.GetInt32(6), SQLTemporal.GetInt32(7), SQLTemporal.GetInt32(8), SQLTemporal.GetInt32(9), SQLTemporal.GetInt32(10));
                        listaEspectaculos.Add(espectaculo.NombreGrupo);
                    }
                }
                return listaEspectaculos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader BuscarDataGrid(int id)
        {
            string Sqlstring = string.Format("SELECT * from Espectaculos where Id={0}", id);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);
            return SQLTemporal;
        }

        public SqlDataReader BuscarDataGrid(string nombre)
        {
            string Sqlstring = string.Format("SELECT * from Espectaculos where NombreGrupo like '{0}' ", nombre);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);
            return SQLTemporal;
        }
    }
}
