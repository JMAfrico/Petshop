create table tab_pacientes(

	id_paciente int identity (1,1) not null ,
	nome_paciente varchar(50) not null,
    endereco_paciente varchar(50) not null,
    telefone_paciente varchar(11) not null,
    sexo_paciente varchar (1),
    nascimento_paciente date,
    primary key(id_paciente)
)

create table tab_medicos(

	id_medico int identity (1,1) not null ,
    nome_medico varchar(50) not null,
    endereco_medico varchar (50) not null,
    telefone_medico varchar (11) not null,
    sexo_medico varchar (1),
	especialidade_medico varchar(30)
    primary key(id_medico)
)

create table tab_consultas(

	id_consulta int identity (1,1)not null,   
    id_medico int , -- chave primaria da tab_medicos
	id_paciente int, -- chave primaria da tab_pacientes 
	dia_consulta date,
	primary key (id_consulta),
	constraint fk_pacienteConsulta foreign key (id_paciente) references tab_pacientes(id_paciente),-- crie chave estrangeira com o nome que quis, e atribui o item id_paciente ao  id_paciente da tabela paciente
	constraint fk_medicoConsulta foreign key (id_medico) references tab_medicos(id_medico)-- crie chave estrangeira com o nome que quis, e atribui o item id_medico ao  id_medico da tabela medicos

)
    
	--insercoes nas tabelas

--MÉTODO 1
-- insert into [nome da tabela] values ()
	INSERT INTO tab_pacientes values ('João','Av. José borges do canto N 16B','11967343894','M','21/05/1991');
	INSERT INTO tab_pacientes values ('Elen','Av. José borges do canto N 16B','11967757056','F','1990/08/03');
	INSERT INTO tab_medicos values('Dr antonio','Avenida São Miguel','25612203','M','Clinico Geral');
	INSERT INTO tab_medicos values('Dra Helena','Liberdade','256120122','F','Gastro');
	

	--nesse método, as inserções são incluidas sequencial, de acordo como a tabela foi criada


--MÉTODO 2
-- insert into [nome da tabela] values ()
	INSERT INTO tab_pacientes (nome_paciente,endereco_paciente) values ('João 2 ','Avenida José 2');
	--nesse método, as inserções são inseridas de acordo com a ordem que eu especifiquei

