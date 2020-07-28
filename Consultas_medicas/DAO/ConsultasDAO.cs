using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Consultas_medicas.DAO
{
    public class ConsultasDAO : conexao
    {
        MySqlCommand comando = null;

        public void Salvar(Consultas consultas)
        {
            try
            { // INSERIR CONSULTAS
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tb_consulta(CodCliente,relatoConsulta,dataConsulta,horaConsulta)VALUES (@CodCliente,@relatoConsulta,@dataConsulta,@horaConsulta )", conection);

                comando.Parameters.AddWithValue("@CodCliente", consultas.CodCliente);
                comando.Parameters.AddWithValue("@relatoConsulta", consultas.relatoConsulta);
                comando.Parameters.AddWithValue("@dataConsulta", consultas.dataConsulta);
                comando.Parameters.AddWithValue("@horaConsulta", consultas.horaConsulta);

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

        public DataTable listarConsultas()
        {
            try
            {//LISTAR AS CONSULTAS

                AbrirConexao();

                DataTable dtconsultas = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT codConsulta AS 'CODIGO',nomeCliente AS 'CLIENTE',cpfCliente AS 'CPF',descricaoAnimal AS 'PET',relatoConsulta AS 'RELATO',dataConsulta AS 'DATA',horaConsulta AS 'HORA' FROM tb_consulta,tb_cliente,tb_animal WHERE tb_cliente.CodCliente = tb_consulta.CodCliente AND tb_cliente.CodAnimal = tb_animal.codAnimal ORDER BY dataConsulta , horaConsulta ", conection);
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
        public DataTable listarClienteConsulta()
        {
            try
            {//LISTAR AS OS DADOS DO CLIENTE

                AbrirConexao();

                DataTable dtclienteConsulta = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT CodCliente,nomeCliente FROM tb_cliente", conection);
                da.SelectCommand = comando;
                da.Fill(dtclienteConsulta);

                return dtclienteConsulta;

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
        public void Editar(Consultas consultas)
        {
            try
            { // EDITAR CONSULTAS
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tb_consulta SET CodCliente = @CodCliente,relatoConsulta = @relatoConsulta,dataConsulta = @dataConsulta,horaConsulta = @horaConsulta WHERE codConsulta = @codConsulta", conection);

                comando.Parameters.AddWithValue("@codConsulta", consultas.codConsulta);
                comando.Parameters.AddWithValue("@CodCliente", consultas.CodCliente);
                comando.Parameters.AddWithValue("@relatoConsulta", consultas.relatoConsulta);
                comando.Parameters.AddWithValue("@dataConsulta", consultas.dataConsulta);
                comando.Parameters.AddWithValue("@horaConsulta", consultas.horaConsulta);

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
		
		
		public void Excluir(Consultas consultas) 
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tb_consulta WHERE codConsulta = @codConsulta ", conection);

                comando.Parameters.AddWithValue("@codConsulta", consultas.codConsulta);

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
		
		public DataTable Pesquisar(Consultas consultas)
        {
            try
            {//PESQUISA DE CLIENTES NA TABELA CONSULTAS
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtconsultas = new DataTable();
                
                comando = new MySqlCommand("SELECT codConsulta AS 'CODIGO',nomeCliente AS 'CLIENTE',cpfCliente AS 'CPF',descricaoAnimal AS 'PET',relatoConsulta AS 'RELATO',dataConsulta AS 'DATA',horaConsulta AS 'HORA' FROM tb_consulta,tb_cliente,tb_animal WHERE tb_cliente.CodCliente = tb_consulta.CodCliente AND tb_cliente.CodAnimal = tb_animal.codAnimal AND nomeCliente LIKE @nomeCliente '%' ORDER BY nomeCliente", conection);
                comando.Parameters.AddWithValue("@nomeCliente",consultas.CodCliente);
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

        public DataTable PesquisarPORCPF(Clientes clientes)
        {
            try
            {//PESQUISA DE CLIENTES NA TABELA CONSULTAS
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtconsultas = new DataTable();

                comando = new MySqlCommand("SELECT codConsulta AS 'CODIGO',nomeCliente AS 'CLIENTE',cpfCliente AS 'CPF',descricaoAnimal AS 'PET',relatoConsulta AS 'RELATO',dataConsulta AS 'DATA',horaConsulta AS 'HORA' FROM tb_consulta,tb_cliente,tb_animal WHERE tb_cliente.CodCliente = tb_consulta.CodCliente AND tb_cliente.CodAnimal = tb_animal.codAnimal AND cpfCliente LIKE @cpfCliente '%' ORDER BY cpfCliente", conection);
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

        public DataTable ListarAnimal()
        {
            try
            {

                AbrirConexao();

                DataTable dtlistaranimais = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT CodAnimal,descricaoAnimal FROM tb_animal ", conection);
                da.SelectCommand = comando;
                da.Fill(dtlistaranimais);

                return dtlistaranimais;

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
