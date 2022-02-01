using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.ENTIDADES
{
    public class Asientos
    {
        #region Propiedades
        private int idRegistro;
        private int idEvento;
        private string tipoAsiento;
        private int numeroAsiento;
        #endregion

        #region Getters/Setters
        public int IdRegistro { get => idRegistro; set => idRegistro = value; }
        public int IdEvento { get => idEvento; set => idEvento = value; }
        public string TipoAsiento { get => tipoAsiento; set => tipoAsiento = value; }
        public int NumeroAsiento { get => numeroAsiento; set => numeroAsiento = value; }
        #endregion

        #region Constructores
        public Asientos(int idRegistro,int idEvento, string tipoAsiento, int numeroAsiento)
        {
            this.idRegistro = idRegistro;
            this.idEvento = idEvento;
            this.tipoAsiento = tipoAsiento;
            this.numeroAsiento = numeroAsiento;
        }

        public Asientos()
        {
        }
        #endregion
    }
}
