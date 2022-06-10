CREATE DATABASE if not EXISTS ProyectoAstronauta;

USE ProyectoAstronauta;

CREATE TABLE users (
  id int(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  username varchar(50) NOT NULL,
  passwordd varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO users (username, passwordd) VALUES
( 'Luis', '1234' ),
( 'Ricardo', '5678' );

SELECT * FROM users;