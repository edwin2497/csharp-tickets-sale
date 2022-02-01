using PROYECTO.ACCESO_DATOS;
using PROYECTO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION.LOGICA
{
    public class Operaciones
    {
        #region Personas

        public int idPersonas = 1;
        OperacionesPersonas op = new OperacionesPersonas();

        public void InsertarPersona(Persona item)
        {
            op.Insertar(item);
            idPersonas++;
        }

        public string EliminarPersona(Persona item)
        {
            if (op.Buscar(item.Id) == null)
            {
                return "Persona seleccionada no existe";
            }
            else
            {
                op.Eliminar(item);
                return "Persona Eliminada Correctamente";
            }
        }

        public string ModificarPersona(Persona item)
        {
            if (op.Buscar(item.Id) == null)
            {
                return "Persona seleccionada no existe";
            }
            else
            {
                op.Modificar(item);
                return "Persona Modificada Correctamente";
            }
        }

        public SqlDataReader CargarPersonas()
        {
            return op.CargarDatos();
        }

        public Persona Login (Persona persona)
        {
            return op.Login(persona);
        }

        public SqlDataReader BuscarPersona(int id)
        {
            return op.BuscarDataGrid(id);
        }

        public SqlDataReader BuscarPersona(string nombre)
        {
            return op.BuscarDataGrid(nombre);
        }

        #endregion

        #region Espectáculos

        public int idEspectáculos = 1;
        OperacionesEspectaculos oe = new OperacionesEspectaculos();

        public void InsertarEspectaculo(Espectaculos item)
        {
            oe.Insertar(item);
            idEspectáculos++;
        }

        public string EliminarEspectaculo(Espectaculos item)
        {
            if (oe.Buscar(item.IdConcierto) == null)
            {
                return "Concierto seleccionado no existe";
            }
            else
            {
                oe.Eliminar(item);
                return "Concierto Eliminado Correctamente";
            }
        }

        public string ModificarEspectaculo(Espectaculos item)
        {
            if (oe.Buscar(item.IdConcierto) == null)
            {
                return "Concierto seleccionado no existe";
            }
            else
            {
                oe.Modificar(item);
                return "Concierto Modificado Correctamente";
            }
        }

        public Espectaculos BuscarEspectaculoGrupo(string nombre)
        {
            return oe.Buscar(nombre);
        }

        public SqlDataReader CargarEspectaculos()
        {
            return oe.CargarDatos();
        }

        public SqlDataReader BuscarEspectaculo(int id)
        {
            return oe.BuscarDataGrid(id);
        }

        public SqlDataReader BuscarEspectaculo(string nombre)
        {
            return oe.BuscarDataGrid(nombre);
        }

        public List<string> CargarDatosCliente()
        {
            return oe.CargarDatosCliente();
        }
        #endregion

        #region Auditoria

        public int idAuditoria = 1;

        OperacionesAuditoria oa = new OperacionesAuditoria();

        public void InsertarAuditoria(Auditoria auditoria)
        {
            oa.Insertar(auditoria);
            idAuditoria++;
        }

        public SqlDataReader CargarAuditoriaAdmin()
        {
            return oa.CargarDatosAdmin();
        }

        public SqlDataReader CargarAuditoriaCliente(int id)
        {
            return oa.CargarDatosCliente(id);
        }

        #endregion

        #region AsientosComprados

        public int idAsientos = 1;

        OperacionesAsientos oas = new OperacionesAsientos();

        public void InsertarAsientos(List<Asientos> listaAsientosComprados)
        {
            foreach (Asientos asiento in listaAsientosComprados)
            {
                oas.Insertar(asiento);
                idAuditoria++;
            }
        }

        public List<Asientos> BuscarAsientos(int id)
        {
            return oas.BuscarTodos(id);
        }


        #endregion
    }
}
