# Kubectl

Tutorial de utilização do Kubernetes em uma aplicação .NET Core com banco de dados Sql Server

## Iniciando

Crie a aplicação .NET Core normalmente com o banco de dados Sql Server

## Docker

Adicione  o Dockerfile

Compile e gere a imagem da aplicação utilizando uma tag de versionamento

```sh
docker build -t api-kubectl:v1 .
```

## Kubernetes

#### Criando Pod por cli

```sh
kubectl run api-kubectl --image api-kubectl:v1 --port 50867 --env="ASPNETCORE_ENVIRONMENT=Development"
```

#### Criando Pod por manifesto

Crie o manifesto .json ou .yaml

```sh
kubectl create -f api-kubectl-pod.json

kubectl expose pod api-kubectl --port 50687 --type LoadBalancer

kubectl get pods --output=wide
```