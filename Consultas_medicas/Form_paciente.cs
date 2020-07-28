using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Consultas_medicas.Models;
using Consultas_medicas.BLL;
using Consultas_medicas.DAO;
using MySql.Data.MySqlClient;
using Ferramentas;


namespace Consultas_medicas
{
    public partial class Form_paciente : Form 
    {
        public Form_paciente()
        {	//INICIALIZAÇÃO DO FORMULÁRIO, TUDO O QUE FOR COLOCADO AQUI AO INICIAR O FORMULÁRIO ELE VAI EXECUTAR
            InitializeComponent();
            listar();//método listar que criei
            listarClientes();
            btn_editar.Visible = false;
            btn_deletar.Visible = false;
            

            //-------------------------------------------//-----------------------------------------------//
        }



        private void button1_Click(object sender, EventArgs e)
        {   //BOTÃO QUE AO SER ACIONADO MUDA DE FORMULÁRIO(NOVA INSTANCIA DE OBJETO) E TORNA INVISÍVEL E FORMULARIO ATUAL
            Menu_principal novo = new Menu_principal();
            novo.Show();
            this.Visible = false;//propriedade que torna inativo o formulário atual
			//------------------------------------------//------------------------------------------------//
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {//NADA
        }//////
		
			//MÉTODO 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr HWnd, int wMsg, int wParam, int IParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
		
		private void limparCampos()
		{
			
				txtcodCliente.Clear();
				txtNome.Clear();
				txtEmail.Clear();
				txttelCelular.Clear();
				txtelFixo.Clear();
				txtEndereco.Clear();
				txtNumero.Clear();
                txtBairro.Clear();
                txtCep.Clear();
                txtComplemento.Clear();
                txtCPF2.Clear();
                txtAnimal.SelectedIndex = -1;
                txtCPF2.BackColor = Color.Black;
                txtCep.BackColor = Color.Black;
        }

        private void salvar(Clientes clientes)
        {
            try
            {
                if (txtNome.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty || txttelCelular.Text.Trim() == string.Empty ||
                    txtEndereco.Text.Trim() == string.Empty || txtNumero.Text.Trim() == string.Empty || txtBairro.Text.Trim() == string.Empty ||
                    txtCep.Text.Trim() == string.Empty || txtComplemento.Text.Trim() == string.Empty || txtCPF2.Text.Trim() == string.Empty || txtAnimal.SelectedValue == null ) 
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ClienteBLL clienteBLL = new ClienteBLL();

                    clientes.nomeCliente = txtNome.Text;
                    clientes.emailCliente = txtEmail.Text;
                    clientes.telefoneCelularCli = Convert.ToInt64(txttelCelular.Text);
                    clientes.telefoneFixoCli = Convert.ToInt64(txtelFixo.Text);
                    clientes.enderecoCliente = txtEndereco.Text;
                    clientes.numeroResidenciaCliente = Convert.ToInt32(txtNumero.Text);
                    clientes.bairroCliente = txtBairro.Text;
                    clientes.cepCliente = txtCep.Text;
                    clientes.ComplementoCliente = txtComplemento.Text;
                    clientes.cpfCliente = txtCPF2.Text;
                    clientes.CodAnimal = txtAnimal.SelectedValue.ToString();

                    clienteBLL.salvar(clientes);//modificado

                    MessageBox.Show("Cliente CADASTRADO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    listarClientes();
                    lblCPF.Visible = false;
                }

            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Informação Incorreta : CPF já existe \n" + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                       
        }

        private void btn_salvar_medico_Click(object sender, EventArgs e)
        {//método para salvar
            if (MessageBox.Show("Confirma os dados ?", "SALVAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clientes clientes = new Clientes();
                salvar(clientes);
            }
                  

        }
        public void listar()
        {//método para chamar o campo descrição animal dentro do combobox
            ClienteBLL clientebll = new ClienteBLL();           
            this.txtAnimal.DataSource = clientebll.listar();                        
            this.txtAnimal.ValueMember = "codAnimal";
            this.txtAnimal.DisplayMember = "descricaoAnimal";
			//no txtanimal, o datasource é refenciado e mostra o comando que esta no método listar, que vem da classe clienteDAO
			
            

        }
        private void listarClientes()
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            dtCliente.DataSource = clienteBLL.listarClientes();

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void Form_paciente_Load(object sender, EventArgs e)
        {
            listarClientes();
            listar();
            txtAnimal.SelectedIndex = -1;
            rd_cliente.Checked = true;

        }

        private void buscar(Clientes clientes)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void picture_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (rd_cliente.Checked == true)
            {
                if (txtPesquisa.Text == "")
                {

                    ClienteBLL clienteBLL = new ClienteBLL();
                    dtCliente.DataSource = clienteBLL.listarClientes();
                }
                else
                {
                    Clientes clientes = new Clientes();
                    pesquisar(clientes);
                }
            }


            if (rd_cpf.Checked == true)
            {
                if (txtPesquisa.Text == "")
                {
                    ClienteBLL clienteBLL = new ClienteBLL();
                    dtCliente.DataSource = clienteBLL.listarClientes();
                }
                else
                {

                    Clientes clientes = new Clientes();
                    pesquisarPORCPF(clientes);
                }
            }
        }

        private void dtCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editar.Visible = true;
            btn_deletar.Visible = true;
            btn_salvar_medico.Visible = false;

            lbl_nome.Text = dtCliente.CurrentRow.Cells[1].Value.ToString();
            lbl_cpf.Text = dtCliente.CurrentRow.Cells[2].Value.ToString();
             lbl_endereco.Text = dtCliente.CurrentRow.Cells[6].Value.ToString();
            lbl_cep.Text = dtCliente.CurrentRow.Cells[7].Value.ToString();
            lbl_bairro.Text = dtCliente.CurrentRow.Cells[8].Value.ToString();
            lbl_numero.Text = dtCliente.CurrentRow.Cells[9].Value.ToString();
            lbl_complemento.Text = dtCliente.CurrentRow.Cells[10].Value.ToString();
            lbl_email.Text = dtCliente.CurrentRow.Cells[3].Value.ToString();
            lbl_fixo.Text = dtCliente.CurrentRow.Cells[5].Value.ToString();
            lbl_cel.Text = dtCliente.CurrentRow.Cells[4].Value.ToString();
            lblAnimal.Text = dtCliente.CurrentRow.Cells[11].Value.ToString();


            txtcodCliente.Text = dtCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dtCliente.CurrentRow.Cells[1].Value.ToString();
            txtCPF2.Text = dtCliente.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = dtCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = dtCliente.CurrentRow.Cells[7].Value.ToString();
            txtBairro.Text = dtCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dtCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dtCliente.CurrentRow.Cells[10].Value.ToString();
            txtEmail.Text = dtCliente.CurrentRow.Cells[3].Value.ToString();
            txtelFixo.Text = dtCliente.CurrentRow.Cells[5].Value.ToString();
            txttelCelular.Text = dtCliente.CurrentRow.Cells[4].Value.ToString();
            txtAnimal.Text = dtCliente.CurrentRow.Cells[11].Value.ToString();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar alteração ?", "ALTERAR PACIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clientes clientes = new Clientes();
                editar(clientes);
            }
			
        }

        
        private void editar(Clientes clientes)
        {
            try
            {
                if (txtNome.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty || txttelCelular.Text.Trim() == string.Empty ||
                txtEndereco.Text.Trim() == string.Empty || txtNumero.Text.Trim() == string.Empty || txtBairro.Text.Trim() == string.Empty ||
                txtCep.Text.Trim() == string.Empty || txtComplemento.Text.Trim() == string.Empty || txtCPF2.Text.Trim() == string.Empty || txtAnimal.SelectedValue == null)
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    ClienteBLL clienteBLL = new ClienteBLL();


                    clientes.CodCliente = Convert.ToInt32(txtcodCliente.Text);
                    clientes.nomeCliente = txtNome.Text;
                    clientes.emailCliente = txtEmail.Text;
                    clientes.telefoneCelularCli = Convert.ToInt64(txttelCelular.Text);
                    clientes.telefoneFixoCli = Convert.ToInt64(txtelFixo.Text);
                    clientes.enderecoCliente = txtEndereco.Text;
                    clientes.numeroResidenciaCliente = Convert.ToInt32(txtNumero.Text);
                    clientes.bairroCliente = txtBairro.Text;
                    clientes.cepCliente = txtCep.Text;
                    clientes.ComplementoCliente = txtComplemento.Text;
                    clientes.cpfCliente = txtCPF2.Text;


                    clientes.CodAnimal = txtAnimal.SelectedValue.ToString();

                    clienteBLL.editar(clientes);//modificado

                    MessageBox.Show("Cliente ALTERADO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    btn_editar.Visible = false;
                    btn_deletar.Visible = false;
                    btn_salvar_medico.Visible = true;
                    lblCPF.Visible = false;
                    listarClientes();
                }
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
		//-----------
		private void excluir(Clientes clientes)
        {
            try
            {
                ClienteBLL clienteBLL = new ClienteBLL();

				clientes.CodCliente = Convert.ToInt32(txtcodCliente.Text);

                clienteBLL.excluir(clientes);//modificado
                            
                MessageBox.Show("Cliente EXCLUÍDO com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
				limparCampos();
                btn_editar.Visible = false;
                btn_deletar.Visible = false;
                btn_salvar_medico.Visible = true;
                lblCPF.Visible = false;
                listarClientes();

            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Permissão negada : Cliente não pode ser excluído \n " + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão ?", "EXClUIR CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clientes clientes = new Clientes();
                excluir(clientes);
            }
        }
		
		//-----------novos--------------------------
		private void pesquisar(Clientes clientes)
		{
            try
            {
                clientes.nomeCliente = txtPesquisa.Text.Trim();
                ClienteBLL clienteBLL = new ClienteBLL();
                dtCliente.DataSource = clienteBLL.pesquisar(clientes);
            }
            catch(Exception erro)
            {
                throw erro;
            }
		}

        private void pesquisarPORCPF(Clientes clientes)
        {
            try
            {

                clientes.cpfCliente = txtPesquisa.Text.Trim();
                ClienteBLL clienteBLL = new ClienteBLL();
                dtCliente.DataSource = clienteBLL.pesquisarCPF(clientes);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
         /*   if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }*/
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCPF2_Leave(object sender, EventArgs e)
        {
            if (txtCPF2.Text != "" || (txtCPF2.Text.Length >= 1 && txtCPF2.Text.Length < 11))
            {
                string validarCPF = txtCPF2.Text;

                if (Validacao.ValidaCPF(validarCPF))
                {
                    lblCPF.Visible = true;
                }
                else
                {
                    MessageBox.Show("CPF Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCPF2.Clear();

                    txtCPF2.BackColor = Color.DimGray;

                }
            }
            
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (txtCep.Text != "" || (txtCep.Text.Length >= 1 && txtCep.Text.Length < 8)) {
                {
                    string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";
                    DataSet dsRetornaEndereco = new DataSet();
                    dsRetornaEndereco.ReadXml(xml.Replace("@cep", txtCep.Text));

                    string retorno = dsRetornaEndereco.Tables[0].Rows[0]["resultado"].ToString();

                    if (retorno == "0")
                    {
                        MessageBox.Show("CEP inválido");

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

        private void txtelFixo_Leave(object sender, EventArgs e)
        {
            if (txtelFixo.Text.Length >= 1 && txtelFixo.Text.Length < 10)
            {
                MessageBox.Show("Telefone inválido ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtelFixo.Clear();
            }
        }

        private void txttelCelular_Leave(object sender, EventArgs e)
        {
            if (txttelCelular.Text.Length >= 1 && txttelCelular.Text.Length < 10)
            {
                MessageBox.Show("Celular inválido ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txttelCelular.Clear();

            }
        }

        //COLOCAR NO EVENTO CLICK ou LEAVE DO TXT CPF(mudar cpf para string)
        /*{
			string validarCPF = txtCPF2.Text;
			
			if (Validacao.IsCpf(validarCPF))
			{
				MessageBox.Show("CPF Valido");
			}
			ELSE
			{
				MessageBox.Show("CPF Inválido");
			}
		}*/

        /*COLOCAR NO EVENTO LEAVE DO TXT CEP
		{
			string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCep.Text));
			DataSet ds = new DataSet();
			ds.ReadXml(xml);
			
			string retorno = xml.Tables[0].Rows["Resultado"].toString();
			
			if (retorno == "0")
			{
				MessageBox.Show("CEP inválido")
			}
			else
			{
				txtEndereco.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
			}
			
			
		}
		*/
    }
}
