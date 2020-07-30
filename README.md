# Kubectl

Aplicação do Kubernetes em um projeto .Net Core

## Iniciando

Crie a aplicação .Net Core

## Docker

Adicione o Dockerfile

Compile e gere a imagem da aplicação com uma tag

```sh
docker build -t api-kubectl:v1 .
docker run -d -p 51124:80 --name api-kubectl api-kubectl:v1
```