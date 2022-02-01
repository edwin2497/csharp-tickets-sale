namespace PROYECTO.PRESENTACION
{
    partial class Administradores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_Mantenimientos = new System.Windows.Forms.TabControl();
            this.tb_Personas = new System.Windows.Forms.TabPage();
            this.gb_IngresoDatos = new System.Windows.Forms.GroupBox();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cb_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.dg_Personas = new System.Windows.Forms.DataGridView();
            this.tb_Espectáculos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CantAsientosDisc = new System.Windows.Forms.Button();
            this.btn_CantAsientosAltos = new System.Windows.Forms.Button();
            this.btn_CantAsientosMedios = new System.Windows.Forms.Button();
            this.btn_CantAsientosBajos = new System.Windows.Forms.Button();
            this.lbl_CantAsientosAltos = new System.Windows.Forms.Label();
            this.lbl_CostAsientosAltos = new System.Windows.Forms.Label();
            this.lbl_CantAsientosDiscapacitados = new System.Windows.Forms.Label();
            this.lbl_CostAsientosDiscapacitados = new System.Windows.Forms.Label();
            this.txt_CantAsientosDiscapacitados = new System.Windows.Forms.TextBox();
            this.txt_CostAsientosDiscapacitados = new System.Windows.Forms.TextBox();
            this.txt_CantAsientosAltos = new System.Windows.Forms.TextBox();
            this.txt_CostAsientosAltos = new System.Windows.Forms.TextBox();
            this.txt_CostAsientosMedios = new System.Windows.Forms.TextBox();
            this.btn_MostrarEspectaculos = new System.Windows.Forms.Button();
            this.lbl_CostAsientosMedios = new System.Windows.Forms.Label();
            this.txt_CantAsientosMedios = new System.Windows.Forms.TextBox();
            this.btn_BuscarEspectaculos = new System.Windows.Forms.Button();
            this.btn_ModificarEspectaculos = new System.Windows.Forms.Button();
            this.btn_EliminarEspectaculos = new System.Windows.Forms.Button();
            this.btn_InsertarEspectaculos = new System.Windows.Forms.Button();
            this.lbl_CantAsientosMedios = new System.Windows.Forms.Label();
            this.txt_CostAsientosBajos = new System.Windows.Forms.TextBox();
            this.lbl_CostAsientosBajos = new System.Windows.Forms.Label();
            this.txt_CantAsientosBajos = new System.Windows.Forms.TextBox();
            this.lbl_CantAsientosBajos = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_NombreGrupo = new System.Windows.Forms.TextBox();
            this.lbl_NombreGrupo = new System.Windows.Forms.Label();
            this.dg_Espectaculos = new System.Windows.Forms.DataGridView();
            this.tb_Auditoria = new System.Windows.Forms.TabPage();
            this.dg_Auditoria = new System.Windows.Forms.DataGridView();
            this.tc_Mantenimientos.SuspendLayout();
            this.tb_Personas.SuspendLayout();
            this.gb_IngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Personas)).BeginInit();
            this.tb_Espectáculos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Espectaculos)).BeginInit();
            this.tb_Auditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Auditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_Mantenimientos
            // 
            this.tc_Mantenimientos.Controls.Add(this.tb_Personas);
            this.tc_Mantenimientos.Controls.Add(this.tb_Espectáculos);
            this.tc_Mantenimientos.Controls.Add(this.tb_Auditoria);
            this.tc_Mantenimientos.Location = new System.Drawing.Point(-1, 1);
            this.tc_Mantenimientos.Name = "tc_Mantenimientos";
            this.tc_Mantenimientos.SelectedIndex = 0;
            this.tc_Mantenimientos.Size = new System.Drawing.Size(1244, 451);
            this.tc_Mantenimientos.TabIndex = 0;
            // 
            // tb_Personas
            // 
            this.tb_Personas.Controls.Add(this.gb_IngresoDatos);
            this.tb_Personas.Controls.Add(this.dg_Personas);
            this.tb_Personas.Location = new System.Drawing.Point(4, 22);
            this.tb_Personas.Name = "tb_Personas";
            this.tb_Personas.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Personas.Size = new System.Drawing.Size(1236, 425);
            this.tb_Personas.TabIndex = 0;
            this.tb_Personas.Text = "Mantenimiento Personas";
            this.tb_Personas.UseVisualStyleBackColor = true;
            // 
            // gb_IngresoDatos
            // 
            this.gb_IngresoDatos.Controls.Add(this.btn_MostrarDatos);
            this.gb_IngresoDatos.Controls.Add(this.label1);
            this.gb_IngresoDatos.Controls.Add(this.txt_Password);
            this.gb_IngresoDatos.Controls.Add(this.cb_TipoUsuario);
            this.gb_IngresoDatos.Controls.Add(this.btn_Buscar);
            this.gb_IngresoDatos.Controls.Add(this.btn_Modificar);
            this.gb_IngresoDatos.Controls.Add(this.btn_Eliminar);
            this.gb_IngresoDatos.Controls.Add(this.btn_Insertar);
            this.gb_IngresoDatos.Controls.Add(this.lbl_TipoUsuario);
            this.gb_IngresoDatos.Controls.Add(this.txt_Email);
            this.gb_IngresoDatos.Controls.Add(this.lbl_Email);
            this.gb_IngresoDatos.Controls.Add(this.txt_Cedula);
            this.gb_IngresoDatos.Controls.Add(this.lbl_Cedula);
            this.gb_IngresoDatos.Controls.Add(this.txt_Apellido);
            this.gb_IngresoDatos.Controls.Add(this.lbl_Apellido);
            this.gb_IngresoDatos.Controls.Add(this.txt_Nombre);
            this.gb_IngresoDatos.Controls.Add(this.lbl_Nombre);
            this.gb_IngresoDatos.Location = new System.Drawing.Point(819, 17);
            this.gb_IngresoDatos.Name = "gb_IngresoDatos";
            this.gb_IngresoDatos.Size = new System.Drawing.Size(414, 398);
            this.gb_IngresoDatos.TabIndex = 5;
            this.gb_IngresoDatos.TabStop = false;
            this.gb_IngresoDatos.Text = "Ingreso Datos";
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.Location = new System.Drawing.Point(268, 247);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(86, 23);
            this.btn_MostrarDatos.TabIndex = 28;
            this.btn_MostrarDatos.Text = "Mostrar Datos";
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(86, 299);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 26;
            // 
            // cb_TipoUsuario
            // 
            this.cb_TipoUsuario.FormattingEnabled = true;
            this.cb_TipoUsuario.Items.AddRange(new object[] {
            "Admin",
            "Cliente"});
            this.cb_TipoUsuario.Location = new System.Drawing.Point(86, 249);
            this.cb_TipoUsuario.Name = "cb_TipoUsuario";
            this.cb_TipoUsuario.Size = new System.Drawing.Size(100, 21);
            this.cb_TipoUsuario.TabIndex = 25;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(268, 198);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(86, 23);
            this.btn_Buscar.TabIndex = 23;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(268, 149);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(86, 23);
            this.btn_Modificar.TabIndex = 22;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(268, 99);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(86, 23);
            this.btn_Eliminar.TabIndex = 20;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(268, 48);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(86, 23);
            this.btn_Insertar.TabIndex = 19;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // lbl_TipoUsuario
            // 
            this.lbl_TipoUsuario.AutoSize = true;
            this.lbl_TipoUsuario.Location = new System.Drawing.Point(6, 257);
            this.lbl_TipoUsuario.Name = "lbl_TipoUsuario";
            this.lbl_TipoUsuario.Size = new System.Drawing.Size(67, 13);
            this.lbl_TipoUsuario.TabIndex = 15;
            this.lbl_TipoUsuario.Text = "Tipo Usuario";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(86, 201);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 14;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(6, 208);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(86, 152);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_Cedula.TabIndex = 12;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Location = new System.Drawing.Point(6, 159);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cedula.TabIndex = 11;
            this.lbl_Cedula.Text = "Cedula";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(86, 102);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 10;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(6, 109);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 9;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(86, 51);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 8;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 58);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 7;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // dg_Personas
            // 
            this.dg_Personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Personas.Location = new System.Drawing.Point(0, 17);
            this.dg_Personas.Name = "dg_Personas";
            this.dg_Personas.Size = new System.Drawing.Size(813, 398);
            this.dg_Personas.TabIndex = 4;
            this.dg_Personas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Personas_CellClick);
            // 
            // tb_Espectáculos
            // 
            this.tb_Espectáculos.Controls.Add(this.groupBox1);
            this.tb_Espectáculos.Controls.Add(this.dg_Espectaculos);
            this.tb_Espectáculos.Location = new System.Drawing.Point(4, 22);
            this.tb_Espectáculos.Name = "tb_Espectáculos";
            this.tb_Espectáculos.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Espectáculos.Size = new System.Drawing.Size(1236, 425);
            this.tb_Espectáculos.TabIndex = 1;
            this.tb_Espectáculos.Tag = "";
            this.tb_Espectáculos.Text = "Mantenimiento Espectáculos";
            this.tb_Espectáculos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CantAsientosDisc);
            this.groupBox1.Controls.Add(this.btn_CantAsientosAltos);
            this.groupBox1.Controls.Add(this.btn_CantAsientosMedios);
            this.groupBox1.Controls.Add(this.btn_CantAsientosBajos);
            this.groupBox1.Controls.Add(this.lbl_CantAsientosAltos);
            this.groupBox1.Controls.Add(this.lbl_CostAsientosAltos);
            this.groupBox1.Controls.Add(this.lbl_CantAsientosDiscapacitados);
            this.groupBox1.Controls.Add(this.lbl_CostAsientosDiscapacitados);
            this.groupBox1.Controls.Add(this.txt_CantAsientosDiscapacitados);
            this.groupBox1.Controls.Add(this.txt_CostAsientosDiscapacitados);
            this.groupBox1.Controls.Add(this.txt_CantAsientosAltos);
            this.groupBox1.Controls.Add(this.txt_CostAsientosAltos);
            this.groupBox1.Controls.Add(this.txt_CostAsientosMedios);
            this.groupBox1.Controls.Add(this.btn_MostrarEspectaculos);
            this.groupBox1.Controls.Add(this.lbl_CostAsientosMedios);
            this.groupBox1.Controls.Add(this.txt_CantAsientosMedios);
            this.groupBox1.Controls.Add(this.btn_BuscarEspectaculos);
            this.groupBox1.Controls.Add(this.btn_ModificarEspectaculos);
            this.groupBox1.Controls.Add(this.btn_EliminarEspectaculos);
            this.groupBox1.Controls.Add(this.btn_InsertarEspectaculos);
            this.groupBox1.Controls.Add(this.lbl_CantAsientosMedios);
            this.groupBox1.Controls.Add(this.txt_CostAsientosBajos);
            this.groupBox1.Controls.Add(this.lbl_CostAsientosBajos);
            this.groupBox1.Controls.Add(this.txt_CantAsientosBajos);
            this.groupBox1.Controls.Add(this.lbl_CantAsientosBajos);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.lbl_Descripcion);
            this.groupBox1.Controls.Add(this.txt_NombreGrupo);
            this.groupBox1.Controls.Add(this.lbl_NombreGrupo);
            this.groupBox1.Location = new System.Drawing.Point(819, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 398);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Datos";
            // 
            // btn_CantAsientosDisc
            // 
            this.btn_CantAsientosDisc.Location = new System.Drawing.Point(202, 318);
            this.btn_CantAsientosDisc.Name = "btn_CantAsientosDisc";
            this.btn_CantAsientosDisc.Size = new System.Drawing.Size(35, 20);
            this.btn_CantAsientosDisc.TabIndex = 41;
            this.btn_CantAsientosDisc.Text = "+";
            this.btn_CantAsientosDisc.UseVisualStyleBackColor = true;
            this.btn_CantAsientosDisc.Click += new System.EventHandler(this.btn_CantAsientosDisc_Click);
            // 
            // btn_CantAsientosAltos
            // 
            this.btn_CantAsientosAltos.Location = new System.Drawing.Point(202, 246);
            this.btn_CantAsientosAltos.Name = "btn_CantAsientosAltos";
            this.btn_CantAsientosAltos.Size = new System.Drawing.Size(35, 20);
            this.btn_CantAsientosAltos.TabIndex = 40;
            this.btn_CantAsientosAltos.Text = "+";
            this.btn_CantAsientosAltos.UseVisualStyleBackColor = true;
            this.btn_CantAsientosAltos.Click += new System.EventHandler(this.btn_CantAsientosAltos_Click);
            // 
            // btn_CantAsientosMedios
            // 
            this.btn_CantAsientosMedios.Location = new System.Drawing.Point(202, 174);
            this.btn_CantAsientosMedios.Name = "btn_CantAsientosMedios";
            this.btn_CantAsientosMedios.Size = new System.Drawing.Size(35, 20);
            this.btn_CantAsientosMedios.TabIndex = 39;
            this.btn_CantAsientosMedios.Text = "+";
            this.btn_CantAsientosMedios.UseVisualStyleBackColor = true;
            this.btn_CantAsientosMedios.Click += new System.EventHandler(this.btn_CantAsientosMedios_Click);
            // 
            // btn_CantAsientosBajos
            // 
            this.btn_CantAsientosBajos.Location = new System.Drawing.Point(202, 102);
            this.btn_CantAsientosBajos.Name = "btn_CantAsientosBajos";
            this.btn_CantAsientosBajos.Size = new System.Drawing.Size(35, 20);
            this.btn_CantAsientosBajos.TabIndex = 38;
            this.btn_CantAsientosBajos.Text = "+";
            this.btn_CantAsientosBajos.UseVisualStyleBackColor = true;
            this.btn_CantAsientosBajos.Click += new System.EventHandler(this.btn_CantAsientosBajos_Click);
            // 
            // lbl_CantAsientosAltos
            // 
            this.lbl_CantAsientosAltos.AutoSize = true;
            this.lbl_CantAsientosAltos.Location = new System.Drawing.Point(15, 254);
            this.lbl_CantAsientosAltos.Name = "lbl_CantAsientosAltos";
            this.lbl_CantAsientosAltos.Size = new System.Drawing.Size(101, 13);
            this.lbl_CantAsientosAltos.TabIndex = 37;
            this.lbl_CantAsientosAltos.Text = "Cant. Asientos Altos";
            // 
            // lbl_CostAsientosAltos
            // 
            this.lbl_CostAsientosAltos.AutoSize = true;
            this.lbl_CostAsientosAltos.Location = new System.Drawing.Point(16, 290);
            this.lbl_CostAsientosAltos.Name = "lbl_CostAsientosAltos";
            this.lbl_CostAsientosAltos.Size = new System.Drawing.Size(100, 13);
            this.lbl_CostAsientosAltos.TabIndex = 36;
            this.lbl_CostAsientosAltos.Text = "Cost. Asientos Altos";
            // 
            // lbl_CantAsientosDiscapacitados
            // 
            this.lbl_CantAsientosDiscapacitados.AutoSize = true;
            this.lbl_CantAsientosDiscapacitados.Location = new System.Drawing.Point(15, 325);
            this.lbl_CantAsientosDiscapacitados.Name = "lbl_CantAsientosDiscapacitados";
            this.lbl_CantAsientosDiscapacitados.Size = new System.Drawing.Size(108, 13);
            this.lbl_CantAsientosDiscapacitados.TabIndex = 35;
            this.lbl_CantAsientosDiscapacitados.Text = "Cant. Discapacitados";
            // 
            // lbl_CostAsientosDiscapacitados
            // 
            this.lbl_CostAsientosDiscapacitados.AutoSize = true;
            this.lbl_CostAsientosDiscapacitados.Location = new System.Drawing.Point(16, 361);
            this.lbl_CostAsientosDiscapacitados.Name = "lbl_CostAsientosDiscapacitados";
            this.lbl_CostAsientosDiscapacitados.Size = new System.Drawing.Size(107, 13);
            this.lbl_CostAsientosDiscapacitados.TabIndex = 34;
            this.lbl_CostAsientosDiscapacitados.Text = "Cost. Discapacitados";
            // 
            // txt_CantAsientosDiscapacitados
            // 
            this.txt_CantAsientosDiscapacitados.Enabled = false;
            this.txt_CantAsientosDiscapacitados.Location = new System.Drawing.Point(137, 318);
            this.txt_CantAsientosDiscapacitados.Name = "txt_CantAsientosDiscapacitados";
            this.txt_CantAsientosDiscapacitados.Size = new System.Drawing.Size(59, 20);
            this.txt_CantAsientosDiscapacitados.TabIndex = 33;
            // 
            // txt_CostAsientosDiscapacitados
            // 
            this.txt_CostAsientosDiscapacitados.Location = new System.Drawing.Point(137, 354);
            this.txt_CostAsientosDiscapacitados.Name = "txt_CostAsientosDiscapacitados";
            this.txt_CostAsientosDiscapacitados.Size = new System.Drawing.Size(100, 20);
            this.txt_CostAsientosDiscapacitados.TabIndex = 32;
            // 
            // txt_CantAsientosAltos
            // 
            this.txt_CantAsientosAltos.Enabled = false;
            this.txt_CantAsientosAltos.Location = new System.Drawing.Point(137, 246);
            this.txt_CantAsientosAltos.Name = "txt_CantAsientosAltos";
            this.txt_CantAsientosAltos.Size = new System.Drawing.Size(59, 20);
            this.txt_CantAsientosAltos.TabIndex = 31;
            // 
            // txt_CostAsientosAltos
            // 
            this.txt_CostAsientosAltos.Location = new System.Drawing.Point(137, 283);
            this.txt_CostAsientosAltos.Name = "txt_CostAsientosAltos";
            this.txt_CostAsientosAltos.Size = new System.Drawing.Size(100, 20);
            this.txt_CostAsientosAltos.TabIndex = 30;
            // 
            // txt_CostAsientosMedios
            // 
            this.txt_CostAsientosMedios.Location = new System.Drawing.Point(137, 211);
            this.txt_CostAsientosMedios.Name = "txt_CostAsientosMedios";
            this.txt_CostAsientosMedios.Size = new System.Drawing.Size(100, 20);
            this.txt_CostAsientosMedios.TabIndex = 29;
            // 
            // btn_MostrarEspectaculos
            // 
            this.btn_MostrarEspectaculos.Location = new System.Drawing.Point(285, 220);
            this.btn_MostrarEspectaculos.Name = "btn_MostrarEspectaculos";
            this.btn_MostrarEspectaculos.Size = new System.Drawing.Size(86, 23);
            this.btn_MostrarEspectaculos.TabIndex = 28;
            this.btn_MostrarEspectaculos.Text = "Mostrar Datos";
            this.btn_MostrarEspectaculos.UseVisualStyleBackColor = true;
            this.btn_MostrarEspectaculos.Click += new System.EventHandler(this.btn_MostrarEspectaculos_Click);
            // 
            // lbl_CostAsientosMedios
            // 
            this.lbl_CostAsientosMedios.AutoSize = true;
            this.lbl_CostAsientosMedios.Location = new System.Drawing.Point(15, 218);
            this.lbl_CostAsientosMedios.Name = "lbl_CostAsientosMedios";
            this.lbl_CostAsientosMedios.Size = new System.Drawing.Size(111, 13);
            this.lbl_CostAsientosMedios.TabIndex = 27;
            this.lbl_CostAsientosMedios.Text = "Cost. Asientos Medios";
            // 
            // txt_CantAsientosMedios
            // 
            this.txt_CantAsientosMedios.Enabled = false;
            this.txt_CantAsientosMedios.Location = new System.Drawing.Point(137, 174);
            this.txt_CantAsientosMedios.Name = "txt_CantAsientosMedios";
            this.txt_CantAsientosMedios.Size = new System.Drawing.Size(59, 20);
            this.txt_CantAsientosMedios.TabIndex = 26;
            // 
            // btn_BuscarEspectaculos
            // 
            this.btn_BuscarEspectaculos.Location = new System.Drawing.Point(285, 171);
            this.btn_BuscarEspectaculos.Name = "btn_BuscarEspectaculos";
            this.btn_BuscarEspectaculos.Size = new System.Drawing.Size(86, 23);
            this.btn_BuscarEspectaculos.TabIndex = 23;
            this.btn_BuscarEspectaculos.Text = "Buscar";
            this.btn_BuscarEspectaculos.UseVisualStyleBackColor = true;
            this.btn_BuscarEspectaculos.Click += new System.EventHandler(this.btn_BuscarEspectaculos_Click);
            // 
            // btn_ModificarEspectaculos
            // 
            this.btn_ModificarEspectaculos.Location = new System.Drawing.Point(285, 120);
            this.btn_ModificarEspectaculos.Name = "btn_ModificarEspectaculos";
            this.btn_ModificarEspectaculos.Size = new System.Drawing.Size(86, 23);
            this.btn_ModificarEspectaculos.TabIndex = 22;
            this.btn_ModificarEspectaculos.Text = "Modificar";
            this.btn_ModificarEspectaculos.UseVisualStyleBackColor = true;
            this.btn_ModificarEspectaculos.Click += new System.EventHandler(this.btn_ModificarEspectaculos_Click);
            // 
            // btn_EliminarEspectaculos
            // 
            this.btn_EliminarEspectaculos.Location = new System.Drawing.Point(285, 72);
            this.btn_EliminarEspectaculos.Name = "btn_EliminarEspectaculos";
            this.btn_EliminarEspectaculos.Size = new System.Drawing.Size(86, 23);
            this.btn_EliminarEspectaculos.TabIndex = 20;
            this.btn_EliminarEspectaculos.Text = "Eliminar";
            this.btn_EliminarEspectaculos.UseVisualStyleBackColor = true;
            this.btn_EliminarEspectaculos.Click += new System.EventHandler(this.btn_EliminarEspectaculos_Click);
            // 
            // btn_InsertarEspectaculos
            // 
            this.btn_InsertarEspectaculos.Location = new System.Drawing.Point(285, 27);
            this.btn_InsertarEspectaculos.Name = "btn_InsertarEspectaculos";
            this.btn_InsertarEspectaculos.Size = new System.Drawing.Size(86, 23);
            this.btn_InsertarEspectaculos.TabIndex = 19;
            this.btn_InsertarEspectaculos.Text = "Insertar";
            this.btn_InsertarEspectaculos.UseVisualStyleBackColor = true;
            this.btn_InsertarEspectaculos.Click += new System.EventHandler(this.btn_InsertarEspectaculos_Click);
            // 
            // lbl_CantAsientosMedios
            // 
            this.lbl_CantAsientosMedios.AutoSize = true;
            this.lbl_CantAsientosMedios.Location = new System.Drawing.Point(15, 181);
            this.lbl_CantAsientosMedios.Name = "lbl_CantAsientosMedios";
            this.lbl_CantAsientosMedios.Size = new System.Drawing.Size(112, 13);
            this.lbl_CantAsientosMedios.TabIndex = 15;
            this.lbl_CantAsientosMedios.Text = "Cant. Asientos Medios";
            // 
            // txt_CostAsientosBajos
            // 
            this.txt_CostAsientosBajos.Location = new System.Drawing.Point(137, 137);
            this.txt_CostAsientosBajos.Name = "txt_CostAsientosBajos";
            this.txt_CostAsientosBajos.Size = new System.Drawing.Size(100, 20);
            this.txt_CostAsientosBajos.TabIndex = 14;
            // 
            // lbl_CostAsientosBajos
            // 
            this.lbl_CostAsientosBajos.AutoSize = true;
            this.lbl_CostAsientosBajos.Location = new System.Drawing.Point(15, 144);
            this.lbl_CostAsientosBajos.Name = "lbl_CostAsientosBajos";
            this.lbl_CostAsientosBajos.Size = new System.Drawing.Size(103, 13);
            this.lbl_CostAsientosBajos.TabIndex = 13;
            this.lbl_CostAsientosBajos.Text = "Cost. Asientos Bajos";
            // 
            // txt_CantAsientosBajos
            // 
            this.txt_CantAsientosBajos.Enabled = false;
            this.txt_CantAsientosBajos.Location = new System.Drawing.Point(137, 102);
            this.txt_CantAsientosBajos.Name = "txt_CantAsientosBajos";
            this.txt_CantAsientosBajos.Size = new System.Drawing.Size(59, 20);
            this.txt_CantAsientosBajos.TabIndex = 12;
            // 
            // lbl_CantAsientosBajos
            // 
            this.lbl_CantAsientosBajos.AutoSize = true;
            this.lbl_CantAsientosBajos.Location = new System.Drawing.Point(15, 109);
            this.lbl_CantAsientosBajos.Name = "lbl_CantAsientosBajos";
            this.lbl_CantAsientosBajos.Size = new System.Drawing.Size(104, 13);
            this.lbl_CantAsientosBajos.TabIndex = 11;
            this.lbl_CantAsientosBajos.Text = "Cant. Asientos Bajos";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(137, 65);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_Descripcion.TabIndex = 10;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(15, 72);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 9;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // txt_NombreGrupo
            // 
            this.txt_NombreGrupo.Location = new System.Drawing.Point(137, 25);
            this.txt_NombreGrupo.Name = "txt_NombreGrupo";
            this.txt_NombreGrupo.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreGrupo.TabIndex = 8;
            // 
            // lbl_NombreGrupo
            // 
            this.lbl_NombreGrupo.AutoSize = true;
            this.lbl_NombreGrupo.Location = new System.Drawing.Point(15, 32);
            this.lbl_NombreGrupo.Name = "lbl_NombreGrupo";
            this.lbl_NombreGrupo.Size = new System.Drawing.Size(36, 13);
            this.lbl_NombreGrupo.TabIndex = 7;
            this.lbl_NombreGrupo.Text = "Grupo";
            // 
            // dg_Espectaculos
            // 
            this.dg_Espectaculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Espectaculos.Location = new System.Drawing.Point(0, 17);
            this.dg_Espectaculos.Name = "dg_Espectaculos";
            this.dg_Espectaculos.Size = new System.Drawing.Size(813, 398);
            this.dg_Espectaculos.TabIndex = 5;
            this.dg_Espectaculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Espectaculos_CellClick);
            // 
            // tb_Auditoria
            // 
            this.tb_Auditoria.Controls.Add(this.dg_Auditoria);
            this.tb_Auditoria.Location = new System.Drawing.Point(4, 22);
            this.tb_Auditoria.Name = "tb_Auditoria";
            this.tb_Auditoria.Size = new System.Drawing.Size(1236, 425);
            this.tb_Auditoria.TabIndex = 2;
            this.tb_Auditoria.Text = "Auditoria";
            this.tb_Auditoria.UseVisualStyleBackColor = true;
            // 
            // dg_Auditoria
            // 
            this.dg_Auditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Auditoria.Location = new System.Drawing.Point(0, 17);
            this.dg_Auditoria.Name = "dg_Auditoria";
            this.dg_Auditoria.Size = new System.Drawing.Size(813, 398);
            this.dg_Auditoria.TabIndex = 6;
            // 
            // Administradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.tc_Mantenimientos);
            this.Name = "Administradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tc_Mantenimientos.ResumeLayout(false);
            this.tb_Personas.ResumeLayout(false);
            this.gb_IngresoDatos.ResumeLayout(false);
            this.gb_IngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Personas)).EndInit();
            this.tb_Espectáculos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Espectaculos)).EndInit();
            this.tb_Auditoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Auditoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Mantenimientos;
        private System.Windows.Forms.TabPage tb_Personas;
        private System.Windows.Forms.GroupBox gb_IngresoDatos;
        private System.Windows.Forms.ComboBox cb_TipoUsuario;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Label lbl_TipoUsuario;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridView dg_Personas;
        private System.Windows.Forms.TabPage tb_Espectáculos;
        private System.Windows.Forms.TabPage tb_Auditoria;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.DataGridView dg_Espectaculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_MostrarEspectaculos;
        private System.Windows.Forms.Label lbl_CostAsientosMedios;
        private System.Windows.Forms.TextBox txt_CantAsientosMedios;
        private System.Windows.Forms.Button btn_BuscarEspectaculos;
        private System.Windows.Forms.Button btn_ModificarEspectaculos;
        private System.Windows.Forms.Button btn_EliminarEspectaculos;
        private System.Windows.Forms.Button btn_InsertarEspectaculos;
        private System.Windows.Forms.Label lbl_CantAsientosMedios;
        private System.Windows.Forms.TextBox txt_CostAsientosBajos;
        private System.Windows.Forms.Label lbl_CostAsientosBajos;
        private System.Windows.Forms.TextBox txt_CantAsientosBajos;
        private System.Windows.Forms.Label lbl_CantAsientosBajos;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_NombreGrupo;
        private System.Windows.Forms.Label lbl_NombreGrupo;
        private System.Windows.Forms.TextBox txt_CantAsientosDiscapacitados;
        private System.Windows.Forms.TextBox txt_CostAsientosDiscapacitados;
        private System.Windows.Forms.TextBox txt_CantAsientosAltos;
        private System.Windows.Forms.TextBox txt_CostAsientosAltos;
        private System.Windows.Forms.TextBox txt_CostAsientosMedios;
        private System.Windows.Forms.Label lbl_CantAsientosAltos;
        private System.Windows.Forms.Label lbl_CostAsientosAltos;
        private System.Windows.Forms.Label lbl_CantAsientosDiscapacitados;
        private System.Windows.Forms.Label lbl_CostAsientosDiscapacitados;
        private System.Windows.Forms.Button btn_CantAsientosDisc;
        private System.Windows.Forms.Button btn_CantAsientosAltos;
        private System.Windows.Forms.Button btn_CantAsientosMedios;
        private System.Windows.Forms.Button btn_CantAsientosBajos;
        private System.Windows.Forms.DataGridView dg_Auditoria;
    }
}