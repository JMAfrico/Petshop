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
    public partial class form_prodServ_cliente : Form
    {
        public form_prodServ_cliente()
        {
            InitializeComponent();
            listarServicoCli();
            //dt_itens_servicos1.Columns["DATA"].Width = 1000;
            
            
        }

       

        public form_prodServ_cliente(String nome,DateTime data ,String cod, String preco, DateTime hora)
        {           
            InitializeComponent();
            lbl_hora.Text = hora.ToString().Substring(11);
            lbl_nome_cliente.Text = nome;
            lbl_codigo.Text = cod;
            lbl_total_geral.Text = ("R$ "+preco);
            lbl_data.Text = data.ToString().Substring(0,10);
            listarServicoCli();
            txtCliente.Text = lbl_nome_cliente.Text;
            txtData.Text = lbl_data.Text;
            txt_cod.Text = lbl_codigo.Text;
            //converterdata();
            Clientes cliente = new Clientes();
            Consultas consultas = new Consultas();
            pesquisarCliente(cliente, consultas);
            
        }

        private void converterdata(){
            DateTime dat = new DateTime();
            dat = Convert.ToDateTime(this.lbl_data.Text);
            MessageBox.Show(dat.ToString().Substring(0,10));
        }

        



        
        private void form_prodServ_cliente_Load(object sender, EventArgs e)
        {
            //pesquisaData();
            

        }

        public void listarServicoCli()
        {
            ConsultaBLL consultasbll = new ConsultaBLL();
            dt_itens_servicos1.DataSource = consultasbll.listarItensServicoCliente();
        }


        private void pesquisarCliente(Clientes cliente,Consultas consultas)
        {
            try
            {
                ConsultaBLL consultasbll = new ConsultaBLL();

                cliente.nomeCliente = txtCliente.Text.Trim();
                consultas.dataConsulta = Convert.ToDateTime(txtData.Text.Trim());

                dt_itens_servicos1.DataSource = consultasbll.pesquisarItensServicoCliente(cliente,consultas);
           

            }
            catch (System.Exception erro)
            {
                throw erro;
            }

        }

        private void pesquisarData(Consultas consulta)
        {
           /* try
            {
                
                consulta.dataConsulta = Convert.ToDateTime(txtData.Text);

                ConsultaBLL consultasbll = new ConsultaBLL();

                dt_itens_servicos.DataSource = consultasbll.listarItensServicoClienteData(consulta);

            }
            catch (System.Exception erro)
            {
                throw erro;
            }*/

        }

        

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            /*if (txtCliente.Text != "")
            {
                Clientes cliente = new Clientes();
                Consultas consultas = new Consultas();
                pesquisarCliente(cliente,consultas);
            }*/

            /*if (txtData.Text != "")
            {
                Clientes cliente = new Clientes();
                Consultas consultas = new Consultas();
                pesquisarCliente(cliente, consultas);
            }*/
                          
        }

        private void lbl_nome_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            /*Consultas consulta = new Consultas();

            if (txtData.Text != "")
            {

                pesquisarData(consulta);
            }*/
        }

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {

        }


        public void pesquisaData()
        {
            string pesquisar = txtData.Text;
            var indice = -1;

            foreach (DataGridViewRow row in dt_itens_servicos1.Rows)
            {

                if (row.Cells["DATA"].Value.ToString().Equals(pesquisar))
                {
                    row.Selected = true;
                    indice = row.Index;
                    MessageBox.Show("Data Localizada posição = " + indice);
                    break;
                }
            }
            
    
            if (indice != -1)//cliente encontrado, vai pra posição
            {
                dt_itens_servicos1.CurrentCell = dt_itens_servicos1.Rows[indice].Cells[0];
            }

            if (indice == -1)//cliente não encontrado, mostra mensagem
            {
                MessageBox.Show("Data não encontrada");              
            }
            //txtPesquisa.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Clientes cliente = new Clientes();
            Consultas consultas = new Consultas();
            pesquisarCliente(cliente, consultas);*/
            //DataGridViewRow row = dt_itens_servicos1.Rows[0];
            //row.Height = 50;
        }


        

    }
}
