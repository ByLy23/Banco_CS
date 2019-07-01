create table cliente(
idCliente int identity(1,1) primary key not null,
dpi bigint not null unique,
nombre varchar(40) not null, 
apellido varchar(50) not null, 
fecha_nac date not null,
correo varchar(50) not null,
telefono int,
username varchar(50) not null,
contrasenia varchar(50) not null,
palabra_clave varchar(50)
);
create table tipoEmpleado(
idTipo int identity(1,1) primary key not null,
puesto varchar(50)
);
create table empleado(
idEmpleado int identity(1,1) primary key not null,
dpi bigint not null unique,
nombre varchar(40) not null, 
apellido varchar(50) not null, 
fecha_nac date not null,
correo varchar(50) not null,
telefono int,
username varchar(50) not null,
contrasenia varchar(50) not null,
palabra_clave varchar(50),
idTipoEmpleado int not null
foreign key (idTipoEmpleado) references tipoEmpleado (idTipo)
);
insert into tipoEmpleado values ('Administrador');
insert into tipoEmpleado values ('Cajero');
insert into tipoEmpleado values ('Agente');

create table consulta(
idConsulta int identity(1,1) primary key not null,
tipoConsulta varchar(50)
);
insert into consulta values ('Queja');
insert into consulta values ('Reclamo');
insert into consulta values ('Sugerencia');
insert into consulta values ('Duda');

create table historialConsulta(
idHistorial int identity(1,1) primary key not null,
fecha date not null,
hora time not null,
motivo varchar(250) not null,
idCliente int not null,
idEmpleado int not null,
foreign key (idCliente) references cliente (idCliente),
foreign key (idEmpleado) references empleado (idEmpleado)
);

create table transferencia(
idTransferencia int identity(1,1) primary key not null,
tipoTransferencia varchar(50)
);
create table historialTransferencia(
idHisTrans int identity(1,1) primary key not null,
fecha date not null,
hora time not null,
bancoDestino varchar(50) not null,
monto decimal(18,3) not null,
idCliente int not null,
idEmpleado int not null,
foreign key (idCliente) references cliente (idCliente),
foreign key (idEmpleado) references empleado (idEmpleado)
);

alter table historialTransferencia
add foreign key (idTransfer) references transferencia (idTransferencia) ;

alter table historialConsulta 
add foreign key (idConsulta) references consulta (idConsulta);