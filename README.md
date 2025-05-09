# EjercicioPractico-Analytics360

Este ejercicio valida la apertura y cierre correctos de símbolos como lo son los paréntesis (), corchetes {} y corchetes cuadrados []

Se puede probar el servicio directamente desde la siguiente pagina: https://adrianacor.github.io/EjercicioPractico-Analytics360/
- Se subio el frontEnd a github pages que es un servicio para hacer deploy desde github
- El backend se subio a render.com
- Se esta usando base de datos en la nube desde clever-cloud.com
  - Se puede acceder a la base de datos desde MySql Workbench o DBeaver con las siguientes credenciales:
    - server Host: bwxhcjdk36v9wmbsnvpv-mysql.services.clever-cloud.com
    - databaseName: bwxhcjdk36v9wmbsnvpv
    - port: 3306
    - user: uerifbjajo0y2znn
    - pass: x7f0rvDOrHtnoSPVeNpf

Para ejecutar este proyecto de manera local: 
Estoy usando NodeJs en su versión 18.19.1
-	Para instalarlo hay que descargar la aplicación desde la página: https://nodejs.org/
Fue realizado con Angular en su versión 19.2.11
Para su ejecucion hay que descargar o clonar el código desde el repositorio
Para el frontEnd:
-	Este se encuentra en la carpeta ejercicio-Analytics360
-	Desde una consola de comandos ir a la carpeta en donde se tiene el ejercicio 
-	Instalar angular en la versión 19.2.11 (recomendado) con el siguiente comando: npm install -g @angular/cli
-	Una vez instalado ejecutar el comando desde la consola npm install --force, esto instalar todas las dependencias necesarias
-	Ya que se instalaron todas las dependencias hay que ejecutar el comando ng serve 
-	La terminal de comandos nos mostrará una URL en la que estará alojado localmente nuestro proyecto
  
Para el backEnd:
-	Este proyecto se encuentra en la carpeta EjercicioAnalytics360API
-	Abre el contenido de la carpeta en Visual Studio 2022 y ejecuta el proyecto
  
Para la base de datos:
-	Debes tener instalado xamp y MySQL Workbench
-	Desde el repositorio descarga el archivo ejercicioanalytics360_balanceo.sql
-	Abres MySQL Workbench y vas al menú Server y das click en Data Import
-	Se creara la base de datos y la tabla necesaria para guardar los datos del ejercicio
-	
NOTA: Tal vez tengas que cambiar el puerto de la URL de la API. 
Eso lo haces desde el frontEnd, dentro del proyecto te vas a src/app/service/api.service.ts y modificas la variable que dice urlAPI de acuerdo al puerto que te arrojo el Visual Studio
