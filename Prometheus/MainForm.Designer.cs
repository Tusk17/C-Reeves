namespace LearnKode
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.lkode = new System.Windows.Forms.Label();
            this.lLearn = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.lineaEstado = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panelTodo = new System.Windows.Forms.Panel();
            this.labelSemantico = new System.Windows.Forms.Label();
            this.labelSintactico = new System.Windows.Forms.Label();
            this.dgvLexer = new System.Windows.Forms.DataGridView();
            this.token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSemanticResult = new System.Windows.Forms.TextBox();
            this.tbSintaxResult = new System.Windows.Forms.TextBox();
            this.consoleControl1 = new ConsoleControl.ConsoleControl();
            this.imgErrorSemantico = new System.Windows.Forms.PictureBox();
            this.imgComienza = new System.Windows.Forms.PictureBox();
            this.imgError = new System.Windows.Forms.PictureBox();
            this.imgCorrecto = new System.Windows.Forms.PictureBox();
            this.labelConsola = new System.Windows.Forms.Label();
            this.tbCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.lineaEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panelTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrorSemantico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComienza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.lkode);
            this.panel1.Controls.Add(this.lLearn);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBoxMin);
            this.panel1.Controls.Add(this.pictureBoxMax);
            this.panel1.Controls.Add(this.pictureBoxCerrar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnNewFile);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnParse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 65);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(218, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ejecutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Borrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Abrir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nuevo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.GhostWhite;
            this.rjButton1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 22;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.DimGray;
            this.rjButton1.Location = new System.Drawing.Point(823, 9);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 22;
            this.rjButton1.Text = "Evaluar";
            this.rjButton1.TextColor = System.Drawing.Color.DimGray;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // lkode
            // 
            this.lkode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkode.AutoSize = true;
            this.lkode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lkode.Location = new System.Drawing.Point(573, 18);
            this.lkode.Name = "lkode";
            this.lkode.Size = new System.Drawing.Size(69, 20);
            this.lkode.TabIndex = 19;
            this.lkode.Text = "Reeves";
            // 
            // lLearn
            // 
            this.lLearn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lLearn.AutoSize = true;
            this.lLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLearn.ForeColor = System.Drawing.Color.White;
            this.lLearn.Location = new System.Drawing.Point(468, 18);
            this.lLearn.Name = "lLearn";
            this.lLearn.Size = new System.Drawing.Size(99, 20);
            this.lLearn.TabIndex = 18;
            this.lLearn.Text = "Compilador";
            this.lLearn.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(174, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMin.Image")));
            this.pictureBoxMin.Location = new System.Drawing.Point(1000, 26);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(30, 12);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMin.TabIndex = 8;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMax.Image")));
            this.pictureBoxMax.Location = new System.Drawing.Point(1036, 14);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(30, 24);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMax.TabIndex = 7;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(1072, 14);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(30, 24);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCerrar.TabIndex = 6;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::LearnKode.Properties.Resources.logo3d;
            this.pictureBox2.Location = new System.Drawing.Point(13, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewFile.BackgroundImage")));
            this.btnNewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewFile.FlatAppearance.BorderSize = 0;
            this.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFile.Location = new System.Drawing.Point(78, 11);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(30, 30);
            this.btnNewFile.TabIndex = 2;
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.BackgroundImage")));
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(124, 11);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(30, 30);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnParse
            // 
            this.btnParse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnParse.BackgroundImage")));
            this.btnParse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParse.FlatAppearance.BorderSize = 0;
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.Location = new System.Drawing.Point(221, 11);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(30, 30);
            this.btnParse.TabIndex = 4;
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // lineaEstado
            // 
            this.lineaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineaEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(2)))));
            this.lineaEstado.Controls.Add(this.pictureBox7);
            this.lineaEstado.Controls.Add(this.pictureBox8);
            this.lineaEstado.Controls.Add(this.pictureBox9);
            this.lineaEstado.Location = new System.Drawing.Point(0, 13);
            this.lineaEstado.Name = "lineaEstado";
            this.lineaEstado.Size = new System.Drawing.Size(1119, 8);
            this.lineaEstado.TabIndex = 10;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::LearnKode.Properties.Resources.minus_solid;
            this.pictureBox7.Location = new System.Drawing.Point(1003, 26);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 12);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::LearnKode.Properties.Resources.window_maximize_regular;
            this.pictureBox8.Location = new System.Drawing.Point(1039, 14);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::LearnKode.Properties.Resources.times_solid__1_;
            this.pictureBox9.Location = new System.Drawing.Point(1075, 14);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            // 
            // panelTodo
            // 
            this.panelTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(174)))));
            this.panelTodo.Controls.Add(this.labelSemantico);
            this.panelTodo.Controls.Add(this.lineaEstado);
            this.panelTodo.Controls.Add(this.labelSintactico);
            this.panelTodo.Controls.Add(this.dgvLexer);
            this.panelTodo.Controls.Add(this.tbSemanticResult);
            this.panelTodo.Controls.Add(this.tbSintaxResult);
            this.panelTodo.Controls.Add(this.consoleControl1);
            this.panelTodo.Controls.Add(this.imgErrorSemantico);
            this.panelTodo.Controls.Add(this.imgComienza);
            this.panelTodo.Controls.Add(this.imgError);
            this.panelTodo.Controls.Add(this.imgCorrecto);
            this.panelTodo.Controls.Add(this.labelConsola);
            this.panelTodo.Controls.Add(this.tbCode);
            this.panelTodo.Location = new System.Drawing.Point(-1, 53);
            this.panelTodo.Name = "panelTodo";
            this.panelTodo.Size = new System.Drawing.Size(1119, 605);
            this.panelTodo.TabIndex = 11;
            // 
            // labelSemantico
            // 
            this.labelSemantico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSemantico.AutoSize = true;
            this.labelSemantico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemantico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.labelSemantico.Location = new System.Drawing.Point(734, 201);
            this.labelSemantico.Name = "labelSemantico";
            this.labelSemantico.Size = new System.Drawing.Size(85, 16);
            this.labelSemantico.TabIndex = 29;
            this.labelSemantico.Text = "Semántico:";
            // 
            // labelSintactico
            // 
            this.labelSintactico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSintactico.AutoSize = true;
            this.labelSintactico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSintactico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.labelSintactico.Location = new System.Drawing.Point(735, 295);
            this.labelSintactico.Name = "labelSintactico";
            this.labelSintactico.Size = new System.Drawing.Size(80, 16);
            this.labelSintactico.TabIndex = 28;
            this.labelSintactico.Text = "Sintáctico:";
            // 
            // dgvLexer
            // 
            this.dgvLexer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLexer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLexer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLexer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvLexer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLexer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLexer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLexer.ColumnHeadersHeight = 25;
            this.dgvLexer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.token,
            this.Lexema,
            this.Linea,
            this.Columna});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLexer.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLexer.EnableHeadersVisualStyles = false;
            this.dgvLexer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.dgvLexer.Location = new System.Drawing.Point(736, 23);
            this.dgvLexer.MultiSelect = false;
            this.dgvLexer.Name = "dgvLexer";
            this.dgvLexer.ReadOnly = true;
            this.dgvLexer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLexer.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLexer.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvLexer.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLexer.Size = new System.Drawing.Size(372, 174);
            this.dgvLexer.TabIndex = 19;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.MinimumWidth = 6;
            this.token.Name = "token";
            this.token.ReadOnly = true;
            this.token.Width = 61;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.MinimumWidth = 6;
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            this.Lexema.Width = 67;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Línea";
            this.Linea.MinimumWidth = 6;
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Width = 58;
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.MinimumWidth = 6;
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            this.Columna.Width = 71;
            // 
            // tbSemanticResult
            // 
            this.tbSemanticResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSemanticResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.tbSemanticResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSemanticResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSemanticResult.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSemanticResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSemanticResult.Location = new System.Drawing.Point(736, 219);
            this.tbSemanticResult.Multiline = true;
            this.tbSemanticResult.Name = "tbSemanticResult";
            this.tbSemanticResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSemanticResult.Size = new System.Drawing.Size(372, 70);
            this.tbSemanticResult.TabIndex = 20;
            // 
            // tbSintaxResult
            // 
            this.tbSintaxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSintaxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.tbSintaxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSintaxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSintaxResult.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSintaxResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSintaxResult.Location = new System.Drawing.Point(736, 313);
            this.tbSintaxResult.Multiline = true;
            this.tbSintaxResult.Name = "tbSintaxResult";
            this.tbSintaxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSintaxResult.Size = new System.Drawing.Size(372, 111);
            this.tbSintaxResult.TabIndex = 18;
            // 
            // consoleControl1
            // 
            this.consoleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleControl1.BackColor = System.Drawing.Color.Black;
            this.consoleControl1.IsInputEnabled = true;
            this.consoleControl1.Location = new System.Drawing.Point(16, 434);
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.SendKeyboardCommandsToProcess = false;
            this.consoleControl1.ShowDiagnostics = true;
            this.consoleControl1.Size = new System.Drawing.Size(702, 148);
            this.consoleControl1.TabIndex = 27;
            // 
            // imgErrorSemantico
            // 
            this.imgErrorSemantico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgErrorSemantico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgErrorSemantico.Image = ((System.Drawing.Image)(resources.GetObject("imgErrorSemantico.Image")));
            this.imgErrorSemantico.Location = new System.Drawing.Point(794, 442);
            this.imgErrorSemantico.Name = "imgErrorSemantico";
            this.imgErrorSemantico.Size = new System.Drawing.Size(298, 140);
            this.imgErrorSemantico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgErrorSemantico.TabIndex = 26;
            this.imgErrorSemantico.TabStop = false;
            this.imgErrorSemantico.Click += new System.EventHandler(this.imgErrorSemantico_Click);
            // 
            // imgComienza
            // 
            this.imgComienza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgComienza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgComienza.Image = global::LearnKode.Properties.Resources.comenzar;
            this.imgComienza.Location = new System.Drawing.Point(795, 442);
            this.imgComienza.Name = "imgComienza";
            this.imgComienza.Size = new System.Drawing.Size(297, 140);
            this.imgComienza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgComienza.TabIndex = 25;
            this.imgComienza.TabStop = false;
            // 
            // imgError
            // 
            this.imgError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgError.Image = ((System.Drawing.Image)(resources.GetObject("imgError.Image")));
            this.imgError.Location = new System.Drawing.Point(795, 442);
            this.imgError.Name = "imgError";
            this.imgError.Size = new System.Drawing.Size(297, 140);
            this.imgError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgError.TabIndex = 24;
            this.imgError.TabStop = false;
            this.imgError.Click += new System.EventHandler(this.imgError_Click);
            // 
            // imgCorrecto
            // 
            this.imgCorrecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCorrecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("imgCorrecto.Image")));
            this.imgCorrecto.Location = new System.Drawing.Point(795, 442);
            this.imgCorrecto.Name = "imgCorrecto";
            this.imgCorrecto.Size = new System.Drawing.Size(297, 140);
            this.imgCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCorrecto.TabIndex = 23;
            this.imgCorrecto.TabStop = false;
            // 
            // labelConsola
            // 
            this.labelConsola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConsola.AutoSize = true;
            this.labelConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.labelConsola.Location = new System.Drawing.Point(11, 415);
            this.labelConsola.Name = "labelConsola";
            this.labelConsola.Size = new System.Drawing.Size(69, 16);
            this.labelConsola.TabIndex = 22;
            this.labelConsola.Text = "Consola:";
            // 
            // tbCode
            // 
            this.tbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbCode.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);";
            this.tbCode.AutoScrollMinSize = new System.Drawing.Size(35, 24);
            this.tbCode.BackBrush = null;
            this.tbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.tbCode.CharHeight = 24;
            this.tbCode.CharWidth = 12;
            this.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbCode.FoldingIndicatorColor = System.Drawing.Color.Orange;
            this.tbCode.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.tbCode.ForeColor = System.Drawing.Color.White;
            this.tbCode.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.tbCode.IsReplaceMode = false;
            this.tbCode.LineNumberColor = System.Drawing.Color.White;
            this.tbCode.Location = new System.Drawing.Point(16, 24);
            this.tbCode.Name = "tbCode";
            this.tbCode.Paddings = new System.Windows.Forms.Padding(0);
            this.tbCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.tbCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbCode.ServiceColors")));
            this.tbCode.Size = new System.Drawing.Size(702, 343);
            this.tbCode.TabIndex = 21;
            this.tbCode.Zoom = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1116, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTodo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compilador Reeves";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.lineaEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panelTodo.ResumeLayout(false);
            this.panelTodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrorSemantico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComienza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel lineaEstado;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lLearn;
        private System.Windows.Forms.Label lkode;
        private System.Windows.Forms.Panel panelTodo;
        private System.Windows.Forms.Label labelSemantico;
        private System.Windows.Forms.Label labelSintactico;
        private System.Windows.Forms.DataGridView dgvLexer;
        private System.Windows.Forms.DataGridViewTextBoxColumn token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.TextBox tbSemanticResult;
        private System.Windows.Forms.TextBox tbSintaxResult;
        private ConsoleControl.ConsoleControl consoleControl1;
        private System.Windows.Forms.PictureBox imgErrorSemantico;
        private System.Windows.Forms.PictureBox imgComienza;
        private System.Windows.Forms.PictureBox imgError;
        private System.Windows.Forms.PictureBox imgCorrecto;
        private System.Windows.Forms.Label labelConsola;
        private FastColoredTextBoxNS.FastColoredTextBox tbCode;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}