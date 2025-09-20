# MusicRiwi# Sistema RiwiMusic

El Sistema RiwiMusic es una aplicación de consola en C# diseñada para gestionar conciertos, clientes y la venta de entradas. Este proyecto, desarrollado como ejercicio de aprendizaje, simula un sistema completo de venta de tiquetes sin usar una base de datos. Toda la información se almacena en memoria utilizando **Listas** y **Diccionarios** para demostrar la aplicación de los conceptos de la Programación Orientada a Objetos (POO) y las consultas con LINQ.

## Características Principales

* **Gestión de Conciertos**: Permite registrar, ver, editar y eliminar conciertos con detalles como artista, ciudad y capacidad.
* **Gestión de Clientes**: Gestiona la información de los clientes, incluyendo registro, listado y modificación de datos.
* **Gestión de Tiquetes**: Simula el proceso de compra de entradas, registrando cada venta y actualizando la capacidad de los conciertos.
* **Historial de Compras**: Permite consultar todas las compras realizadas por un cliente específico.
* **Consultas Avanzadas**: Utiliza LINQ para realizar consultas complejas, como encontrar conciertos por ciudad o el concierto con más ventas.

## Tecnologías Utilizadas

* **C#**: El lenguaje de programación base del proyecto.
* **Programación Orientada a Objetos (POO)**: La arquitectura del sistema se basa en clases (`Concierto`, `Cliente`, `Tiquete`) que encapsulan datos y comportamientos, representando entidades del mundo real.
* **Colecciones**: Se usan **Listas** y **Diccionarios** para almacenar la información de manera eficiente en la memoria de la aplicación.
* **LINQ**: Se implementa para realizar consultas y reportes complejos de manera declarativa y sencilla.

## Principios de POO Aplicados

* **Clases y Objetos**: El sistema se construyó a partir de tres clases principales (`Concierto`, `Cliente`, `Tiquete`), que sirven como planos para crear los objetos que representan a las entidades.
* **Encapsulamiento**: Los atributos de las clases son privados y solo se modifican a través de métodos o propiedades, protegiendo así la integridad de los datos. Por ejemplo, los ingresos de un concierto se calculan a través de un método, en lugar de ser un valor que se pueda modificar directamente.
* **Abstracción**: El sistema oculta la complejidad interna, mostrando al usuario solo la información relevante a través de un menú sencillo y claro. El usuario no necesita saber cómo se gestionan las listas o cómo se ejecutan las consultas para interactuar con el programa.

## Estructura del Proyecto

El proyecto se compone de los siguientes archivos:

* **`Program.cs`**: Contiene la lógica principal del menú, la interacción con el usuario y la manipulación de los datos en las listas.
* **`Concierto.cs`**: Define la clase `Concierto` con sus atributos y métodos.
* **`Cliente.cs`**: Define la clase `Cliente` con sus atributos y métodos.
* **`Tiquete.cs`**: Define la clase `Tiquete` con sus atributos y métodos.

## Cómo Ejecutar el Proyecto

1.  Asegúrate de tener el SDK de .NET instalado en tu máquina.
2.  Clona o descarga este repositorio.
3.  Abre una terminal en la carpeta raíz del proyecto.
4.  Ejecuta el siguiente comando para compilar y correr la aplicación:
    ```bash
    dotnet run
    ```
5.  Sigue las instrucciones en la consola para navegar por el menú y probar las funcionalidades del sistema.
## 📄 Diagramas UML

### Diagrama de Clases

El diagrama de clases representa las entidades del sistema (Concierto, Cliente, Tiquete), sus atributos, métodos y las relaciones entre ellas.

<img width="424" height="414" alt="UML_Diagrama" src="https://github.com/user-attachments/assets/5bf69fe5-1c64-4c6b-ae0c-6f5a81f61966" />


---

### Diagrama de Casos de Uso

El diagrama de casos de uso muestra cómo el usuario interactúa con las diferentes funcionalidades del sistema RiwiMusic.

<img width="490" height="1433" alt="UML_Casos_De_Uso" src="https://github.com/user-attachments/assets/b96153fc-33c6-443b-922f-1af63eb4327e" />
