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

namespace Consultas_medicas
{
    public partial class form_animal : Form
    {
        public form_animal()
        {
            InitializeComponent();
            listarAnimais();
            btn_editar.Visible = false;
            btn_deletar.Visible = false;
        }
		
		private void limparCampos()
		{
			//txtNome.Clear();
            txtRaca.Clear();
            cbSexo.SelectedIndex = 0;
            txtCodAnimal.Clear();
		}

		//salvar
        private void salvar(Animais animais)
        {
            try
            {
				if(txtRaca.Text.Trim()== string.Empty || /*txtNome.Text.Trim() == string.Empty ||*/ cbSexo.Text.Trim() == string.Empty)
				{
					MessageBox.Show("Informações obrigatórias não preenchidas","Atenção" ,MessageBoxButtons.OK , MessageBoxIcon.Error);
				}
				else
				{
					             
                    AnimalBLL animaisBll = new AnimalBLL();

                    animais.descricaoAnimal = txtRaca.Text;
                    //animais.nomeAnimal = txtNome.Text;
                    animais.sexoAnimal = cbSexo.Text;
                    animaisBll.salvar(animais);

                    MessageBox.Show("Animal CADASTRADO com sucesso!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarAnimais();
                    limparCampos();
				}
				

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
		
		//excluir
		private void excluir(Animais animais)
        {
            try
            {
                    AnimalBLL animaisBll = new AnimalBLL();

					animais.codAnimal = Convert.ToInt32(txtCodAnimal.Text);

                    animaisBll.excluir(animais);
						//ou Excluir com maiusculo
                    MessageBox.Show("Animal EXCLUÍDO com sucesso!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					limparCampos();
                    btn_editar.Visible = false;
                    btn_deletar.Visible = false;
                    btn_salvar_medico.Visible = true;
                    listarAnimais();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Você não tem permissão para deletar" + erro.Message, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                

                
            }

        }

		//listar
        private void listarAnimais()
        {
            AnimalBLL animalBLL = new AnimalBLL();
            dtAnimal.DataSource = animalBLL.listarAnimais();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // MOVER A TELA--------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr HWnd, int wMsg, int wParam, int IParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btn_salvar_medico_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma os dados ?", "SALVAR ANIMAL ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Animais animais = new Animais();
                salvar(animais);
            }
			
                   
        }



        private void txtRaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picture_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dtAnimal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editar.Visible = true;
            btn_deletar.Visible = true;
            btn_salvar_medico.Visible = false;

            lblSexo.Text = dtAnimal.CurrentRow.Cells[1].Value.ToString();
            lblRaca.Text = dtAnimal.CurrentRow.Cells[2].Value.ToString();
           // lblNome.Text = dtAnimal.CurrentRow.Cells[3].Value.ToString();

            txtCodAnimal.Text = dtAnimal.CurrentRow.Cells[0].Value.ToString();
            cbSexo.Text = dtAnimal.CurrentRow.Cells[1].Value.ToString();
            txtRaca.Text = dtAnimal.CurrentRow.Cells[2].Value.ToString();
          //  txtNome.Text = dtAnimal.CurrentRow.Cells[3].Value.ToString();
        }
		
		//editar
        private void editar(Animais animais)
        {
            try
            {
                if (txtRaca.Text.Trim() == string.Empty || /*txtNome.Text.Trim() == string.Empty ||*/ cbSexo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informações obrigatórias não preenchidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AnimalBLL animaisBll = new AnimalBLL();

                    animais.codAnimal = Convert.ToInt32(txtCodAnimal.Text);
                    animais.descricaoAnimal = txtRaca.Text;
                   // animais.nomeAnimal = txtNome.Text;
                    animais.sexoAnimal = cbSexo.Text;

                    animaisBll.editar(animais);

                    MessageBox.Show("Animal ALTERADO com sucesso!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    listarAnimais();
                    btn_editar.Visible = false;
                    btn_deletar.Visible = false;
                    btn_salvar_medico.Visible = true;
                }

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar alteração ?", "ALTERAR ANIMAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Animais animais = new Animais();
                editar(animais);
            }

        }

		private void pesquisar(Animais animais)
		{
            try
            {
                animais.descricaoAnimal = textBox1.Text.Trim();
                AnimalBLL animaisBll = new AnimalBLL();			                       
                dtAnimal.DataSource = animaisBll.pesquisar(animais);
            }
            catch(Exception erro)
            {
                throw erro;
            }
		}

      /*  private void pesquisarPORNOME(Animais animais)
        {
            try
            {
                animais.nomeAnimal = textBox1.Text.Trim();
                AnimalBLL animaisBll = new AnimalBLL();
                dtAnimal.DataSource = animaisBll.pesquisarPETNOME(animais);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }*/

        private void txtRaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

                if (textBox1.Text == "")
                {

                    AnimalBLL animalBLL = new AnimalBLL();
                    dtAnimal.DataSource = animalBLL.listarAnimais();

                }
                else
                {
                    Animais animais = new Animais();
                    pesquisar(animais);
                }
            
                
            

        }
        

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão ?", "EXCLUIR ANIMAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Animais animais = new Animais();
                excluir(animais);
            }
        }

        private void form_animal_Load(object sender, EventArgs e)
        {
            listarAnimais();
            //rd_raca.Checked = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }
        }
    }
}
