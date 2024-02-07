/* Lógico_1: */

CREATE TABLE CAIXA (
    codigo varchar(20) PRIMARY KEY,
    data datetime,
    valorAbertura decimal(5,2),
    valorQuebra decimal(5,2),
    horarioAbertura datetime,
    horaFechamento datetime,
    valorEntrada decimal(5,2),
    valorSaida decimal(5,2),
    saldoFinal decimal(5,2),
    fk_UsuarioCaixa_idUsuario int
);

CREATE TABLE CASCO (
    idVasilhame int auto_increment PRIMARY KEY,
    tipoVasilhame int,
    valorVenda decimal(5,2),
    estoqueTotal int,
    estoqueSeco int,
    estoqueCheio int
);

CREATE TABLE CLIENTE (
    idCliente int auto_increment PRIMARY KEY,
    nomeCliente varchar(100),
    telefoneCliente varchar(100),
    rua varchar(100),
    numero int,
    bairro varchar(100),
    cidade varchar(100)
);

CREATE TABLE VENDA (
    codigoVenda varchar(100) PRIMARY KEY,
    dataVenda datetime,
    formaPag int,
    desconto decimal(5,2),
    totalVenda decimal(5,2),
    statusVenda int,
    valorPago decimal(5,2),
    ValorPendentePg decimal(5,2),
    fk_Entregador_idEntregador int,
    fk_Cliente_idCliente int
);

CREATE TABLE DESPESA (
    idDespesa int auto_increment PRIMARY KEY,
    descricaoDespesa varchar(255),
    valorDespesa decimal(5,2),
    tipoSaida int,
    fk_Caixa_codigo varchar(20)
);

CREATE TABLE ENTREGADOR (
    idEntregador int auto_increment PRIMARY KEY,
    nomeEntregador varchar(100),
    veiculo varchar(100),
    placa varchar(100)
);

CREATE TABLE USUARIO_CAIXA (
    nomeUsuario varchar(100),
    passWord int,
    previlegio int,
    idUsuario int auto_increment PRIMARY KEY
);

CREATE TABLE ITEM (
    idItem int auto_increment PRIMARY KEY,
    qtde int,
    valorPag decimal(10,5),
    subTotal decimal(5,2),
    fk_Venda_codigoVenda varchar(100),
    fk_Vasilhame_idVasilhame int
);

CREATE TABLE RECEBIMENTO (
    idReceb int auto_increment PRIMARY KEY,
    data datetime,
    valorRecebido decimal(5,2),
    descricaoReceb varchar(100),
    totalItens int,
    totalRecebido decimal(5,2),
    valorPendente decimal(5,2),
    fk_Venda_codigoVenda varchar(100)
);

CREATE TABLE Abastecimento (
    id int auto_increment PRIMARY KEY,
    tipoMov int,
    qtde int,
    data int,
    fk_IdVasilhame int
);
 
ALTER TABLE CAIXA ADD CONSTRAINT FK_CAIXA_2
    FOREIGN KEY (fk_UsuarioCaixa_idUsuario)
    REFERENCES USUARIO_CAIXA (idUsuario)
    ON DELETE CASCADE;
 
 
ALTER TABLE VENDA ADD CONSTRAINT FK_VENDA_2
    FOREIGN KEY (fk_Entregador_idEntregador)
    REFERENCES ENTREGADOR (idEntregador)
    ON DELETE CASCADE;
 
ALTER TABLE VENDA ADD CONSTRAINT FK_VENDA_3
    FOREIGN KEY (fk_Cliente_idCliente)
    REFERENCES CLIENTE (idCliente)
    ON DELETE CASCADE;
 
ALTER TABLE DESPESA ADD CONSTRAINT FK_DESPESA_2
    FOREIGN KEY (fk_Caixa_codigo)
    REFERENCES CAIXA (codigo)
    ON DELETE CASCADE;
 
ALTER TABLE ITEM ADD CONSTRAINT FK_ITEM_2
    FOREIGN KEY (fk_Venda_codigoVenda)
    REFERENCES VENDA (codigoVenda)
    ON DELETE RESTRICT;
 
ALTER TABLE ITEM ADD CONSTRAINT FK_ITEM_3
    FOREIGN KEY (fk_Vasilhame_idVasilhame)
    REFERENCES CASCO (idVasilhame)
    ON DELETE CASCADE;
 
ALTER TABLE RECEBIMENTO ADD CONSTRAINT FK_RECEBIMENTO_2
    FOREIGN KEY (fk_Venda_codigoVenda)
    REFERENCES VENDA (codigoVenda)
    ON DELETE CASCADE;
 
ALTER TABLE Abastecimento ADD CONSTRAINT FK_Abastecimento_2
    FOREIGN KEY (fk_IdVasilhame)
    REFERENCES CASCO (idVasilhame);