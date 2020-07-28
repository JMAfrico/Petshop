using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;
using Consultas_medicas.DAO;
using System.Data;

namespace Consultas_medicas.BLL
{
    public class ConsultaBLL
    {
        ConsultasDAO consultasDAO = new ConsultasDAO();

		
		
        public void salvar(Consultas consultas)
        {//salvar clientes
            try
            {
                consultasDAO.Salvar(consultas);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
		
		
		
        public DataTable listarClienteConsulta()
        {
            try
            {//listar cliente da tabela cliente na tabela consultas
                DataTable dt = new DataTable();
                dt = consultasDAO.listarClienteConsulta();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
		
		
		

        public DataTable listarConsulta()
        {
            try
            {//listar consultas no datatable do form principal
                DataTable dtcconsulta = new DataTable();
                dtcconsulta = consultasDAO.listarConsultas();

                return dtcconsulta;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
		
		
		
		
		
        public void editar(Consultas consultas)
        {
            try
            {
                consultasDAO.Editar(consultas);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
		
		
		
		
		
		public void excluir(Consultas consultas)
        {
            try
            {
                consultasDAO.Excluir(consultas);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
		
		
		
						//pesquisar
		public DataTable pesquisar(Consultas consultas)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = consultasDAO.Pesquisar(consultas);

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
                dt = consultasDAO.PesquisarPORCPF(clientes);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable listarAnimal()
        {
            try
            {//listar animais da tabela animal na tabela cliente
                DataTable dt = new DataTable();
                dt = consultasDAO.ListarAnimal();


                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
