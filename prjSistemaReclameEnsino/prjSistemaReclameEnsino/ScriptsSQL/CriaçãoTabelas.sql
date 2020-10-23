CREATE TABLE tb_administradores(
	idAdmin			   INT PRIMARY KEY IDENTITY,
	nomeAdmin          VARCHAR(50) NOT NULL,
	nomeUsuario        VARCHAR(20) UNIQUE NOT NULL,
	senhaUsuario	   VARCHAR(20) NOT NULL,
	dataCadastro       DATE NOT NULL,
	isAtivo		       CHAR(1),
	CONSTRAINT CHK_isAtivo CHECK(isAtivo = 'S' OR isAtivo = 'N')
);
