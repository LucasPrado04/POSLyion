USE POSLyion

INSERT INTO Rol VALUES
('admin', default),
('user', default)

INSERT INTO Usuario VALUES
(12121212, 'mauricio', 'email@gmail.com', '123', 2, 1, default),
(21212121, 'lucas', 'email@outlook.com', '321', 1, 1, default)

INSERT INTO Categoria VALUES
('Gaseosas', 1, default),
('Golosinas', 1, default)

INSERT INTO Producto VALUES
('0', 'Schweppes 500ml', 1, 3, 233.33, 350.00, 1, default),
('0', 'Pepsi 1L', 1, 3, 821.54, 1020.00, 1, default),
('1', 'Alfajor Tofi simple chocolate', 2, 10, 121.98, 200.00, 1, default),
('1', 'Mantecol 50g', 2, 6, 212.11, 330.00, 1, default)


INSERT INTO Proveedor VALUES
('Arcor', 'arcor@hotmail.com', '3794111111', 1, default),
('Quilmes', 'quilmes@outlook.com', '3974222222', 0, default)