using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultas_medicas.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Consultas_medicas.DAO
{
    public class ProdutosClienteDAO : conexao
    {
        MySqlCommand comando = null;

        //QUERY PARA SALVAR COMPRA DE PRODUTOS
        public void Salvar(ProdutosCliente produtosCli)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tb_produtos_cliente(cod_cliente, cod_produto, preco_produto, total_compra,data_compra, 	hora_compra) VALUES (@cod_cliente, @cod_produto, @preco_produto, @total_compra, @data_compra, @hora_compra)", conection);

                comando.Parameters.AddWithValue("@cod_cliente", produtosCli.cod_cliente);
                comando.Parameters.AddWithValue("@cod_produto", produtosCli.cod_produto);
                comando.Parameters.AddWithValue("@preco_produto", produtosCli.preco_produto);
                comando.Parameters.AddWithValue("@total_compra", produtosCli.total_compra);
                comando.Parameters.AddWithValue("@data_compra", produtosCli.data_compra);
                comando.Parameters.AddWithValue("@hora_compra", produtosCli.hora_compra);

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

        public DataTable PesquisarComprasCliente(Clientes clientes)
        {
            try
            {

                AbrirConexao();

                DataTable dtclienteConsulta = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                //comando = new MySqlCommand("SELECT * FROM tb_produtos_cliente", conection);
                comando = new MySqlCommand("SELECT PRODUTOS.cod_compra AS 'COMPRA',CLIENTE.nomeCliente AS 'NOME',PRODUTOS.total_compra AS 'TOTAL',PRODUTOS.data_compra AS 'DATA',PRODUTOS.hora_compra AS 'HORA'FROM tb_produtos_cliente PRODUTOS JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = PRODUTOS.cod_cliente WHERE CLIENTE.nomeCliente LIKE @CLIENTE.nomeCliente '%' GROUP by cod_cliente,data_compra;", conection);
                comando.Parameters.AddWithValue("@CLIENTE.nomeCliente", clientes.nomeCliente);

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

        public DataTable PesquisarComprasClienteCod(ProdutosCliente produtoCli)
        {
            try
            {

                AbrirConexao();

                DataTable dtclienteConsulta = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                //comando = new MySqlCommand("SELECT * FROM tb_produtos_cliente", conection);
                comando = new MySqlCommand("SELECT PRODUTOS.cod_compra AS 'COMPRA',CLIENTE.nomeCliente AS 'NOME',PRODUTOS.total_compra AS 'TOTAL',PRODUTOS.data_compra AS 'DATA',PRODUTOS.hora_compra AS 'HORA'FROM tb_produtos_cliente PRODUTOS JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = PRODUTOS.cod_cliente WHERE PRODUTOS.cod_compra = @PRODUTOS.cod_compra;", conection);
                comando.Parameters.AddWithValue("@PRODUTOS.cod_compra", produtoCli.cod_compra);

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


        //query para listar as compras dos clientes
        public DataTable listarProdutosCliente()
        {
            try
            {

                AbrirConexao();

                DataTable dtclienteConsulta = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                //comando = new MySqlCommand("SELECT * FROM tb_produtos_cliente", conection);
                comando = new MySqlCommand("SELECT PRODUTOS.cod_compra AS 'COMPRA',CLIENTE.nomeCliente AS 'NOME',PRODUTOS.total_compra AS 'TOTAL',PRODUTOS.data_compra AS 'DATA',PRODUTOS.hora_compra AS 'HORA'FROM tb_produtos_cliente PRODUTOS JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = PRODUTOS.cod_cliente GROUP by cod_cliente,data_compra;",conection);

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

        //MÉTODO PARA PESQUISAR servicos POR NOME DO CLIENTE
        public DataTable PesquisarItemProdutosCliente(Clientes cliente, ProdutosCliente produtoCliente)
        {
            try
            {
                AbrirConexao();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dtclientes = new DataTable();

                //comando = new MySqlCommand("select CONSULTA.dataConsulta AS 'DATA', CLIENTE.nomeCliente AS 'NOME', SERVICO.nome_servico AS 'SERVICO', SERVICO.preco_servico AS 'PRECO' from tb_consulta CONSULTA JOIN tb_servicos SERVICO on SERVICO.cod_servico = CONSULTA.cod_servico JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = CONSULTA.CodCliente WHERE CLIENTE.nomeCliente LIKE @CLIENTE.nomeCliente '%' ", conection);
                //comando.Parameters.AddWithValue("@CLIENTE.nomeCliente", cliente.nomeCliente);

                comando = new MySqlCommand("select CLIENTE.nomeCliente AS 'NOME', PRODUTOS.nome_produto AS 'PRODUTO',PRODUTOS.preco_produto AS 'PRECO',CLIPRODUTOS.total_compra AS 'TOTAL',DATE_FORMAT(CLIPRODUTOS.data_compra,'%d/%m/%Y') AS 'DATA', CLIPRODUTOS.hora_compra AS 'HORA' from tb_produtos_cliente CLIPRODUTOS JOIN tb_produtos PRODUTOS on PRODUTOS.cod_produto = CLIPRODUTOS.cod_produto JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = CLIPRODUTOS.cod_cliente WHERE CLIENTE.nomeCliente = @CLIENTE.nomeCliente AND CLIPRODUTOS.data_compra = @CLIPRODUTOS.data_compra;", conection);
                comando.Parameters.AddWithValue("@CLIENTE.nomeCliente", cliente.nomeCliente);
                comando.Parameters.AddWithValue("@CLIPRODUTOS.data_compra", produtoCliente.data_compra);


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
    }
}
