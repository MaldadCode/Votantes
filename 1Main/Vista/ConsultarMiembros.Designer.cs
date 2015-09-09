namespace _1Main.Vista
{
    partial class ConsultarMiembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMiembros));
            this.gbFiltrarPor = new System.Windows.Forms.GroupBox();
            this.rbNombresYApellidos = new System.Windows.Forms.RadioButton();
            this.rbApellidos = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.panelCedulabBuscar = new System.Windows.Forms.Button();
            this.panelCedulamTbCedula = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelApellidos = new System.Windows.Forms.Panel();
            this.panelApellidosbBuscar = new System.Windows.Forms.Button();
            this.panelApellidostbPrimerApellido = new System.Windows.Forms.TextBox();
            this.panelApellidostbSegundoApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelNombresYApellidos = new System.Windows.Forms.Panel();
            this.panelNombresYApellidosbBuscar = new System.Windows.Forms.Button();
            this.panelNombresYApellidostbSegundoApellido = new System.Windows.Forms.TextBox();
            this.panelNombresYApellidostbSegundoNombre = new System.Windows.Forms.TextBox();
            this.panelNombresYApellidostbPrimerApellido = new System.Windows.Forms.TextBox();
            this.panelNombresYApellidostbPrimerNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbInfoBtSalir = new System.Windows.Forms.Button();
            this.gbInfoTbCircunscripcion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gbInfoTbSegundoApellido = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gbInfoTbPrimerApellido = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gbInfoTbMesa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gbInfoTbNoOrden = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbInfoTbCentroDeVotacion = new System.Windows.Forms.TextBox();
            this.gbInfoTbOrganismo = new System.Windows.Forms.TextBox();
            this.gbInfoTbMunicipio = new System.Windows.Forms.TextBox();
            this.gbInfoTbProvincia = new System.Windows.Forms.TextBox();
            this.gbInfoTbNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbInfomTbCedula = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbFiltrarPor.SuspendLayout();
            this.panelCedula.SuspendLayout();
            this.panelApellidos.SuspendLayout();
            this.panelNombresYApellidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltrarPor
            // 
            this.gbFiltrarPor.Controls.Add(this.rbNombresYApellidos);
            this.gbFiltrarPor.Controls.Add(this.rbApellidos);
            this.gbFiltrarPor.Controls.Add(this.rbCedula);
            this.gbFiltrarPor.Location = new System.Drawing.Point(10, 10);
            this.gbFiltrarPor.Name = "gbFiltrarPor";
            this.gbFiltrarPor.Size = new System.Drawing.Size(144, 90);
            this.gbFiltrarPor.TabIndex = 0;
            this.gbFiltrarPor.TabStop = false;
            this.gbFiltrarPor.Text = "Filtrar Por:";
            // 
            // rbNombresYApellidos
            // 
            this.rbNombresYApellidos.AutoSize = true;
            this.rbNombresYApellidos.Location = new System.Drawing.Point(6, 65);
            this.rbNombresYApellidos.Name = "rbNombresYApellidos";
            this.rbNombresYApellidos.Size = new System.Drawing.Size(132, 17);
            this.rbNombresYApellidos.TabIndex = 2;
            this.rbNombresYApellidos.TabStop = true;
            this.rbNombresYApellidos.Text = "Nombre(s) y Apellido(s)";
            this.rbNombresYApellidos.UseVisualStyleBackColor = true;
            this.rbNombresYApellidos.CheckedChanged += new System.EventHandler(this.rbNombresYApellidos_CheckedChanged);
            // 
            // rbApellidos
            // 
            this.rbApellidos.AutoSize = true;
            this.rbApellidos.Location = new System.Drawing.Point(6, 42);
            this.rbApellidos.Name = "rbApellidos";
            this.rbApellidos.Size = new System.Drawing.Size(67, 17);
            this.rbApellidos.TabIndex = 1;
            this.rbApellidos.TabStop = true;
            this.rbApellidos.Text = "Apellidos";
            this.rbApellidos.UseVisualStyleBackColor = true;
            this.rbApellidos.CheckedChanged += new System.EventHandler(this.rbApellidos_CheckedChanged);
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Location = new System.Drawing.Point(6, 19);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(58, 17);
            this.rbCedula.TabIndex = 0;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula";
            this.rbCedula.UseVisualStyleBackColor = true;
            this.rbCedula.CheckedChanged += new System.EventHandler(this.rbCedula_CheckedChanged);
            // 
            // panelCedula
            // 
            this.panelCedula.Controls.Add(this.panelCedulabBuscar);
            this.panelCedula.Controls.Add(this.panelCedulamTbCedula);
            this.panelCedula.Controls.Add(this.label1);
            this.panelCedula.Location = new System.Drawing.Point(164, 16);
            this.panelCedula.Name = "panelCedula";
            this.panelCedula.Size = new System.Drawing.Size(635, 84);
            this.panelCedula.TabIndex = 1;
            this.panelCedula.Visible = false;
            // 
            // panelCedulabBuscar
            // 
            this.panelCedulabBuscar.Location = new System.Drawing.Point(190, 10);
            this.panelCedulabBuscar.Name = "panelCedulabBuscar";
            this.panelCedulabBuscar.Size = new System.Drawing.Size(75, 23);
            this.panelCedulabBuscar.TabIndex = 2;
            this.panelCedulabBuscar.Text = "Buscar";
            this.panelCedulabBuscar.UseVisualStyleBackColor = true;
            this.panelCedulabBuscar.Click += new System.EventHandler(this.panelCedulabBuscar_Click);
            // 
            // panelCedulamTbCedula
            // 
            this.panelCedulamTbCedula.Location = new System.Drawing.Point(104, 12);
            this.panelCedulamTbCedula.Mask = "000-0000000-0";
            this.panelCedulamTbCedula.Name = "panelCedulamTbCedula";
            this.panelCedulamTbCedula.ResetOnSpace = false;
            this.panelCedulamTbCedula.Size = new System.Drawing.Size(80, 20);
            this.panelCedulamTbCedula.TabIndex = 1;
            this.panelCedulamTbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panelCedulamTbCedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula*";
            // 
            // panelApellidos
            // 
            this.panelApellidos.Controls.Add(this.panelApellidosbBuscar);
            this.panelApellidos.Controls.Add(this.panelApellidostbPrimerApellido);
            this.panelApellidos.Controls.Add(this.panelApellidostbSegundoApellido);
            this.panelApellidos.Controls.Add(this.label7);
            this.panelApellidos.Controls.Add(this.label6);
            this.panelApellidos.Location = new System.Drawing.Point(164, 16);
            this.panelApellidos.Name = "panelApellidos";
            this.panelApellidos.Size = new System.Drawing.Size(635, 84);
            this.panelApellidos.TabIndex = 2;
            this.panelApellidos.Visible = false;
            // 
            // panelApellidosbBuscar
            // 
            this.panelApellidosbBuscar.Location = new System.Drawing.Point(280, 10);
            this.panelApellidosbBuscar.Name = "panelApellidosbBuscar";
            this.panelApellidosbBuscar.Size = new System.Drawing.Size(75, 23);
            this.panelApellidosbBuscar.TabIndex = 4;
            this.panelApellidosbBuscar.Text = "Buscar";
            this.panelApellidosbBuscar.UseVisualStyleBackColor = true;
            this.panelApellidosbBuscar.Click += new System.EventHandler(this.panelApellidosbBuscar_Click);
            // 
            // panelApellidostbPrimerApellido
            // 
            this.panelApellidostbPrimerApellido.Location = new System.Drawing.Point(104, 12);
            this.panelApellidostbPrimerApellido.Name = "panelApellidostbPrimerApellido";
            this.panelApellidostbPrimerApellido.Size = new System.Drawing.Size(170, 20);
            this.panelApellidostbPrimerApellido.TabIndex = 2;
            this.panelApellidostbPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panelApellidostbPrimerApellido_KeyPress);
            // 
            // panelApellidostbSegundoApellido
            // 
            this.panelApellidostbSegundoApellido.Location = new System.Drawing.Point(104, 38);
            this.panelApellidostbSegundoApellido.Name = "panelApellidostbSegundoApellido";
            this.panelApellidostbSegundoApellido.Size = new System.Drawing.Size(170, 20);
            this.panelApellidostbSegundoApellido.TabIndex = 3;
            this.panelApellidostbSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panelApellidostbSegundoApellido_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Primer Apellido*";
            // 
            // panelNombresYApellidos
            // 
            this.panelNombresYApellidos.Controls.Add(this.panelNombresYApellidosbBuscar);
            this.panelNombresYApellidos.Controls.Add(this.panelNombresYApellidostbSegundoApellido);
            this.panelNombresYApellidos.Controls.Add(this.panelNombresYApellidostbSegundoNombre);
            this.panelNombresYApellidos.Controls.Add(this.panelNombresYApellidostbPrimerApellido);
            this.panelNombresYApellidos.Controls.Add(this.panelNombresYApellidostbPrimerNombre);
            this.panelNombresYApellidos.Controls.Add(this.label5);
            this.panelNombresYApellidos.Controls.Add(this.label4);
            this.panelNombresYApellidos.Controls.Add(this.label3);
            this.panelNombresYApellidos.Controls.Add(this.label2);
            this.panelNombresYApellidos.Location = new System.Drawing.Point(164, 16);
            this.panelNombresYApellidos.Name = "panelNombresYApellidos";
            this.panelNombresYApellidos.Size = new System.Drawing.Size(635, 84);
            this.panelNombresYApellidos.TabIndex = 2;
            this.panelNombresYApellidos.Visible = false;
            // 
            // panelNombresYApellidosbBuscar
            // 
            this.panelNombresYApellidosbBuscar.Location = new System.Drawing.Point(552, 10);
            this.panelNombresYApellidosbBuscar.Name = "panelNombresYApellidosbBuscar";
            this.panelNombresYApellidosbBuscar.Size = new System.Drawing.Size(75, 23);
            this.panelNombresYApellidosbBuscar.TabIndex = 16;
            this.panelNombresYApellidosbBuscar.Text = "Buscar";
            this.panelNombresYApellidosbBuscar.UseVisualStyleBackColor = true;
            this.panelNombresYApellidosbBuscar.Click += new System.EventHandler(this.panelNombreYApellidosbBuscar_Click);
            // 
            // panelNombresYApellidostbSegundoApellido
            // 
            this.panelNombresYApellidostbSegundoApellido.Location = new System.Drawing.Point(376, 38);
            this.panelNombresYApellidostbSegundoApellido.Name = "panelNombresYApellidostbSegundoApellido";
            this.panelNombresYApellidostbSegundoApellido.Size = new System.Drawing.Size(170, 20);
            this.panelNombresYApellidostbSegundoApellido.TabIndex = 15;
            this.panelNombresYApellidostbSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panelNombresYApellidostbSegundoApellido_KeyPress);
            // 
            // panelNombresYApellidostbSegundoNombre
            // 
            this.panelNombresYApellidostbSegundoNombre.Location = new System.Drawing.Point(376, 12);
            this.panelNombresYApellidostbSegundoNombre.Name = "panelNombresYApellidostbSegundoNombre";
            this.panelNombresYApellidostbSegundoNombre.Size = new System.Drawing.Size(170, 20);
            this.panelNombresYApellidostbSegundoNombre.TabIndex = 14;
            this.panelNombresYApellidostbSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panelNombresYApellidostbSegundoNombre_KeyPress);
            // 
            // panelNombresYApellidostbPrimerApellido
            // 
            this.panelNombresYApellidostbPrimerApellido.Location = new System.Drawing.Point(104, 38);
            this.panelNombresYApellidostbPrimerApellido.Name = "panelNombresYApellidostbPrimerApellido";
            this.panelNombresYApellidostbPrimerApellido.Size = new System.Drawing.Size(170, 20);
            this.panelNombresYApellidostbPrimerApellido.TabIndex = 13;
            this.panelNombresYApellidostbPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panelNombresYApellidostbPrimerApellido_KeyPress);
            // 
            // panelNombresYApellidostbPrimerNombre
            // 
            this.panelNombresYApellidostbPrimerNombre.Location = new System.Drawing.Point(104, 12);
            this.panelNombresYApellidostbPrimerNombre.Name = "panelNombresYApellidostbPrimerNombre";
            this.panelNombresYApellidostbPrimerNombre.Size = new System.Drawing.Size(170, 20);
            this.panelNombresYApellidostbPrimerNombre.TabIndex = 12;
            this.panelNombresYApellidostbPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panelNombresYApellidostbPrimerNombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Primer Nombre*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.gbInfoBtSalir);
            this.gbInfo.Controls.Add(this.gbInfoTbCircunscripcion);
            this.gbInfo.Controls.Add(this.label19);
            this.gbInfo.Controls.Add(this.gbInfoTbSegundoApellido);
            this.gbInfo.Controls.Add(this.label18);
            this.gbInfo.Controls.Add(this.gbInfoTbPrimerApellido);
            this.gbInfo.Controls.Add(this.label17);
            this.gbInfo.Controls.Add(this.gbInfoTbMesa);
            this.gbInfo.Controls.Add(this.label16);
            this.gbInfo.Controls.Add(this.gbInfoTbNoOrden);
            this.gbInfo.Controls.Add(this.label15);
            this.gbInfo.Controls.Add(this.comboBox1);
            this.gbInfo.Controls.Add(this.label14);
            this.gbInfo.Controls.Add(this.gbInfoTbCentroDeVotacion);
            this.gbInfo.Controls.Add(this.gbInfoTbOrganismo);
            this.gbInfo.Controls.Add(this.gbInfoTbMunicipio);
            this.gbInfo.Controls.Add(this.gbInfoTbProvincia);
            this.gbInfo.Controls.Add(this.gbInfoTbNombre);
            this.gbInfo.Controls.Add(this.label13);
            this.gbInfo.Controls.Add(this.label12);
            this.gbInfo.Controls.Add(this.label11);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.gbInfomTbCedula);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Location = new System.Drawing.Point(10, 262);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(791, 183);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // gbInfoBtSalir
            // 
            this.gbInfoBtSalir.Location = new System.Drawing.Point(353, 97);
            this.gbInfoBtSalir.Name = "gbInfoBtSalir";
            this.gbInfoBtSalir.Size = new System.Drawing.Size(422, 69);
            this.gbInfoBtSalir.TabIndex = 25;
            this.gbInfoBtSalir.Text = "Salir";
            this.gbInfoBtSalir.UseVisualStyleBackColor = true;
            this.gbInfoBtSalir.Click += new System.EventHandler(this.gbInfoBtSalir_Click);
            // 
            // gbInfoTbCircunscripcion
            // 
            this.gbInfoTbCircunscripcion.Location = new System.Drawing.Point(429, 68);
            this.gbInfoTbCircunscripcion.Name = "gbInfoTbCircunscripcion";
            this.gbInfoTbCircunscripcion.ReadOnly = true;
            this.gbInfoTbCircunscripcion.Size = new System.Drawing.Size(84, 20);
            this.gbInfoTbCircunscripcion.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(344, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Circunscripcion";
            // 
            // gbInfoTbSegundoApellido
            // 
            this.gbInfoTbSegundoApellido.Location = new System.Drawing.Point(653, 42);
            this.gbInfoTbSegundoApellido.Name = "gbInfoTbSegundoApellido";
            this.gbInfoTbSegundoApellido.ReadOnly = true;
            this.gbInfoTbSegundoApellido.Size = new System.Drawing.Size(122, 20);
            this.gbInfoTbSegundoApellido.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(557, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Segundo Apellido";
            // 
            // gbInfoTbPrimerApellido
            // 
            this.gbInfoTbPrimerApellido.Location = new System.Drawing.Point(429, 42);
            this.gbInfoTbPrimerApellido.Name = "gbInfoTbPrimerApellido";
            this.gbInfoTbPrimerApellido.ReadOnly = true;
            this.gbInfoTbPrimerApellido.Size = new System.Drawing.Size(122, 20);
            this.gbInfoTbPrimerApellido.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(344, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Primer Apellido";
            // 
            // gbInfoTbMesa
            // 
            this.gbInfoTbMesa.Location = new System.Drawing.Point(653, 16);
            this.gbInfoTbMesa.Name = "gbInfoTbMesa";
            this.gbInfoTbMesa.ReadOnly = true;
            this.gbInfoTbMesa.Size = new System.Drawing.Size(84, 20);
            this.gbInfoTbMesa.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(614, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Mesa";
            // 
            // gbInfoTbNoOrden
            // 
            this.gbInfoTbNoOrden.Location = new System.Drawing.Point(429, 16);
            this.gbInfoTbNoOrden.Name = "gbInfoTbNoOrden";
            this.gbInfoTbNoOrden.ReadOnly = true;
            this.gbInfoTbNoOrden.Size = new System.Drawing.Size(84, 20);
            this.gbInfoTbNoOrden.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "No. Orden";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(233, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Sexo";
            // 
            // gbInfoTbCentroDeVotacion
            // 
            this.gbInfoTbCentroDeVotacion.Location = new System.Drawing.Point(110, 146);
            this.gbInfoTbCentroDeVotacion.Name = "gbInfoTbCentroDeVotacion";
            this.gbInfoTbCentroDeVotacion.ReadOnly = true;
            this.gbInfoTbCentroDeVotacion.Size = new System.Drawing.Size(228, 20);
            this.gbInfoTbCentroDeVotacion.TabIndex = 12;
            // 
            // gbInfoTbOrganismo
            // 
            this.gbInfoTbOrganismo.Location = new System.Drawing.Point(110, 120);
            this.gbInfoTbOrganismo.Name = "gbInfoTbOrganismo";
            this.gbInfoTbOrganismo.ReadOnly = true;
            this.gbInfoTbOrganismo.Size = new System.Drawing.Size(228, 20);
            this.gbInfoTbOrganismo.TabIndex = 11;
            // 
            // gbInfoTbMunicipio
            // 
            this.gbInfoTbMunicipio.Location = new System.Drawing.Point(110, 94);
            this.gbInfoTbMunicipio.Name = "gbInfoTbMunicipio";
            this.gbInfoTbMunicipio.ReadOnly = true;
            this.gbInfoTbMunicipio.Size = new System.Drawing.Size(228, 20);
            this.gbInfoTbMunicipio.TabIndex = 10;
            // 
            // gbInfoTbProvincia
            // 
            this.gbInfoTbProvincia.Location = new System.Drawing.Point(110, 68);
            this.gbInfoTbProvincia.Name = "gbInfoTbProvincia";
            this.gbInfoTbProvincia.ReadOnly = true;
            this.gbInfoTbProvincia.Size = new System.Drawing.Size(228, 20);
            this.gbInfoTbProvincia.TabIndex = 9;
            // 
            // gbInfoTbNombre
            // 
            this.gbInfoTbNombre.Location = new System.Drawing.Point(110, 42);
            this.gbInfoTbNombre.Name = "gbInfoTbNombre";
            this.gbInfoTbNombre.ReadOnly = true;
            this.gbInfoTbNombre.Size = new System.Drawing.Size(228, 20);
            this.gbInfoTbNombre.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Centro de Votacion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Organismo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Municipio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Provincia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre(s)";
            // 
            // gbInfomTbCedula
            // 
            this.gbInfomTbCedula.Location = new System.Drawing.Point(110, 16);
            this.gbInfomTbCedula.Mask = "000-0000000-0";
            this.gbInfomTbCedula.Name = "gbInfomTbCedula";
            this.gbInfomTbCedula.ReadOnly = true;
            this.gbInfomTbCedula.ResetOnSpace = false;
            this.gbInfomTbCedula.Size = new System.Drawing.Size(80, 20);
            this.gbInfomTbCedula.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cedula";
            // 
            // ConsultarMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 455);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelApellidos);
            this.Controls.Add(this.panelNombresYApellidos);
            this.Controls.Add(this.panelCedula);
            this.Controls.Add(this.gbFiltrarPor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarMiembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarMiembros";
            this.gbFiltrarPor.ResumeLayout(false);
            this.gbFiltrarPor.PerformLayout();
            this.panelCedula.ResumeLayout(false);
            this.panelCedula.PerformLayout();
            this.panelApellidos.ResumeLayout(false);
            this.panelApellidos.PerformLayout();
            this.panelNombresYApellidos.ResumeLayout(false);
            this.panelNombresYApellidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltrarPor;
        private System.Windows.Forms.RadioButton rbNombresYApellidos;
        private System.Windows.Forms.RadioButton rbApellidos;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Panel panelApellidos;
        private System.Windows.Forms.Panel panelNombresYApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox panelCedulamTbCedula;
        private System.Windows.Forms.TextBox panelNombresYApellidostbSegundoApellido;
        private System.Windows.Forms.TextBox panelNombresYApellidostbSegundoNombre;
        private System.Windows.Forms.TextBox panelNombresYApellidostbPrimerApellido;
        private System.Windows.Forms.TextBox panelNombresYApellidostbPrimerNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button panelCedulabBuscar;
        private System.Windows.Forms.Button panelNombresYApellidosbBuscar;
        private System.Windows.Forms.TextBox panelApellidostbPrimerApellido;
        private System.Windows.Forms.TextBox panelApellidostbSegundoApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button panelApellidosbBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.MaskedTextBox gbInfomTbCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox gbInfoTbCentroDeVotacion;
        private System.Windows.Forms.TextBox gbInfoTbOrganismo;
        private System.Windows.Forms.TextBox gbInfoTbMunicipio;
        private System.Windows.Forms.TextBox gbInfoTbProvincia;
        private System.Windows.Forms.TextBox gbInfoTbNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox gbInfoTbMesa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox gbInfoTbNoOrden;
        private System.Windows.Forms.TextBox gbInfoTbSegundoApellido;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox gbInfoTbPrimerApellido;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox gbInfoTbCircunscripcion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button gbInfoBtSalir;
    }
}