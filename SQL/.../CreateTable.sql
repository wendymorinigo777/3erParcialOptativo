DROP TABLE IF EXISTS dbo.Cliente
--Tabla Cliente
CREATE TABLE dbo.Cliente (
    id_Cliente INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    id_Persona INT FOREIGN KEY REFERENCES Persona(id_Persona) NOT NULL,
    Fecha_Ingreso DATETIME NOT NULL DEFAULT(getdate()),
	Calificacion VARCHAR(20) NOT NULL,
	Estado VARCHAR(20) NULL
);
