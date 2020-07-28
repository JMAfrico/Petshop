-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 17-Nov-2019 às 18:28
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
-- Database: `petshop`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_animal`
--

CREATE TABLE `tb_animal` (
  `codAnimal` int(4) NOT NULL,
  `sexoAnimal` varchar(1) NOT NULL,
  `descricaoAnimal` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_animal`
--

INSERT INTO `tb_animal` (`codAnimal`, `sexoAnimal`, `descricaoAnimal`) VALUES
(15, 'M', 'POODLE'),
(16, 'F', 'PITBULL'),
(17, 'F', 'SHIH TZU'),
(19, 'M', 'PUG'),
(20, 'F', 'CHOW CHOW'),
(22, 'M', 'LABRADOR'),
(23, 'M', 'PASTOR ALEMAO'),
(24, 'M', 'BULL TERRIER'),
(25, 'M', 'MALTES'),
(26, 'M', 'ROTTWEILER'),
(27, 'F', 'PINSCHER'),
(28, 'M', 'TESTE'),
(29, 'F', 'MALTEZ');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_atendimento`
--

CREATE TABLE `tb_atendimento` (
  `codAnimal` int(4) NOT NULL,
  `codVeterinario` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `CodCliente` int(4) NOT NULL,
  `CodAnimal` int(4) NOT NULL,
  `nomeCliente` varchar(30) NOT NULL,
  `emailCliente` varchar(50) NOT NULL,
  `TelefoneCelularCli` bigint(11) NOT NULL,
  `TelefoneFixoCli` bigint(10) DEFAULT NULL,
  `enderecoCliente` varchar(50) NOT NULL,
  `numeroResidenciaCliente` int(4) NOT NULL,
  `bairroCliente` varchar(30) NOT NULL,
  `cepCliente` varchar(8) NOT NULL,
  `complementoCliente` varchar(50) NOT NULL,
  `cpfCliente` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`CodCliente`, `CodAnimal`, `nomeCliente`, `emailCliente`, `TelefoneCelularCli`, `TelefoneFixoCli`, `enderecoCliente`, `numeroResidenciaCliente`, `bairroCliente`, `cepCliente`, `complementoCliente`, `cpfCliente`) VALUES
(1, 19, 'ELEN CONCEICAO FERREIRA AFRICO', 'ELEN@HOTMAIL.COM', 15615615615, 1125612123, 'JOSÉ BORGES DO CANTO', 16, 'JARDIM CAMARGO NOVO', '08142010', 'CASAB', '39211358850'),
(2, 16, 'TESTE', 'ITAIM', 11960164015, 1125612203, 'JOSÉ BORGES DO CANTO', 42, 'JARDIM CAMARGO NOVO', '08142010', '262', '08950320827'),
(4, 22, 'JOAO MARCOS AFRICO DA SILVA', 'JOAOZERAS@HOTMAIL.COM', 11960164015, 1125612203, 'JOSÉ BORGES DO CANTO', 16, 'JARDIM CAMARGO NOVO', '08142010', 'CASA 2', '40927503824'),
(5, 22, 'DIOGO', 'JOAJO', 15615615615, 1515615615, 'JOSÉ BORGES DO CANTO', 16, 'JARDIM CAMARGO NOVO', '08142010', 'CASA', '34120579832');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_consulta`
--

CREATE TABLE `tb_consulta` (
  `CodCliente` int(4) NOT NULL,
  `codConsulta` int(4) NOT NULL,
  `relatoConsulta` varchar(50) NOT NULL,
  `dataConsulta` date NOT NULL,
  `horaConsulta` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_consulta`
--

INSERT INTO `tb_consulta` (`CodCliente`, `codConsulta`, `relatoConsulta`, `dataConsulta`, `horaConsulta`) VALUES
(4, 2, 'CAOZINHO TRISTE', '2019-11-22', '12:00:00'),
(2, 3, 'DOENTE', '2019-11-17', '11:00:00'),
(5, 5, 'ROTINA', '2019-11-20', '13:10:00');

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

--
-- Extraindo dados da tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`codFuncionario`, `nomeFuncionario`, `sobrenomeFuncionario`, `emailFuncionario`, `telefoneFixoFunc`, `telefoneCelularFunc`, `enderecoFuncionario`, `bairroFuncionario`, `cepFuncionario`, `numeroResidenciaFuncionario`, `complementoFuncionario`) VALUES
(1, 'ALBERTO DA SILVA', 'AFRICO', 'ALBERTDASILVA@GMAIL.COM', 1122569951, 11564888448, 'JOSÉ BORGES DO CANTO', 'JARDIM CAMARGO NOVO', '08142010', 16, 'CASA ');

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
(3, 'JOAO', '123', '123'),
(5, 'ADMIN', 'ADMIN', 'ADMIN'),
(6, 'KKK', '147', '147'),
(7, 'EU', '147', '147');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_marca`
--

CREATE TABLE `tb_marca` (
  `codFuncionario` int(4) NOT NULL,
  `codConsulta` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tem`
--

CREATE TABLE `tb_tem` (
  `codAnimal` int(4) NOT NULL,
  `codConsulta` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_veterinario`
--

CREATE TABLE `tb_veterinario` (
  `codVeterinario` int(4) NOT NULL,
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
-- Extraindo dados da tabela `tb_veterinario`
--

INSERT INTO `tb_veterinario` (`codVeterinario`, `nomeVeterinario`, `sobrenomeVeterinario`, `crmv`, `especializacao`, `enderecoVeterinario`, `bairroVeterinario`, `cepVeterinario`, `numeroResidenciaVeterinario`, `complementoVeterinario`, `emailVeterinario`, `telefoneFixoVet`, `telefoneCelularVet`) VALUES
(2, 'ELEN', 'AFRICO DA SILVA', '1148', 'CIRURGIA', 'LORENA', 'JARDIM PAULISTA', '01424002', 54, 'PREDIO 2', 'ELEN2@GMAIL.COM', 1125612203, 11970154515);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_animal`
--
ALTER TABLE `tb_animal`
  ADD PRIMARY KEY (`codAnimal`);

--
-- Indexes for table `tb_atendimento`
--
ALTER TABLE `tb_atendimento`
  ADD KEY `codAnimal_fk_atend` (`codAnimal`),
  ADD KEY `codVeterinario_fk_atend` (`codVeterinario`);

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`CodCliente`),
  ADD UNIQUE KEY `cpfCliente` (`cpfCliente`),
  ADD KEY `codAnimal_fk` (`CodAnimal`);

--
-- Indexes for table `tb_consulta`
--
ALTER TABLE `tb_consulta`
  ADD PRIMARY KEY (`codConsulta`),
  ADD KEY `CodCliente_tb_animal` (`CodCliente`);

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
-- Indexes for table `tb_marca`
--
ALTER TABLE `tb_marca`
  ADD KEY `codFuncionario_fk_marca` (`codFuncionario`),
  ADD KEY `codConsulta_fk_marca` (`codConsulta`);

--
-- Indexes for table `tb_tem`
--
ALTER TABLE `tb_tem`
  ADD KEY `codAnimal_fk_tem` (`codAnimal`),
  ADD KEY `codConsulta_fk_tem` (`codConsulta`);

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
-- AUTO_INCREMENT for table `tb_animal`
--
ALTER TABLE `tb_animal`
  MODIFY `codAnimal` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `CodCliente` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tb_consulta`
--
ALTER TABLE `tb_consulta`
  MODIFY `codConsulta` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `codFuncionario` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tb_login`
--
ALTER TABLE `tb_login`
  MODIFY `codUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tb_veterinario`
--
ALTER TABLE `tb_veterinario`
  MODIFY `codVeterinario` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_atendimento`
--
ALTER TABLE `tb_atendimento`
  ADD CONSTRAINT `codAnimal_fk_atend` FOREIGN KEY (`codAnimal`) REFERENCES `tb_animal` (`codAnimal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `codVeterinario_fk_atend` FOREIGN KEY (`codVeterinario`) REFERENCES `tb_veterinario` (`codVeterinario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD CONSTRAINT `CodAnimal_fk` FOREIGN KEY (`CodAnimal`) REFERENCES `tb_animal` (`codAnimal`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_consulta`
--
ALTER TABLE `tb_consulta`
  ADD CONSTRAINT `CodCliente_fk_consulta` FOREIGN KEY (`CodCliente`) REFERENCES `tb_cliente` (`CodCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_marca`
--
ALTER TABLE `tb_marca`
  ADD CONSTRAINT `codConsulta_fk_marca` FOREIGN KEY (`codConsulta`) REFERENCES `tb_consulta` (`codConsulta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `codFuncionario_fk_marca` FOREIGN KEY (`codFuncionario`) REFERENCES `tb_funcionario` (`codFuncionario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_tem`
--
ALTER TABLE `tb_tem`
  ADD CONSTRAINT `CodAnimal_fk_tem` FOREIGN KEY (`codAnimal`) REFERENCES `tb_animal` (`codAnimal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `codVeterinario_fk_tem` FOREIGN KEY (`codConsulta`) REFERENCES `tb_consulta` (`codConsulta`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
