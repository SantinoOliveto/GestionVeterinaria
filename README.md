# GestionVeterinaria

GestionVeterinaria es una aplicación de Windows Forms diseñada para facilitar el registro y la edición de entidades asociadas con una veterinaria, tales como clientes, animales, especies y usuarios. La aplicación permite almacenar, organizar y gestionar eficientemente estos datos, optimizando la operación diaria en una clínica veterinaria.

## Características de la Aplicación

- **Login**: Creación y autenticación de usuarios.
- **Altas**: Registro de nuevas entidades en la base de datos (clientes, animales, especies y usuarios).
- **Reportes**: Generación de dos reportes distintos basados en los datos almacenados para facilitar la gestión y análisis de la información.

## Requisitos

- **Sistema Operativo**: Windows 7 o superior.
- **IDE**: Visual Studio 2022 (recomendado).
- **Framework**: .NET Framework 4.7.2 o superior.
- **Base de Datos**: SQL Server Management Studio.

## Instrucciones de Instalación

Instalación manual
1. **Descargar** el archivo comprimido con el proyecto desde el repositorio y descomprimirlo en el equipo.
2. **Crear la base de datos** en SQL Server Management Studio.
3. **Crear las tablas**: Ejecutar una nueva query en SQL Server Management Studio, copiando y pegando el contenido del archivo `GestionVeterinaria.sql` incluido en el proyecto.
4. **Ejecutar la aplicación**: Abrir el proyecto en el IDE seleccionado (Visual Studio 2022 recomendado), **Editar** la cadena de conexión para que coincida con tu configuración de SQL Server Management Studio y ejecutar la aplicación.


Instalación automatica
1. **Descargar** el archivo comprimido con el proyecto desde el repositorio y descomprimirlo en el equipo.
2. **Inicia SQL Server Management Studio** Inicia sesión en tu servidor SQL con las credenciales correspondientes.
3. **Accede al Menú de Restauración** En el Explorador de Objetos, haz clic derecho en la carpeta Bases de datos y selecciona la opción Restaurar base de datos.
4. **Configura la Restauración** En la ventana de Restaurar base de datos:
     Origen: Selecciona la opción Dispositivo.
     Haz clic en el botón "..." (junto a Dispositivo) para abrir el cuadro de diálogo Seleccionar origen de respaldo.
     En el cuadro emergente, selecciona Agregar y navega hasta la ubicación donde se encuentra `VeterinariaDB.bak`.
     Selecciona `VeterinariaDB.bak` y haz clic en Aceptar.
5. **Selecciona el Nombre de la Base de Datos** En el campo Destino de la base de datos, escribe el nombre que tendrá la base de datos restaurada.
6. **Inicia la Restauración** Haz clic en Aceptar para comenzar la restauración.
7. **Editar** la cadena de conexión para que coincida con tu configuración de SQL Server Management Studio.

## Uso

GestionVeterinaria permite gestionar la información de la clínica veterinaria mediante una interfaz sencilla y eficiente. Los usuarios pueden realizar el registro y edición de clientes, animales, especies y más, además de generar reportes para una mejor visualización de los datos.
