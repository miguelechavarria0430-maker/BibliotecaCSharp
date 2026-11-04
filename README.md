# Sistema de Gestión de Biblioteca en C#

## Descripción
Aplicación de consola desarrollada en C# para representar la navegación de un sistema de gestión de biblioteca.

## Objetivo
Implementar menús interactivos y funciones para representar las operaciones principales de una biblioteca.

## Tecnologías utilizadas
- C#
- .NET 10
- Visual Studio Code
- Git y GitHub

## Funcionalidades
- Menú principal.
- Gestión de libros.
- Gestión de usuarios.
- Gestión de préstamos.
- Búsquedas y reportes.
- Opciones para guardar y cargar datos.
- Confirmación de salida.

## Características técnicas
- Navegación mediante menús y submenús.
- Uso de funciones y métodos estáticos.
- Validación de opciones numéricas.
- Manejo de opciones inválidas.
- Confirmaciones para algunas operaciones.
- Opción para regresar a los menús anteriores.

**Nota:** Las funciones representan las operaciones mediante mensajes descriptivos. No implementan almacenamiento ni operaciones reales sobre datos.

## Requisitos
- Tener instalado el SDK de .NET 10.
- Tener Git instalado.

## Cómo ejecutar el proyecto

1. Abrir una terminal en la carpeta del proyecto.
2. Ejecutar:

```bash
dotnet restore
dotnet run
```

## Flujo de trabajo Git
El proyecto utiliza Git Flow con las ramas principales `main` y `develop`, y ramas de características:

- feature/project-bootstrap
- feature/main-menu-navigation
- feature/books-menu
- feature/users-menu
- feature/loans-menu
- feature/search-reports-menu
- feature/persistence-menu
- feature/exit-flow

Las características se desarrollan en ramas independientes y posteriormente se integran en `develop`. Finalmente, `develop` se integra en `main`.

## Autor
Miguel Angel Quiroga

**Programa:** Análisis y Desarrollo de Software (ADSO)  
**Institución:** SENA
