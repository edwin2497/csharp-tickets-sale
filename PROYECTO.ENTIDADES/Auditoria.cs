using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.ENTIDADES
{
    public class Auditoria
    {
        #region Propiedades
        private int idAuditoria;
        private int idCliente;
        private int idEvento;
        private string asientosComprados;
        private int precioTotal;


        #endregion

        #region Getters/Setters
        public int IdAuditoria { get => idAuditoria; set => idAuditoria = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdEvento { get => idEvento; set => idEvento = value; }
        public string CantidadAsientos { get => asientosComprados; set => asientosComprados = value; }
        public int PrecioTotal { get => precioTotal; set => precioTotal = value; }
        #endregion

        #region Constructores
        public Auditoria()
        {

        }

        public Auditoria(int idAuditoria, int idCliente, int idEvento, string asientosComprados, int precioTotal)
        {
            this.idAuditoria = idAuditoria;
            this.idCliente = idCliente;
            this.idEvento = idEvento;
            this.asientosComprados = asientosComprados;
            this.precioTotal = precioTotal;
        }
        #endregion
    }
}
