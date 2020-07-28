using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Consultas_medicas.BLL; // ADICIONAR ONDE ESTA OS COMANDO
using Consultas_medicas.Models; // ADICIONAR ONDE ESTÁ OS PARAMETROS
using MySql.Data.MySqlClient;

namespace Consultas_medicas
{
    public partial class Form_medico : Form
    {
        public Form_medico()
        {
            InitializeComponent();
            listarVeterinarios();
            btn_editar.Visible = false;
            btn_deletar.Visible = false;
        }
		
		private void limparCampos()
		{
			txtNome.Clear();
			txt_Sobrenome.Clear();
			txtCRMV.Clear();
			txtEspecializacao.Clear();
			txtEnd.Clear();
			txtBairro.Clear();
			txtCep.Clear();
			txtNum.Clear();
			txtComplem.Clear();
			txtEmail.Clear();
			txtelfixo.Clear();
			txtelCelular.Clear();
			txtCodveterinario.Clear();
            txtCRMV.BackColor = Color.Black;

        }

        //MÉTODO PARA SALVAR
        private void salvar(Veterinarios veterinarios)//esse método deve ser privado
        {
            try
            {
                if (txtNome.Text.Trim() == string.Empty || txt_Sobrenome.Text.Trim() == string.Empty || txtCRMV.Text.Trim() == string.Empty ||
                    txtEspecializacao.Text.Trim() == string.Empty || txtEnd.Text.Trim() == string.Empty || txtBairro.Text.Trim() == string.Empty ||
                    txtCep.Text.Trim() == string.Empty || txtNum.Text.Trim() == string.Empty || txtComplem.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty ||
                    txtelfixo.Text.Trim() == string.Empty || txtelCelular.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    VeterinarioBLL veterinariosBLL = new VeterinarioBLL();

                    veterinarios.nomeVeterinario = txtNome.Text;
                    veterinarios.sobrenomeVeterinario = txt_Sobrenome.Text;
                    veterinarios.crmv = txtCRMV.Text;
                    veterinarios.especializacao = txtEspecializacao.Text;
                    veterinarios.enderecoVeterinario = txtEnd.Text;
                    veterinarios.bairroVeterinario = txtBairro.Text;
                    veterinarios.cepVeterinario = txtCep.Text;
                    veterinarios.numeroResidenciaVeterinario = Convert.ToInt32(txtNum.Text);
                    veterinarios.complementoVeterinario = txtComplem.Text;
                    veterinarios.emailVeterinario = txtEmail.Text;
                    veterinarios.telefoneFixoVet = Convert.ToInt64(txtelfixo.Text);
                    veterinarios.telefoneCelularVet = Convert.ToInt64(txtelCelular.Text);

                    veterinariosBLL.salvar(veterinarios);

                    MessageBox.Show("Veterinário CADASTRADO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    listarVeterinarios();
                }

            }
            catch (MySqlException erro)
            {
                MessageBox.Show("CRMV já existe \n " + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCRMV.BackColor = Color.DimGray;
                txtCRMV.Focus();

            }
        }
		
		//excluir
		
		private void excluir(Veterinarios veterinarios)//esse método deve ser privado
        {
            try
            {
                VeterinarioBLL veterinariosBLL = new VeterinarioBLL();

				veterinarios.codVeterinario = Convert.ToInt32(txtCodveterinario.Text);

                veterinariosBLL.excluir(veterinarios);
					//ou excluir com maiuscula
                MessageBox.Show("Veterinário EXCLUÍDO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                btn_editar.Visible = false;
                btn_deletar.Visible = false;
                btn_salvar_medico.Visible = true;
                listarVeterinarios();

            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Você não tem permissão para Excluir " + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		
		//------

        private void listarVeterinarios()
        {
            VeterinarioBLL veterinarioBLL = new VeterinarioBLL();
            dtVeterinario.DataSource = veterinarioBLL.listarVeterinarios();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Menu_principal novo = new Menu_principal();
            novo.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // MOVER A TELA--------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr HWnd, int wMsg, int wParam, int IParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_salvar_medico_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma os dados ?", "SALVAR VETERINARIO ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Veterinarios veterinarios = new Veterinarios();
                salvar(veterinarios);
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {//SOMENTE NÚMEROS COM BACKSPACE = funcionando
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {//SOMENTE LETRAS COM BACKSPACE = funcionando
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txtCRMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txt_Sobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txtEspecializacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void picture_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dtVeterinario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editar.Visible = true;
            btn_deletar.Visible = true;
            btn_salvar_medico.Visible = false;

            lblNome.Text = dtVeterinario.CurrentRow.Cells[1].Value.ToString();
            lblSobrenome.Text = dtVeterinario.CurrentRow.Cells[2].Value.ToString();
            lblCRMV.Text = dtVeterinario.CurrentRow.Cells[3].Value.ToString();
            lblEspec.Text = dtVeterinario.CurrentRow.Cells[4].Value.ToString();
            lblEnd.Text = dtVeterinario.CurrentRow.Cells[5].Value.ToString();
            lblBairro.Text = dtVeterinario.CurrentRow.Cells[6].Value.ToString();
            lblCep.Text = dtVeterinario.CurrentRow.Cells[7].Value.ToString();
            lblNum.Text = dtVeterinario.CurrentRow.Cells[8].Value.ToString();
            lblComplemento.Text = dtVeterinario.CurrentRow.Cells[9].Value.ToString();
            lblEmail.Text = dtVeterinario.CurrentRow.Cells[10].Value.ToString();
            lblFixo.Text = dtVeterinario.CurrentRow.Cells[11].Value.ToString();
            lblCel.Text = dtVeterinario.CurrentRow.Cells[12].Value.ToString();

            txtCodveterinario.Text = dtVeterinario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dtVeterinario.CurrentRow.Cells[1].Value.ToString();
            txt_Sobrenome.Text = dtVeterinario.CurrentRow.Cells[2].Value.ToString();
            txtCRMV.Text = dtVeterinario.CurrentRow.Cells[3].Value.ToString();
            txtEspecializacao.Text = dtVeterinario.CurrentRow.Cells[4].Value.ToString();
            txtEnd.Text = dtVeterinario.CurrentRow.Cells[5].Value.ToString();
            txtBairro.Text = dtVeterinario.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = dtVeterinario.CurrentRow.Cells[7].Value.ToString();
            txtNum.Text = dtVeterinario.CurrentRow.Cells[8].Value.ToString();
            txtComplem.Text = dtVeterinario.CurrentRow.Cells[9].Value.ToString();
            txtEmail.Text = dtVeterinario.CurrentRow.Cells[10].Value.ToString();
            txtelfixo.Text = dtVeterinario.CurrentRow.Cells[11].Value.ToString();
            txtelCelular.Text = dtVeterinario.CurrentRow.Cells[12].Value.ToString();

        }
        private void editar(Veterinarios veterinarios)
        {
            try
            {
                if (txtNome.Text.Trim() == string.Empty || txt_Sobrenome.Text.Trim() == string.Empty || txtCRMV.Text.Trim() == string.Empty ||
                txtEspecializacao.Text.Trim() == string.Empty || txtEnd.Text.Trim() == string.Empty || txtBairro.Text.Trim() == string.Empty ||
                txtCep.Text.Trim() == string.Empty || txtNum.Text.Trim() == string.Empty || txtComplem.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty ||
                txtelfixo.Text.Trim() == string.Empty || txtelCelular.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    VeterinarioBLL veterinariosBLL = new VeterinarioBLL();

                    veterinarios.codVeterinario = Convert.ToInt32(txtCodveterinario.Text);
                    veterinarios.nomeVeterinario = txtNome.Text;
                    veterinarios.sobrenomeVeterinario = txt_Sobrenome.Text;
                    veterinarios.crmv = txtCRMV.Text;
                    veterinarios.especializacao = txtEspecializacao.Text;
                    veterinarios.enderecoVeterinario = txtEnd.Text;
                    veterinarios.bairroVeterinario = txtBairro.Text;
                    veterinarios.cepVeterinario = txtCep.Text;
                    veterinarios.numeroResidenciaVeterinario = Convert.ToInt32(txtNum.Text);
                    veterinarios.complementoVeterinario = txtComplem.Text;
                    veterinarios.emailVeterinario = txtEmail.Text;
                    veterinarios.telefoneFixoVet = Convert.ToInt64(txtelfixo.Text);
                    veterinarios.telefoneCelularVet = Convert.ToInt64(txtelCelular.Text);

                    veterinariosBLL.editar(veterinarios);

                    MessageBox.Show("Veterinário ALTERADO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    btn_editar.Visible = false;
                    btn_deletar.Visible = false;
                    btn_salvar_medico.Visible = true;
                    listarVeterinarios();
                }
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Você não tem permissão para Alterar, CRMV já existe " + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar alteração ?", "ALTERAR VETERINARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Veterinarios veterinarios = new Veterinarios();
                editar(veterinarios);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão ?", "EXClUIR VETERINARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Veterinarios veterinarios = new Veterinarios();
                excluir(veterinarios);
            }
        }
		
				//-----------novos--------------------------
		private void pesquisar(Veterinarios veterinarios)
		{
            try
            {
                veterinarios.nomeVeterinario = txtPesquisar.Text.Trim();

                VeterinarioBLL veterinariosBLL = new VeterinarioBLL();

                dtVeterinario.DataSource = veterinariosBLL.pesquisar(veterinarios);
            }
            catch(Exception erro)
            {
                throw erro;
            }
		}

        private void pesquisarCRMV(Veterinarios veterinarios)
        {
            try
            {
                veterinarios.crmv = txtPesquisar.Text.Trim();

                VeterinarioBLL veterinariosBLL = new VeterinarioBLL();

                dtVeterinario.DataSource = veterinariosBLL.pesquisarCRMV(veterinarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (rd_nomemed.Checked == true)
            {
                if (txtPesquisar.Text == "")
                {
                    VeterinarioBLL veterinariosBLL = new VeterinarioBLL();
                    dtVeterinario.DataSource = veterinariosBLL.listarVeterinarios();
                }
                else
                {

                    Veterinarios veterinarios = new Veterinarios();
                    pesquisar(veterinarios);
                }
            }
            if (rd_crmv.Checked == true)
            {
                if (txtPesquisar.Text == "")
                {
                    VeterinarioBLL veterinariosBLL = new VeterinarioBLL();
                    dtVeterinario.DataSource = veterinariosBLL.listarVeterinarios();
                }
                else
                {

                    Veterinarios veterinarios = new Veterinarios();
                    pesquisarCRMV(veterinarios);
                }
            }



        }

        private void Form_medico_Load(object sender, EventArgs e)
        {
            listarVeterinarios();
            rd_nomemed.Checked = true;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
         //   {

//                e.Handled = true;
  //          }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (txtCep.Text != "" || (txtCep.Text.Length >= 1 && txtCep.Text.Length < 8))
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";
                DataSet dsRetornaEndereco = new DataSet();
                dsRetornaEndereco.ReadXml(xml.Replace("@cep", txtCep.Text));

                string retorno = dsRetornaEndereco.Tables[0].Rows[0]["resultado"].ToString();

                if (retorno == "0")
                {
                    MessageBox.Show("CEP inválido");
                    txtEnd.Clear();
                    txtBairro.Clear();
                }

                else
                {
                    txtEnd.Text = dsRetornaEndereco.Tables[0].Rows[0]["logradouro"].ToString();
                    txtBairro.Text = dsRetornaEndereco.Tables[0].Rows[0]["bairro"].ToString();
                    //cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                    // estado = ds.Tables[0].Rows[0]["uf"].ToString();
                }
            }


            
        }

        private void txtCRMV_Leave(object sender, EventArgs e)
        {
            if(txtCRMV.Text.Length >=1 && txtCRMV.Text.Length < 4)
            {
                MessageBox.Show("CRMV inválido ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCRMV.Clear();
            }
        }

        private void txtelfixo_Leave(object sender, EventArgs e)
        {
            if (txtelfixo.Text.Length >=1 && txtelfixo.Text.Length < 10)
            {
                MessageBox.Show("Telefone inválido ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtelfixo.Clear();
            }
        }

        private void txtelCelular_Leave(object sender, EventArgs e)
        {
            if (txtelCelular.Text.Length >= 1 && txtelCelular.Text.Length < 11)
            {
                MessageBox.Show("Celular inválido ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtelCelular.Clear();
            }
        }
    }
}
