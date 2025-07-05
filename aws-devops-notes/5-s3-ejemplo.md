# 🗃️ Amazon Simple Storage Service (S3)

Amazon Simple Storage Service (S3) es un servicio de almacenamiento de objetos altamente escalable, duradero y seguro ofrecido por **AWS**.  
Permite almacenar y recuperar cualquier cantidad de datos desde cualquier lugar en la web.

---

##  Características clave

-  **Almacenamiento basado en objetos** (no en bloques o archivos)  
-  **Alta durabilidad**: 99.999999999%  
-  **Alta disponibilidad**: 99.99%  
-  **Escalabilidad ilimitada**  
-  **Seguridad integrada**: Encriptación y control de acceso

---

##  Usos comunes en aplicaciones en la nube

-  **Almacenamiento de archivos estáticos**: imágenes, CSS, JS para sitios web  
-  **Backup y recuperación de desastres**  
-  **Almacenamiento de datos para análisis** (Data Lakes)  
-  **Hosting de sitios web estáticos**  
-  **Almacenamiento de logs y archivos de registro**  
-  **Distribución de contenido** mediante integración con CloudFront  
-  **Almacenamiento de archivos** para aplicaciones móviles y web

---

##  Buenas prácticas con S3

-  Usar **nombres de buckets únicos globalmente**  
-  Implementar **políticas de acceso adecuadas**  
-  Considerar el uso de **versionado** para protección contra eliminaciones accidentales  
-  Usar **clases de almacenamiento adecuadas**:  
  - Standard  
  - Intelligent-Tiering  
  - Glacier  
  - Entre otras  
-  Habilitar **encriptación para datos sensibles**  
-  Usar **transferencia acelerada** para distribuciones globales

---

## Ejemplo en python

```python

import boto3
from botocore.exceptions import NoCredentialsError

# Configurar el cliente de S3
s3 = boto3.client('s3',
                  aws_access_key_id='TU_ACCESS_KEY',
                  aws_secret_access_key='TU_SECRET_KEY',
                  region_name='us-east-1')

bucket_name = 'mi-bucket-s3-ejemplo'

# Subir un archivo a S3
def upload_to_s3(local_file, s3_file):
    try:
        s3.upload_file(local_file, bucket_name, s3_file)
        print(f"Archivo {local_file} subido como {s3_file}")
        return True
    except FileNotFoundError:
        print("El archivo no fue encontrado")
        return False
    except NoCredentialsError:
        print("Credenciales no disponibles")
        return False

# Descargar un archivo de S3
def download_from_s3(s3_file, local_file):
    try:
        s3.download_file(bucket_name, s3_file, local_file)
        print(f"Archivo {s3_file} descargado como {local_file}")
        return True
    except FileNotFoundError:
        print("El archivo no fue encontrado en S3")
        return False
    except NoCredentialsError:
        print("Credenciales no disponibles")
        return False

# Ejemplo de uso
upload_to_s3('archivo_local.txt', 'archivo_en_s3.txt')
download_from_s3('archivo_en_s3.txt', 'archivo_descargado.txt')
```