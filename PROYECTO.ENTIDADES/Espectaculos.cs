using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.ENTIDADES
{
    public class Espectaculos
    {
        #region Propiedades
        private int idConcierto;
        private string nombreGrupo;
        private string descripción;
        private int cantidadAsientosBajos;
        private int costoAsientosBajos;
        private int cantidadAsientosMedios;
        private int costoAsientosMedios;
        private int cantidadAsientosAltos;
        private int costoAsientosAltos;
        private int cantidadAsientosDiscapacitados;
        private int costoAsientosDiscapacitados;
        #endregion

        #region Getters/Setters
        public int IdConcierto { get => idConcierto; set => idConcierto = value; }
        public string NombreGrupo { get => nombreGrupo; set => nombreGrupo = value; }
        public string Descripción { get => descripción; set => descripción = value; }
        public int CantidadAsientosBajos { get => cantidadAsientosBajos; set => cantidadAsientosBajos = value; }
        public int CostoAsientosBajos { get => costoAsientosBajos; set => costoAsientosBajos = value; }
        public int CantidadAsientosMedios { get => cantidadAsientosMedios; set => cantidadAsientosMedios = value; }
        public int CostoAsientosMedios { get => costoAsientosMedios; set => costoAsientosMedios = value; }
        public int CantidadAsientosAltos { get => cantidadAsientosAltos; set => cantidadAsientosAltos = value; }
        public int CostoAsientosAltos { get => costoAsientosAltos; set => costoAsientosAltos = value; }
        public int CantidadAsientosDiscapacitados { get => cantidadAsientosDiscapacitados; set => cantidadAsientosDiscapacitados = value; }
        public int CostoAsientosDiscapacitados { get => costoAsientosDiscapacitados; set => costoAsientosDiscapacitados = value; }
        #endregion

        #region Constructores
        public Espectaculos(int idConcierto, string nombreGrupo, string descripción, int cantidadAsientosBajos, int costoAsientosBajos, int cantidadAsientosMedios, int costoAsientosMedios, int cantidadAsientosAltos, int costoAsientosAltos, int cantidadAsientosDiscapacitados, int costoAsientosDiscapacitados)
        {
            this.idConcierto = idConcierto;
            this.nombreGrupo = nombreGrupo;
            this.descripción = descripción;
            this.cantidadAsientosBajos = cantidadAsientosBajos;
            this.costoAsientosBajos = costoAsientosBajos;
            this.cantidadAsientosMedios = cantidadAsientosMedios;
            this.costoAsientosMedios = costoAsientosMedios;
            this.cantidadAsientosAltos = cantidadAsientosAltos;
            this.costoAsientosAltos = costoAsientosAltos;
            this.cantidadAsientosDiscapacitados = cantidadAsientosDiscapacitados;
            this.costoAsientosDiscapacitados = costoAsientosDiscapacitados;
        }

        public Espectaculos()
        {
        }
        #endregion
    }
}
