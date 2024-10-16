# AppCrudUsuarios.Api
Este proyecto es una API RESTful para la gestión de usuarios que permite realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) y gestionar la autenticación mediante JWT. Está diseñado con una arquitectura en capas y es fácil de extender y mantener.
## Caracteristicas

- Gestión de Usuarios: Permite crear, leer, actualizar y eliminar usuarios.
- Control de Acceso: Implementación de niveles de acceso a través de autenticación JWT.
- Documentación API: Generación automática de documentación con Swagger.
- Inyección de Dependencias: Uso de inyección de dependencias para una mejor organización del código.
- Base de Datos: Conexión a SQL Server para almacenamiento persistente de datos.
- Gestión de Sesiones: Autenticación de usuarios mediante tokens JWT.

## Tecnologias utilizadas
- C#: Lenguaje de programación principal para el desarrollo de la API.
- ASP.NET Core: Framework utilizado para crear la API RESTful.
- SQL Server: Base de datos para almacenar la información de usuarios.
- Entity Framework Core: ORM utilizado para interactuar con la base de datos.
- JWT (JSON Web Tokens): Para la autenticación y autorización de usuarios.
- Swagger: Herramienta para documentar y probar la API de manera interactiva.
- Inyección de Dependencias: Para gestionar la creación de instancias de servicios y repositorios.
- LINQ: Para realizar consultas a la base de datos de forma sencilla y efectiva.

## Estructura del Proyecto
- AppCrudUsuarios.Api: Contiene los controladores de la API y la configuración de la aplicación.
- AppCrudUsuarios.Business: Contiene la lógica de negocio y los servicios de la aplicación.
- AppCrudUsuarios.Data: Contiene el contexto de la base de datos y las entidades.
- AppCrudUsuarios.Infrastructure: Contiene la configuración de la base de datos y otras configuraciones de infraestructura.
##Instalación y Ejecución
1.Clona el repositorio:
```
git clone <url-del-repositorio>
```
2.Abre el proyecto en Visual Studio o tu IDE preferido.
3.Configura la cadena de conexión en appsettings.json:
```
"ConnectionStrings": {
  "DefaultConnection": "Server=TU_SERVIDOR;Database=DBCrudUsuarios;User Id=sa;Password=TU_CONTRASEÑA;TrustServerCertificate=true;"
}
```
4.Restaura las dependencias y ejecuta el proyecto.
