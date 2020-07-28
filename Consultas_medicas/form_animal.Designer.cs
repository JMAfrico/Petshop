namespace Consultas_medicas
{
    partial class form_animal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_minimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_nome = new System.Windows.Forms.RadioButton();
            this.rd_raca = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodAnimal = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.dtAnimal = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_salvar_medico = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_minimizar)).BeginInit();
            this.lbl_sexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAnimal)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.picture_minimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picture_minimizar
            // 
            this.picture_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_minimizar.Image = global::Consultas_medicas.Properties.Resources.minimizar;
            this.picture_minimizar.Location = new System.Drawing.Point(8, 5);
            this.picture_minimizar.Name = "picture_minimizar";
            this.picture_minimizar.Size = new System.Drawing.Size(29, 25);
            this.picture_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_minimizar.TabIndex = 73;
            this.picture_minimizar.TabStop = false;
            this.picture_minimizar.Click += new System.EventHandler(this.picture_minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(601, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Animal";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lbl_sexo.Controls.Add(this.groupBox1);
            this.lbl_sexo.Controls.Add(this.label9);
            this.lbl_sexo.Controls.Add(this.label8);
            this.lbl_sexo.Controls.Add(this.txtCodAnimal);
            this.lbl_sexo.Controls.Add(this.lblNome);
            this.lbl_sexo.Controls.Add(this.lblRaca);
            this.lbl_sexo.Controls.Add(this.lblSexo);
            this.lbl_sexo.Controls.Add(this.label3);
            this.lbl_sexo.Controls.Add(this.label6);
            this.lbl_sexo.Controls.Add(this.label7);
            this.lbl_sexo.Controls.Add(this.textBox1);
            this.lbl_sexo.Controls.Add(this.label24);
            this.lbl_sexo.Controls.Add(this.btn_deletar);
            this.lbl_sexo.Controls.Add(this.btn_editar);
            this.lbl_sexo.Controls.Add(this.dtAnimal);
            this.lbl_sexo.Controls.Add(this.panel9);
            this.lbl_sexo.Controls.Add(this.panel7);
            this.lbl_sexo.Controls.Add(this.panel4);
            this.lbl_sexo.Controls.Add(this.panel2);
            this.lbl_sexo.Controls.Add(this.cbSexo);
            this.lbl_sexo.Controls.Add(this.txtNome);
            this.lbl_sexo.Controls.Add(this.txtRaca);
            this.lbl_sexo.Controls.Add(this.label5);
            this.lbl_sexo.Controls.Add(this.label4);
            this.lbl_sexo.Controls.Add(this.label2);
            this.lbl_sexo.Controls.Add(this.btn_voltar);
            this.lbl_sexo.Controls.Add(this.btn_salvar_medico);
            this.lbl_sexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sexo.Location = new System.Drawing.Point(0, 36);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(1276, 681);
            this.lbl_sexo.TabIndex = 2;
            this.lbl_sexo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_nome);
            this.groupBox1.Controls.Add(this.rd_raca);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(901, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 37);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            this.groupBox1.Visible = false;
            // 
            // rd_nome
            // 
            this.rd_nome.AutoSize = true;
            this.rd_nome.ForeColor = System.Drawing.Color.White;
            this.rd_nome.Location = new System.Drawing.Point(107, 13);
            this.rd_nome.Name = "rd_nome";
            this.rd_nome.Size = new System.Drawing.Size(53, 17);
            this.rd_nome.TabIndex = 2;
            this.rd_nome.TabStop = true;
            this.rd_nome.Text = "Nome";
            this.rd_nome.UseVisualStyleBackColor = true;
            // 
            // rd_raca
            // 
            this.rd_raca.AutoSize = true;
            this.rd_raca.ForeColor = System.Drawing.Color.White;
            this.rd_raca.Location = new System.Drawing.Point(12, 13);
            this.rd_raca.Name = "rd_raca";
            this.rd_raca.Size = new System.Drawing.Size(51, 17);
            this.rd_raca.TabIndex = 1;
            this.rd_raca.TabStop = true;
            this.rd_raca.Text = "Raça";
            this.rd_raca.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(293, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 132;
            this.label9.Text = "Codigo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(855, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 131;
            this.label8.Text = "Informações";
            // 
            // txtCodAnimal
            // 
            this.txtCodAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtCodAnimal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodAnimal.Enabled = false;
            this.txtCodAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCodAnimal.ForeColor = System.Drawing.Color.White;
            this.txtCodAnimal.Location = new System.Drawing.Point(351, 23);
            this.txtCodAnimal.MaxLength = 20;
            this.txtCodAnimal.Name = "txtCodAnimal";
            this.txtCodAnimal.Size = new System.Drawing.Size(133, 24);
            this.txtCodAnimal.TabIndex = 130;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblRaca.ForeColor = System.Drawing.Color.White;
            this.lblRaca.Location = new System.Drawing.Point(709, 108);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(13, 20);
            this.lblRaca.TabIndex = 128;
            this.lblRaca.Text = "-";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(713, 66);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(13, 20);
            this.lblSexo.TabIndex = 127;
            this.lblSexo.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(660, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 125;
            this.label6.Text = "Raça:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(662, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 124;
            this.label7.Text = "Sexo:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(424, 285);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 25);
            this.textBox1.TabIndex = 123;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(349, 288);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 20);
            this.label24.TabIndex = 122;
            this.label24.Text = "Pesquisar:";
            // 
            // btn_deletar
            // 
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Location = new System.Drawing.Point(437, 203);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(183, 40);
            this.btn_deletar.TabIndex = 112;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(17, 203);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(201, 36);
            this.btn_editar.TabIndex = 111;
            this.btn_editar.Text = "Salvar Edição";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // dtAnimal
            // 
            this.dtAnimal.AllowUserToAddRows = false;
            this.dtAnimal.AllowUserToDeleteRows = false;
            this.dtAnimal.AllowUserToResizeColumns = false;
            this.dtAnimal.AllowUserToResizeRows = false;
            this.dtAnimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtAnimal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtAnimal.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtAnimal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAnimal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAnimal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtAnimal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dtAnimal.Location = new System.Drawing.Point(353, 327);
            this.dtAnimal.Name = "dtAnimal";
            this.dtAnimal.RowHeadersWidth = 70;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            this.dtAnimal.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAnimal.Size = new System.Drawing.Size(555, 315);
            this.dtAnimal.TabIndex = 110;
            this.dtAnimal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAnimal_CellDoubleClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(10, 259);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1257, 10);
            this.panel9.TabIndex = 109;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel10.Location = new System.Drawing.Point(7, 669);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1259, 10);
            this.panel10.TabIndex = 94;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(626, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(14, 259);
            this.panel7.TabIndex = 97;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel8.Location = new System.Drawing.Point(7, 669);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1259, 10);
            this.panel8.TabIndex = 94;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(1265, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 684);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel5.Location = new System.Drawing.Point(7, 669);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1259, 10);
            this.panel5.TabIndex = 94;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 684);
            this.panel2.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel6.Location = new System.Drawing.Point(7, 669);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1259, 10);
            this.panel6.TabIndex = 94;
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cbSexo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbSexo.ForeColor = System.Drawing.Color.White;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(97, 20);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 26);
            this.cbSexo.TabIndex = 1;
            // 
            // txtRaca
            // 
            this.txtRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtRaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtRaca.ForeColor = System.Drawing.Color.White;
            this.txtRaca.Location = new System.Drawing.Point(97, 62);
            this.txtRaca.MaxLength = 50;
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(387, 24);
            this.txtRaca.TabIndex = 2;
            this.txtRaca.TextChanged += new System.EventHandler(this.txtRaca_TextChanged);
            this.txtRaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRaca_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Raça:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Sexo:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(1120, 610);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(139, 32);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_salvar_medico
            // 
            this.btn_salvar_medico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar_medico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_salvar_medico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_salvar_medico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_salvar_medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_medico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar_medico.ForeColor = System.Drawing.Color.White;
            this.btn_salvar_medico.Location = new System.Drawing.Point(17, 203);
            this.btn_salvar_medico.Name = "btn_salvar_medico";
            this.btn_salvar_medico.Size = new System.Drawing.Size(603, 40);
            this.btn_salvar_medico.TabIndex = 4;
            this.btn_salvar_medico.Text = "Salvar";
            this.btn_salvar_medico.UseVisualStyleBackColor = true;
            this.btn_salvar_medico.Click += new System.EventHandler(this.btn_salvar_medico_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(715, 150);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(13, 20);
            this.lblNome.TabIndex = 129;
            this.lblNome.Text = "-";
            this.lblNome.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(660, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 126;
            this.label3.Text = "Nome:";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nome:";
            this.label5.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(97, 104);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(387, 24);
            this.txtNome.TabIndex = 3;
            this.txtNome.Visible = false;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // form_animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1276, 717);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_animal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Animal";
            this.Load += new System.EventHandler(this.form_animal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_minimizar)).EndInit();
            this.lbl_sexo.ResumeLayout(false);
            this.lbl_sexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAnimal)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lbl_sexo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_salvar_medico;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dtAnimal;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.PictureBox picture_minimizar;
        private System.Windows.Forms.TextBox txtCodAnimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_nome;
        private System.Windows.Forms.RadioButton rd_raca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
    }
}