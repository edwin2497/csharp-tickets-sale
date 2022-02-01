using PROYECTO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.ACCESO_DATOS
{
    public class OperacionesAuditoria : IOperaciones<Auditoria>
    {
        Conexion conexion = new Conexion();
        public Auditoria Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public Auditoria Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Auditoria item)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Auditoria item)//Insertar datos en DB
        {
            string Sqlstring = string.Format("INSERT INTO[dbo].[Auditoria]([IdAuditoria],[IdCliente],[IdEvento],[AsientosComprados],[PrecioTotal]) " + "VALUES ('{0}','{1}','{2}','{3}','{4}')", item.IdAuditoria, item.IdCliente, item.IdEvento, item.CantidadAsientos, item.PrecioTotal);
            conexion.nonQueryUsing(Sqlstring);
        }

        public void Modificar(Auditoria item)
        {
            throw new NotImplementedException();
        }

        public SqlDataReader CargarDatosAdmin()//Envio datos de toda la tabla para mostrar en el datagrid del admin
        {
            string Sqlstring = string.Format("SELECT * from [dbo].[Auditoria] ");
            SqlDataReader dt = conexion.QueryUsing(Sqlstring);
            return dt;
        }

        public SqlDataReader CargarDatosCliente(int id)//Envio datos solo del usuario ingresado para mostrar al cliente
        {
            string Sqlstring = string.Format("SELECT * from Auditoria where IdCliente={0}", id);
            SqlDataReader SQLTemporal = conexion.QueryUsing(Sqlstring);
            return SQLTemporal;
        }
    }
}
