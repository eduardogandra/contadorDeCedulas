namespace contadorDeCedulas
{
    partial class frmContador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContador));
            this.txtTotalGeral = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txtQtdeN2 = new System.Windows.Forms.TextBox();
            this.txtTotalN2 = new System.Windows.Forms.Label();
            this.lblN5 = new System.Windows.Forms.Label();
            this.txtQtdeN5 = new System.Windows.Forms.TextBox();
            this.txtTotalN5 = new System.Windows.Forms.Label();
            this.lblN10 = new System.Windows.Forms.Label();
            this.txtQtdeN10 = new System.Windows.Forms.TextBox();
            this.txtTotalN10 = new System.Windows.Forms.Label();
            this.lblN20 = new System.Windows.Forms.Label();
            this.txtQtdeN20 = new System.Windows.Forms.TextBox();
            this.txtTotalN20 = new System.Windows.Forms.Label();
            this.lblN50 = new System.Windows.Forms.Label();
            this.txtQtdeN50 = new System.Windows.Forms.TextBox();
            this.txtTotalN50 = new System.Windows.Forms.Label();
            this.lblN100 = new System.Windows.Forms.Label();
            this.txtQtdeN100 = new System.Windows.Forms.TextBox();
            this.txtTotalN100 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbNotas = new System.Windows.Forms.GroupBox();
            this.lblM5 = new System.Windows.Forms.Label();
            this.txtM5 = new System.Windows.Forms.TextBox();
            this.txtTotalM5 = new System.Windows.Forms.Label();
            this.lblM10 = new System.Windows.Forms.Label();
            this.txtM10 = new System.Windows.Forms.TextBox();
            this.txtTotalM10 = new System.Windows.Forms.Label();
            this.lblM25 = new System.Windows.Forms.Label();
            this.txtM25 = new System.Windows.Forms.TextBox();
            this.txtTotalM25 = new System.Windows.Forms.Label();
            this.lblM50 = new System.Windows.Forms.Label();
            this.txtM50 = new System.Windows.Forms.TextBox();
            this.txtTotalM50 = new System.Windows.Forms.Label();
            this.lblM1 = new System.Windows.Forms.Label();
            this.txtM1 = new System.Windows.Forms.TextBox();
            this.txtTotalM1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbMoedas = new System.Windows.Forms.GroupBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbTotal.SuspendLayout();
            this.gpbNotas.SuspendLayout();
            this.gpbMoedas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.BackColor = System.Drawing.Color.White;
            this.txtTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalGeral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.Location = new System.Drawing.Point(9, 16);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(193, 41);
            this.txtTotalGeral.TabIndex = 5;
            this.txtTotalGeral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(65, 61);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(84, 23);
            this.btnCopiar.TabIndex = 24;
            this.btnCopiar.Text = "&Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // gpbTotal
            // 
            this.gpbTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gpbTotal.Controls.Add(this.btnCopiar);
            this.gpbTotal.Controls.Add(this.txtTotalGeral);
            this.gpbTotal.Location = new System.Drawing.Point(122, 201);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(212, 91);
            this.gpbTotal.TabIndex = 22;
            this.gpbTotal.TabStop = false;
            this.gpbTotal.Text = "Total Geral";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(10, 32);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(48, 13);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "R$ 2,00:";
            // 
            // txtQtdeN2
            // 
            this.txtQtdeN2.Location = new System.Drawing.Point(65, 29);
            this.txtQtdeN2.MaxLength = 8;
            this.txtQtdeN2.Name = "txtQtdeN2";
            this.txtQtdeN2.Size = new System.Drawing.Size(61, 20);
            this.txtQtdeN2.TabIndex = 3;
            this.txtQtdeN2.Click += new System.EventHandler(this.txtQtdeN2_Click);
            this.txtQtdeN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeN2_KeyPress);
            this.txtQtdeN2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeN2_KeyUp);
            // 
            // txtTotalN2
            // 
            this.txtTotalN2.BackColor = System.Drawing.Color.White;
            this.txtTotalN2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalN2.Location = new System.Drawing.Point(136, 31);
            this.txtTotalN2.Name = "txtTotalN2";
            this.txtTotalN2.Size = new System.Drawing.Size(64, 17);
            this.txtTotalN2.TabIndex = 4;
            this.txtTotalN2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblN5
            // 
            this.lblN5.AutoSize = true;
            this.lblN5.Location = new System.Drawing.Point(10, 58);
            this.lblN5.Name = "lblN5";
            this.lblN5.Size = new System.Drawing.Size(48, 13);
            this.lblN5.TabIndex = 5;
            this.lblN5.Text = "R$ 5,00:";
            // 
            // txtQtdeN5
            // 
            this.txtQtdeN5.Location = new System.Drawing.Point(65, 55);
            this.txtQtdeN5.MaxLength = 8;
            this.txtQtdeN5.Name = "txtQtdeN5";
            this.txtQtdeN5.Size = new System.Drawing.Size(61, 20);
            this.txtQtdeN5.TabIndex = 6;
            this.txtQtdeN5.Click += new System.EventHandler(this.txtQtdeN5_Click);
            this.txtQtdeN5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeN5_KeyPress);
            this.txtQtdeN5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeN5_KeyUp);
            // 
            // txtTotalN5
            // 
            this.txtTotalN5.BackColor = System.Drawing.Color.White;
            this.txtTotalN5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalN5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalN5.Location = new System.Drawing.Point(136, 57);
            this.txtTotalN5.Name = "txtTotalN5";
            this.txtTotalN5.Size = new System.Drawing.Size(64, 17);
            this.txtTotalN5.TabIndex = 7;
            this.txtTotalN5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblN10
            // 
            this.lblN10.AutoSize = true;
            this.lblN10.Location = new System.Drawing.Point(10, 84);
            this.lblN10.Name = "lblN10";
            this.lblN10.Size = new System.Drawing.Size(54, 13);
            this.lblN10.TabIndex = 8;
            this.lblN10.Text = "R$ 10,00:";
            // 
            // txtQtdeN10
            // 
            this.txtQtdeN10.Location = new System.Drawing.Point(65, 81);
            this.txtQtdeN10.MaxLength = 8;
            this.txtQtdeN10.Name = "txtQtdeN10";
            this.txtQtdeN10.Size = new System.Drawing.Size(61, 20);
            this.txtQtdeN10.TabIndex = 9;
            this.txtQtdeN10.Click += new System.EventHandler(this.txtQtdeN10_Click);
            this.txtQtdeN10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeN10_KeyPress);
            this.txtQtdeN10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeN10_KeyUp);
            // 
            // txtTotalN10
            // 
            this.txtTotalN10.BackColor = System.Drawing.Color.White;
            this.txtTotalN10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalN10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalN10.Location = new System.Drawing.Point(136, 83);
            this.txtTotalN10.Name = "txtTotalN10";
            this.txtTotalN10.Size = new System.Drawing.Size(64, 17);
            this.txtTotalN10.TabIndex = 10;
            this.txtTotalN10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblN20
            // 
            this.lblN20.AutoSize = true;
            this.lblN20.Location = new System.Drawing.Point(10, 110);
            this.lblN20.Name = "lblN20";
            this.lblN20.Size = new System.Drawing.Size(54, 13);
            this.lblN20.TabIndex = 11;
            this.lblN20.Text = "R$ 20,00:";
            // 
            // txtQtdeN20
            // 
            this.txtQtdeN20.Location = new System.Drawing.Point(65, 107);
            this.txtQtdeN20.MaxLength = 8;
            this.txtQtdeN20.Name = "txtQtdeN20";
            this.txtQtdeN20.Size = new System.Drawing.Size(61, 20);
            this.txtQtdeN20.TabIndex = 12;
            this.txtQtdeN20.Click += new System.EventHandler(this.txtQtdeN20_Click);
            this.txtQtdeN20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeN20_KeyPress);
            this.txtQtdeN20.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeN20_KeyUp);
            // 
            // txtTotalN20
            // 
            this.txtTotalN20.BackColor = System.Drawing.Color.White;
            this.txtTotalN20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalN20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalN20.Location = new System.Drawing.Point(136, 109);
            this.txtTotalN20.Name = "txtTotalN20";
            this.txtTotalN20.Size = new System.Drawing.Size(64, 17);
            this.txtTotalN20.TabIndex = 13;
            this.txtTotalN20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblN50
            // 
            this.lblN50.AutoSize = true;
            this.lblN50.Location = new System.Drawing.Point(10, 136);
            this.lblN50.Name = "lblN50";
            this.lblN50.Size = new System.Drawing.Size(54, 13);
            this.lblN50.TabIndex = 14;
            this.lblN50.Text = "R$ 50,00:";
            // 
            // txtQtdeN50
            // 
            this.txtQtdeN50.Location = new System.Drawing.Point(65, 133);
            this.txtQtdeN50.MaxLength = 8;
            this.txtQtdeN50.Name = "txtQtdeN50";
            this.txtQtdeN50.Size = new System.Drawing.Size(61, 20);
            this.txtQtdeN50.TabIndex = 15;
            this.txtQtdeN50.Click += new System.EventHandler(this.txtQtdeN50_Click);
            this.txtQtdeN50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeN50_KeyPress);
            this.txtQtdeN50.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeN50_KeyUp);
            // 
            // txtTotalN50
            // 
            this.txtTotalN50.BackColor = System.Drawing.Color.White;
            this.txtTotalN50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalN50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalN50.Location = new System.Drawing.Point(136, 135);
            this.txtTotalN50.Name = "txtTotalN50";
            this.txtTotalN50.Size = new System.Drawing.Size(64, 17);
            this.txtTotalN50.TabIndex = 16;
            this.txtTotalN50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblN100
            // 
            this.lblN100.AutoSize = true;
            this.lblN100.Location = new System.Drawing.Point(4, 162);
            this.lblN100.Name = "lblN100";
            this.lblN100.Size = new System.Drawing.Size(60, 13);
            this.lblN100.TabIndex = 17;
            this.lblN100.Text = "R$ 100,00:";
            // 
            // txtQtdeN100
            // 
            this.txtQtdeN100.Location = new System.Drawing.Point(65, 159);
            this.txtQtdeN100.MaxLength = 8;
            this.txtQtdeN100.Name = "txtQtdeN100";
            this.txtQtdeN100.Size = new System.Drawing.Size(61, 20);
            this.txtQtdeN100.TabIndex = 18;
            this.txtQtdeN100.Click += new System.EventHandler(this.txtQtdeN100_Click);
            this.txtQtdeN100.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeN100_KeyPress);
            this.txtQtdeN100.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeN100_KeyUp);
            // 
            // txtTotalN100
            // 
            this.txtTotalN100.BackColor = System.Drawing.Color.White;
            this.txtTotalN100.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalN100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalN100.Location = new System.Drawing.Point(136, 161);
            this.txtTotalN100.Name = "txtTotalN100";
            this.txtTotalN100.Size = new System.Drawing.Size(64, 17);
            this.txtTotalN100.TabIndex = 19;
            this.txtTotalN100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total:";
            // 
            // gpbNotas
            // 
            this.gpbNotas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpbNotas.Controls.Add(this.label2);
            this.gpbNotas.Controls.Add(this.label1);
            this.gpbNotas.Controls.Add(this.txtTotalN100);
            this.gpbNotas.Controls.Add(this.txtQtdeN100);
            this.gpbNotas.Controls.Add(this.lblN100);
            this.gpbNotas.Controls.Add(this.txtTotalN50);
            this.gpbNotas.Controls.Add(this.txtQtdeN50);
            this.gpbNotas.Controls.Add(this.lblN50);
            this.gpbNotas.Controls.Add(this.txtTotalN20);
            this.gpbNotas.Controls.Add(this.txtQtdeN20);
            this.gpbNotas.Controls.Add(this.lblN20);
            this.gpbNotas.Controls.Add(this.txtTotalN10);
            this.gpbNotas.Controls.Add(this.txtQtdeN10);
            this.gpbNotas.Controls.Add(this.lblN10);
            this.gpbNotas.Controls.Add(this.txtTotalN5);
            this.gpbNotas.Controls.Add(this.txtQtdeN5);
            this.gpbNotas.Controls.Add(this.lblN5);
            this.gpbNotas.Controls.Add(this.txtTotalN2);
            this.gpbNotas.Controls.Add(this.txtQtdeN2);
            this.gpbNotas.Controls.Add(this.lblN2);
            this.gpbNotas.Location = new System.Drawing.Point(13, 8);
            this.gpbNotas.Name = "gpbNotas";
            this.gpbNotas.Size = new System.Drawing.Size(212, 187);
            this.gpbNotas.TabIndex = 1;
            this.gpbNotas.TabStop = false;
            this.gpbNotas.Text = "Notas";
            // 
            // lblM5
            // 
            this.lblM5.AutoSize = true;
            this.lblM5.Location = new System.Drawing.Point(10, 29);
            this.lblM5.Name = "lblM5";
            this.lblM5.Size = new System.Drawing.Size(48, 13);
            this.lblM5.TabIndex = 2;
            this.lblM5.Text = "R$ 0,05:";
            // 
            // txtM5
            // 
            this.txtM5.Location = new System.Drawing.Point(65, 26);
            this.txtM5.MaxLength = 8;
            this.txtM5.Name = "txtM5";
            this.txtM5.Size = new System.Drawing.Size(61, 20);
            this.txtM5.TabIndex = 3;
            this.txtM5.Click += new System.EventHandler(this.txtM5_Click);
            this.txtM5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM5_KeyPress);
            this.txtM5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtM5_KeyUp);
            // 
            // txtTotalM5
            // 
            this.txtTotalM5.BackColor = System.Drawing.Color.White;
            this.txtTotalM5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalM5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalM5.Location = new System.Drawing.Point(136, 28);
            this.txtTotalM5.Name = "txtTotalM5";
            this.txtTotalM5.Size = new System.Drawing.Size(64, 17);
            this.txtTotalM5.TabIndex = 4;
            this.txtTotalM5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblM10
            // 
            this.lblM10.AutoSize = true;
            this.lblM10.Location = new System.Drawing.Point(10, 55);
            this.lblM10.Name = "lblM10";
            this.lblM10.Size = new System.Drawing.Size(48, 13);
            this.lblM10.TabIndex = 5;
            this.lblM10.Text = "R$ 0,10:";
            // 
            // txtM10
            // 
            this.txtM10.Location = new System.Drawing.Point(65, 52);
            this.txtM10.MaxLength = 8;
            this.txtM10.Name = "txtM10";
            this.txtM10.Size = new System.Drawing.Size(61, 20);
            this.txtM10.TabIndex = 6;
            this.txtM10.Click += new System.EventHandler(this.txtM10_Click);
            this.txtM10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM10_KeyPress);
            this.txtM10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtM10_KeyUp);
            // 
            // txtTotalM10
            // 
            this.txtTotalM10.BackColor = System.Drawing.Color.White;
            this.txtTotalM10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalM10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalM10.Location = new System.Drawing.Point(136, 54);
            this.txtTotalM10.Name = "txtTotalM10";
            this.txtTotalM10.Size = new System.Drawing.Size(64, 17);
            this.txtTotalM10.TabIndex = 7;
            this.txtTotalM10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblM25
            // 
            this.lblM25.AutoSize = true;
            this.lblM25.Location = new System.Drawing.Point(10, 81);
            this.lblM25.Name = "lblM25";
            this.lblM25.Size = new System.Drawing.Size(45, 13);
            this.lblM25.TabIndex = 8;
            this.lblM25.Text = "R$ 0,25";
            // 
            // txtM25
            // 
            this.txtM25.Location = new System.Drawing.Point(65, 78);
            this.txtM25.MaxLength = 8;
            this.txtM25.Name = "txtM25";
            this.txtM25.Size = new System.Drawing.Size(61, 20);
            this.txtM25.TabIndex = 9;
            this.txtM25.Click += new System.EventHandler(this.txtM25_Click);
            this.txtM25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM25_KeyPress);
            this.txtM25.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtM25_KeyUp);
            // 
            // txtTotalM25
            // 
            this.txtTotalM25.BackColor = System.Drawing.Color.White;
            this.txtTotalM25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalM25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalM25.Location = new System.Drawing.Point(136, 80);
            this.txtTotalM25.Name = "txtTotalM25";
            this.txtTotalM25.Size = new System.Drawing.Size(64, 17);
            this.txtTotalM25.TabIndex = 10;
            this.txtTotalM25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblM50
            // 
            this.lblM50.AutoSize = true;
            this.lblM50.Location = new System.Drawing.Point(10, 107);
            this.lblM50.Name = "lblM50";
            this.lblM50.Size = new System.Drawing.Size(48, 13);
            this.lblM50.TabIndex = 11;
            this.lblM50.Text = "R$ 0,50:";
            // 
            // txtM50
            // 
            this.txtM50.Location = new System.Drawing.Point(65, 104);
            this.txtM50.MaxLength = 8;
            this.txtM50.Name = "txtM50";
            this.txtM50.Size = new System.Drawing.Size(61, 20);
            this.txtM50.TabIndex = 12;
            this.txtM50.Click += new System.EventHandler(this.txtM50_Click);
            this.txtM50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM50_KeyPress);
            this.txtM50.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtM50_KeyUp);
            // 
            // txtTotalM50
            // 
            this.txtTotalM50.BackColor = System.Drawing.Color.White;
            this.txtTotalM50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalM50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalM50.Location = new System.Drawing.Point(136, 106);
            this.txtTotalM50.Name = "txtTotalM50";
            this.txtTotalM50.Size = new System.Drawing.Size(64, 17);
            this.txtTotalM50.TabIndex = 13;
            this.txtTotalM50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblM1
            // 
            this.lblM1.AutoSize = true;
            this.lblM1.Location = new System.Drawing.Point(10, 133);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(45, 13);
            this.lblM1.TabIndex = 14;
            this.lblM1.Text = "R$ 1,00";
            // 
            // txtM1
            // 
            this.txtM1.Location = new System.Drawing.Point(65, 130);
            this.txtM1.MaxLength = 8;
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(61, 20);
            this.txtM1.TabIndex = 15;
            this.txtM1.Click += new System.EventHandler(this.txtM1_Click);
            this.txtM1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM1_KeyPress);
            this.txtM1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtM1_KeyUp);
            // 
            // txtTotalM1
            // 
            this.txtTotalM1.BackColor = System.Drawing.Color.White;
            this.txtTotalM1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotalM1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTotalM1.Location = new System.Drawing.Point(136, 132);
            this.txtTotalM1.Name = "txtTotalM1";
            this.txtTotalM1.Size = new System.Drawing.Size(64, 17);
            this.txtTotalM1.TabIndex = 16;
            this.txtTotalM1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total:";
            // 
            // gpbMoedas
            // 
            this.gpbMoedas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpbMoedas.Controls.Add(this.label3);
            this.gpbMoedas.Controls.Add(this.label4);
            this.gpbMoedas.Controls.Add(this.txtTotalM1);
            this.gpbMoedas.Controls.Add(this.txtM1);
            this.gpbMoedas.Controls.Add(this.lblM1);
            this.gpbMoedas.Controls.Add(this.txtTotalM50);
            this.gpbMoedas.Controls.Add(this.txtM50);
            this.gpbMoedas.Controls.Add(this.lblM50);
            this.gpbMoedas.Controls.Add(this.txtTotalM25);
            this.gpbMoedas.Controls.Add(this.txtM25);
            this.gpbMoedas.Controls.Add(this.lblM25);
            this.gpbMoedas.Controls.Add(this.txtTotalM10);
            this.gpbMoedas.Controls.Add(this.txtM10);
            this.gpbMoedas.Controls.Add(this.lblM10);
            this.gpbMoedas.Controls.Add(this.txtTotalM5);
            this.gpbMoedas.Controls.Add(this.txtM5);
            this.gpbMoedas.Controls.Add(this.lblM5);
            this.gpbMoedas.Location = new System.Drawing.Point(231, 8);
            this.gpbMoedas.Name = "gpbMoedas";
            this.gpbMoedas.Size = new System.Drawing.Size(212, 158);
            this.gpbMoedas.TabIndex = 20;
            this.gpbMoedas.TabStop = false;
            this.gpbMoedas.Text = "Moedas";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(242, 172);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(105, 23);
            this.btnTotal.TabIndex = 21;
            this.btnTotal.Text = "Atualizar Total - F5";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(350, 172);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 23);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "&Limpar - F2";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(455, 306);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.gpbMoedas);
            this.Controls.Add(this.gpbNotas);
            this.Controls.Add(this.gpbTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmContador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Cédulas";
            this.Load += new System.EventHandler(this.frmContador_Load);
            this.gpbTotal.ResumeLayout(false);
            this.gpbNotas.ResumeLayout(false);
            this.gpbNotas.PerformLayout();
            this.gpbMoedas.ResumeLayout(false);
            this.gpbMoedas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtTotalGeral;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtQtdeN2;
        private System.Windows.Forms.Label txtTotalN2;
        private System.Windows.Forms.Label lblN5;
        private System.Windows.Forms.TextBox txtQtdeN5;
        private System.Windows.Forms.Label txtTotalN5;
        private System.Windows.Forms.Label lblN10;
        private System.Windows.Forms.TextBox txtQtdeN10;
        private System.Windows.Forms.Label txtTotalN10;
        private System.Windows.Forms.Label lblN20;
        private System.Windows.Forms.TextBox txtQtdeN20;
        private System.Windows.Forms.Label txtTotalN20;
        private System.Windows.Forms.Label lblN50;
        private System.Windows.Forms.TextBox txtQtdeN50;
        private System.Windows.Forms.Label txtTotalN50;
        private System.Windows.Forms.Label lblN100;
        private System.Windows.Forms.TextBox txtQtdeN100;
        private System.Windows.Forms.Label txtTotalN100;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbNotas;
        private System.Windows.Forms.Label lblM5;
        private System.Windows.Forms.TextBox txtM5;
        private System.Windows.Forms.Label txtTotalM5;
        private System.Windows.Forms.Label lblM10;
        private System.Windows.Forms.TextBox txtM10;
        private System.Windows.Forms.Label txtTotalM10;
        private System.Windows.Forms.Label lblM25;
        private System.Windows.Forms.TextBox txtM25;
        private System.Windows.Forms.Label txtTotalM25;
        private System.Windows.Forms.Label lblM50;
        private System.Windows.Forms.TextBox txtM50;
        private System.Windows.Forms.Label txtTotalM50;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.TextBox txtM1;
        private System.Windows.Forms.Label txtTotalM1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbMoedas;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnLimpar;
    }
}

