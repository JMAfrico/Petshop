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

namespace Consultas_medicas
{
    public partial class Cad_consulta : Form
    {
        public Cad_consulta()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cad_consulta_Load(object sender, EventArgs e)
        {
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_principal novo = new Menu_principal();
            novo.Show();
            this.Visible = false;
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

        private void salvar(Consultas consultas)
        {
            try
            {
                ConsultaBLL consultaBLL = new ConsultaBLL();

                consultas.CodCliente = cbCliente.SelectedValue.ToString();
                consultas.relatoConsulta = txtRelato.Text;
                consultas.dataConsulta = Convert.ToDateTime(data_consulta);
                consultas.horaConsulta = Convert.ToDateTime(hora_consulta);

                consultaBLL.salvar(consultas);


                MessageBox.Show("Consulta cadastrada com sucesso !", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //listarClientes();

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void listar()
        {//método para chamar o campo nome cliente dentro do combobox
            ConsultaBLL consultaBLL = new ConsultaBLL();
            this.cbCliente.DataSource = consultaBLL.listarClienteConsulta();
            this.cbCliente.ValueMember = "CodCliente";
            this.cbCliente.DisplayMember = "nomeCliente";
        }

        private void listarConsultas()
        {


        }
    }
}
