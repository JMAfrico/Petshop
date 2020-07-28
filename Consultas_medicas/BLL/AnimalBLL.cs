using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;// IMPORTAR A TABELA MODELS ONDE TEM AS CARACTERISTICAS DAS TABELAS
using Consultas_medicas.DAO; // IMPORTAR PASTA DAO ONDE ESTA A CONEXAO E O AnimaisDAO QUE CONTEM O COMMAND
using System.Data;

namespace Consultas_medicas.BLL
{
    public class AnimalBLL
    {
        AnimaisDAO animaisDao = new AnimaisDAO(); // CRIEI UM OBJETO DO TIPO ANIMAISDAO
		
		//pesquisar
		public DataTable pesquisar(Animais animais)
        {
            try
            {
                AnimaisDAO animaisDao = new AnimaisDAO();

                DataTable dt = new DataTable();
                dt = animaisDao.Pesquisar(animais);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
		
		//salvar
        public void salvar (Animais animal) // CRIEI UM MÉTODO SALVAR, QUE TEM COMO PARAMETRO A CLASSE ANIMAIS, OU SEJA , HERDA AS CARACTERISTICAS
        {									// DA CLASSE MODELS.ANIMAIS
            try
            {
                animaisDao.Salvar(animal);  // OBJETO QUE CRIEI, CHAMA O MÉTODO SALVAR QUE ESTÁ NA CLASSE DAO, E SALVA DENTRO DO PARAMETRO animal
            }
            catch(Exception erro)
            {
                throw erro;
            }

        }
		
		
		
		//listar clientes
        public DataTable listarAnimais()
        {
            try
            {
                DataTable dtanimais = new DataTable();
                dtanimais = animaisDao.listarAnimais();

                return dtanimais;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
		
		
		
		
		//editar
        public void editar(Animais animais)
        {
            try
            {
                animaisDao.Editar(animais);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
		
		
		//excluir
		public void excluir(Animais animais)
        {
            try
            {
                animaisDao.Excluir(animais);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        /*public DataTable pesquisarPETNOME(Animais animais)
        {
            try
            {
                AnimaisDAO animaisDao = new AnimaisDAO();

                DataTable dt = new DataTable();
                dt = animaisDao.PesquisarPETNOME(animais);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }*/

    }
}
