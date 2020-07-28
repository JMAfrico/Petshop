using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;// ADICIONAR O MODELS VETERINARIO
using MySql.Data.MySqlClient;//   ADICIONAR A STRING DE CONEXAO
using System.Data;

namespace Consultas_medicas.DAO
{
    public class VeterinariosDAO : conexao // HERDA A CLASSE CONEXAO
    {
        MySqlCommand comando = null;

        public void Salvar(Veterinarios veterinarios)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tb_veterinario(nomeVeterinario,sobrenomeVeterinario,crmv,especializacao,enderecoVeterinario,bairroVeterinario,cepVeterinario,numeroResidenciaVeterinario,complementoVeterinario,emailVeterinario,telefoneFixoVet,telefoneCelularVet) VALUES (@nome,@sobrenome,@crmv,@especializacao,@endereco,@bairro,@cep,@numero,@complemento,@email,@telfixo,@telcel)", conection);

                comando.Parameters.AddWithValue("@nome",veterinarios.nomeVeterinario);
                comando.Parameters.AddWithValue("@sobrenome",veterinarios.sobrenomeVeterinario);
                comando.Parameters.AddWithValue("@crmv",veterinarios.crmv);
                comando.Parameters.AddWithValue("@especializacao",veterinarios.especializacao);
                comando.Parameters.AddWithValue("@endereco",veterinarios.enderecoVeterinario);
                comando.Parameters.AddWithValue("@bairro",veterinarios.bairroVeterinario);
                comando.Parameters.AddWithValue("@cep",veterinarios.cepVeterinario);
                comando.Parameters.AddWithValue("@numero",veterinarios.numeroResidenciaVeterinario);
                comando.Parameters.AddWithValue("@complemento",veterinarios.complementoVeterinario);
                comando.Parameters.AddWithValue("@email",veterinarios.emailVeterinario);
                comando.Parameters.AddWithValue("@telfixo",veterinarios.telefoneFixoVet);
                comando.Parameters.AddWithValue("@telcel",veterinarios.telefoneCelularVet);

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
        public DataTable listarVeterinarios()
        {
            try
            {//MOSTRAR A LISTA DE VETERINÁRIOS
                AbrirConexao();

                DataTable dtveterinario = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT codVeterinario AS 'CODIGO',nomeVeterinario AS 'NOME',sobrenomeVeterinario AS 'SOBRENOME',crmv AS 'CRMV',especializacao AS 'ESPECIALIZACAO',enderecoVeterinario AS 'ENDERECO',bairroVeterinario AS 'BAIRRO',cepVeterinario AS 'CEP',numeroResidenciaVeterinario AS 'NUMERO',complementoVeterinario AS 'COMPLEMENTO',emailVeterinario AS 'EMAIL',telefoneFixoVet AS 'FIXO',telefoneCelularVet AS 'CELULAR' FROM tb_veterinario", conection);
                da.SelectCommand = comando;
                da.Fill(dtveterinario);
                return dtveterinario;

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
        public void Editar(Veterinarios veterinarios)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tb_veterinario SET nomeVeterinario = @nome, sobrenomeVeterinario = @sobrenome,crmv = @crmv ,especializacao = @especializacao ,enderecoVeterinario = @endereco,bairroVeterinario = @bairro,cepVeterinario = @cep,numeroResidenciaVeterinario = @numero,complementoVeterinario = @complemento,emailVeterinario = @email,telefoneFixoVet = @telfixo,telefoneCelularVet = @telcel WHERE codVeterinario = @codVeterinario", conection);

                comando.Parameters.AddWithValue("@codVeterinario", veterinarios.codVeterinario);
                comando.Parameters.AddWithValue("@nome", veterinarios.nomeVeterinario);
                comando.Parameters.AddWithValue("@sobrenome", veterinarios.sobrenomeVeterinario);
                comando.Parameters.AddWithValue("@crmv", veterinarios.crmv);
                comando.Parameters.AddWithValue("@especializacao", veterinarios.especializacao);
                comando.Parameters.AddWithValue("@endereco", veterinarios.enderecoVeterinario);
                comando.Parameters.AddWithValue("@bairro", veterinarios.bairroVeterinario);
                comando.Parameters.AddWithValue("@cep", veterinarios.cepVeterinario);
                comando.Parameters.AddWithValue("@numero", veterinarios.numeroResidenciaVeterinario);
                comando.Parameters.AddWithValue("@complemento", veterinarios.complementoVeterinario);
                comando.Parameters.AddWithValue("@email", veterinarios.emailVeterinario);
                comando.Parameters.AddWithValue("@telfixo", veterinarios.telefoneFixoVet);
                comando.Parameters.AddWithValue("@telcel", veterinarios.telefoneCelularVet);


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
		
		
		public void Excluir(Veterinarios veterinarios) 
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tb_veterinario WHERE codVeterinario = @codVeterinario ", conection);

                comando.Parameters.AddWithValue("@codVeterinario", veterinarios.codVeterinario);

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

        public DataTable Pesquisar(Veterinarios veterinarios)
        {
            try
            {//PESQUISA DE veterinarios
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtveterinario = new DataTable();

                comando = new MySqlCommand("SELECT codVeterinario AS 'CODIGO',nomeVeterinario AS 'NOME',sobrenomeVeterinario AS 'SOBRENOME',crmv AS 'CRMV',especializacao AS 'ESPECIALIZACAO',enderecoVeterinario AS 'ENDERECO',bairroVeterinario AS 'BAIRRO',cepVeterinario AS 'CEP',numeroResidenciaVeterinario AS 'NUMERO',complementoVeterinario AS 'COMPLEMENTO',emailVeterinario AS 'EMAIL',telefoneFixoVet AS 'FIXO',telefoneCelularVet AS 'CELULAR' FROM tb_veterinario WHERE nomeVeterinario LIKE @nomeVeterinario '%' ORDER BY nomeVeterinario", conection);
                comando.Parameters.AddWithValue("@nomeVeterinario", veterinarios.nomeVeterinario);
                da.SelectCommand = comando;
                da.Fill(dtveterinario);
                return dtveterinario;

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
            


         public DataTable PesquisarCRMV(Veterinarios veterinarios)
            {
                try
                {//PESQUISA DE veterinarios
                    AbrirConexao();

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dtveterinario = new DataTable();

                    comando = new MySqlCommand("SELECT nomeVeterinario AS 'NOME',sobrenomeVeterinario AS 'SOBRENOME',crmv AS 'CRMV',especializacao AS 'ESPECIALIZACAO',enderecoVeterinario AS 'ENDERECO',bairroVeterinario AS 'BAIRRO',cepVeterinario AS 'CEP',numeroResidenciaVeterinario AS 'NUMERO',complementoVeterinario AS 'COMPLEMENTO',emailVeterinario AS 'EMAIL',telefoneFixoVet AS 'FIXO',telefoneCelularVet AS 'CELULAR' FROM tb_veterinario WHERE crmv LIKE @crmv '%' ORDER BY crmv", conection);
                    comando.Parameters.AddWithValue("@crmv", veterinarios.crmv);
                    da.SelectCommand = comando;
                    da.Fill(dtveterinario);
                    return dtveterinario;

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
