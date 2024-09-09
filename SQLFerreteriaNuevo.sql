--TABLAS DE LA BASE DE DATOS FerreteriaPDB
CREATE DATABASE FerreteriaPBD;
USE FerreteriaPBD;
--TABLA PROVEEDORES
CREATE TABLE Proveedores
(
	prov_ProveedorID VARCHAR(8) PRIMARY KEY,
	prov_Nombre VARCHAR(50) NOT NULL,
	prov_Direccion VARCHAR(100) NOT NULL,
	prov_Telefono VARCHAR(20) NOT NULL,
	prov_CorreoEletronico VARCHAR(30) NOT NULL
);
--TABLA CATEGORIAS
CREATE TABLE Categorias
(
	cate_CategoriaID VARCHAR(8) PRIMARY KEY,
	cate_Nombre VARCHAR (30),
);
--INSERCIONES DE CATEGORIAS
INSERT INTO Categorias (cate_CategoriaID, cate_Nombre) VALUES
('CA000001', 'Adhesivos y Selladores'),
('CA000002', 'Cerrajeria'),
('CA000003', 'Electricidad'),
('CA000004', 'Ferreteria General'),
('CA000005', 'Herramientas Electricas'),
('CA000006', 'Herramientas Manuales'),
('CA000007', 'Iluminacion'),
('CA000008', 'Jardineria'),
('CA000009', 'Materiales de Construccion'),
('CA000010', 'Pintura y Decoracion'),
('CA000011', 'Plomeria'),
('CA000012', 'Seguridad y Proteccion');
--TABLA PRODUCTOS
CREATE TABLE ProductosAlta
(
	prod_ProductoID VARCHAR(8) PRIMARY KEY,
	prod_Producto VARCHAR(100) NOT NULL,
	prod_Precio DECIMAL(15, 2) NOT NULL,
	prod_ProveedorID VARCHAR(8) NOT NULL,
	prod_Proveedor VARCHAR(50) NOT NULL,
	prod_Marca VARCHAR(100) NOT NULL,
	prod_CategoriaID VARCHAR(8) NOT NULL,
	prod_Categoria VARCHAR(40) NOT NULL,
	FOREIGN KEY (prod_ProveedorID) REFERENCES Proveedores (prov_ProveedorID),
	FOREIGN KEY (prod_CategoriaID) REFERENCES Categorias (cate_CategoriaID),
);	
--TABLA ESTADOS
CREATE TABLE Estados
(
	esta_EstadoID VARCHAR(8),
	esta_Estado VARCHAR(20),
);
--INSERCIONES DE ESTADOS
INSERT INTO Estados (esta_EstadoID, esta_Estado) VALUES
('ES000001', 'Disponible'),
('ES000002', 'En Liquidacion'),
('ES000003', 'Inspeccionar'),
('ES000004', 'Apartado'),
('ES000005', 'En Transito'),
('ES000006', 'Reabastecer');
--TABLA INVENTARIO
CREATE TABLE RevisionesInventario
(
	inve_RevisionID VARCHAR(8) PRIMARY KEY,
	inve_ProductoID VARCHAR(8),
	inve_ProductoNombre VARCHAR (100),
	inve_CantidadActual INT NOT NULL,
	inve_Notas TEXT,
	inve_Estado VARCHAR(30),
	inve_Ubicacion TEXT NOT NULL,
	FOREIGN KEY (inve_ProductoID) REFERENCES ProductosAlta(prod_ProductoID)
);
--TABLA CLIENTES
CREATE TABLE Clientes
(
	clie_ClienteID VARCHAR(8) PRIMARY KEY,
	clie_Nombre VARCHAR(50) NOT NULL,
	clie_Apellidos VARCHAR(100) NOT NULL,
	clie_Telefono VARCHAR(20) NOT NULL,
);
--TABLA EMPLEADOS
CREATE TABLE Empleados
(
	empl_EmpleadoID VARCHAR(8) PRIMARY KEY,
	empl_Empleado VARCHAR(50) NOT NULL,
	empl_Apellidos VARCHAR(100) NOT NULL,
	empl_Telefono VARCHAR(20) NOT NULL,
	empl_CorreoElectronico VARCHAR(30) NOT NULL,
);
--TABLA VENTA
CREATE TABLE Venta
(
	vent_VentaID VARCHAR(8) PRIMARY KEY,
	vent_Fecha VARCHAR(20) NOT NULL,
	vent_ClienteID VARCHAR(8) NOT NULL,
	vent_ClienteApellidos VARCHAR(100) NOT NULL,
	vent_EmpleadoID VARCHAR(8) NOT NULL,
	vent_EmpleadoApellidos VARCHAR(100) NOT NULL,
	vent_TotalVenta DECIMAL(15, 2) NOT NULL,
	FOREIGN KEY (vent_ClienteID) REFERENCES Clientes (clie_ClienteID),
	FOREIGN KEY (vent_EmpleadoID) REFERENCES Empleados (empl_EmpleadoID),
);
--TABLA PEDIDOS
CREATE TABLE Pedidos
(
	pedi_PedidoID VARCHAR(8) PRIMARY KEY,
	pedi_ProveedorID VARCHAR(8) NOT NULL,
	pedi_Proveedor VARCHAR(50) NOT NULL,
	pedi_ProductoID VARCHAR(8) NOT NULL,
	pedi_Producto VARCHAR(100) NOT NULL,
	pedi_FechaPedido VARCHAR(20) NOT NULL,
	pedi_FechaEntrega VARCHAR(20) NOT NULL,
	pedi_Cantidad INT NOT NULL,
	FOREIGN KEY (pedi_ProveedorID) REFERENCES Proveedores (prov_ProveedorID),
	FOREIGN KEY (pedi_ProductoID) REFERENCES ProductosAlta (prod_ProductoID)
);
--TABLA DEVOLUCIONES
CREATE TABLE Devolucion
(
    devo_DevolucionID VARCHAR(8) PRIMARY KEY,
    devo_PedidoID VARCHAR(8) NOT NULL,
	devo_Pedido VARCHAR(100) NOT NULL,
	devo_Observaciones TEXT NOT NULL,
	devo_CantidadDevolucion INT NOT NULL,
    FOREIGN KEY (devo_PedidoID) REFERENCES Pedidos(pedi_PedidoID),
);
--PROCESOS ALMACENADOS DENTRO DE LA BASE DE DATOS
--PROCESOS DE LA TABLA PROVEEDORES
--LISTAR PROVEEDORES
CREATE PROC prov_ListarProveedores
AS
SELECT * FROM Proveedores ORDER BY prov_ProveedorID
GO 
--BUSCAR PROVEEDORES
CREATE PROC prov_BuscarProveedores
@prov_Nombre VARCHAR(50)
AS
SELECT * FROM Proveedores WHERE prov_Nombre LIKE @prov_Nombre + '%'
GO
--MANTENIMIENTO DE PROVEEDORES
CREATE PROC prov_MantenimientoProveedores
@prov_ProveedorID VARCHAR(8),
@prov_Nombre VARCHAR(50),
@prov_Direccion VARCHAR(100),
@prov_Telefono VARCHAR(20),
@prov_CorreoElectronico VARCHAR(30),
@prov_accion VARCHAR(50) OUTPUT
AS
--GENERACIÓN DE CÓDIGO Y AGREGACIÓN DE PROVEEDOR
IF(@prov_accion='1')
BEGIN
	DECLARE @prov_IDNuevo VARCHAR(8), @prov_CodMax VARCHAR(8)
	SET @prov_CodMax = (SELECT MAX(prov_ProveedorID) FROM Proveedores)
	SET @prov_CodMax = ISNULL(@prov_CodMax, 'PR000000')
	SET @prov_IDNuevo = 'PR' + RIGHT('000000' + CAST(CAST(SUBSTRING(@prov_CodMax, 3, 6) AS INT) + 1 AS VARCHAR(6)), 6)
	INSERT INTO Proveedores(prov_ProveedorID, prov_Nombre, prov_Direccion, prov_Telefono, prov_CorreoEletronico)
	VALUES(@prov_IDNuevo, @prov_Nombre, @prov_Direccion, @prov_Telefono, @prov_CorreoElectronico)
	SET @prov_accion = 'Se genero el ID para proveedor: ' + @prov_IDNuevo
END
--MODIFICACIÓN/ACTUALIZACIÓN DE PROVEEDOR
ELSE IF (@prov_accion = '2')
BEGIN
	UPDATE Proveedores SET prov_Nombre = @prov_Nombre, prov_Direccion = @prov_Direccion, prov_Telefono = @prov_Telefono,
	prov_CorreoEletronico = @prov_CorreoElectronico WHERE prov_ProveedorID = @prov_ProveedorID
	SET @prov_accion = 'Se ha modificado el proveedor con codigo: ' + @prov_ProveedorID 
END
--ELIMINACIÓN DE PROVEEDOR
ELSE IF (@prov_accion = '3')
BEGIN
	DELETE FROM Proveedores WHERE prov_ProveedorID = @prov_ProveedorID
	SET @prov_accion = 'Se ha eliminado el proveedor con codigo: ' + @prov_ProveedorID
END
GO
--PROCESOS DE LA TABLA CLIENTES
--LISTAR CLIENTES
CREATE PROC clie_ListarClientes
AS
SELECT * FROM Clientes ORDER BY clie_ClienteID
GO 
--BUSCAR CLIENTES
CREATE PROC clie_BuscarClientes
@clie_Nombre VARCHAR(50)
AS
SELECT * FROM Clientes WHERE clie_Nombre LIKE @clie_Nombre + '%'
GO
--MANTENIMIENTO DE CLIENTES
CREATE PROC clie_MantenimientoClientes
@clie_ClienteID VARCHAR(8),
@clie_Nombre VARCHAR(50),
@clie_Apellidos VARCHAR(100),
@clie_Telefono VARCHAR(20),
@clie_accion VARCHAR(50) OUTPUT
AS
--GENERACIÓN DE CÓDIGO Y AGREGACIÓN DE CLIENTES
IF(@clie_accion='1')
BEGIN
	DECLARE @clie_IDNuevo VARCHAR(8), @clie_CodMax VARCHAR(8)
	SET @clie_CodMax = (SELECT MAX(clie_ClienteID) FROM Clientes)
	SET @clie_CodMax = ISNULL(@clie_CodMax, 'CL000000')
	SET @clie_IDNuevo = 'CL' + RIGHT('000000' + CAST(CAST(SUBSTRING(@clie_CodMax, 3, 6) AS INT) + 1 AS VARCHAR(6)), 6)
	INSERT INTO Clientes(clie_ClienteID, clie_Nombre, clie_Apellidos, clie_Telefono)
	VALUES(@clie_IDNuevo, @clie_Nombre, @clie_Apellidos, @clie_Telefono)
	SET @clie_accion = 'Se genero el ID para cliente: ' + @clie_IDNuevo
END
--MODIFICACIÓN/ACTUALIZACIÓN DE CLIENTES
ELSE IF (@clie_accion = '2')
BEGIN
	UPDATE Clientes SET clie_Nombre = @clie_Nombre, @clie_Apellidos = @clie_Apellidos, clie_Telefono = @clie_Telefono
	WHERE clie_ClienteID = @clie_ClienteID
	SET @clie_accion = 'Se ha modificado el cliente con codigo: ' + @clie_ClienteID 
END
--ELIMINACIÓN DE CLIENTES
ELSE IF (@clie_accion = '3')
BEGIN
	DELETE FROM Clientes WHERE clie_ClienteID = @clie_ClienteID
	SET @clie_accion = 'Se ha eliminado el cliente con codigo: ' + @clie_ClienteID
END
GO
--PROCESOS DE LA TABLA EMPLEADOS
--LISTAR EMPLEADOS
CREATE PROC empl_ListarEmpleados
AS
SELECT * FROM Empleados ORDER BY empl_EmpleadoID
GO 
--BUSCAR EMPLEADOS
CREATE PROC empl_BuscarEmpleados
@empl_Empleado VARCHAR(50)
AS
SELECT * FROM Empleados WHERE empl_Empleado LIKE @empl_Empleado + '%'
GO
--MANTENIMIENTO EMPLEADOS
CREATE PROC empl_MantenimientoEmpleados
@empl_EmpleadoID VARCHAR(8),
@empl_Empleado VARCHAR(50),
@empl_Apellidos VARCHAR(100),
@empl_Telefono VARCHAR(20),
@empl_CorreoElectronico VARCHAR(30),
@empl_accion VARCHAR(50) OUTPUT
AS
--GENERACION DE CODIGO Y AGREGACION DE EMPLEADOS
IF(@empl_accion='1')
BEGIN
	DECLARE @empl_IDNuevo VARCHAR(8), @empl_CodMax VARCHAR(8)
	SET @empl_CodMax = (SELECT MAX(empl_EmpleadoID) FROM Empleados)
	SET @empl_CodMax = ISNULL(@empl_CodMax, 'EM000000')
	SET @empl_IDNuevo = 'EM' + RIGHT('000000' + CAST(CAST(SUBSTRING(@empl_CodMax, 3, 6) AS INT) + 1 AS VARCHAR(6)), 6)
	INSERT INTO Empleados(empl_EmpleadoID, empl_Empleado, empl_Apellidos, empl_Telefono, empl_CorreoElectronico)
	VALUES(@empl_IDNuevo, @empl_Empleado, @empl_Apellidos, @empl_Telefono, @empl_CorreoElectronico)
	SET @empl_accion = 'Se genero el ID para empleado: ' + @empl_IDNuevo
END
--MODIFICACION DE EMPLEADOS
ELSE IF (@empl_accion = '2')
BEGIN
	UPDATE Empleados SET empl_Empleado = @empl_Empleado, @empl_Apellidos = @empl_Apellidos, empl_Telefono = @empl_Telefono, empl_CorreoElectronico = @empl_CorreoElectronico
	WHERE empl_EmpleadoID = @empl_EmpleadoID
	SET @empl_accion = 'Se ha modificado el empleado con codigo: ' + @empl_EmpleadoID 
END
--ELIMINACION DE EMPLEADOS
ELSE IF (@empl_accion = '3')
BEGIN
	DELETE FROM Empleados WHERE empl_EmpleadoID = @empl_EmpleadoID
	SET @empl_accion = 'Se ha eliminado el empleado con codigo: ' + @empl_EmpleadoID
END
GO
--PROCESOS DE LA TABLA PRODUCTOSALTA
--LISTAR PROCUTOS
CREATE PROC prod_ListarProductos
AS
SELECT * FROM ProductosAlta ORDER BY prod_ProductoID
GO 
--BUSCAR PRODUCTOS
CREATE PROC prod_BuscarProductos
@prod_Categoria VARCHAR(40)
AS
SELECT * FROM ProductosAlta WHERE prod_Categoria LIKE @prod_Categoria + '%'
GO
--MANTENIMIENTO DE PRODUCTOS
CREATE PROC prod_MantenimientoProductos
@prod_ProductoID VARCHAR(8),
@prod_Producto VARCHAR(100),
@prod_Precio DECIMAL(15, 2),
@prod_ProveedorID VARCHAR(8),
@prod_Proveedor VARCHAR(50),
@prod_Marca VARCHAR(100),
@prod_CategoriaID VARCHAR(8),
@prod_Categoria VARCHAR(40),
@prod_accion VARCHAR(50) OUTPUT
AS
--GENERACION DE CODIGO Y AGREGACION DE PRODUCTOS
IF(@prod_accion = '1')
BEGIN
	DECLARE @prod_IDNuevo VARCHAR(8), @prod_CodMax VARCHAR(8)
	SET @prod_CodMax = (SELECT MAX(prod_ProductoID) FROM ProductosAlta)
	SET @prod_CodMax = ISNULL(@prod_CodMax, 'PA000000')
	SET @prod_IDNuevo = 'PA' + RIGHT('000000' + CAST(CAST(SUBSTRING(@prod_CodMax, 3, 6) AS INT) + 1 AS VARCHAR(6)), 6)
	SET @prod_ProductoID = @prod_IDNuevo
	INSERT INTO ProductosAlta(prod_ProductoID, prod_Producto, prod_Precio, prod_ProveedorID, prod_Proveedor, prod_Marca, prod_CategoriaID, prod_Categoria)
	VALUES(@prod_ProductoID, @prod_Producto, @prod_Precio, @prod_ProveedorID, @prod_Proveedor, @prod_Marca, @prod_CategoriaID, @prod_Categoria)
	SET @prod_accion = 'Se genero el ID para el producto: ' + @prod_IDNuevo
END
--MODIFICACION/ACTUALIZACION DE PRODUCTOS
ELSE IF (@prod_accion = '2')
BEGIN
	UPDATE ProductosAlta SET prod_Producto = @prod_Producto, prod_Precio = @prod_Precio, prod_ProveedorID = @prod_ProveedorID, prod_Proveedor = @prod_Proveedor,
	prod_Marca = @prod_Marca, prod_CategoriaID = @prod_CategoriaID, prod_Categoria = @prod_Categoria
	WHERE prod_ProductoID = @prod_ProductoID
	SET @prod_accion = 'Se ha modificado el producto con codigo: ' + @prod_ProductoID 
END
--ELIMINACION DE PRODUCTOS
ELSE IF (@prod_accion = '3')
BEGIN
	DELETE FROM ProductosAlta WHERE prod_ProductoID = @prod_ProductoID
	SET @prod_accion = 'Se ha eliminado el producto con codigo: ' + @prod_ProductoID
END
GO
--PROCESOS DE LA TABLA INVENTARIOS
--LISTAR REVISIONES
CREATE PROC inve_ListarRevisiones
AS
SELECT * FROM RevisionesInventario ORDER BY inve_RevisionID
GO 
--BUSCAR EN INVENTARIO
CREATE PROC inve_BuscarProductos
@inve_ProductoNombre VARCHAR(100)
AS
SELECT * FROM RevisionesInventario WHERE inve_ProductoNombre LIKE @inve_ProductoNombre + '%'
GO
--MANTENIMIENTO DE REVISIONES
CREATE PROC inve_MantenimientoRevisiones
    @inve_RevisionID VARCHAR(8),
    @inve_ProductoID VARCHAR(8),
    @inve_ProductoNombre VARCHAR(100),
    @inve_CantidadActual INT,
    @inve_Notas TEXT,
    @inve_Estado VARCHAR(30),
    @inve_Ubicacion TEXT,
    @inve_accion VARCHAR(50) OUTPUT
AS
BEGIN
--GENERACION DE CODIGO Y AGREGACION DE REVISIONES
    IF (@inve_accion = '1')
    BEGIN
        DECLARE @inve_IDNuevo VARCHAR(8), @inve_CodMax VARCHAR(8);
        SELECT @inve_CodMax = MAX(inve_RevisionID) FROM RevisionesInventario;
        SET @inve_CodMax = ISNULL(@inve_CodMax, 'RI000000');
        SET @inve_IDNuevo = 'RI' + RIGHT('000000' + CAST(CAST(SUBSTRING(@inve_CodMax, 3, 6) AS INT) + 1 AS VARCHAR(6)), 6);
        INSERT INTO RevisionesInventario(inve_RevisionID, inve_ProductoID, inve_ProductoNombre, inve_CantidadActual, inve_Notas, inve_Estado, inve_Ubicacion)
        VALUES(@inve_IDNuevo, @inve_ProductoID, @inve_ProductoNombre, @inve_CantidadActual, @inve_Notas, @inve_Estado, @inve_Ubicacion);
        SET @inve_accion = 'Se genero el ID para la Revision de Inventario: ' + @inve_IDNuevo;
    END
--MODIFICACION/ACTUALIZACION DE REVISIONES
    ELSE IF (@inve_accion = '2')
    BEGIN
        UPDATE RevisionesInventario
        SET inve_ProductoID = @inve_ProductoID,
            inve_ProductoNombre = @inve_ProductoNombre,
            inve_CantidadActual = @inve_CantidadActual,
            inve_Notas = @inve_Notas,
            inve_Estado = @inve_Estado,
            inve_Ubicacion = @inve_Ubicacion
        WHERE inve_RevisionID = @inve_RevisionID;
        SET @inve_accion = 'Se ha modificado la Revision de Inventario con codigo: ' + @inve_RevisionID;
    END
    -- ELIMINACION DE REVISIONES
    ELSE IF (@inve_accion = '3')
    BEGIN
        DELETE FROM RevisionesInventario WHERE inve_RevisionID = @inve_RevisionID;
        SET @inve_accion = 'Se ha eliminado la Revision de Inventario con codigo: ' + @inve_RevisionID;
    END
END
GO
--PROCESOS DE LA TABLA VENTAS
--LISTAR VENTAS
CREATE PROC vent_ListarVentas
AS
SELECT * FROM Venta ORDER BY vent_VentaID
GO
--BUSCAR VENTAS
CREATE PROC vent_BuscarVentas
@vent_EmpleadoApellidos VARCHAR(100)
AS
SELECT * FROM Venta WHERE vent_EmpleadoApellidos LIKE @vent_EmpleadoApellidos + '%'
GO
--MANTENIMIENTO DE VENTAS
CREATE PROC vent_MantenimientoVentas
    @vent_VentaID VARCHAR(8),
    @vent_Fecha VARCHAR(20),
    @vent_ClienteID VARCHAR(8),
    @vent_ClienteApellidos VARCHAR(100),
    @vent_EmpleadoID VARCHAR(8),
	@vent_EmpleadoApellidos VARCHAR(100),
	@vent_TotalVenta DECIMAL(15, 2),
    @vent_accion VARCHAR(50) OUTPUT
AS
BEGIN
--GENERACION DE CODIGO Y AGREGACION DE VENTAS
    IF (@vent_accion = '1')
    BEGIN
        DECLARE @vent_IDNuevo VARCHAR(8), @vent_CodMax VARCHAR(8);
        SELECT @vent_CodMax = MAX(vent_VentaID) FROM Venta;
        SET @vent_CodMax = ISNULL(@vent_CodMax, 'VE000000');
        SET @vent_IDNuevo = 'VE' + RIGHT('000000' + CAST(CAST(SUBSTRING(@vent_CodMax, 3, 6) AS INT) + 1 AS VARCHAR(6)), 6);        
        INSERT INTO Venta(vent_VentaID, vent_Fecha, vent_ClienteID, vent_ClienteApellidos, vent_EmpleadoID,
		vent_EmpleadoApellidos, vent_TotalVenta)
        VALUES(@vent_IDNuevo, @vent_Fecha, @vent_ClienteID, @vent_ClienteApellidos, @vent_EmpleadoID, 
		@vent_EmpleadoApellidos, @vent_TotalVenta);
        SET @vent_accion = 'Se genero el ID para la Venta: ' + @vent_IDNuevo;
    END
--MODIFICACION/ACTUALIZACION DE VENTAS
    ELSE IF (@vent_accion = '2')
    BEGIN
        UPDATE Venta
        SET 
			vent_Fecha = @vent_Fecha,
            vent_ClienteID = @vent_ClienteID,
            vent_ClienteApellidos = @vent_ClienteApellidos,
            vent_EmpleadoID = @vent_EmpleadoID,
			vent_EmpleadoApellidos = @vent_EmpleadoApellidos,
			vent_TotalVenta = @vent_TotalVenta
        WHERE vent_VentaID = @vent_VentaID;
        SET @vent_accion = 'Se ha modificado la venta con codigo: ' + @vent_VentaID;
    END
--ELIMINACION DE VENTAS
    ELSE IF (@vent_accion = '3')
    BEGIN
        DELETE FROM Venta WHERE vent_VentaID = @vent_VentaID;
        SET @vent_accion = 'Se ha eliminado la venta con codigo: ' + @vent_VentaID;
    END
END
GO
--PROCESOS DE LA TABLA DEVOLUCIONES
--LISTAR DEVOLUCIONES
CREATE PROC devo_ListarDevoluciones
AS
SELECT * FROM Devolucion ORDER BY devo_DevolucionID
GO
--BUSCAR DEVOLUCIONES
CREATE PROC devo_BuscarDevoluciones
@devo_DevolucionID VARCHAR(100)
AS
SELECT * FROM Devolucion WHERE devo_DevolucionID LIKE @devo_DevolucionID + '%'
GO
--MANTENIMIENTO DE DEVOLUCIONES
CREATE PROC devo_MantenimientoDevoluciones
    @devo_DevolucionID VARCHAR(8),
    @devo_PedidoID VARCHAR(8),
	@devo_Pedido VARCHAR(100),
    @devo_Observaciones TEXT,
	@devo_CantidadDevolucion INT,
    @devo_accion VARCHAR(50) OUTPUT
AS
BEGIN
--GENERACION DE CODIGO Y AGREGACION DE DEVOLUCIONES
    IF (@devo_accion = '1')
    BEGIN
        DECLARE @devo_IDNuevo VARCHAR(8), @devo_CodMax VARCHAR(8);
        SELECT @devo_CodMax = MAX(devo_DevolucionID) FROM Devolucion;
        SET @devo_CodMax = ISNULL(@devo_CodMax, 'DE000000');
        SET @devo_IDNuevo = 'DE' + RIGHT('000000' + CAST(CAST(SUBSTRING(@devo_CodMax, 3, 6) AS INT) + 1 AS VARCHAR(6)), 6);        
        INSERT INTO Devolucion(devo_DevolucionID, devo_PedidoID, devo_Pedido, devo_Observaciones,
		devo_CantidadDevolucion)
        VALUES(@devo_IDNuevo, @devo_PedidoID, @devo_Pedido, @devo_Observaciones, @devo_CantidadDevolucion);
        SET @devo_accion = 'Se genero el ID para la Devolucion: ' + @devo_IDNuevo;
    END
--MODIFICACION/ACTUALIZACION DE DEVOLUCIONES
    ELSE IF (@devo_accion = '2')
    BEGIN
        UPDATE Devolucion
        SET 
            devo_PedidoID = @devo_PedidoID,
            devo_Pedido = @devo_Pedido,
			devo_Observaciones = @devo_Observaciones,
			devo_CantidadDevolucion = @devo_CantidadDevolucion
        WHERE devo_DevolucionID = @devo_DevolucionID;
        SET @devo_accion = 'Se ha modificado la devolucion con codigo: ' + @devo_DevolucionID;
    END
--ELIMINACION DE DEVOLUCIONES
    ELSE IF (@devo_accion = '3')
    BEGIN
        DELETE FROM Devolucion WHERE devo_DevolucionID = @devo_DevolucionID;
        SET @devo_accion = 'Se ha eliminado la devolucion con codigo: ' + @devo_DevolucionID;
    END
END
GO
--PROCESOS DE LA TABLA PEDIDOS
--LISTAR PEDIDOS
CREATE PROC pedi_ListarPedidos
AS
SELECT * FROM Pedidos ORDER BY pedi_PedidoID
GO
--BUSCAR PEDIDOS
CREATE PROC pedi_BuscarPedidos
@pedi_Producto VARCHAR(100)
AS
SELECT * FROM Pedidos WHERE pedi_Producto LIKE @pedi_Producto + '%'
GO
--MANTENIMIENTO DE PEDIDOS
CREATE PROC pedi_MantenimientoPedidos
    @pedi_PedidoID VARCHAR(8),
    @pedi_ProveedorID VARCHAR(8),
    @pedi_Proveedor VARCHAR(50),
    @pedi_ProductoID VARCHAR(8),
    @pedi_Producto VARCHAR(100),
	@pedi_FechaPedido VARCHAR(20),
	@pedi_FechaEntrega VARCHAR(20),
	@pedi_Cantidad INT,
    @pedi_accion VARCHAR(50) OUTPUT
AS
BEGIN
--MODIFICACION/ACTUALIZACION DE PEDIDOS
    IF (@pedi_accion = '1')
    BEGIN
        DECLARE @pedi_IDNuevo VARCHAR(8), @pedi_CodMax VARCHAR(8);
        SELECT @pedi_CodMax = MAX(pedi_PedidoID) FROM Pedidos;
        SET @pedi_CodMax = ISNULL(@pedi_CodMax, 'PE000000');
        SET @pedi_IDNuevo = 'PE' + RIGHT('000000' + CAST(CAST(SUBSTRING(@pedi_CodMax, 3, 6) AS INT) + 1 AS VARCHAR(6)), 6);        
        INSERT INTO Pedidos(pedi_PedidoID, pedi_ProveedorID, pedi_Proveedor, pedi_ProductoID, pedi_Producto,
		pedi_FechaPedido, pedi_FechaEntrega, pedi_Cantidad)
        VALUES(@pedi_IDNuevo, @pedi_ProveedorID, @pedi_Proveedor, @pedi_ProductoID, @pedi_Producto, @pedi_FechaPedido, 
		@pedi_FechaEntrega, @pedi_Cantidad);
        SET @pedi_accion = 'Se genero el ID para la Venta: ' + @pedi_IDNuevo;
    END
--MODIFICACION/ACTUALIZACION DE PEDIDOS
    ELSE IF (@pedi_accion = '2')
    BEGIN
        UPDATE Pedidos
        SET 
			pedi_ProveedorID = @pedi_ProveedorID,
            pedi_Proveedor = @pedi_Proveedor,
            pedi_ProductoID = @pedi_ProductoID,
            pedi_Producto = @pedi_Producto,
			pedi_FechaPedido = @pedi_FechaPedido,
			pedi_FechaEntrega = @pedi_FechaEntrega,
			pedi_Cantidad = @pedi_Cantidad
        WHERE pedi_PedidoID = @pedi_PedidoID;
        SET @pedi_accion = 'Se ha modificado el pedido con codigo: ' + @pedi_PedidoID;
    END
--ELIMINACION DE PEDIDOS
    ELSE IF (@pedi_accion = '3')
    BEGIN
        DELETE FROM Pedidos WHERE pedi_PedidoID = @pedi_PedidoID;
        SET @pedi_accion = 'Se ha eliminado el pedido con codigo: ' + @pedi_PedidoID;
    END
END
GO
--LLENAR COMBO BOX DE Pedidos
CREATE PROC pedi_CBXPedidos
AS
SELECT pedi_PedidoID, pedi_Producto FROM Pedidos
GO
--LLENAR COMBO BOX DE CLIENTES
CREATE PROC clie_CBXClientes
AS
SELECT clie_ClienteID, clie_Apellidos FROM Clientes
GO
DROP PROC clie_CBXClientes
--LLENAR COMBO BOX DE Empleados
CREATE PROC empl_CBXEmpleados
AS
SELECT empl_EmpleadoID, empl_Apellidos FROM Empleados
GO
DROP PROC empl_CBXEmpleados
--LLENAR COMBO BOX DE PROVEEDORES
CREATE PROC prov_CBXProoveedores
AS
SELECT prov_ProveedorID, prov_Nombre FROM Proveedores
GO
--LLENAR COMBO BOX DE CATEGORIA
CREATE PROC cate_CBXCategoria
AS
SELECT cate_CategoriaID, cate_Nombre FROM Categorias
GO
--LLENAR COMBOBOX DE PRODUCTOS
CREATE PROC prod_CBXProductos
AS
SELECT prod_ProductoID, prod_Producto FROM ProductosAlta
GO
--LLENAR COMBOBOX DE ESTADOS
CREATE PROC esta_CBXEstados
AS
SELECT esta_EstadoID, esta_Estado FROM Estados
GO
--LLENAR COMBO BOX DE ESTADOS
CREATE PROC esta_CBXEstados
AS
SELECT esta_EstadoID, esta_Estado FROM Estados
GO
