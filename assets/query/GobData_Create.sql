CREATE TABLE NombreEvento(
    IdCliente INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Mes VARCHAR(50) NOT NULL,
    Dia INT NOT NULL,
    Estado VARCHAR(100) NOT NULL,
    Convocante VARCHAR(100) NOT NULL,
    Numero_Evento VARCHAR(100) NOT NULL,
    Division VARCHAR(80) NOT NULL
);

CREATE TABLE DocumentosEvento(
    IdDocumento INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(70) NOT NULL,
    Documento ARBINARY(MAX) NOT NULL,
    Extension VARCHAR(100) NOT NULL,
    NombreDocID INT NOT NULL,
    CONSTRAINT FK_NombreDoc FOREIGN KEY (NombreDocID) REFERENCES NombreEvento(IdCliente)
)
GO

CREATE TABLE PartidasE(
    IdPartida INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    N_Partida INT NOT NULL,
    Descripcion VARCHAR(300) NOT NULL,
    Cant_Min INT NOT NULL,
    Cant_Max INT NOT NULL,
    Unidad_Medida VARCHAR(50) NOT NULL,
    Se_Ofrece VARCHAR(300) NOT NULL,
    Marca VARCHAR(50) NOT NULL,
    Catalogo VARCHAR(50) NOT NULL,
    Pais_Origen VARCHAR(50) NOT NULL,
    Fabricante VARCHAR(50) NOT NULL,
    Costo_Unitario DECIMAL(10,3) NOT NULL,
    Moneda VARCHAR(10) NOT NULL,
    Costo_Nacional DECIMAL(10,3) NOT NULL,
    Porcentaje_Ganancia DECIMAL(5,2) NOT NULL,
    Total_Unitario DECIMAL(10,3) NOT NULL,
    NombrePartID INT NOT NULL,
    CONSTRAINT FK_NombrePart FOREIGN KEY (NombrePartID) REFERENCES NombreEvento(IdCliente)
)
GO