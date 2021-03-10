--
-- Base de datos: `controlempleados`
-- BD Inicial
--
CREATE DATABASE IF NOT EXISTS controlempleados;
USE controlempleados;

-- Estructura de tabla para la tabla `ayuda`

CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` text COLLATE utf8_unicode_ci NOT NULL,
  `indice` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Volcado de datos para la tabla `ayuda`

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`) VALUES
(1, 'Página web ayuda/ayuda.chm', 'menu.html'),
(2, 'Página web ayuda/ayuda.chm', 'Menúboletos.html');

-- Estructura de tabla para la tabla `empleados`

CREATE TABLE `empleados` (
  `codigo_empleado` int(11) NOT NULL,
  `nombre_completo` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `puesto` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `departamento` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcado de datos para la tabla `empleados`

INSERT INTO `empleados` (`codigo_empleado`, `nombre_completo`, `puesto`, `departamento`, `estado`) VALUES
(1, 'RANDY CHOC', 'AUDITOR DE SISTEMAS', 'IT', 1),
(2, 'RANDALL CHOC', 'AUXILIAR DE SISTEMAS', 'IT', 1);

-- Estructura de tabla para la tabla `login`

CREATE TABLE `login` (
  `usuario` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `contrasenia` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `codigo_empleado` int(11) NOT NULL,
  `nivel` tinyint(4) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Estructura de tabla para la tabla `registro_empleados`

CREATE TABLE `registro_empleados` (
  `codigo_registro` int(11) NOT NULL,
  `codigo_empleado` int(11) NOT NULL,
  `fecha_registro` date NOT NULL,
  `hora_entrada` time NOT NULL,
  `hora_salida` time DEFAULT NULL,
  `total_de_horas` time DEFAULT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Índices para tablas volcadas
-- Indices de la tabla `empleados`

ALTER TABLE `empleados`
  ADD PRIMARY KEY (`codigo_empleado`);

-- Indices de la tabla `login`

ALTER TABLE `login`
  ADD PRIMARY KEY (`usuario`),
  ADD KEY `fk_codEmpleadoLogIn` (`codigo_empleado`);

-- Indices de la tabla `registro_empleados`

ALTER TABLE `registro_empleados`
  ADD PRIMARY KEY (`codigo_registro`),
  ADD KEY `fk_codigo_empleado` (`codigo_empleado`);

-- AUTO_INCREMENT de las tablas volcadas
-- AUTO_INCREMENT de la tabla `empleados`

ALTER TABLE `empleados`
  MODIFY `codigo_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

-- AUTO_INCREMENT de la tabla `registro_empleados`

ALTER TABLE `registro_empleados`
  MODIFY `codigo_registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=111;

-- Restricciones para tablas volcadas
-- Filtros para la tabla `login`

ALTER TABLE `login`
  ADD CONSTRAINT `fk_codEmpleadoLogIn` FOREIGN KEY (`codigo_empleado`) REFERENCES `empleados` (`codigo_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

-- Filtros para la tabla `registro_empleados`

ALTER TABLE `registro_empleados`
  ADD CONSTRAINT `fk_codigo_empleado` FOREIGN KEY (`codigo_empleado`) REFERENCES `empleados` (`codigo_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;