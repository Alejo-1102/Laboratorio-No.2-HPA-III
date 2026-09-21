# Laboratorio #2: Clases en C# - Herramientas de la Programación Aplicada III
> **Institución:** Universidad Tecnológica de Panamá (UTP) - FISC  
> **Carrera / Grupo:** Ingeniería en Sistemas Computacionales (III Año) - Grupo 1IL133  
> **Instructor(a):** Ing. Irina Fong  
> **Fecha Límite de Entrega:** 31 de agosto de 2026
> **Autor:** Alejandro Garcia / 8-10322-677

## Descripción General
Repositorio oficial que contiene el desarrollo de las actividades correspondientes al Laboratorio #2: Clases en C#, centrado en el Módulo II (Elementos Básicos del Lenguaje). El objetivo principal es la aplicación de la Programación Orientada a Objetos (POO), modelado UML, estructuración de clases, métodos con parámetros, variables de instancia, propiedades con descriptores get/set y control de errores en C#.

---

## Contenido del Laboratorio y Estructura de Problemas

### Problema 1: Estructura de un Programa por Consola y Clases Básicas
* **Objetivo:** Comprender la estructura de una aplicación de consola en C#, el uso del método Main como punto de entrada y la creación formal de clases (LibroCalificacion) utilizando la convención de nomenclatura estándar PascalCase.
* **Implementación:** Declaración de métodos públicos (public void MostrarMensaje()), instanciación de objetos mediante el operador new e invocación de métodos a través del operador punto (.).
*  **Capturas de Ejecucion:**

### Problema 2: Modularidad y Métodos con Parámetros
* **Objetivo:** Profundizar en el paso de argumentos y parámetros para personalizar el comportamiento dinámico de los objetos.
* **Implementación:** Recepción de datos por consola (Console.ReadLine()), paso de variables como argumentos a métodos (ej. MostrarMensaje(string nombreCurso)) y uso de marcadores de posición por índice ({0}) combinados con saltos de línea (\n) para formatear la salida en pantalla.
*  **Capturas de Ejecucion:**

---

### Problema 3: Variables de Instancia, Propiedades y Encapsulamiento (Último desarrollado)
* **Objetivo:** Aplicar el ocultamiento de información protegiendo los datos mediante el modificador de acceso private y gestionándolos de forma segura a través de propiedades públicas con descriptores de acceso get y set.
* **Implementación:** 
  * Declaración de campos privados (variables de instancia) fuera de los métodos.
  * Uso de descriptores get para retornar valores y set para asignar y validar datos de manera encapsulada.
  * Inicialización de constructores con parámetros para asignar valores iniciales al instanciar múltiples objetos.
 * **Capturas de Ejecucion:**

---

## Tecnologías y Normas de Desarrollo
* **Lenguaje:** C#
* **Entorno de Desarrollo:** Visual Studio (.NET / Aplicación de consola)
* **Estándares de Estilo:** 
  * PascalCase (UpperCamelCase) para nombres de clases y propiedades (ej. LibroCalificaciones, NombreCurso).
  * camelCase para variables locales y parámetros.

## Instrucciones de Ejecución
1. Clona este repositorio en tu equipo local.
2. Abre la solución o los proyectos individuales utilizando Visual Studio.
3. Compila y ejecuta el problema específico que desees evaluar (asegúrate de verificar las configuraciones de compilación para .NET).

## Estructura de Directorios
Esquema en árbol que detalla la organización de las carpetas y archivos críticos del proyecto para facilitar su revisión:

Laboratorio-No.2-HPA-III/
```text
LibroCalificaciones_1/
  ├── LibroCalificaciones_1/
  └── LibroCalificaciones_1.slnx
LibroCalificaciones_2/
  ├── LibroCalificaciones_2/
  └── LibroCalificaciones_2.slnx
LibroCalificaciones_3/
  ├── LibroCalificaciones_3/
  └── LibroCalificaciones_3.slnx
└── README.md
