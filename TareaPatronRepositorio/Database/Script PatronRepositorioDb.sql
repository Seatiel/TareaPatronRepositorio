create table Usuarios(
UsuarioId int identity(1,1) primary key,
NombreUsuario varchar(50),
Clave varchar(15)
);

create table Peliculas(
PeliculaId int identity(1,1) primary key,
Estreno varchar(50),
Descripcion varchar(100),
Fecha date,
CategoriaId int
);


create table Categorias(
CategoriaId int identity(1,1) primary key,
Categoria varchar(50)
);