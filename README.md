# GobData
Este proyecto es una aplicación de Windows Forms desarrollada en C# para una empresa financiera. La aplicación gestiona varios eventos, cada uno de los cuales contiene varias partidas en los que se registran datos esenciales. Además, se pueden adjuntar documentos a estas partidas para garantizar un seguimiento integral de los eventos y la gestión de la documentación. El sistema está diseñado para facilitar la entrada eficiente de datos y el almacenamiento seguro, lo que lo convierte en una herramienta valiosa para la gestión de eventos financieros.

## Vista de la aplicación 🖥️
Aquí puedes ver algunas capturas de pantalla de la aplicación en funcionamiento:

<img src="https://github.com/user-attachments/assets/73c6b19b-97ea-4248-b2da-cff0de0fc101" alt="GobData" width="425" />

## Requisitos Previos 🔍
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [Docker MySQL](https://hub.docker.com/_/mysql)
- [Visual Studio 2022](https://visualstudio.microsoft.com/es/downloads/)
- [SDK .NET 8](https://dotnet.microsoft.com/es-es/download/dotnet/8.0)

## Docker - MySql 🐳
### 1. Descargar MySQL para Docker

Descargar o asegurarse de tener actualizada la imagen de MySQL para Docker con el siguiente comando:

```bash
docker pull mysql
```
### 2. Ejecutar MySQL en un contenedor Docker
Asegúrate de tener Docker instalado y en funcionamiento.
```bash
docker --version
```

Luego, ejecuta el siguiente comando para iniciar un contenedor MySQL:
```bash
docker container run -d -p 3309:3306 --name sistemaGobData -e MYSQL_ROOT_PASSWORD=my-secret-pw -e MYSQL_DATABASE=dbGobData mysql
```
#### Explicación:

- `--name:` Nombre del contenedor.
- `MYSQL_ROOT_PASSWORD:` Establece la contraseña para el usuario root. (cambia "my-secret-pw" por tu contraseña).
- `MYSQL_DATABASE:` Crea una base de datos inicial.
- `-p 3309:3306:` Mapea el puerto 3309 del contenedor al puerto 3306 de tu máquina.
- `mysql:` Utiliza la última versión de la imagen de MySQL.

Más información sobre Docker y MySQL: [Docker MySQL](https://hub.docker.com/_/mysql)

## Tablas necesarias
> [!TIP]
> En la carpeta `assets/query/GobData_Create.sql` viene el archivo sql para crear las tablas necesarias.

## Código CSharp 🚀
> [!IMPORTANT]
> Debes creear el archivo `App.config` (sustituir "my-secret-pw" por tu contraseña). En ese archivo debes poner lo siguiente:

```bash
<configuration>
	<connectionStrings>
		<add name="DefaultConnection"
			connectionString="Server = localhost; Database = dbGobData; Port = 3309; User ID = root;Password = my-secret-pw;"
			providerName="MySql.Data.MySqlClient" />
	</connectionStrings>
</configuration>
```
### Pasos para restaurar Paquetes NuGet
1. **Abrir el Proyecto en Visual Studio**
    - Abre la solución (`.sln`) y el proyecto (`.csproj`) en Visual Studio.
2. **Restaurar Paquetes NuGet**
    - En Visual Studio, ve a `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution`.
    - Haz clic en `Restore` para restaurar todos los paquetes NuGet definidos en `packages.config`.

Esto asegurará que todas las dependencias de tu proyecto se descarguen y configuren correctamente.
