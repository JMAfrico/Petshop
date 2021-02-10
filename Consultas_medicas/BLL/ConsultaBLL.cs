﻿using System;
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


        //Método controlador para salvar nova consulta
        public void salvar(Consultas consultas)
        {
            try
            {
                consultasDAO.Salvar(consultas);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }


        //Método controlador para listar cliente na tabela de consulta
        public DataTable listarClienteConsulta()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = consultasDAO.listarClienteConsulta();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }


        //LISTAR O SERVICO DO RESPECTIVO CLIENTE
        public DataTable listarItensServicoCliente()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = consultasDAO.listarItemServicoCliente();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        //LISTAR O PRODUTO DO RESPECTIVO CLIENTE
        public DataTable listarProdutosServicoCliente()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = consultasDAO.listarItemProdutoCliente();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        //Método controlador para pesquisar servicos por nome do cliente
        public DataTable pesquisarItensServicoCliente(Clientes clientes,Consultas consultas)
        {
            try
            {

                DataTable dt = new DataTable();
                dt = consultasDAO.PesquisarItemServicoCliente(clientes, consultas);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }



        //Método controlador para pesquisar produtos por nome do cliente
        public DataTable pesquisarItensProdutosCliente(Clientes clientes)
        {
            try
            {

                DataTable dt = new DataTable();
                dt = consultasDAO.PesquisarItemProdutoCliente(clientes);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }











        public DataTable listarItensServicoClienteData(Consultas consultas)
        {
            try
            {

                DataTable dt = new DataTable();
                dt = consultasDAO.PesquisarItemServicoClienteData(consultas);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }



        //Método controlador para listar consultas na tabela
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




        //Método controlador para editar consulta
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



        //Método controlador para excluir consulta
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



        //Método controlador para pesquisar consulta por nome de cliente
		public DataTable pesquisar(Clientes clientes)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = consultasDAO.Pesquisar(clientes);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        //Método controlador para pesquisar consulta por CPF de cliente
        public DataTable pesquisarCPF(Consultas consultas)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = consultasDAO.PesquisarPORcodConsulta(consultas);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //Método controlador para listar cliente e seus animais animais no combobox
        public DataTable listarCliente_e_AnimalCombobox()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = consultasDAO.listarCliente_e_AnimalCombobox();


                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
