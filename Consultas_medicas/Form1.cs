using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Runtime.InteropServices;
using Consultas_medicas.Models;
using Consultas_medicas.BLL;
using Consultas_medicas.DAO;
using Ferramentas;


namespace Consultas_medicas
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
            listarConsultas();
            listar();
            btn_editar.Visible = false;
            btn_deletar.Visible = false;
            //listarAnimal();
            limparCampos();
        }
		


        private void Menu_principal_Load(object sender, EventArgs e)
        {//COMEÇA MOSTRANDO A HORA NO SISTEMA
            listarConsultas();
            listar();
            limparCampos();
          //  listarAnimal();

            label1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            rd_cliente.Checked = true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
 

        }



        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_medico novo = new Form_medico();
            novo.ShowDialog();
            this.Visible = false;
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_paciente novo = new Form_paciente();
            novo.ShowDialog();
            this.Visible = false;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /*private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                //STRING DE CONEXAO, CRIEI UM OBJETO , E INSTANCIEI ELE COM O MÉTODO CONNECTIONSTRING
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "server=localhost;user=root;database=petshop;port=3306;password=root;";
                //STRING DE COMANDOS, CRIEI UM OBJETO CHAMADO CMD , E ELE VAI MANIPULAR MEUS DADOS
                MySqlCommand cmd = new MySqlCommand();
                MessageBox.Show("Conectado");
            }
            catch
            {
                MessageBox.Show("Nao conectou");
            }
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picture_fechar_Click(object sender, EventArgs e)
        {//FECHA A APLICAÇÃO

            if (MessageBox.Show("Deseja Sair ?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void picture_diminuir_Click(object sender, EventArgs e)
        {//DIMINUI A DIMENSÃO DA TELA
            this.WindowState = FormWindowState.Maximized;
            picture_diminuir.Visible = false;
            picture_restaurar.Visible = true;
            dtConsultas.Width = 1000;
            dtConsultas.Height = 600;
        }

        private void picture_restaurar_Click(object sender, EventArgs e)
        {//RESTAURA A DIMENSÃO DA TELA
            this.WindowState = FormWindowState.Normal;
            picture_restaurar.Visible = false;
            picture_diminuir.Visible = true;
            dtConsultas.Width = 771;
            dtConsultas.Height = 484;
        }

        private void picture_minimizar_Click(object sender, EventArgs e)
        {// MINIMIZA A TELA
            this.WindowState = FormWindowState.Minimized;
        }
        // MOVER A TELA--------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr HWnd, int wMsg, int wParam, int IParam);

        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //------------------------------------------------
        private void btn_cadastraa_Click(object sender, EventArgs e)
        {

            if (btn_cad_cliente.Visible == true && btn_cad_funcionario.Visible == true && btn_cad_pet.Visible == true && btn_cad_func.Visible == true)
            {
                btn_cad_cliente.Visible = false;
                btn_cad_funcionario.Visible = false;
                btn_cad_pet.Visible = false;
                btn_cad_func.Visible = false;
            }
            else
            {
                btn_cad_cliente.Visible = true;
                btn_cad_funcionario.Visible = true;
                btn_cad_pet.Visible = true;
                btn_cad_func.Visible = true;
            }

            
            
                    
        }

        private void btn_cad_cliente_Click(object sender, EventArgs e)
        {
            Form_paciente novo = new Form_paciente();
            novo.ShowDialog();
            this.Visible = false;
        }

        private void btn_cad_funcionario_Click(object sender, EventArgs e)
        {
            Form_medico n2 = new Form_medico();
            n2.ShowDialog();
            this.Visible = false;
        }

        private void btn_cad_pet_Click(object sender, EventArgs e)
        {
            form_animal n1 = new form_animal();
            n1.ShowDialog();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
                //CONTROLE ESTÁ ASSOCIADO A DATA NO FORMULARIO LOAD, AQUI SÓ ESTÁ DIZENDO
                //QUE A DATA ESTÁ NO LABEL1
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //CONTROLE ESTÁ ASSOCIADO A HORA DO COMANDO TIMER1, AQUI SÓ ESTÁ DIZENDO
            //QUE A DATA ESTÁ NO LABEL2
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_cad_func_Click(object sender, EventArgs e)
        {
            Form_Funcionario novo = new Form_Funcionario();
            novo.ShowDialog();
            this.Visible = false;
        }

        private void btn_cad_pet_Click_1(object sender, EventArgs e)
        {
            form_animal novo = new form_animal();
            novo.ShowDialog();
            this.Visible = false;
        }

        private void btn_cad_func_Click_1(object sender, EventArgs e)
        {
            Form_Funcionario novo = new Form_Funcionario();
            novo.ShowDialog();
            this.Visible = false;
        }

        private void Barra_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salvar(Consultas consultas)
        {
            try
            {
				 if (txtRelato.Text.Trim() == string.Empty || cbCliente.SelectedValue == null || data_consulta.Text.Trim() == string.Empty || hora_consulta.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
					ConsultaBLL consultaBLL = new ConsultaBLL();
                    AnimalBLL animal = new AnimalBLL();

					consultas.CodCliente = cbCliente.SelectedValue.ToString();
					consultas.relatoConsulta = txtRelato.Text;
					consultas.dataConsulta = Convert.ToDateTime(data_consulta.Text);
					consultas.horaConsulta = Convert.ToDateTime(hora_consulta.Text);


					consultaBLL.salvar(consultas);
					MessageBox.Show("Consulta CADASTRADA com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

					limparCampos();
					listarConsultas();
				}
				

            }
            catch (Exception erro)
            {
                MessageBox.Show("OPS..ERRO, VERIFIQUE SE OS CAMPOS ESTÃO CORRETOS " + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		
		
		private void limparCampos()
		{
			txtCodconsulta.Clear();
			//txtRelato.Clear();
			cbCliente.SelectedIndex = -1;
            hora_consulta.Text = string.Empty;//deixa a hora vzaia

		}

        public void listar()
        {//método para chamar o campo nome cliente dentro do combobox
            ConsultaBLL consultaBLL = new ConsultaBLL();
            this.cbCliente.DataSource = consultaBLL.listarClienteConsulta();
            this.cbCliente.ValueMember = "CodCliente";
            this.cbCliente.DisplayMember = "nomeCliente";
        }

      /* private void listarAnimal()
        {//método para chamar o campo descrição animal dentro do combobox
            ConsultaBLL consultaBLL = new ConsultaBLL();
            this.txtRelato.DataSource = consultaBLL.listarAnimal();
            this.txtRelato.ValueMember = "codAnimal";
            this.txtRelato.DisplayMember = "descricaoAnimal";
            //no txtanimal, o datasource é refenciado e mostra o comando que esta no método listar, que vem da classe clienteDAO
        }*/

        private void listarConsultas()
        {
            ConsultaBLL consultaBLL = new ConsultaBLL(); 
            dtConsultas.DataSource = consultaBLL.listarConsulta();

        }

        private void btn_salvar_consulta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma os dados ?", "SALVAR CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Consultas consultas = new Consultas();
                salvar(consultas);
            }
        }

        private void editar(Consultas consultas)
        {
            try
            {
				if (txtRelato.Text.Trim() == string.Empty || cbCliente.SelectedValue == null || data_consulta.Text.Trim() == string.Empty || hora_consulta.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
					ConsultaBLL consultaBLL = new ConsultaBLL();

					consultas.codConsulta = Convert.ToInt32(txtCodconsulta.Text);
					consultas.CodCliente = cbCliente.SelectedValue.ToString();
					consultas.relatoConsulta = txtRelato.Text;
					consultas.dataConsulta = Convert.ToDateTime(data_consulta.Text);
					consultas.horaConsulta = Convert.ToDateTime(hora_consulta.Text);

					consultaBLL.editar(consultas);


					MessageBox.Show("Consulta ALTERADA com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					limparCampos();
					btn_editar.Visible = false;
					btn_deletar.Visible = false;
					btn_salvar_consulta.Visible = true;
					listarConsultas();
				}

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
		
		private void excluir(Consultas consultas)
        {
            try
            {
                ConsultaBLL consultaBLL = new ConsultaBLL();

				consultas.codConsulta = Convert.ToInt32(txtCodconsulta.Text);

                consultaBLL.excluir(consultas);


                MessageBox.Show("Consulta EXCLUÍDA com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                btn_editar.Visible = false;
                btn_deletar.Visible = false;
                btn_salvar_consulta.Visible = true;
                listarConsultas();

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void dtConsultas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editar.Visible = true;
            btn_deletar.Visible = true;
            btn_salvar_consulta.Visible = false;

            cbCliente.Text = dtConsultas.CurrentRow.Cells[1].Value.ToString();
            txtCodconsulta.Text = dtConsultas.CurrentRow.Cells[0].Value.ToString();
            txtRelato.Text = dtConsultas.CurrentRow.Cells["RELATO"].Value.ToString();
            data_consulta.Text = dtConsultas.CurrentRow.Cells["DATA"].Value.ToString();
            hora_consulta.Text = dtConsultas.CurrentRow.Cells["HORA"].Value.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar alteração ?", "ALTERAR CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Consultas consultas = new Consultas();
                editar(consultas);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão ?", "EXClUIR CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Consultas consultas = new Consultas();
                excluir(consultas);
            }
        }
		
				//-----------novos--------------------------
		private void pesquisar(Consultas consultas)
		{
            try
            {
                consultas.CodCliente = txtPesquisar.Text.Trim();
                ConsultaBLL consultaBLL = new ConsultaBLL();
                dtConsultas.DataSource = consultaBLL.pesquisar(consultas);
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
                
                clientes.cpfCliente = txtPesquisar.Text.Trim();
                ConsultaBLL consultaBLL = new ConsultaBLL();
                dtConsultas.DataSource = consultaBLL.pesquisarCPF(clientes);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void TxtRelato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
           if (rd_cliente.Checked == true)
            {
                if (txtPesquisar.Text == "")
                {
                    ConsultaBLL consultaBLL = new ConsultaBLL();
                    dtConsultas.DataSource = consultaBLL.listarConsulta();
                }
                else
                {
                    Consultas consultas = new Consultas();
                    pesquisar(consultas);
                }
            }

            if (rd_cpf.Checked == true)
            {
                if (txtPesquisar.Text == "")
                {
                    ConsultaBLL consultaBLL = new ConsultaBLL();
                   dtConsultas.DataSource = consultaBLL.listarConsulta();
                }
                else
                {

                    Clientes clientes = new Clientes();
                    pesquisarPORCPF(clientes);
                }
            
            }
        }

        

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
         //   {

               // e.Handled = true;
           // }
        }

        private void hora_consulta_Click(object sender, EventArgs e)
        {           
            hora_consulta.SelectionStart = 0;//quando clica inicia na posição zero
            hora_consulta.Focus();
        }

        private void hora_consulta_Leave(object sender, EventArgs e)
        {

        }

        private void data_consulta_ValueChanged(object sender, EventArgs e)
        {

        }


        private bool ValidaData(string data)
        {
            bool retorno = true;

            string dataValidacao = DateTime.Now.ToShortDateString();
            DateTime dataValida = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            if (Convert.ToDateTime(data_consulta.Text) < Convert.ToDateTime(dataValidacao))
            {
                MessageBox.Show("Data inválida ","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                retorno = false;
            }

            return retorno;
        }

        private void data_consulta_Leave(object sender, EventArgs e)
        {
            if (ValidaData(data_consulta.Text) == false)
            {
                data_consulta.Focus();
                data_consulta.ResetText();
            }
        }


    }
}
