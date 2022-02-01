using PRESENTACION.LOGICA;
using PROYECTO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO.PRESENTACION
{
    public partial class VentaBoletos : Form
    {
        Operaciones op = new Operaciones();
        Espectaculos espectaculo = new Espectaculos();
        Persona persona = new Persona();
        Asientos asiento = new Asientos();
        List<Asientos> listaAsientosComprados = new List<Asientos>();

        //Variable que almacena el total a pagar
        int total;

        //Variables para almacenar cant y total a pagar de asientos altos
        int cantAltos;
        int totalAltos;

        //Variables para almacenar cant y total a pagar de asientos discapacitados
        int cantDisc;
        int totalDisc;

        //Variables para almacenar cant y total a pagar de asientos altos
        int cantMedios;
        int totalMedios;

        //Variables para almacenar cant y total a pagar de asientos altos
        int cantBajos;
        int totalBajos;

        //Acumulador para los datos de cant asientos comprados y el tipo que se muestra en la auditoria
        string asientosComprados = "";

        public VentaBoletos()
        {
            InitializeComponent();
            ocultarAsientos();
        }

        public void datosPersonales(Persona personaLogin)
        {
            //Cargo datos personales de la persona que esta logeada

            persona = personaLogin;

            lbl_Id.Text = persona.Id.ToString();
            lbl_Nombre.Text = persona.Nombre + " " + persona.Apellido;
            lbl_Cedula.Text = persona.Cedula;
            lbl_Email.Text = persona.Email;

            MostrarAuditoria();
        }

        public void pago()
        {
            espectaculo = op.BuscarEspectaculoGrupo(lb_ListaCategoria.SelectedItem.ToString());//Busco espectaculo por nombre

            //Acumuladores para mostrar datos de tipos de asientos seleccionados asi como el precio total por x cantidad de asientos seleccionados
            string mostrarTotal = "";
            string mostrarAltos = "";
            string mostrarDisc = "";
            string mostrarMedios = "";
            string mostrarBajos = "";

            //Realizo el calculo del total a pagar x cantidad de asientos de x tipo seleccionados
            totalAltos = cantAltos * espectaculo.CostoAsientosAltos;
            totalDisc = cantDisc * espectaculo.CostoAsientosDiscapacitados;
            totalMedios = cantMedios * espectaculo.CostoAsientosMedios;
            totalBajos = cantBajos * espectaculo.CostoAsientosBajos;

            //Total a pagar segun los calculos realizados anteriormente
            total = totalAltos + totalDisc + totalMedios + totalBajos; 

            if (totalAltos != 0)
            {
                mostrarAltos = "Asientos altos : " + cantAltos + " Costo: ₡ " + totalAltos;
                mostrarTotal += mostrarAltos + "\r\n";
            }
            if (totalDisc != 0)
            {
                mostrarDisc = "Asientos Discapacitados : " + cantDisc + " Costo: ₡ " + totalDisc;
                mostrarTotal += mostrarDisc + "\r\n";
            }
            if (totalMedios != 0)
            {
                mostrarMedios += "Asientos Medios : " + cantMedios + " Costo: ₡ " + totalMedios;
                mostrarTotal += mostrarMedios + "\r\n";
            }
           if (totalBajos != 0)
            {
                mostrarBajos = "Asientos Bajos : " + cantBajos + " Costo: ₡ " + totalBajos;
                mostrarTotal += mostrarBajos + "\r\n";
            }

            asientosComprados = mostrarTotal;

            mostrarTotal += /*mostrarAltos + "\r\n" + mostrarMedios + "\r\n" + mostrarBajos + "\r\n" + mostrarDisc + "\r\n" +*/ "Total: " + total;
            //asientosComprados = mostrarAltos + "\r\n" + mostrarDisc;

            txt_pago.Text = mostrarTotal;
        }

        public void MostrarAuditoria()
        {
            //Metodo que me carga el datagrid con los datos de la DB
            DataTable dt = new DataTable();
            dt.Load(op.CargarAuditoriaCliente(persona.Id));
            dg_Recibos.AutoGenerateColumns = true;
            dg_Recibos.DataSource = dt;
            dg_Recibos.Refresh();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if(total != 0)
            {
                op.InsertarAuditoria(new Auditoria(op.idAuditoria, int.Parse(lbl_Id.Text.ToString()), espectaculo.IdConcierto, asientosComprados, total));

                op.InsertarAsientos(listaAsientosComprados);

                CargarAsientosComprados();

                txt_pago.Text = "";

                MessageBox.Show("Compra Realizada Correctamente", "Compra Boletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe haber seleccionado asientos antes de comprar", "Compra Boletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cb_Categorías_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cargo lista de espectaculos desde la DB
            lbl_Espectaculos.Visible = true;
            lb_ListaCategoria.Visible = true;
            lb_ListaCategoria.DataSource = op.CargarDatosCliente();
        }

        private void lb_ListaCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Espectaculos espectaculo = op.BuscarEspectaculoGrupo(lb_ListaCategoria.SelectedItem.ToString());//Busco espectaculo por nombre
            
            //Cargo asientos altos
            if(espectaculo.CantidadAsientosAltos == 0)
            {
                btn_AsientoAlto_1.Visible = false;
                btn_AsientoAlto_2.Visible = false;
                btn_AsientoAlto_3.Visible = false;
                btn_AsientoAlto_4.Visible = false;
                btn_AsientoAlto_5.Visible = false;
                btn_AsientoAlto_6.Visible = false;
                btn_AsientoAlto_7.Visible = false;
                btn_AsientoAlto_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosAltos == 1)
            {
                btn_AsientoAlto_1.Visible = false;
                btn_AsientoAlto_2.Visible = true;
                btn_AsientoAlto_3.Visible = false;
                btn_AsientoAlto_4.Visible = false;
                btn_AsientoAlto_5.Visible = false;
                btn_AsientoAlto_6.Visible = false;
                btn_AsientoAlto_7.Visible = false;
                btn_AsientoAlto_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosAltos == 2)
            {
                btn_AsientoAlto_1.Visible = true;
                btn_AsientoAlto_2.Visible = false;
                btn_AsientoAlto_3.Visible = true;
                btn_AsientoAlto_4.Visible = false;
                btn_AsientoAlto_5.Visible = false;
                btn_AsientoAlto_6.Visible = false;
                btn_AsientoAlto_7.Visible = false;
                btn_AsientoAlto_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosAltos == 3)
            {
                btn_AsientoAlto_1.Visible = true;
                btn_AsientoAlto_2.Visible = true;
                btn_AsientoAlto_3.Visible = true;
                btn_AsientoAlto_4.Visible = false;
                btn_AsientoAlto_5.Visible = false;
                btn_AsientoAlto_6.Visible = false;
                btn_AsientoAlto_7.Visible = false;
                btn_AsientoAlto_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosAltos == 4)
            {
                btn_AsientoAlto_1.Visible = true;
                btn_AsientoAlto_2.Visible = false;
                btn_AsientoAlto_3.Visible = true;
                btn_AsientoAlto_4.Visible = true;
                btn_AsientoAlto_5.Visible = false;
                btn_AsientoAlto_6.Visible = true;
                btn_AsientoAlto_7.Visible = false;
                btn_AsientoAlto_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosAltos == 5)
            {
                btn_AsientoAlto_1.Visible = true;
                btn_AsientoAlto_2.Visible = false;
                btn_AsientoAlto_3.Visible = true;
                btn_AsientoAlto_4.Visible = true;
                btn_AsientoAlto_5.Visible = false;
                btn_AsientoAlto_6.Visible = true;
                btn_AsientoAlto_7.Visible = false;
                btn_AsientoAlto_8.Visible = true;
            }
            else if (espectaculo.CantidadAsientosAltos == 6)
            {
                btn_AsientoAlto_1.Visible = true;
                btn_AsientoAlto_2.Visible = true;
                btn_AsientoAlto_3.Visible = true;
                btn_AsientoAlto_4.Visible = false;
                btn_AsientoAlto_5.Visible = true;
                btn_AsientoAlto_6.Visible = true;
                btn_AsientoAlto_7.Visible = true;
                btn_AsientoAlto_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosAltos == 7)
            {
                btn_AsientoAlto_1.Visible = true;
                btn_AsientoAlto_2.Visible = true;
                btn_AsientoAlto_3.Visible = true;
                btn_AsientoAlto_4.Visible = true;
                btn_AsientoAlto_5.Visible = true;
                btn_AsientoAlto_6.Visible = true;
                btn_AsientoAlto_7.Visible = true;
                btn_AsientoAlto_8.Visible = false;
            }
            else
            {
                btn_AsientoAlto_1.Visible = true;
                btn_AsientoAlto_2.Visible = true;
                btn_AsientoAlto_3.Visible = true;
                btn_AsientoAlto_4.Visible = true;
                btn_AsientoAlto_5.Visible = true;
                btn_AsientoAlto_6.Visible = true;
                btn_AsientoAlto_7.Visible = true;
                btn_AsientoAlto_8.Visible = true;
            }

            //Cargo asientos discapacitados
            if (espectaculo.CantidadAsientosDiscapacitados == 0)
            {
                btn_AsientoDis_1.Visible = false;
                btn_AsientoDis_2.Visible = false;
                btn_AsientoDis_3.Visible = false;
                btn_AsientoDis_4.Visible = false;
                btn_AsientoDis_5.Visible = false;
                btn_AsientoDis_6.Visible = false;
            }
            else if (espectaculo.CantidadAsientosDiscapacitados == 1)
            {
                btn_AsientoDis_1.Visible = true;
                btn_AsientoDis_2.Visible = false;
                btn_AsientoDis_3.Visible = false;
                btn_AsientoDis_4.Visible = false;
                btn_AsientoDis_5.Visible = false;
                btn_AsientoDis_6.Visible = false;
            }
            else if (espectaculo.CantidadAsientosDiscapacitados == 2)
            {
                btn_AsientoDis_1.Visible = true;
                btn_AsientoDis_2.Visible = true;
                btn_AsientoDis_3.Visible = false;
                btn_AsientoDis_4.Visible = false;
                btn_AsientoDis_5.Visible = false;
                btn_AsientoDis_6.Visible = false;
            }
            else if (espectaculo.CantidadAsientosDiscapacitados == 3)
            {
                btn_AsientoDis_1.Visible = true;
                btn_AsientoDis_2.Visible = true;
                btn_AsientoDis_3.Visible = true;
                btn_AsientoDis_4.Visible = false;
                btn_AsientoDis_5.Visible = false;
                btn_AsientoDis_6.Visible = false;
            }
            else if (espectaculo.CantidadAsientosDiscapacitados == 4)
            {
                btn_AsientoDis_1.Visible = true;
                btn_AsientoDis_2.Visible = true;
                btn_AsientoDis_3.Visible = true;
                btn_AsientoDis_4.Visible = true;
                btn_AsientoDis_5.Visible = false;
                btn_AsientoDis_6.Visible = false;
            }
            else if (espectaculo.CantidadAsientosDiscapacitados == 5)
            {
                btn_AsientoDis_1.Visible = true;
                btn_AsientoDis_2.Visible = true;
                btn_AsientoDis_3.Visible = true;
                btn_AsientoDis_4.Visible = true;
                btn_AsientoDis_5.Visible = true;
                btn_AsientoDis_6.Visible = false;
            }
            else
            {
                btn_AsientoDis_1.Visible = true;
                btn_AsientoDis_2.Visible = true;
                btn_AsientoDis_3.Visible = true;
                btn_AsientoDis_4.Visible = true;
                btn_AsientoDis_5.Visible = true;
                btn_AsientoDis_6.Visible = true;
            }


            //Cargo precios x tipo de asiento

            lbl_PrecioAsiAltos.Text = "₡ " + espectaculo.CostoAsientosAltos.ToString();
            lbl_PrecioAsiMedios.Text = "₡ " + espectaculo.CostoAsientosMedios.ToString();
            lbl_PrecioAsiBajos.Text = "₡ " + espectaculo.CostoAsientosBajos.ToString();
            lbl_PrecioAsiDisc.Text = "₡ " + espectaculo.CostoAsientosDiscapacitados.ToString();

            //Cargo asientos Medios
            if (espectaculo.CantidadAsientosMedios == 0)
            {
                btn_AsientoMedio_1.Visible = false;
                btn_AsientoMedio_2.Visible = false;
                btn_AsientoMedio_3.Visible = false;
                btn_AsientoMedio_4.Visible = false;
                btn_AsientoMedio_5.Visible = false;
                btn_AsientoMedio_6.Visible = false;
                btn_AsientoMedio_7.Visible = false;
                btn_AsientoMedio_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosMedios == 1)
            {
                btn_AsientoMedio_1.Visible = false;
                btn_AsientoMedio_2.Visible = true;
                btn_AsientoMedio_3.Visible = false;
                btn_AsientoMedio_4.Visible = false;
                btn_AsientoMedio_5.Visible = false;
                btn_AsientoMedio_6.Visible = false;
                btn_AsientoMedio_7.Visible = false;
                btn_AsientoMedio_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosMedios == 2)
            {
                btn_AsientoMedio_1.Visible = true;
                btn_AsientoMedio_2.Visible = false;
                btn_AsientoMedio_3.Visible = true;
                btn_AsientoMedio_4.Visible = false;
                btn_AsientoMedio_5.Visible = false;
                btn_AsientoMedio_6.Visible = false;
                btn_AsientoMedio_7.Visible = false;
                btn_AsientoMedio_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosMedios == 3)
            {
                btn_AsientoMedio_1.Visible = true;
                btn_AsientoMedio_2.Visible = true;
                btn_AsientoMedio_3.Visible = true;
                btn_AsientoMedio_4.Visible = false;
                btn_AsientoMedio_5.Visible = false;
                btn_AsientoMedio_6.Visible = false;
                btn_AsientoMedio_7.Visible = false;
                btn_AsientoMedio_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosMedios == 4)
            {
                btn_AsientoMedio_1.Visible = true;
                btn_AsientoMedio_2.Visible = false;
                btn_AsientoMedio_3.Visible = true;
                btn_AsientoMedio_4.Visible = true;
                btn_AsientoMedio_5.Visible = false;
                btn_AsientoMedio_6.Visible = true;
                btn_AsientoMedio_7.Visible = false;
                btn_AsientoMedio_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosMedios == 5)
            {
                btn_AsientoMedio_1.Visible = true;
                btn_AsientoMedio_2.Visible = false;
                btn_AsientoMedio_3.Visible = true;
                btn_AsientoMedio_4.Visible = true;
                btn_AsientoMedio_5.Visible = false;
                btn_AsientoMedio_6.Visible = true;
                btn_AsientoMedio_7.Visible = false;
                btn_AsientoMedio_8.Visible = true;
            }
            else if (espectaculo.CantidadAsientosMedios == 6)
            {
                btn_AsientoMedio_1.Visible = true;
                btn_AsientoMedio_2.Visible = true;
                btn_AsientoMedio_3.Visible = true;
                btn_AsientoMedio_4.Visible = false;
                btn_AsientoMedio_5.Visible = true;
                btn_AsientoMedio_6.Visible = true;
                btn_AsientoMedio_7.Visible = true;
                btn_AsientoMedio_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosMedios == 7)
            {
                btn_AsientoMedio_1.Visible = true;
                btn_AsientoMedio_2.Visible = true;
                btn_AsientoMedio_3.Visible = true;
                btn_AsientoMedio_4.Visible = true;
                btn_AsientoMedio_5.Visible = true;
                btn_AsientoMedio_6.Visible = true;
                btn_AsientoMedio_7.Visible = true;
                btn_AsientoMedio_8.Visible = false;
            }
            else
            {
                btn_AsientoMedio_1.Visible = true;
                btn_AsientoMedio_2.Visible = true;
                btn_AsientoMedio_3.Visible = true;
                btn_AsientoMedio_4.Visible = true;
                btn_AsientoMedio_5.Visible = true;
                btn_AsientoMedio_6.Visible = true;
                btn_AsientoMedio_7.Visible = true;
                btn_AsientoMedio_8.Visible = true;
            }

            //Cargo asientos Bajos
            if (espectaculo.CantidadAsientosBajos == 0)
            {
                btn_AsientoBajo_1.Visible = false;
                btn_AsientoBajo_2.Visible = false;
                btn_AsientoBajo_3.Visible = false;
                btn_AsientoBajo_4.Visible = false;
                btn_AsientoBajo_5.Visible = false;
                btn_AsientoBajo_6.Visible = false;
                btn_AsientoBajo_7.Visible = false;
                btn_AsientoBajo_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosBajos == 1)
            {
                btn_AsientoBajo_1.Visible = false;
                btn_AsientoBajo_2.Visible = true;
                btn_AsientoBajo_3.Visible = false;
                btn_AsientoBajo_4.Visible = false;
                btn_AsientoBajo_5.Visible = false;
                btn_AsientoBajo_6.Visible = false;
                btn_AsientoBajo_7.Visible = false;
                btn_AsientoBajo_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosBajos == 2)
            {
                btn_AsientoBajo_1.Visible = true;
                btn_AsientoBajo_2.Visible = false;
                btn_AsientoBajo_3.Visible = true;
                btn_AsientoBajo_4.Visible = false;
                btn_AsientoBajo_5.Visible = false;
                btn_AsientoBajo_6.Visible = false;
                btn_AsientoBajo_7.Visible = false;
                btn_AsientoBajo_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosBajos == 3)
            {
                btn_AsientoBajo_1.Visible = true;
                btn_AsientoBajo_2.Visible = true;
                btn_AsientoBajo_3.Visible = true;
                btn_AsientoBajo_4.Visible = false;
                btn_AsientoBajo_5.Visible = false;
                btn_AsientoBajo_6.Visible = false;
                btn_AsientoBajo_7.Visible = false;
                btn_AsientoBajo_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosBajos == 4)
            {
                btn_AsientoBajo_1.Visible = true;
                btn_AsientoBajo_2.Visible = false;
                btn_AsientoBajo_3.Visible = true;
                btn_AsientoBajo_4.Visible = true;
                btn_AsientoBajo_5.Visible = false;
                btn_AsientoBajo_6.Visible = true;
                btn_AsientoBajo_7.Visible = false;
                btn_AsientoBajo_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosBajos == 5)
            {
                btn_AsientoBajo_1.Visible = true;
                btn_AsientoBajo_2.Visible = false;
                btn_AsientoBajo_3.Visible = true;
                btn_AsientoBajo_4.Visible = true;
                btn_AsientoBajo_5.Visible = false;
                btn_AsientoBajo_6.Visible = true;
                btn_AsientoBajo_7.Visible = false;
                btn_AsientoBajo_8.Visible = true;
            }
            else if (espectaculo.CantidadAsientosBajos == 6)
            {
                btn_AsientoBajo_1.Visible = true;
                btn_AsientoBajo_2.Visible = true;
                btn_AsientoBajo_3.Visible = true;
                btn_AsientoBajo_4.Visible = false;
                btn_AsientoBajo_5.Visible = true;
                btn_AsientoBajo_6.Visible = true;
                btn_AsientoBajo_7.Visible = true;
                btn_AsientoBajo_8.Visible = false;
            }
            else if (espectaculo.CantidadAsientosBajos == 7)
            {
                btn_AsientoBajo_1.Visible = true;
                btn_AsientoBajo_2.Visible = true;
                btn_AsientoBajo_3.Visible = true;
                btn_AsientoBajo_4.Visible = true;
                btn_AsientoBajo_5.Visible = true;
                btn_AsientoBajo_6.Visible = true;
                btn_AsientoBajo_7.Visible = true;
                btn_AsientoBajo_8.Visible = false;
            }
            else
            {
                btn_AsientoBajo_1.Visible = true;
                btn_AsientoBajo_2.Visible = true;
                btn_AsientoBajo_3.Visible = true;
                btn_AsientoBajo_4.Visible = true;
                btn_AsientoBajo_5.Visible = true;
                btn_AsientoBajo_6.Visible = true;
                btn_AsientoBajo_7.Visible = true;
                btn_AsientoBajo_8.Visible = true;
            }

            CargarAsientosComprados();
        }

        private void btn_AsientoDis_1_Click(object sender, EventArgs e)
        {
            if (btn_AsientoDis_1.BackColor == Color.Blue)
            {
                btn_AsientoDis_1.BackColor = Color.Green;
                cantDisc++;
                pago();

                String tipoAsiento = "Discapacitado";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoDis_1.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoDis_1.BackColor = Color.Blue;
                cantDisc--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoDis_2_Click(object sender, EventArgs e)
        {
            if (btn_AsientoDis_1.BackColor == Color.Blue)
            {
                btn_AsientoDis_1.BackColor = Color.Green;
                cantDisc++;
                pago();

                String tipoAsiento = "Discapacitado";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoDis_2.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoDis_1.BackColor = Color.Blue;
                cantDisc--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoDis_3_Click(object sender, EventArgs e)
        {
            if (btn_AsientoDis_3.BackColor == Color.Blue)
            {
                btn_AsientoDis_3.BackColor = Color.Green;
                cantDisc++;
                pago();

                String tipoAsiento = "Discapacitado";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoDis_3.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoDis_3.BackColor = Color.Blue;
                cantDisc--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoDis_4_Click(object sender, EventArgs e)
        {
            if (btn_AsientoDis_4.BackColor == Color.Blue)
            {
                btn_AsientoDis_4.BackColor = Color.Green;
                cantDisc++;
                pago();


                String tipoAsiento = "Discapacitado";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoDis_4.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoDis_4.BackColor = Color.Blue;
                cantDisc--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoDis_5_Click(object sender, EventArgs e)
        {
            if (btn_AsientoDis_5.BackColor == Color.Blue)
            {
                btn_AsientoDis_5.BackColor = Color.Green;
                cantDisc++;
                pago();

                String tipoAsiento = "Discapacitado";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoDis_5.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoDis_5.BackColor = Color.Blue;
                cantDisc--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoDis_6_Click(object sender, EventArgs e)
        {
            if (btn_AsientoDis_6.BackColor == Color.Blue)
            {
                btn_AsientoDis_6.BackColor = Color.Green;
                cantDisc++;
                pago();

                String tipoAsiento = "Discapacitado";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoDis_6.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoDis_6.BackColor = Color.Blue;
                cantDisc--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoAlto_1_Click(object sender, EventArgs e)
        {
            if (btn_AsientoAlto_1.BackColor == Color.Gray)
            {
                btn_AsientoAlto_1.BackColor = Color.Green;
                cantAltos++;
                pago();

                String tipoAsiento = "Asiento Alto";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoAlto_1.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoAlto_1.BackColor = Color.Gray;
                cantAltos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoAlto_2_Click(object sender, EventArgs e)
        {
            if (btn_AsientoAlto_2.BackColor == Color.Gray)
            {
                btn_AsientoAlto_2.BackColor = Color.Green;
                cantAltos++;
                pago();

                String tipoAsiento = "Asiento Alto";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoAlto_2.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoAlto_2.BackColor = Color.Gray;
                cantAltos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoAlto_3_Click(object sender, EventArgs e)
        {
            if (btn_AsientoAlto_3.BackColor == Color.Gray)
            {
                btn_AsientoAlto_3.BackColor = Color.Green;
                cantAltos++;
                pago();

                String tipoAsiento = "Asiento Alto";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoAlto_3.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoAlto_3.BackColor = Color.Gray;
                cantAltos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoAlto_4_Click(object sender, EventArgs e)
        {
            if (btn_AsientoAlto_4.BackColor == Color.Gray)
            {
                btn_AsientoAlto_4.BackColor = Color.Green;
                cantAltos++;
                pago();

                String tipoAsiento = "Asiento Alto";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoAlto_4.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoAlto_4.BackColor = Color.Gray;
                cantAltos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoAlto_5_Click(object sender, EventArgs e)
        {
            if (btn_AsientoAlto_5.BackColor == Color.Gray)
            {
                btn_AsientoAlto_5.BackColor = Color.Green;
                cantAltos++;
                pago();

                String tipoAsiento = "Asiento Alto";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoAlto_5.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoAlto_5.BackColor = Color.Gray;
                cantAltos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoAlto_6_Click(object sender, EventArgs e)
        {
            if (btn_AsientoAlto_6.BackColor == Color.Gray)
            {
                btn_AsientoAlto_6.BackColor = Color.Green;
                cantAltos++;
                pago();

                String tipoAsiento = "Asiento Alto";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoAlto_6.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoAlto_6.BackColor = Color.Gray;
                cantAltos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoAlto_7_Click(object sender, EventArgs e)
        {
            if (btn_AsientoAlto_7.BackColor == Color.Gray)
            {
                btn_AsientoAlto_7.BackColor = Color.Green;
                cantAltos++;
                pago();

                String tipoAsiento = "Asiento Alto";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoAlto_7.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoAlto_7.BackColor = Color.Gray;
                cantAltos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoAlto_8_Click(object sender, EventArgs e)
        {
            if (btn_AsientoAlto_8.BackColor == Color.Gray)
            {
                btn_AsientoAlto_8.BackColor = Color.Green;
                cantAltos++;
                pago();

                String tipoAsiento = "Asiento Alto";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoAlto_8.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoAlto_8.BackColor = Color.Gray;
                cantAltos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoMedio_1_Click(object sender, EventArgs e)
        {
            if (btn_AsientoMedio_1.BackColor == Color.Gray)
            {
                btn_AsientoMedio_1.BackColor = Color.Green;
                cantMedios++;
                pago();

                String tipoAsiento = "Asiento Medio";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoMedio_1.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoMedio_1.BackColor = Color.Gray;
                cantMedios--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoMedio_2_Click(object sender, EventArgs e)
        {
            if (btn_AsientoMedio_2.BackColor == Color.Gray)
            {
                btn_AsientoMedio_2.BackColor = Color.Green;
                cantMedios++;
                pago();

                String tipoAsiento = "Asiento Medio";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoMedio_2.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoMedio_2.BackColor = Color.Gray;
                cantMedios--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoMedio_3_Click(object sender, EventArgs e)
        {
            if (btn_AsientoMedio_3.BackColor == Color.Gray)
            {
                btn_AsientoMedio_3.BackColor = Color.Green;
                cantMedios++;
                pago();

                String tipoAsiento = "Asiento Medio";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoMedio_3.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoMedio_3.BackColor = Color.Gray;
                cantMedios--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoMedio_4_Click(object sender, EventArgs e)
        {
            if (btn_AsientoMedio_4.BackColor == Color.Gray)
            {
                btn_AsientoMedio_4.BackColor = Color.Green;
                cantMedios++;
                pago();

                String tipoAsiento = "Asiento Medio";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoMedio_4.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoMedio_4.BackColor = Color.Gray;
                cantMedios--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoMedio_5_Click(object sender, EventArgs e)
        {
            if (btn_AsientoMedio_5.BackColor == Color.Gray)
            {
                btn_AsientoMedio_5.BackColor = Color.Green;
                cantMedios++;
                pago();

                String tipoAsiento = "Asiento Medio";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoMedio_5.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoMedio_5.BackColor = Color.Gray;
                cantMedios--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoMedio_6_Click(object sender, EventArgs e)
        {
            if (btn_AsientoMedio_6.BackColor == Color.Gray)
            {
                btn_AsientoMedio_6.BackColor = Color.Green;
                cantMedios++;
                pago();

                String tipoAsiento = "Asiento Medio";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoMedio_6.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoMedio_6.BackColor = Color.Gray;
                cantMedios--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoMedio_7_Click(object sender, EventArgs e)
        {
            if (btn_AsientoMedio_7.BackColor == Color.Gray)
            {
                btn_AsientoMedio_7.BackColor = Color.Green;
                cantMedios++;
                pago();

                String tipoAsiento = "Asiento Medio";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoMedio_7.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoMedio_7.BackColor = Color.Gray;
                cantMedios--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoMedio_8_Click(object sender, EventArgs e)
        {
            if (btn_AsientoMedio_8.BackColor == Color.Gray)
            {
                btn_AsientoMedio_8.BackColor = Color.Green;
                cantMedios++;
                pago();

                String tipoAsiento = "Asiento Medio";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoMedio_8.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoMedio_8.BackColor = Color.Gray;
                cantMedios--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoBajo_1_Click(object sender, EventArgs e)
        {
            if (btn_AsientoBajo_1.BackColor == Color.Gray)
            {
                btn_AsientoBajo_1.BackColor = Color.Green;
                cantBajos++;
                pago();

                String tipoAsiento = "Asiento Bajo";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoBajo_1.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoBajo_1.BackColor = Color.Gray;
                cantBajos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoBajo_2_Click(object sender, EventArgs e)
        {
            if (btn_AsientoBajo_2.BackColor == Color.Gray)
            {
                btn_AsientoBajo_2.BackColor = Color.Green;
                cantBajos++;
                pago();

                String tipoAsiento = "Asiento Bajo";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoBajo_2.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoBajo_2.BackColor = Color.Gray;
                cantBajos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoBajo_3_Click(object sender, EventArgs e)
        {
            if (btn_AsientoBajo_3.BackColor == Color.Gray)
            {
                btn_AsientoBajo_3.BackColor = Color.Green;
                cantBajos++;
                pago();

                String tipoAsiento = "Asiento Bajo";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoBajo_3.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoBajo_3.BackColor = Color.Gray;
                cantBajos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoBajo_4_Click(object sender, EventArgs e)
        {
            if (btn_AsientoBajo_4.BackColor == Color.Gray)
            {
                btn_AsientoBajo_4.BackColor = Color.Green;
                cantBajos++;
                pago();

                String tipoAsiento = "Asiento Bajo";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoBajo_4.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoBajo_4.BackColor = Color.Gray;
                cantBajos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoBajo_5_Click(object sender, EventArgs e)
        {
            if (btn_AsientoBajo_5.BackColor == Color.Gray)
            {
                btn_AsientoBajo_5.BackColor = Color.Green;
                cantBajos++;
                pago();

                String tipoAsiento = "Asiento Bajo";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoBajo_5.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoBajo_5.BackColor = Color.Gray;
                cantBajos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoBajo_6_Click(object sender, EventArgs e)
        {
            if (btn_AsientoBajo_6.BackColor == Color.Gray)
            {
                btn_AsientoBajo_6.BackColor = Color.Green;
                cantBajos++;
                pago();

                String tipoAsiento = "Asiento Bajo";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoBajo_6.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoBajo_6.BackColor = Color.Gray;
                cantBajos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoBajo_7_Click(object sender, EventArgs e)
        {
            if (btn_AsientoBajo_7.BackColor == Color.Gray)
            {
                btn_AsientoBajo_7.BackColor = Color.Green;
                cantBajos++;
                pago();

                String tipoAsiento = "Asiento Bajo";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoBajo_7.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoBajo_7.BackColor = Color.Gray;
                cantBajos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        private void btn_AsientoBajo_8_Click(object sender, EventArgs e)
        {
            if (btn_AsientoBajo_8.BackColor == Color.Gray)
            {
                btn_AsientoBajo_8.BackColor = Color.Green;
                cantBajos++;
                pago();

                String tipoAsiento = "Asiento Bajo";
                asiento = new Asientos(0, espectaculo.IdConcierto, tipoAsiento, int.Parse(btn_AsientoBajo_8.Text.ToString()));
                listaAsientosComprados.Add(asiento);
            }
            else
            {
                btn_AsientoBajo_8.BackColor = Color.Gray;
                cantBajos--;
                pago();

                listaAsientosComprados.Remove(asiento);
            }
        }

        public void CargarAsientosComprados()
        {
            Espectaculos espectaculo = op.BuscarEspectaculoGrupo(lb_ListaCategoria.SelectedItem.ToString());//Busco espectaculo por nombre

            var ListaAsientos = op.BuscarAsientos(espectaculo.IdConcierto);//Asigno a lista la los asientos comprados x concierto

            foreach (Asientos asientos in ListaAsientos)//Recorro lista, valido tipo de asiento, valido numero asiento y deshabilito x boto y le cambio el color
            {
                if (asientos.TipoAsiento == "Asiento Alto")
                {
                    if (asientos.NumeroAsiento == 1)
                    {
                        btn_AsientoAlto_1.Enabled = false;
                        btn_AsientoAlto_1.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 2)
                    {
                        btn_AsientoAlto_2.Enabled = false;
                        btn_AsientoAlto_2.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 3)
                    {
                        btn_AsientoAlto_3.Enabled = false;
                        btn_AsientoAlto_3.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 4)
                    {
                        btn_AsientoAlto_4.Enabled = false;
                        btn_AsientoAlto_4.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 5)
                    {
                        btn_AsientoAlto_5.Enabled = false;
                        btn_AsientoAlto_5.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 6)
                    {
                        btn_AsientoAlto_6.Enabled = false;
                        btn_AsientoAlto_6.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 7)
                    {
                        btn_AsientoAlto_7.Enabled = false;
                        btn_AsientoAlto_7.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 8)
                    {
                        btn_AsientoAlto_8.Enabled = false;
                        btn_AsientoAlto_8.BackColor = Color.Red;
                    }
                }

                if(asientos.TipoAsiento == "Asiento Medio")
                {
                    if (asientos.NumeroAsiento == 1)
                    {
                        btn_AsientoMedio_1.Enabled = false;
                        btn_AsientoMedio_1.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 2)
                    {
                        btn_AsientoMedio_2.Enabled = false;
                        btn_AsientoMedio_2.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 3)
                    {
                        btn_AsientoMedio_3.Enabled = false;
                        btn_AsientoMedio_3.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 4)
                    {
                        btn_AsientoMedio_4.Enabled = false;
                        btn_AsientoMedio_4.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 5)
                    {
                        btn_AsientoMedio_5.Enabled = false;
                        btn_AsientoMedio_5.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 6)
                    {
                        btn_AsientoMedio_6.Enabled = false;
                        btn_AsientoMedio_6.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 7)
                    {
                        btn_AsientoMedio_7.Enabled = false;
                        btn_AsientoMedio_7.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 8)
                    {
                        btn_AsientoMedio_8.Enabled = false;
                        btn_AsientoMedio_8.BackColor = Color.Red;
                    }
                }

                if (asientos.TipoAsiento == "Asiento Bajo")
                {
                    if (asientos.NumeroAsiento == 1)
                    {
                        btn_AsientoBajo_1.Enabled = false;
                        btn_AsientoBajo_1.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 2)
                    {
                        btn_AsientoBajo_2.Enabled = false;
                        btn_AsientoBajo_2.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 3)
                    {
                        btn_AsientoBajo_3.Enabled = false;
                        btn_AsientoBajo_3.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 4)
                    {
                        btn_AsientoBajo_4.Enabled = false;
                        btn_AsientoBajo_4.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 5)
                    {
                        btn_AsientoBajo_5.Enabled = false;
                        btn_AsientoBajo_5.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 6)
                    {
                        btn_AsientoBajo_6.Enabled = false;
                        btn_AsientoBajo_6.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 7)
                    {
                        btn_AsientoBajo_7.Enabled = false;
                        btn_AsientoBajo_7.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 8)
                    {
                        btn_AsientoBajo_8.Enabled = false;
                        btn_AsientoBajo_8.BackColor = Color.Red;
                    }
                }

                if (asientos.TipoAsiento == "Discapacitado")
                {
                    if (asientos.NumeroAsiento == 1)
                    {
                        btn_AsientoDis_1.Enabled = false;
                        btn_AsientoDis_1.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 2)
                    {
                        btn_AsientoDis_2.Enabled = false;
                        btn_AsientoDis_2.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 3)
                    {
                        btn_AsientoDis_3.Enabled = false;
                        btn_AsientoDis_3.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 4)
                    {
                        btn_AsientoDis_4.Enabled = false;
                        btn_AsientoDis_4.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 5)
                    {
                        btn_AsientoDis_5.Enabled = false;
                        btn_AsientoDis_5.BackColor = Color.Red;
                    }
                    if (asientos.NumeroAsiento == 6)
                    {
                        btn_AsientoDis_6.Enabled = false;
                        btn_AsientoDis_6.BackColor = Color.Red;
                    }
                }
            }
        }

        public void ocultarAsientos()
        {
            //lbl_Altos.Text ="Asientos Altos";

            btn_AsientoDis_1.Visible = false;
            btn_AsientoDis_2.Visible = false;
            btn_AsientoDis_3.Visible = false;
            btn_AsientoDis_4.Visible = false;
            btn_AsientoDis_5.Visible = false;
            btn_AsientoDis_6.Visible = false;

            btn_AsientoAlto_1.Visible = false;
            btn_AsientoAlto_2.Visible = false;
            btn_AsientoAlto_3.Visible = false;
            btn_AsientoAlto_4.Visible = false;
            btn_AsientoAlto_5.Visible = false;
            btn_AsientoAlto_6.Visible = false;
            btn_AsientoAlto_7.Visible = false;
            btn_AsientoAlto_8.Visible = false;

            btn_AsientoMedio_1.Visible = false;
            btn_AsientoMedio_2.Visible = false;
            btn_AsientoMedio_3.Visible = false;
            btn_AsientoMedio_4.Visible = false;
            btn_AsientoMedio_5.Visible = false;
            btn_AsientoMedio_6.Visible = false;
            btn_AsientoMedio_7.Visible = false;
            btn_AsientoMedio_8.Visible = false;

            btn_AsientoBajo_1.Visible = false;
            btn_AsientoBajo_2.Visible = false;
            btn_AsientoBajo_3.Visible = false;
            btn_AsientoBajo_4.Visible = false;
            btn_AsientoBajo_5.Visible = false;
            btn_AsientoBajo_6.Visible = false;
            btn_AsientoBajo_7.Visible = false;
            btn_AsientoBajo_8.Visible = false;
        }
    }
}
