
CREATE DATABASE finapp;

USE finapp;

CREATE TABLE client (
    no_client INT AUTO_INCREMENT PRIMARY KEY,
    name_client VARCHAR(100) NOT NULL,
);

CREATE TABLE global_portfolio (
    no_portfolio INT AUTO_INCREMENT PRIMARY KEY,
    no_client INT,
    FOREIGN KEY (no_client) REFERENCES client(no_client)
);

CREATE TABLE local_portfolio (
    no_portfolio INT AUTO_INCREMENT PRIMARY KEY,
    no_client INT,
    FOREIGN KEY (no_client) REFERENCES client(no_client)
);

