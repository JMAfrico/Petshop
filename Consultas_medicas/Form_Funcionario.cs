using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Consultas_medicas.BLL;
using Consultas_medicas.Models;
using Ferramentas;

namespace Consultas_medicas
{
    public partial class Form_Funcionario : Form
    {
        public Form_Funcionario()
        {
            InitializeComponent();
            listarFuncionarios();
            btn_editar.Visible = false;
            btn_deletar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_principal novo = new Menu_principal();
            novo.Show();
            this.Visible = false;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Menu_principal novo = new Menu_principal();
            novo.Show();
            this.Visible = false;
        }
        // MOVER A TELA--------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr HWnd, int wMsg, int wParam, int IParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_salvar_medico_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma os dados ?", "SALVAR FUNCIONARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funcionarios funcionarios = new Funcionarios();
                salvar(funcionarios);
            }
        }

        private void limparCampos()
        {

            txtcodfunci.Clear();
            txtNome.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            txtCel.Clear();
            txttelFixo.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCel.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();

        }
        private void salvar(Funcionarios funcionarios)
        {
            try
            {
                if (txtNome.Text.Trim() == string.Empty || txtSobrenome.Text.Trim() == string.Empty ||
                 txtEndereco.Text.Trim() == string.Empty || txtBairro.Text.Trim() == string.Empty ||
                 txtCep.Text.Trim() == string.Empty || txtNumero.Text.Trim() == string.Empty || txtComplemento.Text.Trim() == string.Empty ||
                 txtEmail.Text.Trim() == string.Empty ||
                 txttelFixo.Text.Trim() == string.Empty || txtCel.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FuncionarioBLL funcionarioBLL = new FuncionarioBLL();

                    //funcionarios.codFuncionario = Convert.ToInt32(txtcodfunci.Text);
                    funcionarios.nomeFuncionario = txtNome.Text;
                    funcionarios.sobrenomeFuncionario = txtSobrenome.Text;
                    funcionarios.emailFuncionario = txtEmail.Text;
                    funcionarios.telefoneCelularFunc = Convert.ToInt64(txtCel.Text);
                    funcionarios.telefoneFixoFunc = Convert.ToInt64(txttelFixo.Text);
                    funcionarios.enderecoFuncionario = txtEndereco.Text;
                    funcionarios.bairroFuncionario = txtBairro.Text;
                    funcionarios.cepFuncionario = txtCep.Text;
                    funcionarios.numeroResidenciaFuncionario = Convert.ToInt32(txtNumero.Text);
                    funcionarios.complementoFuncionario = txtComplemento.Text;

                    funcionarioBLL.salvar(funcionarios);

                    MessageBox.Show("Funcionário CADASTRADO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    txtCep.BackColor = Color.Black;
                    btn_salvar_medico.Visible = true;
                    btn_deletar.Visible = false;
                    btn_editar.Visible = false;
                    listarFuncionarios();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //--------------
        private void excluir(Funcionarios funcionarios)
        {
            try
            {
                FuncionarioBLL funcionarioBLL = new FuncionarioBLL();

                funcionarios.codFuncionario = Convert.ToInt32(txtcodfunci.Text);

                funcionarioBLL.excluir(funcionarios);

                MessageBox.Show("Funcionário EXCLUÍDO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                btn_salvar_medico.Visible = true;
                btn_deletar.Visible = false;
                btn_editar.Visible = false;
                listarFuncionarios();
                
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        private void listarFuncionarios()
        {
            FuncionarioBLL funcionarioBll = new FuncionarioBLL();
            dtFuncionario.DataSource = funcionarioBll.listarFuncionarios();

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void picture_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dtFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_salvar_medico.Visible = false;
            btn_deletar.Visible = true;
            btn_editar.Visible = true;

            lbl_nome.Text = dtFuncionario.CurrentRow.Cells[1].Value.ToString();
            lblSobrenome.Text = dtFuncionario.CurrentRow.Cells[2].Value.ToString();
            lblEndereco.Text = dtFuncionario.CurrentRow.Cells[6].Value.ToString();
            lblBairro.Text = dtFuncionario.CurrentRow.Cells[7].Value.ToString();
            lblCep.Text = dtFuncionario.CurrentRow.Cells[8].Value.ToString();
            lblNumero.Text = dtFuncionario.CurrentRow.Cells[9].Value.ToString();
            lblComplemento.Text = dtFuncionario.CurrentRow.Cells[10].Value.ToString();
            lblEmail.Text = dtFuncionario.CurrentRow.Cells[3].Value.ToString();
            lblFixo.Text = dtFuncionario.CurrentRow.Cells[4].Value.ToString();
            lblCel.Text = dtFuncionario.CurrentRow.Cells[5].Value.ToString();

            txtcodfunci.Text = dtFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dtFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtSobrenome.Text = dtFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = dtFuncionario.CurrentRow.Cells[6].Value.ToString();
            txtBairro.Text = dtFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtCep.Text = dtFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dtFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dtFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEmail.Text = dtFuncionario.CurrentRow.Cells[3].Value.ToString();
            txttelFixo.Text = dtFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtCel.Text = dtFuncionario.CurrentRow.Cells[5].Value.ToString();
        }

        private void dtFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar alteração ?", "ALTERAR FUNCIONARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funcionarios funcionarios = new Funcionarios();
                editar(funcionarios);
            }

        }

        private void editar(Funcionarios funcionarios)
        {
            try
            {
                if (txtNome.Text.Trim() == string.Empty || txtSobrenome.Text.Trim() == string.Empty ||
                    txtEndereco.Text.Trim() == string.Empty || txtBairro.Text.Trim() == string.Empty ||
                    txtCep.Text.Trim() == string.Empty || txtNumero.Text.Trim() == string.Empty || txtComplemento.Text.Trim() == string.Empty ||
                    txtEmail.Text.Trim() == string.Empty ||
                    txttelFixo.Text.Trim() == string.Empty || txtCel.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FuncionarioBLL funcionarioBLL = new FuncionarioBLL();

                    //funcionarios.codFuncionario = Convert.ToInt32(txtcodfunci.Text);
                    funcionarios.nomeFuncionario = txtNome.Text;
                    funcionarios.sobrenomeFuncionario = txtSobrenome.Text;
                    funcionarios.emailFuncionario = txtEmail.Text;
                    funcionarios.telefoneCelularFunc = Convert.ToInt64(txtCel.Text);
                    funcionarios.telefoneFixoFunc = Convert.ToInt64(txttelFixo.Text);
                    funcionarios.enderecoFuncionario = txtEndereco.Text;
                    funcionarios.bairroFuncionario = txtBairro.Text;
                    funcionarios.cepFuncionario = txtCep.Text;
                    funcionarios.numeroResidenciaFuncionario = Convert.ToInt32(txtNumero.Text);
                    funcionarios.complementoFuncionario = txtComplemento.Text;

                    funcionarioBLL.editar(funcionarios);

                    MessageBox.Show("Funcionário ALTERADO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    btn_salvar_medico.Visible = true;
                    btn_deletar.Visible = false;
                    btn_editar.Visible = false;
                    listarFuncionarios();
                    txtCep.BackColor = Color.Black;
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão ?", "EXCLUIR FUNCIONARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funcionarios funcionarios = new Funcionarios();
                excluir(funcionarios);
            }
        }

        //-----------novos--------------------------
        private void pesquisar(Funcionarios funcionarios)
        {
            try
            {
                funcionarios.nomeFuncionario = txtPesquisar.Text.Trim();

                FuncionarioBLL funcionarioBll = new FuncionarioBLL();

                dtFuncionario.DataSource = funcionarioBll.pesquisar(funcionarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Funcionario_Load(object sender, EventArgs e)
        {
            listarFuncionarios();
        }

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                FuncionarioBLL funcionarioBll = new FuncionarioBLL();
                dtFuncionario.DataSource = funcionarioBll.listarFuncionarios();
            }
            else
            {

                Funcionarios funcionarios = new Funcionarios();
                pesquisar(funcionarios);
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if(txtCep.Text != "" || (txtCep.Text.Length >= 1 && txtCep.Text.Length < 8)) {

                {
                    string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";
                    DataSet dsRetornaEndereco = new DataSet();
                    dsRetornaEndereco.ReadXml(xml.Replace("@cep", txtCep.Text));

                    string retorno = dsRetornaEndereco.Tables[0].Rows[0]["resultado"].ToString();

                    if (retorno == "0")
                    {
                        MessageBox.Show("CEP inválido","Busca de CEP",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        
                        txtCep.BackColor = Color.DimGray;
                        txtEndereco.Clear();
                        txtBairro.Clear();

                    }

                    else
                    {
                        txtEndereco.Text = dsRetornaEndereco.Tables[0].Rows[0]["logradouro"].ToString();
                        txtBairro.Text = dsRetornaEndereco.Tables[0].Rows[0]["bairro"].ToString();
                        //cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                        // estado = ds.Tables[0].Rows[0]["uf"].ToString();
                    }
                }
            }
        }

        private void txttelFixo_Leave(object sender, EventArgs e)
        {
            if (txttelFixo.Text.Length >= 1 && txttelFixo.Text.Length < 10)
            {
                MessageBox.Show("Telefone inválido ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txttelFixo.Clear();
            }
        }

        private void txtCel_Leave(object sender, EventArgs e)
        {
            if (txtCel.Text.Length >= 1 && txtCel.Text.Length < 10)
            {
                MessageBox.Show("Celular inválido ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCel.Clear();
            }
        }
    }
}
