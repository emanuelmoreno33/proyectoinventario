namespace Inventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdInventario = new System.Windows.Forms.Button();
            this.cmdMaterial = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.cmdAyuda = new System.Windows.Forms.Button();
            this.Inventario = new System.Windows.Forms.Panel();
            this.tablas = new System.Windows.Forms.GroupBox();
            this.tablasIn = new System.Windows.Forms.DataGridView();
            this.idmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadinicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockalertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantflexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant360DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioregistradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioprogramaDataSet1 = new Inventario.inventarioprogramaDataSet1();
            this.Produccion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matnuevo360 = new System.Windows.Forms.NumericUpDown();
            this.matflexnuevo = new System.Windows.Forms.NumericUpDown();
            this.matnuevospeed = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.matnuevoalerta = new System.Windows.Forms.NumericUpDown();
            this.matnuevocant = new System.Windows.Forms.NumericUpDown();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.matnuenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combomaterialact = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matactcant = new System.Windows.Forms.NumericUpDown();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mod360 = new System.Windows.Forms.NumericUpDown();
            this.modflex = new System.Windows.Forms.NumericUpDown();
            this.modspeed = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.modmaterialnombre = new System.Windows.Forms.ComboBox();
            this.matmodalerta = new System.Windows.Forms.NumericUpDown();
            this.matmodcantidad = new System.Windows.Forms.NumericUpDown();
            this.btnmodificacion = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.matmodnombrenuevo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.Panel();
            this.materialTableAdapter = new Inventario.inventarioprogramaDataSet1TableAdapters.materialTableAdapter();
            this.tableAdapterManager = new Inventario.inventarioprogramaDataSet1TableAdapters.TableAdapterManager();
            this.prodflex = new System.Windows.Forms.NumericUpDown();
            this.prodspeed = new System.Windows.Forms.NumericUpDown();
            this.prod360 = new System.Windows.Forms.NumericUpDown();
            this.menu.SuspendLayout();
            this.Inventario.SuspendLayout();
            this.tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablasIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioprogramaDataSet1)).BeginInit();
            this.Produccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matnuevo360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matflexnuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matnuevospeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matnuevoalerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matnuevocant)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matactcant)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mod360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modflex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matmodalerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matmodcantidad)).BeginInit();
            this.Material.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodflex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod360)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdInventario
            // 
            this.cmdInventario.Location = new System.Drawing.Point(24, 9);
            this.cmdInventario.Margin = new System.Windows.Forms.Padding(4);
            this.cmdInventario.Name = "cmdInventario";
            this.cmdInventario.Size = new System.Drawing.Size(93, 86);
            this.cmdInventario.TabIndex = 3;
            this.cmdInventario.Text = "Inventario";
            this.cmdInventario.UseVisualStyleBackColor = true;
            this.cmdInventario.Click += new System.EventHandler(this.CmdInventario_Click_1);
            // 
            // cmdMaterial
            // 
            this.cmdMaterial.Location = new System.Drawing.Point(125, 9);
            this.cmdMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cmdMaterial.Name = "cmdMaterial";
            this.cmdMaterial.Size = new System.Drawing.Size(93, 86);
            this.cmdMaterial.TabIndex = 4;
            this.cmdMaterial.Text = "Material";
            this.cmdMaterial.UseVisualStyleBackColor = true;
            this.cmdMaterial.Click += new System.EventHandler(this.CmdMaterial_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.cmdAyuda);
            this.menu.Controls.Add(this.cmdMaterial);
            this.menu.Controls.Add(this.cmdInventario);
            this.menu.Location = new System.Drawing.Point(0, 7);
            this.menu.Margin = new System.Windows.Forms.Padding(4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1068, 107);
            this.menu.TabIndex = 3;
            // 
            // cmdAyuda
            // 
            this.cmdAyuda.Location = new System.Drawing.Point(956, 9);
            this.cmdAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAyuda.Name = "cmdAyuda";
            this.cmdAyuda.Size = new System.Drawing.Size(93, 86);
            this.cmdAyuda.TabIndex = 5;
            this.cmdAyuda.Text = "Ayuda";
            this.cmdAyuda.UseVisualStyleBackColor = true;
            this.cmdAyuda.Click += new System.EventHandler(this.cmdAyuda_Click);
            // 
            // Inventario
            // 
            this.Inventario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inventario.Controls.Add(this.tablas);
            this.Inventario.Controls.Add(this.Produccion);
            this.Inventario.Location = new System.Drawing.Point(-1, 122);
            this.Inventario.Margin = new System.Windows.Forms.Padding(4);
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(1069, 432);
            this.Inventario.TabIndex = 5;
            this.Inventario.Visible = false;
            // 
            // tablas
            // 
            this.tablas.Controls.Add(this.tablasIn);
            this.tablas.Location = new System.Drawing.Point(16, 5);
            this.tablas.Margin = new System.Windows.Forms.Padding(4);
            this.tablas.Name = "tablas";
            this.tablas.Padding = new System.Windows.Forms.Padding(4);
            this.tablas.Size = new System.Drawing.Size(812, 421);
            this.tablas.TabIndex = 4;
            this.tablas.TabStop = false;
            this.tablas.Text = "Inventario";
            // 
            // tablasIn
            // 
            this.tablasIn.AllowUserToAddRows = false;
            this.tablasIn.AllowUserToDeleteRows = false;
            this.tablasIn.AllowUserToOrderColumns = true;
            this.tablasIn.AllowUserToResizeColumns = false;
            this.tablasIn.AutoGenerateColumns = false;
            this.tablasIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablasIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablasIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmaterialDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadinicialDataGridViewTextBoxColumn,
            this.stockalertDataGridViewTextBoxColumn,
            this.cantspeedDataGridViewTextBoxColumn,
            this.cantflexDataGridViewTextBoxColumn,
            this.cant360DataGridViewTextBoxColumn,
            this.usuarioregistradoDataGridViewTextBoxColumn});
            this.tablasIn.DataSource = this.materialBindingSource1;
            this.tablasIn.Location = new System.Drawing.Point(11, 23);
            this.tablasIn.Margin = new System.Windows.Forms.Padding(4);
            this.tablasIn.Name = "tablasIn";
            this.tablasIn.ReadOnly = true;
            this.tablasIn.Size = new System.Drawing.Size(793, 388);
            this.tablasIn.TabIndex = 1;
            // 
            // idmaterialDataGridViewTextBoxColumn
            // 
            this.idmaterialDataGridViewTextBoxColumn.DataPropertyName = "idmaterial";
            this.idmaterialDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idmaterialDataGridViewTextBoxColumn.Name = "idmaterialDataGridViewTextBoxColumn";
            this.idmaterialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Material";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadinicialDataGridViewTextBoxColumn
            // 
            this.cantidadinicialDataGridViewTextBoxColumn.DataPropertyName = "cantidad_inicial";
            this.cantidadinicialDataGridViewTextBoxColumn.HeaderText = "cantidad Actual";
            this.cantidadinicialDataGridViewTextBoxColumn.Name = "cantidadinicialDataGridViewTextBoxColumn";
            this.cantidadinicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockalertDataGridViewTextBoxColumn
            // 
            this.stockalertDataGridViewTextBoxColumn.DataPropertyName = "stock_alert";
            this.stockalertDataGridViewTextBoxColumn.HeaderText = "Stock Alert";
            this.stockalertDataGridViewTextBoxColumn.Name = "stockalertDataGridViewTextBoxColumn";
            this.stockalertDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantspeedDataGridViewTextBoxColumn
            // 
            this.cantspeedDataGridViewTextBoxColumn.DataPropertyName = "cant_speed";
            this.cantspeedDataGridViewTextBoxColumn.HeaderText = "Cant. usada en speed";
            this.cantspeedDataGridViewTextBoxColumn.Name = "cantspeedDataGridViewTextBoxColumn";
            this.cantspeedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantflexDataGridViewTextBoxColumn
            // 
            this.cantflexDataGridViewTextBoxColumn.DataPropertyName = "cant_flex";
            this.cantflexDataGridViewTextBoxColumn.HeaderText = "Cant. usada en flex";
            this.cantflexDataGridViewTextBoxColumn.Name = "cantflexDataGridViewTextBoxColumn";
            this.cantflexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cant360DataGridViewTextBoxColumn
            // 
            this.cant360DataGridViewTextBoxColumn.DataPropertyName = "cant_360";
            this.cant360DataGridViewTextBoxColumn.HeaderText = "Cant. usada en 360";
            this.cant360DataGridViewTextBoxColumn.Name = "cant360DataGridViewTextBoxColumn";
            this.cant360DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioregistradoDataGridViewTextBoxColumn
            // 
            this.usuarioregistradoDataGridViewTextBoxColumn.DataPropertyName = "usuario_registrado";
            this.usuarioregistradoDataGridViewTextBoxColumn.HeaderText = "Registrado por";
            this.usuarioregistradoDataGridViewTextBoxColumn.Name = "usuarioregistradoDataGridViewTextBoxColumn";
            this.usuarioregistradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "material";
            this.materialBindingSource1.DataSource = this.inventarioprogramaDataSet1;
            // 
            // inventarioprogramaDataSet1
            // 
            this.inventarioprogramaDataSet1.DataSetName = "inventarioprogramaDataSet1";
            this.inventarioprogramaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Produccion
            // 
            this.Produccion.Controls.Add(this.prod360);
            this.Produccion.Controls.Add(this.prodspeed);
            this.Produccion.Controls.Add(this.prodflex);
            this.Produccion.Controls.Add(this.label3);
            this.Produccion.Controls.Add(this.button5);
            this.Produccion.Controls.Add(this.label2);
            this.Produccion.Controls.Add(this.label1);
            this.Produccion.Location = new System.Drawing.Point(836, 5);
            this.Produccion.Margin = new System.Windows.Forms.Padding(4);
            this.Produccion.Name = "Produccion";
            this.Produccion.Padding = new System.Windows.Forms.Padding(4);
            this.Produccion.Size = new System.Drawing.Size(227, 421);
            this.Produccion.TabIndex = 3;
            this.Produccion.TabStop = false;
            this.Produccion.Text = "Produccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "360";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(11, 249);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 28);
            this.button5.TabIndex = 8;
            this.button5.Text = "Confirmar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flex";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matnuevo360);
            this.groupBox1.Controls.Add(this.matflexnuevo);
            this.groupBox1.Controls.Add(this.matnuevospeed);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.matnuevoalerta);
            this.groupBox1.Controls.Add(this.matnuevocant);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.matnuenom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(623, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material nuevo";
            // 
            // matnuevo360
            // 
            this.matnuevo360.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matnuevo360.Location = new System.Drawing.Point(346, 184);
            this.matnuevo360.Name = "matnuevo360";
            this.matnuevo360.Size = new System.Drawing.Size(61, 28);
            this.matnuevo360.TabIndex = 15;
            // 
            // matflexnuevo
            // 
            this.matflexnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matflexnuevo.Location = new System.Drawing.Point(219, 184);
            this.matflexnuevo.Name = "matflexnuevo";
            this.matflexnuevo.Size = new System.Drawing.Size(61, 28);
            this.matflexnuevo.TabIndex = 14;
            // 
            // matnuevospeed
            // 
            this.matnuevospeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matnuevospeed.Location = new System.Drawing.Point(87, 184);
            this.matnuevospeed.Name = "matnuevospeed";
            this.matnuevospeed.Size = new System.Drawing.Size(61, 28);
            this.matnuevospeed.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(295, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 24);
            this.label17.TabIndex = 12;
            this.label17.Text = "360:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(161, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 24);
            this.label16.TabIndex = 11;
            this.label16.Text = "Flex:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 24);
            this.label15.TabIndex = 10;
            this.label15.Text = "Speed:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Cantidad usada en:";
            // 
            // matnuevoalerta
            // 
            this.matnuevoalerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matnuevoalerta.Location = new System.Drawing.Point(165, 93);
            this.matnuevoalerta.Name = "matnuevoalerta";
            this.matnuevoalerta.Size = new System.Drawing.Size(206, 30);
            this.matnuevoalerta.TabIndex = 8;
            // 
            // matnuevocant
            // 
            this.matnuevocant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matnuevocant.Location = new System.Drawing.Point(165, 57);
            this.matnuevocant.Name = "matnuevocant";
            this.matnuevocant.Size = new System.Drawing.Size(206, 30);
            this.matnuevocant.TabIndex = 7;
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnnuevo.FlatAppearance.BorderSize = 3;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(445, 63);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(133, 57);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "Confirmar";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // matnuenom
            // 
            this.matnuenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matnuenom.Location = new System.Drawing.Point(165, 20);
            this.matnuenom.Margin = new System.Windows.Forms.Padding(4);
            this.matnuenom.Name = "matnuenom";
            this.matnuenom.Size = new System.Drawing.Size(206, 30);
            this.matnuenom.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Stock alert:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cantidad inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combomaterialact);
            this.groupBox2.Controls.Add(this.matactcant);
            this.groupBox2.Controls.Add(this.btnactualizar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(646, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(422, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material nuevo (Existente)";
            // 
            // combomaterialact
            // 
            this.combomaterialact.DataSource = this.materialBindingSource;
            this.combomaterialact.DisplayMember = "nombre";
            this.combomaterialact.FormattingEnabled = true;
            this.combomaterialact.Location = new System.Drawing.Point(130, 27);
            this.combomaterialact.Name = "combomaterialact";
            this.combomaterialact.Size = new System.Drawing.Size(207, 24);
            this.combomaterialact.TabIndex = 6;
            this.combomaterialact.ValueMember = "idmaterial";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.inventarioprogramaDataSet1;
            // 
            // matactcant
            // 
            this.matactcant.Location = new System.Drawing.Point(130, 65);
            this.matactcant.Name = "matactcant";
            this.matactcant.Size = new System.Drawing.Size(207, 22);
            this.matactcant.TabIndex = 6;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(78, 136);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(202, 31);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.Text = "Confirmar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 50);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cantidad a\r\nagregar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mod360);
            this.groupBox3.Controls.Add(this.modflex);
            this.groupBox3.Controls.Add(this.modspeed);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.modmaterialnombre);
            this.groupBox3.Controls.Add(this.matmodalerta);
            this.groupBox3.Controls.Add(this.matmodcantidad);
            this.groupBox3.Controls.Add(this.btnmodificacion);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.matmodnombrenuevo);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(16, 255);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1052, 191);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificacion";
            // 
            // mod360
            // 
            this.mod360.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod360.Location = new System.Drawing.Point(855, 129);
            this.mod360.Name = "mod360";
            this.mod360.Size = new System.Drawing.Size(61, 28);
            this.mod360.TabIndex = 19;
            // 
            // modflex
            // 
            this.modflex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modflex.Location = new System.Drawing.Point(855, 95);
            this.modflex.Name = "modflex";
            this.modflex.Size = new System.Drawing.Size(61, 28);
            this.modflex.TabIndex = 18;
            // 
            // modspeed
            // 
            this.modspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modspeed.Location = new System.Drawing.Point(855, 61);
            this.modspeed.Name = "modspeed";
            this.modspeed.Size = new System.Drawing.Size(61, 28);
            this.modspeed.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(785, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 24);
            this.label19.TabIndex = 16;
            this.label19.Text = "360:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(785, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 24);
            this.label20.TabIndex = 15;
            this.label20.Text = "Flex:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(778, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 24);
            this.label21.TabIndex = 14;
            this.label21.Text = "Speed:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(777, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(240, 25);
            this.label18.TabIndex = 13;
            this.label18.Text = "Nueva cantidad usada en:";
            // 
            // modmaterialnombre
            // 
            this.modmaterialnombre.DataSource = this.materialBindingSource;
            this.modmaterialnombre.DisplayMember = "nombre";
            this.modmaterialnombre.FormattingEnabled = true;
            this.modmaterialnombre.Location = new System.Drawing.Point(196, 33);
            this.modmaterialnombre.Name = "modmaterialnombre";
            this.modmaterialnombre.Size = new System.Drawing.Size(160, 24);
            this.modmaterialnombre.TabIndex = 12;
            this.modmaterialnombre.ValueMember = "idmaterial";
            this.modmaterialnombre.SelectedIndexChanged += new System.EventHandler(this.modmaterialnombre_SelectedIndexChanged);
            // 
            // matmodalerta
            // 
            this.matmodalerta.Location = new System.Drawing.Point(585, 80);
            this.matmodalerta.Name = "matmodalerta";
            this.matmodalerta.Size = new System.Drawing.Size(120, 22);
            this.matmodalerta.TabIndex = 11;
            // 
            // matmodcantidad
            // 
            this.matmodcantidad.Location = new System.Drawing.Point(585, 34);
            this.matmodcantidad.Name = "matmodcantidad";
            this.matmodcantidad.Size = new System.Drawing.Size(120, 22);
            this.matmodcantidad.TabIndex = 10;
            // 
            // btnmodificacion
            // 
            this.btnmodificacion.Location = new System.Drawing.Point(453, 146);
            this.btnmodificacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificacion.Name = "btnmodificacion";
            this.btnmodificacion.Size = new System.Drawing.Size(133, 31);
            this.btnmodificacion.TabIndex = 9;
            this.btnmodificacion.Text = "Confirmar";
            this.btnmodificacion.UseVisualStyleBackColor = true;
            this.btnmodificacion.Click += new System.EventHandler(this.btnmodificacion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(403, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Nuevo Stock Alert:";
            // 
            // matmodnombrenuevo
            // 
            this.matmodnombrenuevo.Location = new System.Drawing.Point(196, 75);
            this.matmodnombrenuevo.Margin = new System.Windows.Forms.Padding(4);
            this.matmodnombrenuevo.Name = "matmodnombrenuevo";
            this.matmodnombrenuevo.Size = new System.Drawing.Size(160, 22);
            this.matmodnombrenuevo.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nueva cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nuevo nombre:";
            // 
            // Material
            // 
            this.Material.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Material.Controls.Add(this.groupBox3);
            this.Material.Controls.Add(this.groupBox2);
            this.Material.Controls.Add(this.groupBox1);
            this.Material.Location = new System.Drawing.Point(0, 122);
            this.Material.Margin = new System.Windows.Forms.Padding(4);
            this.Material.MaximumSize = new System.Drawing.Size(1096, 450);
            this.Material.MinimumSize = new System.Drawing.Size(1096, 450);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(1096, 450);
            this.Material.TabIndex = 6;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.materialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // prodflex
            // 
            this.prodflex.Location = new System.Drawing.Point(12, 53);
            this.prodflex.Name = "prodflex";
            this.prodflex.Size = new System.Drawing.Size(120, 22);
            this.prodflex.TabIndex = 10;
            // 
            // prodspeed
            // 
            this.prodspeed.Location = new System.Drawing.Point(12, 120);
            this.prodspeed.Name = "prodspeed";
            this.prodspeed.Size = new System.Drawing.Size(120, 22);
            this.prodspeed.TabIndex = 11;
            // 
            // prod360
            // 
            this.prod360.Location = new System.Drawing.Point(12, 188);
            this.prod360.Name = "prod360";
            this.prod360.Size = new System.Drawing.Size(120, 22);
            this.prod360.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.Inventario);
            this.Controls.Add(this.Material);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Inventario Helmets & Stuff";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.Inventario.ResumeLayout(false);
            this.tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablasIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioprogramaDataSet1)).EndInit();
            this.Produccion.ResumeLayout(false);
            this.Produccion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matnuevo360)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matflexnuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matnuevospeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matnuevoalerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matnuevocant)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matactcant)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mod360)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modflex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matmodalerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matmodcantidad)).EndInit();
            this.Material.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodflex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod360)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdInventario;
        private System.Windows.Forms.Button cmdMaterial;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button cmdAyuda;
        private System.Windows.Forms.Panel Inventario;
        private System.Windows.Forms.GroupBox tablas;
        private System.Windows.Forms.DataGridView tablasIn;
        private System.Windows.Forms.GroupBox Produccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown matnuevo360;
        private System.Windows.Forms.NumericUpDown matflexnuevo;
        private System.Windows.Forms.NumericUpDown matnuevospeed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown matnuevoalerta;
        private System.Windows.Forms.NumericUpDown matnuevocant;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox matnuenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown matactcant;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown matmodalerta;
        private System.Windows.Forms.NumericUpDown matmodcantidad;
        private System.Windows.Forms.Button btnmodificacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox matmodnombrenuevo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel Material;
        private inventarioprogramaDataSet1 inventarioprogramaDataSet1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private inventarioprogramaDataSet1TableAdapters.materialTableAdapter materialTableAdapter;
        private inventarioprogramaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox combomaterialact;
        private System.Windows.Forms.ComboBox modmaterialnombre;
        private System.Windows.Forms.NumericUpDown mod360;
        private System.Windows.Forms.NumericUpDown modflex;
        private System.Windows.Forms.NumericUpDown modspeed;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadinicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockalertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantflexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant360DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioregistradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materialBindingSource1;
        private System.Windows.Forms.NumericUpDown prod360;
        private System.Windows.Forms.NumericUpDown prodspeed;
        private System.Windows.Forms.NumericUpDown prodflex;
    }
}

