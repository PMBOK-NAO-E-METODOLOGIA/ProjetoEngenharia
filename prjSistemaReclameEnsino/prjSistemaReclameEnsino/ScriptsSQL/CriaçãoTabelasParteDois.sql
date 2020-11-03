create table tags(
	idTag 	  int primary key identity,
	descTag   varchar(30) unique
)

CREATE TABLE comentarios(
	idComentario	 	     INT PRIMARY KEY IDENTITY,
	nomeUsuario	   		     VARCHAR(50),
	tituloComentario		 VARCHAR(50) not null,
	descricaoProblema		 VARCHAR(1000) NOT NULL,   
	dataComentario 	     	 DATE NOT NULL,
	foiVisto			     CHAR(1),
	
	constraint chk_foiVisto check(foiVisto = 'S' OR foiVisto = 'N')
)

CREATE TABLE filtro_comentarios(

	idComentario INT NOT NULL,
	idTag INT NOT NULL,
	
	CONSTRAINT fk_tags_filtro FOREIGN KEY (idTag) REFERENCES tags(idTag),
	CONSTRAINT fk_comentarios_filtro FOREIGN KEY (idComentario) REFERENCES comentarios(idComentario)

)