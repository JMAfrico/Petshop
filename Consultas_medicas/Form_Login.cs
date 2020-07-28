using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Consultas_medicas.DAO;
using Consultas_medicas.BLL;
using Consultas_medicas.Models;


namespace Consultas_medicas
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {


        }

        private void txtSenha_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {


        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_cadastrar_login novo = new Form_cadastrar_login();
            novo.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginDAO login = new LoginDAO();
            login.verificarLogin(txtlogin.Text, txtSenha.Text);
            {
                if (login.tem)
                {
                    MessageBox.Show("Login Efetuado com sucesso","LOGIN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Menu_principal novo = new Menu_principal();
                    novo.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos,tente novamente","LOGIN",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
