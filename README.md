# Proyecto: Métodos de Ordenación en C#

## 📌 Introducción

Este proyecto implementa múltiples algoritmos clásicos de ordenación en el lenguaje C#. Su propósito principal es ilustrar y comparar distintas técnicas de ordenamiento aplicadas sobre un arreglo de números enteros. El usuario puede seleccionar interactivamente el algoritmo deseado, visualizar paso a paso los cambios en el arreglo y analizar cómo se comporta cada método en tiempo real.

Los algoritmos incluidos son:

- Burbuja (menor, mayor y con señal)
- Sacudida (Shaker Sort)
- Inserción e Inserción Binaria
- Selección
- Shell
- Quicksort (recursivo)
- Heapsort

---

## 🧠 Explicación del Código

### Estructura de Archivos

- **`Ordenación.cs`**: Contiene la clase `Ordenación`, que implementa todos los métodos de ordenación y una función auxiliar para imprimir el arreglo.
- **`Program.cs`**: Contiene la clase principal `Program`, donde se inicializa el menú interactivo que permite al usuario seleccionar el método de ordenación y visualizar los resultados.

### Detalles de Implementación

Cada algoritmo está implementado como un método público dentro de la clase `Ordenación`. Se imprime el arreglo en cada paso relevante para observar la evolución del orden. El programa reinicia el arreglo original antes de cada ordenamiento para que las pruebas sean independientes entre sí.

Por ejemplo:
```csharp
int[] array = new int[] { 1, 4, 5, 7, 3, 8, 2, 9, 10, 21, 6, 11, 51, 49, 80, 100, 30, 64, 63, 2149, 552, 1864 };
````

---

## 📊 Análisis de Rendimiento

| Algoritmo              | Complejidad Promedio | Complejidad Peor Caso | Tipo       |
| ---------------------- | -------------------- | --------------------- | ---------- |
| Burbuja (y variantes)  | O(n²)                | O(n²)                 | Estable    |
| Sacudida (Shaker Sort) | O(n²)                | O(n²)                 | Estable    |
| Inserción              | O(n²)                | O(n²)                 | Estable    |
| Inserción Binaria      | O(n²)                | O(n²)                 | Estable    |
| Selección              | O(n²)                | O(n²)                 | No estable |
| Shell                  | O(n log² n)          | O(n²)                 | No estable |
| Quicksort              | O(n log n)           | O(n²)                 | No estable |
| Heapsort               | O(n log n)           | O(n log n)            | No estable |

> **Nota:** En los algoritmos como Quicksort y Heapsort se observa un mejor rendimiento en comparación con los algoritmos cuadráticos, especialmente cuando el tamaño del arreglo crece.

---

## ✅ Conclusiones

* Los algoritmos **Burbuja**, **Inserción**, y **Selección** son didácticos y útiles para arreglos pequeños, pero ineficientes para grandes volúmenes de datos.
* **Shell**, **Quicksort** y **Heapsort** son más eficientes y escalables. En particular, **Quicksort** es muy veloz en promedio, pero puede degradarse si no se elige bien el pivote.
* **Heapsort**, aunque siempre es O(n log n), puede ser más costoso en práctica debido a su acceso no contiguo en memoria.
* **Shell Sort** ofrece un balance entre simplicidad y rendimiento aceptable sin ser recursivo.

### Recomendaciones:

* Para **arreglos grandes y sin restricciones de orden estable**, usar **Quicksort**.
* Para **orden estable o inserciones frecuentes**, usar **Inserción**.
* Para **aprendizaje y visualización paso a paso**, los métodos implementados en este proyecto son muy útiles para entender cómo funcionan los algoritmos internamente.

---

## 🧪 Ejemplo de prueba

Arreglo original:

```
1, 4, 5, 7, 3, 8, 2, 9, 10, 21, 6, 11, 51, 49, 80, 100, 30, 64, 63, 2149, 552, 1864
```

### Resultados esperados para cada algoritmo (todos ordenan de menor a mayor):

```
1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 21, 30, 49, 51, 63, 64, 80, 100, 552, 1864, 2149
```

Todos los métodos, al finalizar, deberían entregar este resultado si fueron implementados correctamente.

---

## 🧑‍💻 Autor

Desarrollado como ejercicio académico para ilustrar y comparar algoritmos de ordenación clásicos usando C#.

```
Valerie Watts Feria
```
