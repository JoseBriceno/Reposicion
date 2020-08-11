
-- Datos para ingresar a la base.


-- Las contraseñas son '123' se ingresan encriptadas.

execute insertar_Empleado '0101199804248','Jonathan Alexis','Aleman Linares','1998-05-09','96693357','M','Farmaceutico','Activo','Y8msdnxDm9U='
execute insertar_Empleado '1807200000429','Hugo Geovany','Murillo Urbina','2000-02-17','96693300','M','Auxiliar','Activo','Y8msdnxDm9U='
execute insertar_Empleado '1807200100475','Marlon Josue','Mejia Monterroso','2000-12-30','96689955','M','Auxiliar','Activo','Y8msdnxDm9U='
execute insertar_Empleado '1807199900111','Marian Alejandra','Carcamo Perez','1999-04-10','95693300','F','Auxiliar','Activo','Y8msdnxDm9U='

execute insertar_cliente 'Luis Jose','Martinez Oseguera','Colonia la conquista','96857423','0101199600235'
execute insertar_cliente 'Mario Dario','Soto Funez','Colonia la esperanza','96857424','1807200000253'
execute insertar_cliente 'Cielo Fernanda','Gallardo Duran','Colonia intibuca','96757313','0101199900236'
execute insertar_cliente 'Nahomi Delcir','Calix Funez','Colonia amaya amador','95757320','0101199801236'


Insert into categoria(nombre_categoria)
values('Vitaminas y Minerales'),('Alergias, Gripe y Tos'),
('Dolor y Fiebre'),('Equipo Médico'),('Curación y Primeros Auxílios'),
('Malestar Estomacal'),('Dermatológicos');
