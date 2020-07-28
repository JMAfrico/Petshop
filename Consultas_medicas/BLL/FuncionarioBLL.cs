using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;
using Consultas_medicas.DAO;
using System.Data;  

namespace Consultas_medicas.BLL
{
    public class FuncionarioBLL
    {
        FuncionariosDAO funcionarioDAO = new FuncionariosDAO();

		
		
		
		
        public void salvar(Funcionarios funcionario)
        {
            try
            {
                funcionarioDAO.Salvar(funcionario);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
		
		
		
		
        public DataTable listarFuncionarios()
        {
            try
            {//listar clientes
                DataTable dtfunc = new DataTable();
                dtfunc = funcionarioDAO.listarFuncionarios();

                return dtfunc;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
		
		
		
		
        public void editar(Funcionarios funcionario)
        {
            try
            {
                funcionarioDAO.Editar(funcionario);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
		
		
		
		public void excluir(Funcionarios funcionario)
        {
            try
            {
                funcionarioDAO.Excluir(funcionario);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
		
		//pesquisar
		public DataTable pesquisar(Funcionarios funcionario)
        {
            try
            {
                
                DataTable dt = new DataTable();
                dt = funcionarioDAO.Pesquisar(funcionario);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


    }
}
