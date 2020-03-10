create database Senatur_Manha;
go

use Senatur_Manha
go

create table TipoUsuario(
IdTipoUsuario int primary key identity,
Titulo varchar (200)
)
go

create table Usuario(
IdUsuario int primary key identity,
Email varchar(200),
Senha varchar(16),
IdTipoUsuario int foreign key references TipoUsuario(IdTipoUsuario)
)
go

create table Pacote(
IdPacote int primary key identity,
NomePacote varchar(200),
Descricao varchar(5000),
DataIda date,
DataVolta date,
Valor decimal,
Ativo bit,
NomeCidade varchar(200)
)
go


insert into TipoUsuario (Titulo)
values('Administrador'),
	  ('Usuario')

insert into Usuario(Email, Senha, IdTipoUsuario)
values('ana@gmail.com', 'ana123', 1),
	  ('nicolas@gmail.com', 'nicolas123', 2)

insert into Pacote(NomePacote, Descricao, Valor ,DataIda, DataVolta, Ativo, NomeCidade)
values	('Salvador - 5 dias/4 diarias', 'x', 854.90, '06-08-2020', '10-08-2020', 1, 'Salvador' ),
		('Resorts na Bahia - 5 dias/ 4 diarias' ,'x', 1826.00, '14-05-2020', '18-05-2020', 1, 'Salvador'),
		('Bonito via Campo Grande - 5 dias/4 diarias', ' x', 1004.00, '28-03-2020', '01-04-2020', 1, 'Bonito')

select*from TipoUsuario;
select*from Usuario;
select*from Pacote;



drop database Senatur_Manha