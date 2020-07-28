using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Consultas_medicas.DAO
{
    public class ClientesDAO : conexao
    {
        MySqlCommand comando = null;

        // INSERIR CLIENTE


        public void Salvar(Clientes clientes)
        { 
            try
            {
                AbrirConexao();

                    comando = new MySqlCommand("INSERT INTO tb_cliente(CodAnimal,nomeCliente,emailCliente,TelefoneCelularCli,TelefoneFixoCli,enderecoCliente,numeroResidenciaCliente,bairroCliente,cepCliente,complementoCliente,cpfCliente)VALUES (@CodAnimal,@nomeCliente,@emailCliente,@TelefoneCelularCli,@TelefoneFixoCli,@enderecoCliente,@numeroResidenciaCliente,@bairroCliente,@cepCliente,@complementoCliente,@cpfCliente)", conection);
                    comando.Parameters.AddWithValue("@CodAnimal", clientes.CodAnimal);
                    comando.Parameters.AddWithValue("@nomeCliente", clientes.nomeCliente);
                    comando.Parameters.AddWithValue("@emailCliente", clientes.emailCliente);
                    comando.Parameters.AddWithValue("@TelefoneCelularCli", clientes.telefoneCelularCli);
                    comando.Parameters.AddWithValue("@TelefoneFixoCli", clientes.telefoneFixoCli);
                    comando.Parameters.AddWithValue("@enderecoCliente", clientes.enderecoCliente);
                    comando.Parameters.AddWithValue("@numeroResidenciaCliente", clientes.numeroResidenciaCliente);
                    comando.Parameters.AddWithValue("@bairroCliente", clientes.bairroCliente);
                    comando.Parameters.AddWithValue("@cepCliente", clientes.cepCliente);
                    comando.Parameters.AddWithValue("@complementoCliente", clientes.ComplementoCliente);
                    comando.Parameters.AddWithValue("@cpfCliente", clientes.cpfCliente);

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
		
		//LISTAR NO COMBOBOX O ANIMAL DA TABELA ANIMAIS
        public DataTable listar()
        {
            try
            {

                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT descricaoAnimal,codAnimal FROM tb_animal", conection);
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

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
		
		//MOSTRAR A LISTA DE CLIENTES
        public DataTable listarClientes()
        {
            try
            {
                AbrirConexao();

                DataTable dtclientes = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT CodCliente AS 'CODIGO',nomeCliente AS 'CLIENTE',cpfCliente AS 'CPF',emailCliente AS 'EMAIL',TelefoneCelularCli AS 'CELULAR',TelefoneFixoCli AS 'TELEFONE',enderecoCliente AS 'ENDERECO',cepCliente AS 'CEP',bairroCliente AS 'BAIRRO',numeroResidenciaCliente AS 'NUMERO',complementoCliente AS 'COMPLEMENTO' , descricaoAnimal AS 'ANIMAL 'FROM tb_cliente,tb_animal WHERE tb_animal.codAnimal = tb_cliente.CodAnimal ORDER BY CodCliente", conection);
                da.SelectCommand = comando;
                da.Fill(dtclientes);
                return dtclientes;

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
		
		// EDITAR CLIENTES
        public void Editar(Clientes clientes)
        {
            try
            { 
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tb_cliente SET CodAnimal = @CodAnimal,nomeCliente = @nomeCliente,emailCliente = @emailCliente,TelefoneCelularCli = @TelefoneCelularCli ,TelefoneFixoCli = @TelefoneFixoCli,enderecoCliente = @enderecoCliente,numeroResidenciaCliente = @numeroResidenciaCliente,bairroCliente = @bairroCliente,cepCliente = @cepCliente,complementoCliente = @complementoCliente,cpfCliente = @cpfCliente WHERE CodCliente = @CodCliente", conection);

                comando.Parameters.AddWithValue("@CodCliente", clientes.CodCliente);
                comando.Parameters.AddWithValue("@CodAnimal", clientes.CodAnimal);
                comando.Parameters.AddWithValue("@nomeCliente", clientes.nomeCliente);
                comando.Parameters.AddWithValue("@emailCliente", clientes.emailCliente);
                comando.Parameters.AddWithValue("@TelefoneCelularCli", clientes.telefoneCelularCli);
                comando.Parameters.AddWithValue("@TelefoneFixoCli", clientes.telefoneFixoCli);
                comando.Parameters.AddWithValue("@enderecoCliente", clientes.enderecoCliente);
                comando.Parameters.AddWithValue("@numeroResidenciaCliente", clientes.numeroResidenciaCliente);
                comando.Parameters.AddWithValue("@bairroCliente", clientes.bairroCliente);
                comando.Parameters.AddWithValue("@cepCliente", clientes.cepCliente);
                comando.Parameters.AddWithValue("@complementoCliente", clientes.ComplementoCliente);
                comando.Parameters.AddWithValue("@cpfCliente", clientes.cpfCliente);

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
		
		
		//EXCLUIR CLIENTES
		public void Excluir(Clientes clientes) 
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tb_cliente WHERE CodCliente = @CodCliente ", conection);

                comando.Parameters.AddWithValue("@CodCliente", clientes.CodCliente);

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
		
		public DataTable Pesquisar(Clientes clientes)
        {
            try
            {//Pesquisa DE CLIENTES
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtclientes = new DataTable();
                
                comando = new MySqlCommand("SELECT CodCliente AS 'CODIGO', nomeCliente AS 'CLIENTE', cpfCliente AS 'CPF', emailCliente AS 'EMAIL', TelefoneCelularCli AS 'CELULAR', TelefoneFixoCli AS 'TELEFONE', enderecoCliente AS 'ENDERECO', cepCliente AS 'CEP', bairroCliente AS 'BAIRRO', numeroResidenciaCliente AS 'NUMERO', complementoCliente AS 'COMPLEMENTO' FROM tb_cliente WHERE nomeCliente LIKE @nomeCliente '%' ORDER BY nomeCliente", conection);
                comando.Parameters.AddWithValue("@nomeCliente", clientes.nomeCliente);
                da.SelectCommand = comando;
                da.Fill(dtclientes);
                return dtclientes;

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

        public DataTable PesquisarPORCPF(Clientes clientes)
        {
            try
            {//PESQUISA DE CLIENTES NA TABELA CONSULTAS
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtconsultas = new DataTable();

                comando = new MySqlCommand("SELECT CodCliente AS 'CODIGO', nomeCliente AS 'CLIENTE', cpfCliente AS 'CPF', emailCliente AS 'EMAIL', TelefoneCelularCli AS 'CELULAR', TelefoneFixoCli AS 'TELEFONE', enderecoCliente AS 'ENDERECO', cepCliente AS 'CEP', bairroCliente AS 'BAIRRO', numeroResidenciaCliente AS 'NUMERO', complementoCliente AS 'COMPLEMENTO' FROM tb_cliente WHERE cpfCliente LIKE @cpfCliente '%' ORDER BY cpfCliente ", conection);
                comando.Parameters.AddWithValue("@cpfCliente", clientes.cpfCliente);
                da.SelectCommand = comando;
                da.Fill(dtconsultas);
                return dtconsultas;

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

    }
}
