 --Tabla Usuario
DROP TABLE IF EXISTS dbo.Usuario
CREATE TABLE dbo.Usuario (
    id_usuario  INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	id_Persona INT FOREIGN KEY REFERENCES Persona(id_Persona) NOT NULL,
    Nombre_Usuario VARCHAR(50) NOT NULL,
    Contrasenha VARCHAR(50) NOT NULL,
	Nivel VARCHAR(50) NOT NULL,
	Estado VARCHAR(50) NOT NULL
);
