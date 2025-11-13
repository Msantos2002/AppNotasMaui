# 📝 AppNotasMaui

Aplicación básica desarrollada en **.NET MAUI** como parte de la actividad del curso  

La app permite escribir notas cortas y mostrarlas inmediatamente en pantalla sin utilizar bases de datos ni patrones avanzados. Está diseñada para cumplir con los requisitos de una aplicación sencilla, funcional y multiplataforma.


##  Funcionalidad Principal

La aplicación incluye:

-  Un **Entry** donde el usuario ingresa una nota.
-  Un **Button** llamado **"Agregar Nota"**.
-  Un contenedor donde se agregan dinámicamente todas las notas ingresadas.
-  Una **Image** decorativa (`dotnet_bot.png`).
-  Cada nota aparece como un nuevo **Label** debajo del botón.

###  Flujo de Uso

1. El usuario escribe una nota.
2. Presiona **Agregar Nota**.
3. La nota aparece al instante como un nuevo `Label` dentro del layout.
4. Si la entrada está vacía, aparece un mensaje con `DisplayAlert`.
5. El `ScrollView` permite ver todas las notas añadidas.

---

## 🧩Layout Utilizado

Se implementó un **VerticalStackLayout** dentro de un `ScrollView`, lo que permite:

- Organización vertical simple.
- Responsividad en Windows y Android.
- Agregación dinámica de elementos en tiempo de ejecución.

Estructura general del diseño:

1. Label de título  
2. Imagen decorativa  
3. Entry para ingresar la nota  
4. Botón para agregar  
5. Contenedor vertical para mostrar las notas  

---

## 📁 Estructura del Proyecto

