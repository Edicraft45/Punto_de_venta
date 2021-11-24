-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-11-2021 a las 19:57:40
-- Versión del servidor: 10.4.20-MariaDB
-- Versión de PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `verificador_de_precios`
--

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `cantidad`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `cantidad` (
`producto_codigo` int(11)
,`Total` decimal(32,0)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `producto_codigo` bigint(13) UNSIGNED NOT NULL,
  `producto_nombre` varchar(255) NOT NULL,
  `producto_cantidad` smallint(9) UNSIGNED NOT NULL,
  `producto_precio` double(10,2) UNSIGNED NOT NULL,
  `producto_imagen` varchar(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`producto_codigo`, `producto_nombre`, `producto_cantidad`, `producto_precio`, `producto_imagen`) VALUES
(501, 'Coca-cola', 20, 17.90, 'https://m.media-amazon.com/images/I/5156FefjlqL._SX425_.jpg'),
(502, 'Takis Fuego', 14, 18.90, 'https://www.barcel.com.mx/sites/default/files/takis_fuego.png'),
(503, 'Dr Pepper', 12, 20.90, 'https://munchiezonline.co.za/wp-content/uploads/2021/07/Dr-Pepper.png'),
(504, 'Cheetos', 14, 14.90, 'https://modeloramanow.vtexassets.com/arquivos/ids/155400/4.png'),
(505, 'Chips', 15, 17.90, 'https://www.barcel.com.mx/sites/default/files/chips-jalapeno-v2.png'),
(506, 'Doritos', 12, 17.90, 'https://www.doritos.com/sites/doritos.com/files/2018-08/new-nacho-cheese.png'),
(507, 'Tostitos', 14, 17.90, 'https://cdn.shopify.com/s/files/1/0394/1027/0253/products/976486541-1585078504935_600x600.png'),
(508, 'Paketaxo', 15, 24.90, 'https://paketaxo.com.mx/images/home/paketaxo_quexo.png'),
(509, 'Maruchan', 22, 11.90, 'https://maruchan.com.mx/web/wp-content/uploads/2020/11/camaronlimonhabanero.png'),
(510, '7UP', 18, 14.90, 'https://www.100centena.com/pub/media/catalog/product/cache/07a142c8a19d573ee4b03489790d6e90/n/d/ndzmytmzmg-1000x1000.png'),
(511, 'Gansito', 14, 12.90, 'https://i0.wp.com/www.casagamovi.cl/wp-content/uploads/2020/07/gansiro-marinela.png'),
(512, 'Principe', 12, 13.90, 'https://marinelausa.com/sites/default/files/BBUSA_Principe_84g_RND-third.png'),
(513, 'Polvorones', 12, 13.90, 'https://s.cornershopapp.com/product-images/383117.png'),
(514, 'Barritas', 11, 14.90, 'https://res.cloudinary.com/walmart-labs/image/upload/w_960,dpr_auto,f_auto,q_auto:best/gr/images/product-images/img_large/00750100013305L.jpg'),
(515, 'Cremax', 17, 26.90, 'https://lapatroncita.mx/wp-content/uploads/2020/04/cremax_niefve_fresa.jpg'),
(516, 'Oreo', 14, 14.90, 'https://freshmarketbqto.com/wp-content/uploads/2021/03/PQmKjR5x-n-removebg-preview.png'),
(517, 'Emperador', 11, 13.90, 'https://gamesa.com.mx/recetas/storage/app/uploads/public/5ff/61c/24b/5ff61c24b2995763435832.png'),
(518, 'Polvorones', 14, 13.90, 'https://s.cornershopapp.com/product-images/383117.png'),
(519, 'Arcoiris', 15, 14.90, 'https://cdn.shopify.com/s/files/1/0706/6309/products/work235676_1142x.jpg'),
(520, 'Canelitas', 15, 14.90, 'https://lagranbodega.vteximg.com.br/arquivos/ids/215407-600-600/7501030491644_1.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `numero_de_empleado` int(11) NOT NULL,
  `nombre` varchar(51) CHARACTER SET latin1 DEFAULT NULL,
  `apellido1` varchar(51) CHARACTER SET latin1 DEFAULT NULL,
  `apellido2` varchar(51) CHARACTER SET latin1 DEFAULT NULL,
  `celular` bigint(12) DEFAULT NULL,
  `curp` varchar(24) CHARACTER SET latin1 NOT NULL,
  `rfc` varchar(20) CHARACTER SET latin1 NOT NULL,
  `nss` varchar(11) CHARACTER SET latin1 NOT NULL,
  `correo` varchar(254) CHARACTER SET latin1 DEFAULT NULL,
  `direccion` varchar(254) CHARACTER SET latin1 DEFAULT NULL,
  `pass` varchar(32) NOT NULL,
  `permisosUsuario` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`numero_de_empleado`, `nombre`, `apellido1`, `apellido2`, `celular`, `curp`, `rfc`, `nss`, `correo`, `direccion`, `pass`, `permisosUsuario`) VALUES
(1, 'Cesar', 'Solano', 'Bejarano', 6621543717, 'SOLANO123456789', 'SOLANO0123456789', '12345', 'cesars@gmail.com', 'Los Lagos', '12345', 1),
(2, 'Humberto', 'Abril', 'García', 6621543987, 'Humb817637563', 'hhfue7635244', 'kdh7376', 'abril@gmail.com', 'Hermosillo, Sonora', '12345', 1),
(3, 'Edi Uriel', 'Maldonado', 'Hernández', 6621765294, 'MPOS165DA5153', '1561355', '1531', 'edicraft45@gmail.com', 'Loma Linda', '12345', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `idventa` int(11) NOT NULL,
  `fechaventa` date NOT NULL,
  `horaventa` time NOT NULL,
  `operadorVenta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`idventa`, `fechaventa`, `horaventa`, `operadorVenta`) VALUES
(1, '2020-11-19', '12:01:11', 1),
(3, '2020-10-30', '05:10:15', 1),
(4, '2020-09-30', '07:10:15', 2),
(5, '2020-11-14', '13:51:55', 1),
(6, '2021-11-23', '01:55:48', 2),
(26, '2021-11-23', '04:19:03', 2),
(27, '2021-11-23', '04:57:06', 2),
(28, '2021-11-23', '04:59:22', 1),
(33, '2021-11-24', '12:47:18', 2),
(34, '2021-11-24', '02:09:20', 1),
(35, '2021-11-24', '03:09:16', 1),
(36, '2021-11-24', '03:15:49', 2),
(37, '2021-11-24', '03:16:53', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_detalle`
--

CREATE TABLE `ventas_detalle` (
  `id_venta` int(11) NOT NULL,
  `producto_codigo` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `producto_precio` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ventas_detalle`
--

INSERT INTO `ventas_detalle` (`id_venta`, `producto_codigo`, `cantidad`, `producto_precio`) VALUES
(1, 501, 2, 17.9),
(1, 503, 2, 20.9),
(1, 506, 4, 17.9),
(3, 520, 3, 14.9),
(3, 511, 5, 12.9),
(3, 508, 4, 24.9),
(3, 501, 4, 17.9),
(4, 503, 5, 20.9),
(4, 512, 4, 13.9),
(4, 519, 1, 14.9),
(4, 514, 3, 14.9),
(4, 508, 1, 24.9),
(5, 507, 4, 17.9),
(5, 516, 3, 14.9),
(5, 515, 1, 26.9),
(6, 509, 2, 11.9),
(6, 508, 3, 24.9),
(26, 520, 3, 14.9),
(26, 519, 2, 14.9),
(26, 513, 1, 13.9),
(27, 514, 1, 14.9),
(27, 515, 1, 26.9),
(27, 516, 1, 14.9),
(28, 502, 1, 18.9),
(28, 504, 1, 14.9),
(33, 509, 10, 11.9),
(33, 508, 1, 24.9),
(33, 501, 1, 17.9),
(34, 502, 1, 18.9),
(34, 502, 1, 18.9),
(35, 509, 1, 11.9),
(36, 509, 2, 11.9),
(37, 501, 3, 17.9),
(37, 505, 1, 17.9),
(37, 507, 1, 17.9),
(37, 520, 1, 14.9),
(37, 511, 1, 12.9);

-- --------------------------------------------------------

--
-- Estructura para la vista `cantidad`
--
DROP TABLE IF EXISTS `cantidad`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `cantidad`  AS SELECT `ventas_detalle`.`producto_codigo` AS `producto_codigo`, sum(`ventas_detalle`.`cantidad`) AS `Total` FROM `ventas_detalle` GROUP BY `ventas_detalle`.`producto_codigo` ORDER BY `ventas_detalle`.`producto_codigo` ASC ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD UNIQUE KEY `producto_codigo` (`producto_codigo`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD UNIQUE KEY `idventa` (`idventa`),
  ADD KEY `operadorVenta` (`operadorVenta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `idventa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
