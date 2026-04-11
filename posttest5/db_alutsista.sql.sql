CREATE DATABASE IF NOT EXISTS db_alutsista;
USE db_alutsista;

CREATE TABLE IF NOT EXISTS tabel_alutsista (
    id VARCHAR(50) PRIMARY KEY,
    nama VARCHAR(100),
    jenis VARCHAR(50),
    status VARCHAR(50)
);

-- Contoh data awal (opsional)
INSERT INTO tabel_alutsista VALUES ('T-01', 'Leopard 2RI', 'Main Battle Tank', 'Aktif');
INSERT INTO tabel_alutsista VALUES ('T-02', 'K2 Black Panther', 'Main Battle Tank', 'Maintenance');