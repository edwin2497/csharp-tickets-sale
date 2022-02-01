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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_IniciarSesión_Click(object sender, EventArgs e)
        {
            SOCKETCLIENTE.SocketCliente sc = new SOCKETCLIENTE.SocketCliente();

            Persona personaLogin = new Persona();//Creo objeto

            personaLogin = sc.ExecuteClientObject(new Persona(0, null, null, null, txt_Usuario.Text, null, txt_Password.Text));//Asingno a variable persona el objeto que me devuelve el socket

            if (personaLogin.Email != null)//Valido que el objeto que me retorna si esta
            {
                MessageBox.Show("Inicio de sesión correcto", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);//Mensaje login correcto
               
                if (personaLogin.TipoUsuario.Equals("Admin"))
                {
                    this.Hide();
                    Administradores admForm = new Administradores();
                    admForm.Visible = true;
                }
                else
                {
                    this.Hide();
                    VentaBoletos boletosForm = new VentaBoletos();
                    boletosForm.Visible = true;
                    boletosForm.datosPersonales(personaLogin);
                } 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mensaje de error
            }
        }
    }
}
