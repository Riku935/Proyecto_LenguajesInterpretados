CREATE DATABASE if not EXISTS ProyectoAstronauta;

USE ProyectoAstronauta;

CREATE TABLE Player(
    player_id INTEGER PRIMARY KEY NOT NULL,
    player_score VARCHAR(255) NOT NULL,
    player_name VARCHAR(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO Player (player_id, player_score, player_name) VALUES
(1, '400','Luis');

SELECT * FROM Player;



CREATE TABLE users (
  id int(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  username varchar(50) NOT NULL,
  passwordd varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO users (username, passwordd) VALUES
( 'Luis', '1234' ),
( 'Ricardo', '5678' );