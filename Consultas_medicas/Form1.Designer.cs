namespace Consultas_medicas
{
    partial class Menu_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Painel_Conteiner = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_cpf = new System.Windows.Forms.RadioButton();
            this.rd_cliente = new System.Windows.Forms.RadioButton();
            this.dtConsultas = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nada = new System.Windows.Forms.Panel();
            this.txtRelato = new System.Windows.Forms.ComboBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.Label();
            this.txtCodconsulta = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salvar_consulta = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hora_consulta = new System.Windows.Forms.MaskedTextBox();
            this.data_consulta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Barra_Titulo = new System.Windows.Forms.FlowLayoutPanel();
            this.picture_fechar = new System.Windows.Forms.PictureBox();
            this.picture_restaurar = new System.Windows.Forms.PictureBox();
            this.picture_diminuir = new System.Windows.Forms.PictureBox();
            this.picture_minimizar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btn_cad_func = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cad_pet = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_cad_funcionario = new System.Windows.Forms.Button();
            this.SubMenu_cadastro = new System.Windows.Forms.Panel();
            this.btn_cad_cliente = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_cadastraa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Painel_Conteiner.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.nada.SuspendLayout();
            this.Barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_diminuir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_minimizar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Painel_Conteiner
            // 
            this.Painel_Conteiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Painel_Conteiner.Controls.Add(this.groupBox1);
            this.Painel_Conteiner.Controls.Add(this.dtConsultas);
            this.Painel_Conteiner.Controls.Add(this.txtPesquisar);
            this.Painel_Conteiner.Controls.Add(this.label24);
            this.Painel_Conteiner.Controls.Add(this.label8);
            this.Painel_Conteiner.Controls.Add(this.panel8);
            this.Painel_Conteiner.Controls.Add(this.panel7);
            this.Painel_Conteiner.Controls.Add(this.nada);
            this.Painel_Conteiner.Location = new System.Drawing.Point(220, 32);
            this.Painel_Conteiner.Name = "Painel_Conteiner";
            this.Painel_Conteiner.Size = new System.Drawing.Size(780, 618);
            this.Painel_Conteiner.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_cpf);
            this.groupBox1.Controls.Add(this.rd_cliente);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(566, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 37);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rd_cpf
            // 
            this.rd_cpf.AutoSize = true;
            this.rd_cpf.ForeColor = System.Drawing.Color.White;
            this.rd_cpf.Location = new System.Drawing.Point(107, 13);
            this.rd_cpf.Name = "rd_cpf";
            this.rd_cpf.Size = new System.Drawing.Size(45, 17);
            this.rd_cpf.TabIndex = 2;
            this.rd_cpf.TabStop = true;
            this.rd_cpf.Text = "CPF";
            this.rd_cpf.UseVisualStyleBackColor = true;
            // 
            // rd_cliente
            // 
            this.rd_cliente.AutoSize = true;
            this.rd_cliente.ForeColor = System.Drawing.Color.White;
            this.rd_cliente.Location = new System.Drawing.Point(12, 13);
            this.rd_cliente.Name = "rd_cliente";
            this.rd_cliente.Size = new System.Drawing.Size(57, 17);
            this.rd_cliente.TabIndex = 1;
            this.rd_cliente.TabStop = true;
            this.rd_cliente.Text = "Cliente";
            this.rd_cliente.UseVisualStyleBackColor = true;
            // 
            // dtConsultas
            // 
            this.dtConsultas.AllowUserToAddRows = false;
            this.dtConsultas.AllowUserToDeleteRows = false;
            this.dtConsultas.AllowUserToResizeColumns = false;
            this.dtConsultas.AllowUserToResizeRows = false;
            this.dtConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtConsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtConsultas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsultas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtConsultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dtConsultas.Location = new System.Drawing.Point(6, 164);
            this.dtConsultas.Name = "dtConsultas";
            this.dtConsultas.RowHeadersWidth = 12;
            this.dtConsultas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            this.dtConsultas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtConsultas.Size = new System.Drawing.Size(762, 259);
            this.dtConsultas.TabIndex = 124;
            this.dtConsultas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtConsultas_CellDoubleClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.White;
            this.txtPesquisar.Location = new System.Drawing.Point(89, 133);
            this.txtPesquisar.MaxLength = 30;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(471, 25);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(10, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 20);
            this.label24.TabIndex = 122;
            this.label24.Text = "Pesquisar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(310, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nova Consulta";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(384, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(396, 116);
            this.panel8.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 116);
            this.panel7.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nada
            // 
            this.nada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.nada.Controls.Add(this.txtRelato);
            this.nada.Controls.Add(this.btn_deletar);
            this.nada.Controls.Add(this.Codigo);
            this.nada.Controls.Add(this.txtCodconsulta);
            this.nada.Controls.Add(this.btn_editar);
            this.nada.Controls.Add(this.btn_salvar_consulta);
            this.nada.Controls.Add(this.cbCliente);
            this.nada.Controls.Add(this.label4);
            this.nada.Controls.Add(this.label3);
            this.nada.Controls.Add(this.hora_consulta);
            this.nada.Controls.Add(this.data_consulta);
            this.nada.Controls.Add(this.label6);
            this.nada.Controls.Add(this.label5);
            this.nada.Location = new System.Drawing.Point(46, 429);
            this.nada.Name = "nada";
            this.nada.Size = new System.Drawing.Size(681, 186);
            this.nada.TabIndex = 31;
            // 
            // txtRelato
            // 
            this.txtRelato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtRelato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRelato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRelato.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelato.ForeColor = System.Drawing.Color.White;
            this.txtRelato.FormattingEnabled = true;
            this.txtRelato.Items.AddRange(new object[] {
            "EXAMES LABORATORIAIS",
            "CONSULTAS",
            "CIRURGIA",
            "INTERNAÇÃO",
            "EMERGÊNCIA",
            "RAIO X",
            "ESPECIALIDADE",
            "ESTÉTICA ANIMAL"});
            this.txtRelato.Location = new System.Drawing.Point(76, 66);
            this.txtRelato.Name = "txtRelato";
            this.txtRelato.Size = new System.Drawing.Size(438, 27);
            this.txtRelato.TabIndex = 128;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Location = new System.Drawing.Point(425, 136);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(180, 41);
            this.btn_deletar.TabIndex = 127;
            this.btn_deletar.Text = "Excluir Consulta";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Codigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ForeColor = System.Drawing.Color.White;
            this.Codigo.Location = new System.Drawing.Point(531, 37);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(58, 19);
            this.Codigo.TabIndex = 126;
            this.Codigo.Text = "Codigo:";
            // 
            // txtCodconsulta
            // 
            this.txtCodconsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtCodconsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodconsulta.Enabled = false;
            this.txtCodconsulta.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtCodconsulta.ForeColor = System.Drawing.Color.White;
            this.txtCodconsulta.Location = new System.Drawing.Point(591, 32);
            this.txtCodconsulta.MaxLength = 50;
            this.txtCodconsulta.Name = "txtCodconsulta";
            this.txtCodconsulta.Size = new System.Drawing.Size(74, 27);
            this.txtCodconsulta.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(43, 136);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(180, 41);
            this.btn_editar.TabIndex = 112;
            this.btn_editar.Text = "Confirmar Alteração";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_salvar_consulta
            // 
            this.btn_salvar_consulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_salvar_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_salvar_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_consulta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar_consulta.ForeColor = System.Drawing.Color.White;
            this.btn_salvar_consulta.Location = new System.Drawing.Point(229, 136);
            this.btn_salvar_consulta.Name = "btn_salvar_consulta";
            this.btn_salvar_consulta.Size = new System.Drawing.Size(180, 41);
            this.btn_salvar_consulta.TabIndex = 6;
            this.btn_salvar_consulta.Text = "Salvar";
            this.btn_salvar_consulta.UseVisualStyleBackColor = true;
            this.btn_salvar_consulta.Click += new System.EventHandler(this.btn_salvar_consulta_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cbCliente.DisplayMember = "Paciente";
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.ForeColor = System.Drawing.Color.White;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(76, 31);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(438, 27);
            this.cbCliente.TabIndex = 1;
            this.cbCliente.ValueMember = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Relato:";
            // 
            // hora_consulta
            // 
            this.hora_consulta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.hora_consulta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_consulta.Location = new System.Drawing.Point(263, 99);
            this.hora_consulta.Mask = "90:00";
            this.hora_consulta.Name = "hora_consulta";
            this.hora_consulta.Size = new System.Drawing.Size(66, 27);
            this.hora_consulta.TabIndex = 4;
            this.hora_consulta.ValidatingType = typeof(System.DateTime);
            this.hora_consulta.Click += new System.EventHandler(this.hora_consulta_Click);
            this.hora_consulta.Leave += new System.EventHandler(this.hora_consulta_Leave);
            // 
            // data_consulta
            // 
            this.data_consulta.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.data_consulta.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.data_consulta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_consulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_consulta.Location = new System.Drawing.Point(76, 99);
            this.data_consulta.MinDate = new System.DateTime(2019, 11, 10, 0, 0, 0, 0);
            this.data_consulta.Name = "data_consulta";
            this.data_consulta.Size = new System.Drawing.Size(119, 27);
            this.data_consulta.TabIndex = 3;
            this.data_consulta.ValueChanged += new System.EventHandler(this.data_consulta_ValueChanged);
            this.data_consulta.Leave += new System.EventHandler(this.data_consulta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(213, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data:";
            // 
            // Barra_Titulo
            // 
            this.Barra_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Barra_Titulo.Controls.Add(this.picture_fechar);
            this.Barra_Titulo.Controls.Add(this.picture_restaurar);
            this.Barra_Titulo.Controls.Add(this.picture_diminuir);
            this.Barra_Titulo.Controls.Add(this.picture_minimizar);
            this.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_Titulo.Name = "Barra_Titulo";
            this.Barra_Titulo.Size = new System.Drawing.Size(1000, 32);
            this.Barra_Titulo.TabIndex = 7;
            this.Barra_Titulo.WrapContents = false;
            this.Barra_Titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Barra_Titulo_Paint);
            this.Barra_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Titulo_MouseDown);
            // 
            // picture_fechar
            // 
            this.picture_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_fechar.Image = global::Consultas_medicas.Properties.Resources.fechar;
            this.picture_fechar.Location = new System.Drawing.Point(3, 3);
            this.picture_fechar.Name = "picture_fechar";
            this.picture_fechar.Size = new System.Drawing.Size(25, 25);
            this.picture_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_fechar.TabIndex = 0;
            this.picture_fechar.TabStop = false;
            this.picture_fechar.Click += new System.EventHandler(this.picture_fechar_Click);
            // 
            // picture_restaurar
            // 
            this.picture_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_restaurar.Image = global::Consultas_medicas.Properties.Resources.minimizar_m;
            this.picture_restaurar.Location = new System.Drawing.Point(34, 3);
            this.picture_restaurar.Name = "picture_restaurar";
            this.picture_restaurar.Size = new System.Drawing.Size(25, 25);
            this.picture_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_restaurar.TabIndex = 3;
            this.picture_restaurar.TabStop = false;
            this.picture_restaurar.Visible = false;
            this.picture_restaurar.Click += new System.EventHandler(this.picture_restaurar_Click);
            // 
            // picture_diminuir
            // 
            this.picture_diminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_diminuir.Image = global::Consultas_medicas.Properties.Resources.minimizar_m;
            this.picture_diminuir.Location = new System.Drawing.Point(65, 3);
            this.picture_diminuir.Name = "picture_diminuir";
            this.picture_diminuir.Size = new System.Drawing.Size(25, 25);
            this.picture_diminuir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_diminuir.TabIndex = 2;
            this.picture_diminuir.TabStop = false;
            this.picture_diminuir.Visible = false;
            this.picture_diminuir.Click += new System.EventHandler(this.picture_diminuir_Click);
            // 
            // picture_minimizar
            // 
            this.picture_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_minimizar.Image = global::Consultas_medicas.Properties.Resources.minimizar;
            this.picture_minimizar.Location = new System.Drawing.Point(96, 3);
            this.picture_minimizar.Name = "picture_minimizar";
            this.picture_minimizar.Size = new System.Drawing.Size(29, 25);
            this.picture_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_minimizar.TabIndex = 1;
            this.picture_minimizar.TabStop = false;
            this.picture_minimizar.Click += new System.EventHandler(this.picture_minimizar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.btn_cad_func);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btn_cad_pet);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.btn_cad_funcionario);
            this.MenuVertical.Controls.Add(this.SubMenu_cadastro);
            this.MenuVertical.Controls.Add(this.btn_cad_cliente);
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.btn_cadastraa);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btn_fechar);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 32);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 618);
            this.MenuVertical.TabIndex = 8;
            // 
            // btn_cad_func
            // 
            this.btn_cad_func.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_func.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_cad_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_func.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_func.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cad_func.Location = new System.Drawing.Point(19, 465);
            this.btn_cad_func.Name = "btn_cad_func";
            this.btn_cad_func.Size = new System.Drawing.Size(194, 32);
            this.btn_cad_func.TabIndex = 16;
            this.btn_cad_func.Text = "Funcionario";
            this.btn_cad_func.UseVisualStyleBackColor = true;
            this.btn_cad_func.Visible = false;
            this.btn_cad_func.Click += new System.EventHandler(this.btn_cad_func_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(12, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 5);
            this.panel1.TabIndex = 18;
            // 
            // btn_cad_pet
            // 
            this.btn_cad_pet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_pet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_cad_pet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_pet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_pet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cad_pet.Location = new System.Drawing.Point(19, 427);
            this.btn_cad_pet.Name = "btn_cad_pet";
            this.btn_cad_pet.Size = new System.Drawing.Size(194, 32);
            this.btn_cad_pet.TabIndex = 15;
            this.btn_cad_pet.Text = "Animal";
            this.btn_cad_pet.UseVisualStyleBackColor = true;
            this.btn_cad_pet.Visible = false;
            this.btn_cad_pet.Click += new System.EventHandler(this.btn_cad_pet_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Consultas_medicas.Properties.Resources.LOGOnomePet2;
            this.pictureBox2.Location = new System.Drawing.Point(3, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btn_cad_funcionario
            // 
            this.btn_cad_funcionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_funcionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_cad_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_funcionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_funcionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cad_funcionario.Location = new System.Drawing.Point(19, 389);
            this.btn_cad_funcionario.Name = "btn_cad_funcionario";
            this.btn_cad_funcionario.Size = new System.Drawing.Size(194, 32);
            this.btn_cad_funcionario.TabIndex = 14;
            this.btn_cad_funcionario.Text = "Veterinário";
            this.btn_cad_funcionario.UseVisualStyleBackColor = true;
            this.btn_cad_funcionario.Visible = false;
            this.btn_cad_funcionario.Click += new System.EventHandler(this.btn_cad_funcionario_Click);
            // 
            // SubMenu_cadastro
            // 
            this.SubMenu_cadastro.Location = new System.Drawing.Point(15, 389);
            this.SubMenu_cadastro.Name = "SubMenu_cadastro";
            this.SubMenu_cadastro.Size = new System.Drawing.Size(200, 161);
            this.SubMenu_cadastro.TabIndex = 16;
            // 
            // btn_cad_cliente
            // 
            this.btn_cad_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_cad_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_cliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_cliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cad_cliente.Location = new System.Drawing.Point(19, 351);
            this.btn_cad_cliente.Name = "btn_cad_cliente";
            this.btn_cad_cliente.Size = new System.Drawing.Size(196, 32);
            this.btn_cad_cliente.TabIndex = 13;
            this.btn_cad_cliente.Text = "Cliente";
            this.btn_cad_cliente.UseVisualStyleBackColor = true;
            this.btn_cad_cliente.Visible = false;
            this.btn_cad_cliente.Click += new System.EventHandler(this.btn_cad_cliente_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(12, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(12, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(12, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Relatórios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_cadastraa
            // 
            this.btn_cadastraa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastraa.FlatAppearance.BorderSize = 0;
            this.btn_cadastraa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_cadastraa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastraa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastraa.ForeColor = System.Drawing.Color.White;
            this.btn_cadastraa.Location = new System.Drawing.Point(12, 164);
            this.btn_cadastraa.Name = "btn_cadastraa";
            this.btn_cadastraa.Size = new System.Drawing.Size(208, 32);
            this.btn_cadastraa.TabIndex = 3;
            this.btn_cadastraa.Text = "Cadastrar/Alterar";
            this.btn_cadastraa.UseVisualStyleBackColor = true;
            this.btn_cadastraa.Click += new System.EventHandler(this.btn_cadastraa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultas_medicas.Properties.Resources.logOpET_OF1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(12, 240);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(208, 32);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.Text = "Encerrar Aplicação";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu_principal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.Painel_Conteiner);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.Barra_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.Painel_Conteiner.ResumeLayout(false);
            this.Painel_Conteiner.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.nada.ResumeLayout(false);
            this.nada.PerformLayout();
            this.Barra_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_diminuir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_minimizar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Conteiner;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FlowLayoutPanel Barra_Titulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox picture_diminuir;
        private System.Windows.Forms.PictureBox picture_minimizar;
        private System.Windows.Forms.PictureBox picture_fechar;
        private System.Windows.Forms.PictureBox picture_restaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_cadastraa;
        private System.Windows.Forms.Panel SubMenu_cadastro;
        private System.Windows.Forms.Button btn_cad_funcionario;
        private System.Windows.Forms.Button btn_cad_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_cad_func;
        private System.Windows.Forms.Button btn_cad_pet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker data_consulta;
        private System.Windows.Forms.MaskedTextBox hora_consulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel nada;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btn_salvar_consulta;
        private System.Windows.Forms.DataGridView dtConsultas;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txtCodconsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_cpf;
        private System.Windows.Forms.RadioButton rd_cliente;
        private System.Windows.Forms.ComboBox txtRelato;
    }
}

