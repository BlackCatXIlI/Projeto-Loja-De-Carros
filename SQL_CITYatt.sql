CREATE DATABASE LOJA1;




USE LOJA1;

DROP database loja1;

CREATE TABLE LOGIN(
CODIGO INT PRIMARY KEY AUTO_INCREMENT,
USUARIO VARCHAR(10),
SENHA VARCHAR(10)
);

insert into LOGIN(USUARIO,SENHA) values('Admin','1234567');


CREATE TABLE CLIENTE (
COD_CLI INT PRIMARY KEY AUTO_INCREMENT,
NOME VARCHAR(25),
SOBRENOME VARCHAR(25),
NASCIMENTO DATE
);


CREATE TABLE ENDERECO(
CODIGO_END INT PRIMARY KEY AUTO_INCREMENT,
CODIGO_CLI INT,
LOGRADOURO VARCHAR(20),
NUMERO VARCHAR(20),
BAIRRO VARCHAR(20),
CIDADE VARCHAR(20),
foreign key(CODIGO_CLI) REFERENCES CLIENTE(COD_CLI)
);



CREATE TABLE VEICULOS (
COD_VEICULO INT PRIMARY KEY AUTO_INCREMENT,
MODELO VARCHAR(20),
FABRICANTE VARCHAR(15),
COR VARCHAR(10),
PLACA VARCHAR(10),
DESCRICAO VARCHAR(50),
NOME VARCHAR(250),
IMAGE_DATA mediumblob
 
);
SELECT * FROM veiculos;
SELECT * FROM LOGIN;
SELECT * FROM ENDERECO;
SELECT * FROM CLIENTE;

SELECT COD_CLI, NOME, SOBRENOME, DATA_NASCIMENTO, LOGRADOURO, NÚMERO, BAIRRO, CIDADE
FROM CLIENTE
INNER JOIN ENDERECO ON COD_CLI= CODIGO_END;

ALTER TABLE ENDERECO
CHANGE COD_CLI CODIGO_CLI int;

SELECT DATE_FORMAT(NASCIMENTO, '%d/%m/%Y') AS NASCIMENTO
FROM CLIENTE;

UPDATE CLIENTE
SET NASCIMENTO = STR_TO_DATE(NASCIMENTO, '%d/%m/%Y');

select * from ARQUIVOS;


