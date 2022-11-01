USE UC13

INSERT INTO Usuarios VALUES ('Cloud Strife', 'Senha1234');
INSERT INTO Usuarios VALUES ('Tifa Lockart', 'Senha4321');
INSERT INTO Usuarios VALUES ('Sephirot', 'Senha5678');
INSERT INTO Usuarios VALUES ('Barret', 'Senha8765');

INSERT INTO Classes VALUES ('Guerreiro', 'Soldado Classe S');
INSERT INTO Classes VALUES ('Lutadora', 'Classe A');
INSERT INTO Classes VALUES ('Samurai', 'Ronin');
INSERT INTO Classes VALUES ('Assalto', 'Tiro');

INSERT INTO Habilidades VALUES ('Limit Break');
INSERT INTO Habilidades VALUES ('Super punch');
INSERT INTO Habilidades VALUES ('Fire III');
INSERT INTO Habilidades VALUES ('Big ban');

INSERT INTO Personagens VALUES ('Cloud', 1,1 );
INSERT INTO Personagens VALUES ('Tifa', 2,2);
INSERT INTO Personagens VALUES ('Sephirot', 3,3);
INSERT INTO Personagens VALUES ('Barret', 3,1);

INSERT INTO ClassesHabilidades VALUES (1,1), (1,2);
INSERT INTO ClassesHabilidades VALUES (2,2), (2,1);
INSERT INTO ClassesHabilidades VALUES (3,1), (3,3);
INSERT INTO ClassesHabilidades VALUES (1,2), (1,1);

SELECT * FROM Usuarios;
SELECT * FROM Classes;
SELECT * FROM Habilidades;
SELECT * FROM Personagens;
SELECT * FROM ClassesHabilidades;