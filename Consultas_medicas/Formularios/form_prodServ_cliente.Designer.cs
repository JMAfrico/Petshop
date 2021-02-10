namespace Consultas_medicas
{
    partial class form_prodServ_cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_nome_cliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total_geral = new System.Windows.Forms.Label();
            this.dt_itens_servicos1 = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_itens_servicos1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome_cliente
            // 
            this.lbl_nome_cliente.AutoSize = true;
            this.lbl_nome_cliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cliente.Location = new System.Drawing.Point(83, 23);
            this.lbl_nome_cliente.Name = "lbl_nome_cliente";
            this.lbl_nome_cliente.Size = new System.Drawing.Size(14, 19);
            this.lbl_nome_cliente.TabIndex = 1;
            this.lbl_nome_cliente.Text = "-";
            this.lbl_nome_cliente.TextChanged += new System.EventHandler(this.lbl_nome_cliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // lbl_total_geral
            // 
            this.lbl_total_geral.AutoSize = true;
            this.lbl_total_geral.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_geral.Location = new System.Drawing.Point(62, 51);
            this.lbl_total_geral.Name = "lbl_total_geral";
            this.lbl_total_geral.Size = new System.Drawing.Size(14, 19);
            this.lbl_total_geral.TabIndex = 7;
            this.lbl_total_geral.Text = "-";
            // 
            // dt_itens_servicos1
            // 
            this.dt_itens_servicos1.AllowUserToAddRows = false;
            this.dt_itens_servicos1.AllowUserToDeleteRows = false;
            this.dt_itens_servicos1.AllowUserToResizeColumns = false;
            this.dt_itens_servicos1.AllowUserToResizeRows = false;
            this.dt_itens_servicos1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_itens_servicos1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_itens_servicos1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dt_itens_servicos1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dt_itens_servicos1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_itens_servicos1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt_itens_servicos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_itens_servicos1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dt_itens_servicos1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dt_itens_servicos1.Location = new System.Drawing.Point(12, 99);
            this.dt_itens_servicos1.Name = "dt_itens_servicos1";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime;
            this.dt_itens_servicos1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_itens_servicos1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_itens_servicos1.Size = new System.Drawing.Size(918, 312);
            this.dt_itens_servicos1.TabIndex = 10;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(524, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(140, 20);
            this.txtCliente.TabIndex = 12;
            this.txtCliente.Visible = false;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(400, 23);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(14, 19);
            this.lbl_data.TabIndex = 14;
            this.lbl_data.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(724, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Código:";
            this.label6.Visible = false;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(781, 55);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(14, 19);
            this.lbl_codigo.TabIndex = 17;
            this.lbl_codigo.Text = "-";
            this.lbl_codigo.Visible = false;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(524, 28);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(140, 20);
            this.txtData.TabIndex = 15;
            this.txtData.Visible = false;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(524, 54);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(140, 20);
            this.txt_cod.TabIndex = 18;
            this.txt_cod.Visible = false;
            this.txt_cod.TextChanged += new System.EventHandler(this.txt_cod_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Pesquisa nome/data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(404, 54);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(14, 19);
            this.lbl_hora.TabIndex = 21;
            this.lbl_hora.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hora:";
            // 
            // form_prodServ_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 467);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dt_itens_servicos1);
            this.Controls.Add(this.lbl_total_geral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nome_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_prodServ_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens do Cliente";
            this.Load += new System.EventHandler(this.form_prodServ_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_itens_servicos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total_geral;
        private System.Windows.Forms.DataGridView dt_itens_servicos1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label label4;
    }
}