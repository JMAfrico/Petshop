﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Consultas_medicas.DAO
{
    public class FuncionariosDAO : conexao
    {
        MySqlCommand comando = null;

        public void Salvar(Funcionarios funcionarios)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tb_funcionario(nomeFuncionario,sobrenomeFuncionario,emailFuncionario,telefoneFixoFunc,telefoneCelularFunc,enderecoFuncionario,bairroFuncionario,cepFuncionario,numeroResidenciaFuncionario,complementoFuncionario) VALUES (@nome,@sobrenome,@email,@TelefoneFixo,@TelefoneCelular,@endereco,@bairro,@cep,@numeroResidencia,@complemento)", conection);

                comando.Parameters.AddWithValue("@nome", funcionarios.nomeFuncionario);
                comando.Parameters.AddWithValue("@sobrenome", funcionarios.sobrenomeFuncionario);
                comando.Parameters.AddWithValue("@email", funcionarios.emailFuncionario);
                comando.Parameters.AddWithValue("@TelefoneFixo", funcionarios.telefoneFixoFunc);
                comando.Parameters.AddWithValue("@TelefoneCelular", funcionarios.telefoneCelularFunc);
                comando.Parameters.AddWithValue("@endereco", funcionarios.enderecoFuncionario);
                comando.Parameters.AddWithValue("@bairro", funcionarios.bairroFuncionario);
                comando.Parameters.AddWithValue("@cep", funcionarios.cepFuncionario);
                comando.Parameters.AddWithValue("@numeroResidencia", funcionarios.numeroResidenciaFuncionario);
                comando.Parameters.AddWithValue("@complemento", funcionarios.complementoFuncionario);


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
        public DataTable listarFuncionarios()
        {
            try
            {//MOSTRAR A LISTA DE FUNCIONARIOS
                AbrirConexao();

                DataTable dtfunc = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT codFuncionario AS 'COD' , nomeFuncionario AS 'NOME', sobrenomeFuncionario AS 'SOBRENOME',emailFuncionario AS 'EMAIL',telefoneFixoFunc AS 'TEL_FIXO',telefoneCelularFunc AS 'TEL_CEL', enderecoFuncionario AS 'ENDERECO', bairroFuncionario AS 'BAIRRO',cepFuncionario AS 'CEP',numeroResidenciaFuncionario AS 'NUM', complementoFuncionario AS 'COMPLEMENTO' from tb_funcionario", conection);
                da.SelectCommand = comando;
                da.Fill(dtfunc);
                return dtfunc;

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
        public void Editar(Funcionarios funcionarios)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tb_funcionario SET nomeFuncionario = @nome ,sobrenomeFuncionario = @sobrenome ,emailFuncionario = @email ,telefoneFixoFunc = @TelefoneFixo,telefoneCelularFunc = @TelefoneCelular,enderecoFuncionario = @endereco,bairroFuncionario = @bairro,cepFuncionario = @cep,numeroResidenciaFuncionario = @numeroResidencia,complementoFuncionario = @complemento WHERE codFuncionario = @codFuncionario", conection);

                comando.Parameters.AddWithValue("@codFuncionario", funcionarios.codFuncionario);
                comando.Parameters.AddWithValue("@nome", funcionarios.nomeFuncionario);
                comando.Parameters.AddWithValue("@sobrenome", funcionarios.sobrenomeFuncionario);
                comando.Parameters.AddWithValue("@email", funcionarios.emailFuncionario);
                comando.Parameters.AddWithValue("@TelefoneFixo", funcionarios.telefoneFixoFunc);
                comando.Parameters.AddWithValue("@TelefoneCelular", funcionarios.telefoneCelularFunc);
                comando.Parameters.AddWithValue("@endereco", funcionarios.enderecoFuncionario);
                comando.Parameters.AddWithValue("@bairro", funcionarios.bairroFuncionario);
                comando.Parameters.AddWithValue("@cep", funcionarios.cepFuncionario);
                comando.Parameters.AddWithValue("@numeroResidencia", funcionarios.numeroResidenciaFuncionario);
                comando.Parameters.AddWithValue("@complemento", funcionarios.complementoFuncionario);


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
		
				//EXCLUIR FUNCIONARIOS
		public void Excluir(Funcionarios funcionarios) 
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tb_funcionario WHERE codFuncionario = @codFuncionario ", conection);

                comando.Parameters.AddWithValue("@codFuncionario", funcionarios.codFuncionario);

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
		
		
		
		public DataTable Pesquisar(Funcionarios funcionarios)
        {
            try
            {//PESQUISA DE FUNCIONARIOS
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtfunc = new DataTable();
                
                comando = new MySqlCommand("SELECT codFuncionario AS 'COD' , nomeFuncionario AS 'NOME', sobrenomeFuncionario AS 'SOBRENOME',emailFuncionario AS 'EMAIL',telefoneFixoFunc AS 'TEL_FIXO',telefoneCelularFunc AS 'TEL_CEL', enderecoFuncionario AS 'ENDERECO', bairroFuncionario AS 'BAIRRO',cepFuncionario AS 'CEP',numeroResidenciaFuncionario AS 'NUM', complementoFuncionario AS 'COMPLEMENTO' FROM tb_funcionario WHERE nomeFuncionario LIKE @nome '%' ORDER BY nomeFuncionario", conection);
                comando.Parameters.AddWithValue("@nome", funcionarios.nomeFuncionario);
                da.SelectCommand = comando;
                da.Fill(dtfunc);
                return dtfunc;

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
