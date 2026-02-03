# 👁️ Sistema de Procesamiento Digital de Imágenes y Visión Artificial

Una suite de software de escritorio desarrollada en **C# .NET** capaz de aplicar algoritmos matemáticos de filtrado, transformación y análisis de color en imágenes estáticas y flujos de video en tiempo real. Integra módulos de **Visión por Computadora** para la detección y seguimiento de objetos.

## 📸 Galería del Proyecto

### 🎨 Módulo de Filtros de Imagen
*Aplicación de filtros de convolución y ajustes de color con visualización de Histograma.*
![Interfaz de Filtros de Imagen](./PIA_ProceImg/screenshots/FiltroImg.gif)
![Interfaz de Filtros de Imagen](./PIA_ProceImg/screenshots/FiltroImg2.gif)
### 🎥 Módulo de Procesamiento de Video
*Renderizado en tiempo real de efectos visuales y controles de reproducción.*
![Interfaz de Video](./PIA_ProceImg/screenshots/FiltroVideo.gif)
![Interfaz de Video](./PIA_ProceImg/screenshots/FiltroVideo2.gif)
## 🚀 Características Principales

### 🖼️ Procesamiento de Imágenes Estáticas
- **Lectura y Escritura:** Carga de imágenes locales y guardado de resultados procesados.
- **Manipulación de Píxeles:** Ajustes manuales mediante sliders para:
  - Brillo
  - Saturación
  - Contraste
- **Análisis de Datos:** Generación de **Histograma RGB** para visualizar la distribución de color.

### 📹 Procesamiento de Video en Tiempo Real
- Capacidad para cargar archivos de video.
- Controles de reproducción integrados (Play, Pause, Stop, Reset).

### 🤖 Visión Artificial (Computer Vision)
- **Detección de Objetos:** Implementación de algoritmos de **Color Tracking** utilizando la cámara web.
- Uso de librerías especializadas (**AForge.NET** y **Emgu CV**) para el manejo de dispositivos de captura y análisis de matrices.

## 🧮 Catálogo de Filtros Implementados

El sistema aplica transformaciones matriciales y lógicas para lograr los siguientes efectos:

| Categoría | Filtros Disponibles |
| :--- | :--- |
| **Color y Tono** | Negativo, Moradizar, Sepia, Escala de Grises, Colorizar, Gamma |
| **Distorsión** | Aberración Cromática, Ruido (Noise), Flip (Espejo) |
| **Artísticos** | Mosaico (Pixel Art), Mosaico Duplicado |
| **Convolución** | Filtro Kirsch (Detección de Bordes), Difuminado Gaussiano |

## 🛠️ Tecnologías y Arquitectura

- **Lenguaje:** C# (Windows Forms Application).
- **Framework:** .NET Framework.
- **Librerías de Visión:**
  - `AForge.Video.DirectShow` (Gestión de hardware de cámara).
  - `Emgu.CV` (Wrapper de OpenCV para .NET).
