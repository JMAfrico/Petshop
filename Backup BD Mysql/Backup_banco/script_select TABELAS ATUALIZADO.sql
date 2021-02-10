select ClienteAnimal.cod_cadastro,cliente.nomeCliente,tipo.nome_tipo_animal,pesoAnimal,corAnimal
from tb_clienteanimal ClienteAnimal
inner join tb_cliente cliente on cliente.CodCliente = ClienteAnimal.cod_cliente
inner join tb_tipo_animal tipo on tipo.cod_tipo_animal = ClienteAnimal.cod_tipo_animal order by cliente.nomeCliente;

select ClienteAnimal.cod_cadastro,cliente.nomeCliente,tipo.nome_tipo_animal,raca.nome_raca_animal,pesoAnimal,corAnimal
from tb_clienteanimal ClienteAnimal
inner join tb_cliente cliente on cliente.CodCliente = ClienteAnimal.cod_cliente
inner join tb_tipo_animal tipo on tipo.cod_tipo_animal = ClienteAnimal.cod_tipo_animal
inner join tb_raca raca on raca.cod_raca_animal = ClienteAnimal.cod_raca_animal group by raca.cod_raca_animal;

select ClienteAnimal.cod_cadastro,cliente.nomeCliente,tipo.nome_tipo_animal,raca.nome_raca_animal,pesoAnimal,corAnimal
from tb_clienteanimal ClienteAnimal
inner join tb_cliente cliente on cliente.CodCliente = ClienteAnimal.cod_cliente
inner join tb_tipo_animal tipo on tipo.cod_tipo_animal = ClienteAnimal.cod_tipo_animal
inner join tb_raca raca on raca.cod_raca_animal = ClienteAnimal.cod_raca_animal group by cliente.nomeCliente;

/*TABELA DE ANIMAIS X CLIENTES DA TABELA RELACIONAMENTO ANIMALXCLIENTE*/
SELECT cliente.cpfCliente AS 'CPF',cliente.nomeCliente AS 'CLIENTE',
tipo.nome_tipo_animal AS 'TIPO',
raca.nome_raca_animal AS 'RACA',
 nome_animal AS 'NOME' from tb_clienteanimal
 ClienteAnimal join tb_cliente cliente on cliente.CodCliente = ClienteAnimal.cod_cliente inner join tb_tipo_animal tipo
 on tipo.cod_tipo_animal = ClienteAnimal.cod_tipo_animal inner join tb_raca raca 
 on raca.cod_raca_animal = ClienteAnimal.cod_raca_animal WHERE cliente.nomeCliente LIKE "%J%" group by ClienteAnimal.cod_cadastro ;
 
 SELECT cliente.cpfCliente AS 'CPF',
 cliente.nomeCliente AS 'CLIENTE',
 tipo.nome_tipo_animal AS 'TIPO', 
 nome_raca_animal AS 'RACA', 
 nome_animal AS 'NOME' from 
 tb_clienteanimais ClienteAnimal join tb_cliente cliente on cliente.CodCliente = ClienteAnimal.cod_cliente 
 inner join tb_tipo_animal tipo on tipo.cod_tipo_animal = ClienteAnimal.cod_tipo_animal 
 group by ClienteAnimal.cod_cadastro order by cliente.nomeCliente;
 

/*TABELA DE BUSCAR CLIENTE PARA CONSULTA*/ 
SELECT cliente.cpfCliente AS 'CPF',
cliente.nomeCliente AS 'CLIENTE',
tipo.nome_tipo_animal AS 'TIPO', 
raca.nome_raca_animal AS 'RACA', 
nome_animal AS 'NOME' from 
tb_clienteanimais ClienteAnimal join tb_cliente cliente on cliente.CodCliente = ClienteAnimal.cod_cliente 
join tb_tipo_animal tipo on tipo.cod_tipo_animal = ClienteAnimal.cod_tipo_animal 
join tb_raca raca on raca.cod_raca = ClienteAnimal.cod_raca_animal
group by ClienteAnimal.cod_cadastro order by cliente.nomeCliente;

/*pesquisa de relacionamento animal por nome de cliente*/
SELECT ClienteAnimal.cod_cadastro AS 'CADASTRO',
cliente.nomeCliente AS 'CLIENTE',
tipo.nome_tipo_animal AS 'TIPO',
raca.nome_raca_animal AS 'RACA',
nome_animal AS 'NOME' ,pesoAnimal AS 'PESO', 
alturaAnimal AS 'ALTURA', corAnimal AS 'COR' 
from tb_clienteanimais ClienteAnimal 
join tb_cliente cliente on cliente.CodCliente = ClienteAnimal.cod_cliente 
inner join tb_tipo_animal tipo on tipo.cod_tipo_animal = ClienteAnimal.cod_tipo_animal
join tb_raca raca on raca.cod_raca = ClienteAnimal.cod_raca_animal
WHERE cliente.nomeCliente LIKE @cliente.nomeCliente '%' ORDER BY cliente.nomeCliente;



SELECT codConsulta AS 'CODIGO',
CLIENTE.nomeCliente AS 'CLIENTE',
TIPO.nome_tipo_animal AS 'TIPO',
cod_raca_animal_consulta AS 'RACA',
VETERINARIO.nomeVeterinario AS 'VETERINARIO',
desc_servicos AS 'SERVICOS',valortotal_consulta AS'VALOR TOTAL',
dataConsulta AS 'DATA',horaConsulta AS 'HORA' FROM tb_consulta CONSULTA 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = CONSULTA.CodCliente 
JOIN tb_veterinario VETERINARIO on VETERINARIO.codVeterinario = CONSULTA.cod_veterinario 
JOIN tb_tipo_animal TIPO on TIPO.cod_tipo_animal = CONSULTA.cod_tipo_animal_consulta;





SELECT codConsulta AS 'CODIGO',
CLIENTE.nomeCliente AS 'CLIENTE',
TIPO.nome_tipo_animal AS 'TIPO',
RACA.nome_raca_animal AS 'RACA',
CLIANI.nome_animal AS 'NOME',
VETERINARIO.nomeVeterinario AS 'VETERINARIO',
desc_servicos AS 'SERVICOS',
valortotal_consulta AS'VALOR TOTAL',
dataConsulta AS 'DATA',
horaConsulta AS 'HORA', 
CLIENTE.emailCliente AS 'EMAIL' 
FROM tb_consulta CONSULTA 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = CONSULTA.CodCliente 
JOIN tb_veterinario VETERINARIO on VETERINARIO.codVeterinario = CONSULTA.cod_veterinario 
JOIN tb_tipo_animal TIPO on TIPO.cod_tipo_animal = CONSULTA.cod_tipo_animal_consulta
JOIN tb_raca RACA on RACA.cod_raca = CONSULTA.cod_raca_animal_consulta
JOIN tb_clienteanimais CLIANI on CLIANI.nome_animal = CONSULTA.cod_raca_animal_consulta;



SELECT CONSULTA.codConsulta AS 'CODIGO',
CLIENTE.nomeCliente AS 'CLIENTE',
TIPO.nome_tipo_animal AS 'TIPO',
RACA.nome_raca_animal AS 'RACA',
VETERINARIO.nomeVeterinario AS 'VETERINARIO',
SERVICOS.nome_servico AS 'SERVIÇOS',
valortotal_consulta AS'VALOR TOTAL',
dataConsulta AS 'DATA',
horaConsulta AS 'HORA'
from tb_consulta CONSULTA
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = CONSULTA.CodCliente 
JOIN tb_tipo_animal TIPO on TIPO.cod_tipo_animal = CONSULTA.cod_tipo_animal_consulta
JOIN tb_raca RACA on RACA.cod_raca = CONSULTA.cod_raca_animal_consulta
JOIN tb_veterinario VETERINARIO on VETERINARIO.codVeterinario = CONSULTA.cod_veterinario 
JOIN tb_servicos SERVICOS on SERVICOS.cod_servico = CONSULTA.codConsulta 
is not null ;


SELECT 
CONSULTA.codConsulta AS 'CODIGO',
CLIENTE.nomeCliente AS 'CLIENTE',
SERVICOS.nome_servico AS 'SERVIÇOS',
CONSULTA.valortotal_consulta AS'VALOR TOTAL'
from tb_consulta CONSULTA 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = CONSULTA.CodCliente 
JOIN tb_servicos SERVICOS on SERVICOS.cod_servico = CONSULTA.codConsulta is not null;


select 
CONSULTA.dataConsulta AS 'DATA', 
CLIENTE.nomeCliente AS 'NOME', 
SERVICO.nome_servico AS 'SERVICO', 
SERVICO.preco_servico AS 'PRECO' 
from tb_consulta CONSULTA 
JOIN tb_servicos SERVICO on SERVICO.cod_servico = CONSULTA.cod_servico 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = CONSULTA.CodCliente 
WHERE CLIENTE.nomeCliente = "JOÃO MARCOS AFRICO DA SILVA" AND CONSULTA.dataConsulta = "30-01-2021";

select
CLIENTE.nomeCliente AS 'NOME', 
SERVICO.nome_servico AS 'SERVICO', 
PRODUTO.nome_produto AS 'PRODUITO' 
from tb_itens_cliente ITENS
JOIN tb_servicos SERVICO on SERVICO.cod_servico = ITENS.cod_servico 
JOIN tb_produtos PRODUTO on PRODUTO.cod_produto = ITENS.cod_produto 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = ITENS.cod_cliente is not null
WHERE CLIENTE.CodCliente = 18 ;


select * from tb_itens_cliente;

/*SELECIONA TODOS OS ITENS DO CLIENTE NUMERO "X" */
SELECT * FROM `tb_itens_cliente` WHERE `cod_cliente` = 18;

/*SELECIONA TODOS OS SERVICOS DO CLIENTE NUMERO "X" */
SELECT 
CLIENTE.nomeCliente AS 'NOME' ,
SERVICO.nome_servico AS 'SERVICO'
FROM tb_itens_cliente ITENS 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = ITENS.cod_cliente
JOIN tb_servicos SERVICO on SERVICO.cod_servico = ITENS.cod_servico 
WHERE ITENS.cod_cliente = 18;

/*SELECIONA TODOS OS PRODUTOS DO CLIENTE NUMERO "X" */
SELECT 
CLIENTE.nomeCliente AS 'NOME' ,
PRODUTO.nome_produto AS 'PRODUTO' 
FROM tb_itens_cliente ITENS 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = ITENS.cod_cliente
JOIN tb_produtos PRODUTO on PRODUTO.cod_produto = ITENS.cod_produto 
WHERE ITENS.cod_cliente = 15;



/*uniao de produtos e servicos "X" */
SELECT 
ITENS.cod_registro ,
CLIENTE.nomeCliente AS 'NOME' ,
SERVICO.nome_servico AS 'ITEM',
'SERVICO' AS TABELA
FROM tb_itens_cliente ITENS 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = ITENS.cod_cliente
JOIN tb_servicos SERVICO on SERVICO.cod_servico = ITENS.cod_servico 
WHERE ITENS.cod_cliente = 15
union all
SELECT 
ITENS.cod_registro,
CLIENTE.nomeCliente AS 'NOME' ,
PRODUTO.nome_produto ,
'PRODUTO' AS TABELA
FROM tb_itens_cliente ITENS 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = ITENS.cod_cliente
JOIN tb_produtos PRODUTO on PRODUTO.cod_produto = ITENS.cod_produto ORDER BY cod_registro;

SELECT 
ITENS.cod_registro ,
CLIENTE.nomeCliente AS 'NOME' ,
SERVICO.nome_servico AS 'ITEM',
'SERVICO' AS TABELA
FROM tb_itens_cliente ITENS 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = ITENS.cod_cliente
JOIN tb_servicos SERVICO on SERVICO.cod_servico = ITENS.cod_servico 
WHERE (CLIENTE.nomeCliente = "BRENO KASHIMA") 
union 
SELECT 
ITENS.cod_registro,
CLIENTE.nomeCliente AS 'NOME' ,
PRODUTO.nome_produto ,
'PRODUTO' AS TABELA
FROM tb_itens_cliente ITENS 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = ITENS.cod_cliente
JOIN tb_produtos PRODUTO on PRODUTO.cod_produto = ITENS.cod_produto ORDER BY 'TABELA';



SELECT desc_servicos FROM tb_consulta where CodCliente = 19;

/*select PARA MOSTRAR CODIGO DA CONSULTA, DO CLIENTE E FILTRAR PELA DATA*/
SELECT codConsulta,CodCliente,DATE_FORMAT(dataConsulta,"%d/%m/%Y") AS DATA FROM tb_consulta WHERE (CodCliente = 18 and dataConsulta = "2021-02-04");

/*SELECT PARA MOSTRAR CODIGO DA CONSULTA, DO CLIENTE E FILTRAR PELA DATA E EXCLUIR*/
DELETE FROM tb_consulta WHERE CodCliente = 18 and dataConsulta = "2021-02-04" ;

/*MOSTRA AS COMPRAS DO CLIENTE*/
SELECT 
PRODUTOS.cod_compra AS 'COMPRA',
CLIENTE.nomeCliente AS 'NOME',  
PRODUTOS.total_compra AS 'TOTAL',
PRODUTOS.data_compra AS 'DATA',
PRODUTOS.hora_compra AS 'HORA'
FROM tb_produtos_cliente PRODUTOS 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = PRODUTOS.cod_cliente GROUP by cod_cliente,data_compra;

/*MOSTRA O CLIENTE,DATA,HORA E OS ITENS DAS SUAS COMPRAS*/
select 
CLIENTE.nomeCliente AS 'NOME', 
PRODUTOS.nome_produto AS 'PRODUTO',
PRODUTOS.preco_produto AS 'PRECO',
CLIPRODUTOS.total_compra AS 'TOTAL',
DATE_FORMAT(CLIPRODUTOS.data_compra,'%d/%m/%Y') AS 'DATA', 
CLIPRODUTOS.hora_compra AS 'HORA'
from tb_produtos_cliente CLIPRODUTOS 
JOIN tb_produtos PRODUTOS on PRODUTOS.cod_produto = CLIPRODUTOS.cod_produto 
JOIN tb_cliente CLIENTE on CLIENTE.CodCliente = CLIPRODUTOS.cod_cliente 
WHERE CLIENTE.nomeCliente = "JOAO MARCOS AFRICO DA SILVA" AND CLIPRODUTOS.data_compra = "2021-02-08";

