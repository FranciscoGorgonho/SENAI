-- criação de banco de dados
CREATE DATABASE TesteSegurancaBE7FS4;

--colocar o banco de dados em uso
USE TesteSegurancaBE7FS4;

--criação de uma tabela para armaznar usuários
CREATE TABLE Usuarios
(
	ID INT PRIMARY KEY IDENTITY, --identity torna o campo auto incremental
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL
);

--Consulta a todos os dados da tabela criada

SELECT * FROM Usuarios;

-- cadastrar um usuario no banco de dados

INSERT INTO Usuarios VALUES ('dante@email.com' ,'1234' )
INSERT INTO Usuarios VALUES ('tiago@email.com' ,'4321' )
INSERT INTO Usuarios VALUES ('pedro@email.com' ,'5678' );

--Hasheando dados em uma consulta
SELECT Id,Email FROM Usuarios;



--hasheando dados em uma consulta
SELECT ID, Email, HASHBYTES('MD2',Senha) FROM Usuarios;

--hasheando dados e filtrando apenas um usuario
SELECT ID, Email, HASHBYTES('MD2',Senha) FROM Usuarios WHERE Id = 1;

--hasheando dados e filtrando apenas um usuario e dando apelido a couna hasheada
SELECT ID, Email, HASHBYTES('MD2',Senha) AS 'Senha Hash' FROM Usuarios;

--tilizando algotitmo MD2 (seguindo os ultimos exempolos de linhaXcolunas)
SELECT ID, Email, HASHBYTES('MD2',Senha) AS 'Senha Hash' FROM Usuarios;

--tilizando algotitmo MD4 (seguindo os ultimos exempolos de linhaXcolunas)
SELECT ID, Email, HASHBYTES('MD4',Senha) AS 'Senha Hash' FROM Usuarios;

--tilizando algotitmo MD5 (seguindo os ultimos exempolos de linhaXcolunas)
SELECT ID, Email, HASHBYTES('MD5',Senha) AS 'Senha Hash' FROM Usuarios;

--tilizando algotitmo SHA (seguindo os ultimos exempolos de linhaXcolunas)
SELECT ID, Email, HASHBYTES('SHA',Senha) AS 'Senha Hash' FROM Usuarios;

--tilizando algotitmo SH1 (seguindo os ultimos exempolos de linhaXcolunas)
SELECT ID, Email, HASHBYTES('SHA1',Senha) AS 'Senha Hash' FROM Usuarios;

--tilizando algotitmo SHA2_256 (seguindo os ultimos exempolos de linhaXcolunas)
SELECT ID, Email, HASHBYTES('SHA2_256',Senha) AS 'Senha Hash' FROM Usuarios;

--tilizando algotitmo SHA2_512 (seguindo os ultimos exempolos de linhaXcolunas)
SELECT ID, Email, HASHBYTES('SHA2_512',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1;