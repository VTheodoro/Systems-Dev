
CREATE DATABASE IF NOT EXISTS crud_csharp;

USE crud_csharp;

CREATE TABLE IF NOT EXISTS login (
    id INT AUTO_INCREMENT PRIMARY KEY, 
    usuario VARCHAR(50) NOT NULL,      
    senha VARCHAR(255) NOT NULL        
);


INSERT INTO login (usuario, senha) VALUES ('admin', '123');