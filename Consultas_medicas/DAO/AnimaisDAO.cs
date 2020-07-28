using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;//IMPORTAR PASTA MODEL
using MySql.Data.MySqlClient;
using System.Data;

namespace Consultas_medicas.DAO
{
    //PASSO 3 : AQUI FICA OS COMANDOS PARA MEXER NA TABELA

    public class AnimaisDAO : conexao // HERDA A CLASSE CONEXÃO
    {
        MySqlCommand comando = null;

		//pesquisar
		public DataTable Pesquisar(Animais animais)
        {
            try
            {
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtanimais = new DataTable();
                
                comando = new MySqlCommand("SELECT codAnimal AS 'CODIGO' ,sexoAnimal AS 'SEXO',descricaoAnimal AS 'RACA' FROM tb_animal WHERE descricaoAnimal LIKE @descricaoAnimal '%' ORDER BY descricaoAnimal", conection);
                comando.Parameters.AddWithValue("@descricaoAnimal", animais.descricaoAnimal);
				
                da.SelectCommand = comando;
                da.Fill(dtanimais);
                return dtanimais;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
		
		//salvar 
        public void Salvar(Animais animais) // CLASSE ANIMAL, OBJETO CRIADO POR MIN AQUI animais
        {
            try
            {
                AbrirConexao();//USA O MÉTODO ABRICONEXAO() HERDADO DA CLASSE CONEXAO

                comando = new MySqlCommand("INSERT INTO tb_animal(sexoAnimal, descricaoAnimal) VALUES (@sexo,@descricao)",conection);
                comando.Parameters.AddWithValue("@sexo",animais.sexoAnimal);
                comando.Parameters.AddWithValue("@descricao", animais.descricaoAnimal);
                //comando.Parameters.AddWithValue("@nome", animais.nomeAnimal);

                comando.ExecuteNonQuery();

                
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
		
		//listar animais no datatable
        public DataTable listarAnimais()
        {
            try
            {//MOSTRAR A LISTA DE CLIENTES
                AbrirConexao();

                DataTable dtanimais = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT codAnimal AS 'CODIGO' ,sexoAnimal AS 'SEXO',descricaoAnimal AS 'RACA' FROM tb_animal ", conection);
                da.SelectCommand = comando;
                da.Fill(dtanimais);
                return dtanimais;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
		
		//editar
        public void Editar(Animais animais) // CLASSE ANIMAL, OBJETO CRIADO POR MIN AQUI animais
        {
            try
            {
                AbrirConexao();//USA O MÉTODO ABRICONEXAO() HERDADO DA CLASSE CONEXAO

                comando = new MySqlCommand("UPDATE tb_animal SET sexoAnimal = @sexo, descricaoAnimal = @descricao WHERE codAnimal = @codAnimal ", conection);
                comando.Parameters.AddWithValue("@sexo", animais.sexoAnimal);
                comando.Parameters.AddWithValue("@descricao", animais.descricaoAnimal);
                //comando.Parameters.AddWithValue("@nome", animais.nomeAnimal);
                comando.Parameters.AddWithValue("@codAnimal", animais.codAnimal);

                comando.ExecuteNonQuery();


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
		//excluir
        public void Excluir(Animais animais) 
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tb_animal WHERE codAnimal = @codAnimal ", conection);

                comando.Parameters.AddWithValue("@codAnimal", animais.codAnimal);
                comando.ExecuteNonQuery();


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

       /* public DataTable PesquisarPETNOME(Animais animais)
        {
            try
            {
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtanimais = new DataTable();

                comando = new MySqlCommand("SELECT codAnimal AS 'CODIGO' ,sexoAnimal AS 'SEXO',descricaoAnimal AS 'RACA',nomeAnimal AS 'NOME' FROM tb_animal WHERE nomeAnimal LIKE @nomeAnimal '%' ORDER BY nomeAnimal", conection);
                comando.Parameters.AddWithValue("@nomeAnimal", animais.nomeAnimal);

                da.SelectCommand = comando;
                da.Fill(dtanimais);
                return dtanimais;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }*/


    }
    
}
