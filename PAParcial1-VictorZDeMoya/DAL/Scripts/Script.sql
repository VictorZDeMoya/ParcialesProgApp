Create table Producto(
IdProducto int identity primary key,
Costo float,
Descripcion varchar(50),
ValorInv float,
Existencia int
);

Create table Inv(
iD int,
Total float
);