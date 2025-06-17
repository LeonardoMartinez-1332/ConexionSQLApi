# 📡 ConexionSQLApi

API REST desarrollada en **ASP.NET Core** que permite verificar la conexión a una base de datos **SQL Server**, pensada para ser consumida desde una app móvil hecha en **Xamarin Forms**.

---

## 🚀 Funcionalidad

- ✔️ Endpoint `/api/conexion/test` que realiza una prueba de conexión
- <p align="center">
  <img src="https://github.com/LeonardoMartinez-1332/ConexionSQLApi/blob/master/conexion-exitosa.png?raw=true" alt="Conexión Exitosa" width="500"/>
</p>
- 🛡️ Manejo de errores con mensajes claros
- 📱 Compatible con consumo desde frontend móvil (Xamarin, Android, etc.)

---

## 🛠️ Tecnologías utilizadas

- ASP.NET Core 8.0
- SQL Server Express (LocalDB)
- Visual Studio 2022
- C#

---

## ⚙️ Estructura del proyecto

📁 ConexionSQLApi
├── Controllers
│ └── ConexionController.cs
├── Properties
├── appsettings.json
├── ConexionSQLApi.csproj
└── ConexionSQLApi.sln

---

## 🔍 Uso del endpoint

1. Corre el proyecto desde Visual Studio  
2. Abre tu navegador y accede a:

https://localhost:{PUERTO}/api/conexion/test


3. Posibles respuestas:

- ✅ `Conexión exitosa`
- ❌ `Error al conectar: [mensaje]`

---

## 🤝 Integración con Xamarin

Este backend está diseñado para ser consumido desde una aplicación móvil hecha con Xamarin Forms, mediante peticiones HTTP a los endpoints definidos.

---

## 🧠 Autor

**Leonardo Martínez**  
Alias: *Malware*  
Universidad Politécnica de García  
`Sistema conectado, mente imparable.` ⚔️

---

## 📌 Licencia

Este proyecto es de uso académico y libre para fines de aprendizaje.
