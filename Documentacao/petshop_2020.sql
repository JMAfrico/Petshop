-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 08-Set-2020 às 23:03
-- Versão do servidor: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `petshop_2020`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `CodCliente` int(4) NOT NULL,
  `nomeCliente` varchar(30) NOT NULL,
  `emailCliente` varchar(50) NOT NULL,
  `TelefoneCelularCli` bigint(11) NOT NULL,
  `TelefoneFixoCli` bigint(10) DEFAULT NULL,
  `enderecoCliente` varchar(50) NOT NULL,
  `numeroResidenciaCliente` int(4) NOT NULL,
  `bairroCliente` varchar(30) NOT NULL,
  `cepCliente` varchar(8) NOT NULL,
  `complementoCliente` varchar(50) NOT NULL,
  `referencia_cliente` varchar(50) DEFAULT NULL,
  `cpfCliente` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`CodCliente`, `nomeCliente`, `emailCliente`, `TelefoneCelularCli`, `TelefoneFixoCli`, `enderecoCliente`, `numeroResidenciaCliente`, `bairroCliente`, `cepCliente`, `complementoCliente`, `referencia_cliente`, `cpfCliente`) VALUES
(6, 'Joao Marcos', 'joao_marcossilva@hotmail.com', 11982650333, 1125612203, 'avenida jose borges do canto', 16, 'itaim paulista', '08142010', 'casa B', 'em frente escola ezequiel', '39211358850');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_clienteanimal`
--

CREATE TABLE `tb_clienteanimal` (
  `cod_cadastro` int(10) NOT NULL,
  `cod_cliente` int(10) NOT NULL,
  `cod_tipo_animal` int(10) NOT NULL,
  `cod_raca_animal` int(10) NOT NULL,
  `nome_animal` varchar(50) NOT NULL,
  `pesoAnimal` varchar(10) DEFAULT '0',
  `alturaAnimal` varchar(10) DEFAULT '0',
  `corAnimal` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_consulta`
--

CREATE TABLE `tb_consulta` (
  `CodCliente` int(4) NOT NULL,
  `codConsulta` int(4) NOT NULL,
  `cod_tipo_animal_consulta` int(10) NOT NULL,
  `cod_raca_animal_consulta` int(10) NOT NULL,
  `cod_veterinario` int(10) NOT NULL,
  `cod_servico` int(10) NOT NULL,
  `valortotal_consulta` varchar(10) NOT NULL DEFAULT '0',
  `dataConsulta` date NOT NULL,
  `horaConsulta` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `codFuncionario` int(4) NOT NULL,
  `nomeFuncionario` varchar(20) NOT NULL,
  `sobrenomeFuncionario` varchar(30) NOT NULL,
  `emailFuncionario` varchar(50) NOT NULL,
  `telefoneFixoFunc` bigint(10) DEFAULT NULL,
  `telefoneCelularFunc` bigint(11) NOT NULL,
  `enderecoFuncionario` varchar(50) NOT NULL,
  `bairroFuncionario` varchar(30) NOT NULL,
  `cepFuncionario` varchar(8) NOT NULL,
  `numeroResidenciaFuncionario` int(4) NOT NULL,
  `complementoFuncionario` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_login`
--

CREATE TABLE `tb_login` (
  `codUsuario` int(11) NOT NULL,
  `nomeUsuario` varchar(50) NOT NULL,
  `senhaUsuario` varchar(15) NOT NULL,
  `confirmarSenha` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_login`
--

INSERT INTO `tb_login` (`codUsuario`, `nomeUsuario`, `senhaUsuario`, `confirmarSenha`) VALUES
(3, 'JOAO', '123', '123');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_raca`
--

CREATE TABLE `tb_raca` (
  `cod_raca_animal` int(10) NOT NULL,
  `nome_raca_animal` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_raca`
--

INSERT INTO `tb_raca` (`cod_raca_animal`, `nome_raca_animal`) VALUES
(1, 'pitbull');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_servicos`
--

CREATE TABLE `tb_servicos` (
  `cod_servico` int(10) NOT NULL,
  `nome_servico` varchar(50) NOT NULL,
  `preco_servico` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tipo_animal`
--

CREATE TABLE `tb_tipo_animal` (
  `cod_tipo_animal` int(10) NOT NULL,
  `nome_tipo_animal` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_tipo_animal`
--

INSERT INTO `tb_tipo_animal` (`cod_tipo_animal`, `nome_tipo_animal`) VALUES
(1, 'cao'),
(2, 'gato');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_veterinario`
--

CREATE TABLE `tb_veterinario` (
  `codVeterinario` int(10) NOT NULL,
  `nomeVeterinario` varchar(20) NOT NULL,
  `sobrenomeVeterinario` varchar(30) NOT NULL,
  `crmv` varchar(4) NOT NULL,
  `especializacao` varchar(20) NOT NULL,
  `enderecoVeterinario` varchar(50) NOT NULL,
  `bairroVeterinario` varchar(30) NOT NULL,
  `cepVeterinario` varchar(8) NOT NULL,
  `numeroResidenciaVeterinario` int(4) NOT NULL,
  `complementoVeterinario` varchar(50) NOT NULL,
  `emailVeterinario` varchar(50) NOT NULL,
  `telefoneFixoVet` bigint(10) NOT NULL,
  `telefoneCelularVet` bigint(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`CodCliente`),
  ADD UNIQUE KEY `cpfCliente` (`cpfCliente`);

--
-- Indexes for table `tb_clienteanimal`
--
ALTER TABLE `tb_clienteanimal`
  ADD PRIMARY KEY (`cod_cadastro`),
  ADD KEY `fk_ClientetbCliente` (`cod_cliente`),
  ADD KEY `fk_TipoAnimaltbAnimal` (`cod_tipo_animal`),
  ADD KEY `fk_RacaAnimaltbAnimal` (`cod_raca_animal`);

--
-- Indexes for table `tb_consulta`
--
ALTER TABLE `tb_consulta`
  ADD PRIMARY KEY (`codConsulta`),
  ADD KEY `CodCliente_tb_animal` (`CodCliente`),
  ADD KEY `fk_TipoAnimaltbanimalCliente` (`cod_tipo_animal_consulta`),
  ADD KEY `fk_RacaAnimaltbanimalCliente_consulta` (`cod_raca_animal_consulta`),
  ADD KEY `fk_VeterinariotbVeterinario_consulta` (`cod_veterinario`),
  ADD KEY `fk_ServicostbServicos_consulta` (`cod_servico`);

--
-- Indexes for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`codFuncionario`);

--
-- Indexes for table `tb_login`
--
ALTER TABLE `tb_login`
  ADD PRIMARY KEY (`codUsuario`),
  ADD UNIQUE KEY `nomeUsuario` (`nomeUsuario`);

--
-- Indexes for table `tb_raca`
--
ALTER TABLE `tb_raca`
  ADD PRIMARY KEY (`cod_raca_animal`);

--
-- Indexes for table `tb_servicos`
--
ALTER TABLE `tb_servicos`
  ADD PRIMARY KEY (`cod_servico`);

--
-- Indexes for table `tb_tipo_animal`
--
ALTER TABLE `tb_tipo_animal`
  ADD PRIMARY KEY (`cod_tipo_animal`);

--
-- Indexes for table `tb_veterinario`
--
ALTER TABLE `tb_veterinario`
  ADD PRIMARY KEY (`codVeterinario`),
  ADD UNIQUE KEY `crmv` (`crmv`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `CodCliente` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tb_clienteanimal`
--
ALTER TABLE `tb_clienteanimal`
  MODIFY `cod_cadastro` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tb_consulta`
--
ALTER TABLE `tb_consulta`
  MODIFY `codConsulta` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `codFuncionario` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tb_login`
--
ALTER TABLE `tb_login`
  MODIFY `codUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tb_raca`
--
ALTER TABLE `tb_raca`
  MODIFY `cod_raca_animal` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tb_servicos`
--
ALTER TABLE `tb_servicos`
  MODIFY `cod_servico` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tb_tipo_animal`
--
ALTER TABLE `tb_tipo_animal`
  MODIFY `cod_tipo_animal` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tb_veterinario`
--
ALTER TABLE `tb_veterinario`
  MODIFY `codVeterinario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_clienteanimal`
--
ALTER TABLE `tb_clienteanimal`
  ADD CONSTRAINT `fk_ClientetbCliente` FOREIGN KEY (`cod_cliente`) REFERENCES `tb_cliente` (`CodCliente`),
  ADD CONSTRAINT `fk_RacaAnimaltbAnimal` FOREIGN KEY (`cod_raca_animal`) REFERENCES `tb_raca` (`cod_raca_animal`),
  ADD CONSTRAINT `fk_TipoAnimaltbAnimal` FOREIGN KEY (`cod_tipo_animal`) REFERENCES `tb_tipo_animal` (`cod_tipo_animal`);

--
-- Limitadores para a tabela `tb_consulta`
--
ALTER TABLE `tb_consulta`
  ADD CONSTRAINT `fk_ClientetbanimalCliente_consulta` FOREIGN KEY (`CodCliente`) REFERENCES `tb_clienteanimal` (`cod_cliente`),
  ADD CONSTRAINT `fk_RacaAnimaltbanimalCliente_consulta` FOREIGN KEY (`cod_raca_animal_consulta`) REFERENCES `tb_clienteanimal` (`cod_raca_animal`),
  ADD CONSTRAINT `fk_ServicostbServicos_consulta` FOREIGN KEY (`cod_servico`) REFERENCES `tb_servicos` (`cod_servico`),
  ADD CONSTRAINT `fk_TipoAnimaltbanimalCliente` FOREIGN KEY (`cod_tipo_animal_consulta`) REFERENCES `tb_clienteanimal` (`cod_tipo_animal`),
  ADD CONSTRAINT `fk_VeterinariotbVeterinario_consulta` FOREIGN KEY (`cod_veterinario`) REFERENCES `tb_veterinario` (`codVeterinario`);

--
-- Limitadores para a tabela `tb_raca`
--
ALTER TABLE `tb_raca`
  ADD CONSTRAINT `fk_racaAnimal_tipoAnimal` FOREIGN KEY (`cod_raca_animal`) REFERENCES `tb_tipo_animal` (`cod_tipo_animal`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
