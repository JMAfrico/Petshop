using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;
using Consultas_medicas.DAO;
using System.Data;
using Ferramentas;

namespace Consultas_medicas.BLL
{
    public class ClienteBLL
    {
        ClientesDAO clientesDAO = new ClientesDAO();
		
		
		
		

        public void salvar(Clientes clientes)
        {//salvar clientes
            try
            {
                clientesDAO.Salvar(clientes);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
		
		
		
		
        public DataTable listar()
        {
            try
            {//listar animais da tabela animal na tabela cliente
                DataTable dt = new DataTable();
                dt = clientesDAO.listar();


                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

		
		
		
		
        public DataTable listarClientes()
        {
            try
            {//listar clientes
                DataTable dtclientes = new DataTable();
                dtclientes = clientesDAO.listarClientes();

                return dtclientes;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
		
		
		
		
        public void editar(Clientes clientes)
        {
            try
            {
                clientesDAO.Editar(clientes);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
		
		
		
	    public void excluir(Clientes clientes)
        {
            try
            {
                clientesDAO.Excluir(clientes);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
		
		
				//pesquisar
		public DataTable pesquisar(Clientes clientes)
        {
            try
            {
                ClientesDAO clientesDAO = new ClientesDAO();
                DataTable dt = new DataTable();
                dt = clientesDAO.Pesquisar(clientes);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisarCPF(Clientes clientes)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clientesDAO.PesquisarPORCPF(clientes);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
