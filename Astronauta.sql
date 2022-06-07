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