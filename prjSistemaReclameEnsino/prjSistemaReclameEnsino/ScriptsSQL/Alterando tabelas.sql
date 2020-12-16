ALTER TABLE comentarios ADD foiRespondido CHAR(1);
ALTER TABLE comentarios ADD CONSTRAINT CHK_foiRespondido CHECK (foiRespondido='S' OR foiRespondido='N');

ALTER TABLE comentarios ADD respostaComentario VARCHAR(1000);
ALTER TABLE comentarios ADD respondente INT;

ALTER TABLE comentarios ADD CONSTRAINT FK_admin_comentario FOREIGN KEY (respondente) 
REFERENCES tb_administradores(idAdmin) 