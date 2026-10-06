CREATE DATABASE IF NOT EXISTS sispadoca;

USE sispadoca;

CREATE TABLE IF NOT EXISTS cliente (
	id_cliente int AUTO_INCREMENT NOT NULL,
	nome varchar(150) NOT NULL,
	cpf varchar(14) NOT NULL UNIQUE,
	data_nascimento date NOT NULL,
	telefone varchar(20) NOT NULL,
	email varchar(150) NOT NULL,
	logradouro varchar(150) NOT NULL,
	numero varchar(20) NOT NULL,
	bairro varchar(100) NOT NULL,
	cidade varchar(100) NOT NULL,
	cep varchar(9) NOT NULL,
	data_cadastro date NOT NULL,
	status varchar(30) NOT NULL,
	PRIMARY KEY (id_cliente)
);
CREATE TABLE IF NOT EXISTS funcionario (
	id_funcionario int AUTO_INCREMENT NOT NULL,
	nome varchar(150) NOT NULL,
	cpf varchar(14) NOT NULL UNIQUE,
	rg varchar(20) NOT NULL,
	data_nascimento date NOT NULL,
	telefone varchar(20) NOT NULL,
	email varchar(150) NOT NULL,
	cargo varchar(100) NOT NULL,
	salario decimal(12,2) NOT NULL,
	data_admissao date NOT NULL,
	status varchar(30) NOT NULL,
	id_filial int NOT NULL,
	PRIMARY KEY (id_funcionario)
);
CREATE TABLE IF NOT EXISTS itens_pedido (
	id_itens_pedido int AUTO_INCREMENT NOT NULL,
	id_venda int NOT NULL,
	id_produto int NOT NULL,
	quantidade decimal(12,3) NOT NULL,
	preco_unitario decimal(12,2) NOT NULL,
	desconto decimal(12,2) NOT NULL,
	subtotal decimal(12,2) NOT NULL,
	observacao text NOT NULL,
	PRIMARY KEY (id_itens_pedido)
);
CREATE TABLE IF NOT EXISTS produto (
    id_produto int AUTO_INCREMENT NOT NULL,
    ncm varchar(150) NOT NULL,
    descricao text NOT NULL,
    preco_venda decimal(12,2) NOT NULL,
    custo decimal(12,2) NOT NULL,
    peso decimal(12,3) NOT NULL,
    unidade_medida varchar(30) NOT NULL,
    validade_dias int NOT NULL,
    id_categoria int NOT NULL,
    id_fornecedor int NOT NULL,
    status varchar(30) NOT NULL,
    data_cadastro date NOT NULL,
    PRIMARY KEY (id_produto)
);
CREATE TABLE IF NOT EXISTS estoque (
	id_estoque int AUTO_INCREMENT NOT NULL,
	id_produto int NOT NULL,
	quantidade decimal(12,3) NOT NULL,
	quantidade_minima decimal(12,3) NOT NULL,
	quantidade_maxima decimal(12,3) NOT NULL,
	lote varchar(60) NOT NULL,
	data_entrada date NOT NULL,
	data_validade date NOT NULL,
	localizacao varchar(100) NOT NULL,
	status varchar(30) NOT NULL,
	ultima_atualizacao datetime NOT NULL,
	PRIMARY KEY (id_estoque)
);
CREATE TABLE IF NOT EXISTS venda (
	id_venda int AUTO_INCREMENT NOT NULL,
	id_cliente int NOT NULL,
	id_funcionario int NOT NULL,
	id_filial int NOT NULL,
	data_venda date NOT NULL,
	hora_venda time NOT NULL,
	valor_subtotal decimal(12,2) NOT NULL,
	desconto decimal(12,2) NOT NULL,
	valor_total decimal(12,2) NOT NULL,
	status varchar(30) NOT NULL,
	PRIMARY KEY (id_venda)
);
ALTER TABLE itens_pedido ADD CONSTRAINT fk_item_venda_venda FOREIGN KEY (id_venda) REFERENCES venda (id_venda);
ALTER TABLE itens_pedido ADD CONSTRAINT fk_item_venda_produto FOREIGN KEY (id_produto) REFERENCES produto (id_produto);
ALTER TABLE estoque ADD CONSTRAINT fk_estoque_id_produto FOREIGN KEY (id_produto) REFERENCES produto (id_produto);
ALTER TABLE venda ADD CONSTRAINT fk_venda_id_cliente FOREIGN KEY (id_cliente) REFERENCES cliente (id_cliente);
ALTER TABLE venda ADD CONSTRAINT fk_venda_id_funcionario FOREIGN KEY (id_funcionario) REFERENCES funcionario (id_funcionario);