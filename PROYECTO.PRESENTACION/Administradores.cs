using Microsoft.VisualBasic;
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
using System.Drawing.Printing;

namespace PROYECTO.PRESENTACION
{
    public partial class Administradores : Form
    {
        Operaciones op = new Operaciones();

        int contAsientosBajos = 0;
        int contAsientosMedios = 0;
        int contAsientosAltos = 0;
        int contAsientosDisc = 0;

        public Administradores()
        {
            InitializeComponent();
            MostrarPersonas();//Cargo datagrid personas
            MostrarEspectaculos();//Cargo datagrid espectaculos
            MostrarAuditoria();//Cargo datagrid auditoria
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text.Equals("") || txt_Apellido.Text.Equals("") || txt_Cedula.Text.Equals("") || txt_Email.Text.Equals("") || txt_Password.Text.Equals(""))//Valido que no se dejara ningun espacio en blanco
            {
                MessageBox.Show("No puede dejar espacios en blanco", "Agregar Persona", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
            }
            else
            {
                op.InsertarPersona(new Persona(op.idPersonas, txt_Nombre.Text, txt_Apellido.Text, txt_Cedula.Text, txt_Email.Text, cb_TipoUsuario.SelectedItem.ToString(), txt_Password.Text));//Llamo metodo insertar y le envio una persona

                MessageBox.Show("Persona Agregada Correctamente", "Agregar Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestro mensaje

                txt_Nombre.Text = "";
                txt_Apellido.Text = "";
                txt_Cedula.Text = "";
                txt_Email.Text = "";
                txt_Password.Text = "";
            }

            MostrarPersonas();//Actualizo datagrid personas
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(op.EliminarPersona(new Persona(int.Parse(dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[0].Value.ToString()), dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[1].Value.ToString(), dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[2].Value.ToString(),
                dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[3].Value.ToString(), dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[4].Value.ToString(), dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[5].Value.ToString(), dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[6].Value.ToString())), "Eliminar Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);//Llamo metodo eliminar, le envio una persona y muestro mensaje

            MostrarPersonas();//Actualizo datagrid personas
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(op.ModificarPersona(new Persona(int.Parse(dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[0].Value.ToString()), txt_Nombre.Text, txt_Apellido.Text, txt_Cedula.Text, txt_Email.Text, cb_TipoUsuario.SelectedItem.ToString(), txt_Password.Text)), "Modificar Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);//Llamo metodo modificar, le envio una persona y muestro mensaje

            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Cedula.Text = "";
            txt_Email.Text = "";
            txt_Password.Text = "";

            MostrarPersonas();//Actualizo datagrid personas
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string opcion = Interaction.InputBox("Desea buscar por ID o por Nombre", "Buscar Persona");

            if (opcion == "ID")
            {
                int id = int.Parse(Interaction.InputBox("Ingrese un ID para Buscar", "Buscar Persona"));

                if (op.BuscarPersona(id) == null)
                {
                    MessageBox.Show("ID ingresado no existe", "Buscar Persona", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Load(op.BuscarPersona(id));
                    dg_Personas.AutoGenerateColumns = true;
                    dg_Personas.DataSource = dt;
                }
            }
            else if (opcion == "Nombre")
            {
                string nombre = Interaction.InputBox("Ingrese un Nombre para Buscar", "Buscar Persona");

                if (op.BuscarPersona(nombre) == null)
                {
                    MessageBox.Show("Nombre ingresado no existe", "Buscar Persona", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Load(op.BuscarPersona(nombre));
                    dg_Personas.AutoGenerateColumns = true;
                    dg_Personas.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar alguna de las opciones anteriores", "Buscar Persona", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
            }

        }

        private void dg_Personas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Metodo que carga datos del datagrid a los textbox al hacer click
            txt_Nombre.Text = dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[1].Value.ToString();
            txt_Apellido.Text = dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[2].Value.ToString();
            txt_Cedula.Text = dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[3].Value.ToString();
            txt_Email.Text = dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[4].Value.ToString();
            txt_Password.Text = dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[6].Value.ToString();
            cb_TipoUsuario.SelectedItem = dg_Personas.Rows[dg_Personas.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void dg_Espectaculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Metodo que carga datos del datagrid a los textbox al hacer click
            txt_NombreGrupo.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[1].Value.ToString();
            txt_Descripcion.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[2].Value.ToString();
            txt_CantAsientosBajos.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[3].Value.ToString();
            txt_CostAsientosBajos.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[4].Value.ToString();
            txt_CantAsientosMedios.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[5].Value.ToString();
            txt_CostAsientosMedios.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[6].Value.ToString();
            txt_CantAsientosAltos.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[7].Value.ToString();
            txt_CostAsientosAltos.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[8].Value.ToString();
            txt_CantAsientosDiscapacitados.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[9].Value.ToString();
            txt_CostAsientosDiscapacitados.Text = dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[10].Value.ToString();
        }

        public void MostrarPersonas()
        {
            //Metodo que me carga el datagrid con los datos de la DB
            DataTable dt = new DataTable();
            dt.Load(op.CargarPersonas());
            dg_Personas.AutoGenerateColumns = true;
            dg_Personas.DataSource = dt;
            dg_Personas.Refresh();
        }

        public void MostrarEspectaculos()
        {
            //Metodo que me carga el datagrid con los datos de la DB
            DataTable dt = new DataTable();
            dt.Load(op.CargarEspectaculos());
            dg_Espectaculos.AutoGenerateColumns = true;
            dg_Espectaculos.DataSource = dt;
            dg_Espectaculos.Refresh();
        }

        public void MostrarAuditoria()
        {
            //Metodo que me carga el datagrid con los datos de la DB
            DataTable dt = new DataTable();
            dt.Load(op.CargarAuditoriaAdmin());
            dg_Auditoria.AutoGenerateColumns = true;
            dg_Auditoria.DataSource = dt;
            dg_Auditoria.Refresh();
        }

        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            MostrarPersonas();//Actualizo datagrid personas
        }

        private void btn_MostrarEspectaculos_Click(object sender, EventArgs e)
        {
            MostrarEspectaculos();//Actualizo datagrid espectaculos
        }

        private void btn_InsertarEspectaculos_Click(object sender, EventArgs e)
        {
            op.InsertarEspectaculo(new Espectaculos(op.idEspectáculos, txt_NombreGrupo.Text, txt_Descripcion.Text, int.Parse(txt_CantAsientosBajos.Text), int.Parse(txt_CostAsientosBajos.Text), int.Parse(txt_CantAsientosMedios.Text), int.Parse(txt_CostAsientosMedios.Text),
               int.Parse(txt_CantAsientosAltos.Text), int.Parse(txt_CostAsientosAltos.Text), int.Parse(txt_CantAsientosDiscapacitados.Text), int.Parse(txt_CostAsientosDiscapacitados.Text)));//Llamo metodo insertar y le envio un espectaculo

            txt_NombreGrupo.Text = "";
            txt_Descripcion.Text = "";
            txt_CantAsientosBajos.Text = "";
            txt_CostAsientosBajos.Text = "";
            txt_CantAsientosMedios.Text = "";
            txt_CostAsientosMedios.Text = "";
            txt_CantAsientosAltos.Text = "";
            txt_CostAsientosAltos.Text = "";
            txt_CantAsientosDiscapacitados.Text = "";
            txt_CostAsientosDiscapacitados.Text = "";

            MessageBox.Show("Espectaculo Agregado Correctamente", "Agregar Espectaculo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MostrarEspectaculos();//Actualizo datagrid espectaculos
        }

        private void btn_EliminarEspectaculos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(op.EliminarEspectaculo(new Espectaculos(int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[0].Value.ToString()), dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[1].Value.ToString(), dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[2].Value.ToString(),
                     int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[3].Value.ToString()), int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[4].Value.ToString()), int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[5].Value.ToString()), int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[6].Value.ToString()),
                     int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[7].Value.ToString()), int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[8].Value.ToString()), int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[9].Value.ToString()), int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[10].Value.ToString()))),
                     "Eliminar Espectaculo", MessageBoxButtons.OK, MessageBoxIcon.Information);//Llamo metodo eliminar, le envio un espectaculo y muestro mensaje

            MostrarEspectaculos();//Actualizo datagrid espectaculos
        }

        private void btn_ModificarEspectaculos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(op.ModificarEspectaculo(new Espectaculos(int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[0].Value.ToString()), txt_NombreGrupo.Text, txt_Descripcion.Text, int.Parse(txt_CantAsientosBajos.Text), int.Parse(txt_CostAsientosBajos.Text), int.Parse(txt_CantAsientosMedios.Text), int.Parse(txt_CostAsientosMedios.Text),
               int.Parse(txt_CantAsientosAltos.Text), int.Parse(txt_CostAsientosAltos.Text), int.Parse(txt_CantAsientosDiscapacitados.Text), int.Parse(txt_CostAsientosDiscapacitados.Text))), "Modificar Espectaculo", MessageBoxButtons.OK, MessageBoxIcon.Information);//Llamo metodo modificar, le envio un espectaculo y muestro mensaje

            txt_NombreGrupo.Text = "";
            txt_Descripcion.Text = "";
            txt_CantAsientosBajos.Text = "";
            txt_CostAsientosBajos.Text = "";
            txt_CantAsientosMedios.Text = "";
            txt_CostAsientosMedios.Text = "";
            txt_CantAsientosAltos.Text = "";
            txt_CostAsientosAltos.Text = "";
            txt_CantAsientosDiscapacitados.Text = "";
            txt_CostAsientosDiscapacitados.Text = "";

            MostrarEspectaculos();//Actualizo datagrid espectaculos
        }

        private void btn_BuscarEspectaculos_Click(object sender, EventArgs e)
        {
            string opcion = Interaction.InputBox("Desea buscar por ID o por Grupo", "Buscar Espectaculo");

            if (opcion == "ID")
            {
                int id = int.Parse(Interaction.InputBox("Ingrese un ID para Buscar", "Buscar Espectaculo"));

                //op.BuscarEspectaculo(id);
                if (op.BuscarEspectaculo(id) == null)
                {
                    MessageBox.Show("ID ingresado no existe", "Buscar Espectaculo", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Load(op.BuscarPersona(id));
                    dg_Espectaculos.AutoGenerateColumns = true;
                    dg_Espectaculos.DataSource = dt;
                }
            }
            else if (opcion == "Nombre")
            {
                string nombre = Interaction.InputBox("Ingrese un Grupo para Buscar", "Buscar Espectaculo");

                if (op.BuscarEspectaculo(nombre) == null)
                {
                    MessageBox.Show("Nombre ingresado no existe", "Buscar Espectaculo", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Load(op.BuscarEspectaculo(nombre));
                    dg_Espectaculos.AutoGenerateColumns = true;
                    dg_Espectaculos.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar alguna de las opciones anteriores", "Buscar Espectaculo", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
            }
        }

        private void btn_CantAsientosBajos_Click(object sender, EventArgs e)
        {
            if (txt_CantAsientosBajos.Text.Equals(""))//Valido que textbox esta vacio
            {
                if (contAsientosBajos < 8)//Valido que contador no pase el maximo de asientos
                {
                    contAsientosBajos++;//Aumento contador
                    txt_CantAsientosBajos.Text = contAsientosBajos.ToString();
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el maximo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
            }
            else
            {
                contAsientosBajos = int.Parse(txt_CantAsientosBajos.Text);//Si no esta vacio le asigno a contador el valor de los asientos del objeto

                if (contAsientosBajos < 8)//Valido que contador no pase el maximo de asientos
                {
                    contAsientosBajos++;//Aumento contador
                    txt_CantAsientosBajos.Text = contAsientosBajos.ToString();
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el maximo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
            }
        }

        private void btn_CantAsientosMedios_Click(object sender, EventArgs e)
        {
            if (txt_CantAsientosMedios.Text.Equals(""))//Valido que textbox esta vacio
            {
                if (contAsientosMedios < 8)//Valido que contador no pase el maximo de asientos
                {
                    contAsientosMedios++;//Aumento contador
                    txt_CantAsientosMedios.Text = contAsientosMedios.ToString();
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el maximo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
            }
            else
            {
                contAsientosMedios = int.Parse(txt_CantAsientosMedios.Text);//Si no esta vacio le asigno a contador el valor de los asientos del objeto

                if (contAsientosMedios < 8)//Valido que contador no pase el maximo de asientos
                {
                    contAsientosMedios++;//Aumento contador
                    txt_CantAsientosMedios.Text = contAsientosMedios.ToString();
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el maximo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
            }
        }

        private void btn_CantAsientosAltos_Click(object sender, EventArgs e)
        {
            if (txt_CantAsientosAltos.Text.Equals(""))//Valido que textbox esta vacio
            {
                if (contAsientosAltos < 8)//Valido que contador no pase el maximo de asientos
                {
                    contAsientosAltos++;//Aumento contador
                    txt_CantAsientosAltos.Text = contAsientosAltos.ToString();
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el maximo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
            }
            else
            {
                contAsientosAltos = int.Parse(txt_CantAsientosAltos.Text);//Si no esta vacio le asigno a contador el valor de los asientos del objeto

                if (contAsientosAltos < 8)//Valido que contador no pase el maximo de asientos
                {
                    contAsientosAltos++;//Aumento contador
                    txt_CantAsientosAltos.Text = contAsientosAltos.ToString();
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el maximo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
            }
        }

        private void btn_CantAsientosDisc_Click(object sender, EventArgs e)
        {
            if (txt_CantAsientosDiscapacitados.Text.Equals(""))//Valido que textbox esta vacio
            {
                if (contAsientosDisc < 6)//Valido que contador no pase el maximo de asientos
                {
                    contAsientosDisc++;//Aumento contador
                    txt_CantAsientosDiscapacitados.Text = contAsientosDisc.ToString();
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el maximo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
            }
            else
            {
                contAsientosDisc = int.Parse(txt_CantAsientosDiscapacitados.Text);//Si no esta vacio le asigno a contador el valor de los asientos del objeto

                if (contAsientosDisc < 8)//Valido que contador no pase el maximo de asientos
                {
                    contAsientosDisc++;//Aumento contador
                    txt_CantAsientosDiscapacitados.Text = contAsientosDisc.ToString();
                }
                else
                {
                    MessageBox.Show("Ha alcanzado el maximo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
                }
            }
        }

        //private void btn_RestoAsientosBajos_Click(object sender, EventArgs e)
        //{
        //    if (txt_CantAsientosBajos.Text.Equals(""))//Valido que textbox esta vacio
        //    {
        //        if (contAsientosBajos > 0)//Valido que contador no sea menor que 0
        //        {
        //            contAsientosBajos--;//Decremento contador
        //            txt_CantAsientosBajos.Text = contAsientosBajos.ToString();
        //        }
        //        else
        //        {
        //            txt_CantAsientosBajos.Text = contAsientosBajos.ToString();
        //            MessageBox.Show("Ha alcanzado el minimo de asientos para esta localidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
        //        }
        //    }
        //    else
        //    {
        //        int inicial = int.Parse(dg_Espectaculos.Rows[dg_Espectaculos.CurrentRow.Index].Cells[3].Value.ToString());/*int.Parse(txt_CantAsientosBajos.Text)*/
        //        contAsientosBajos = int.Parse(txt_CantAsientosBajos.Text);//Si no esta vacio le asigno a contador el valor de los asientos del objeto

        //        if (contAsientosBajos > inicial)
        //        {
        //            contAsientosBajos--;//Decremento contador
        //            txt_CantAsientosBajos.Text = contAsientosBajos.ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No puede reducir los asientos debajo de los ingresados originalmente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
        //        }
        //    }
        //}

    }
}
