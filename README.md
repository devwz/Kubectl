# Kubectl

Aplicação do Kubernetes em um projeto .Net Core

## Iniciando

Crie a aplicação .Net Core

## Docker

Adicione o Dockerfile

Compile e gere a imagem da aplicação com uma tag

docker build -t api-kubectl:v1 .
docker run -d -p 51124:80 --name api-kubectl api-kubectl:v1

## Kubernetes

#### Linha de comando

v 1.16
Criando pod por linha de comando
kubectl run --generator=run-pod/v1 api-kubectl --image api-kubectl:v1 --env "ASPNETCORE_ENVIRONMENT=Development"

v 1.16
Criado deployment por linha de comando
kubectl create deployment api-kubectl --image api-kubectl:v1

v 1.16
Para replicar deployment
kubectl scale deployment api-kubectl --replicas 10

v 1.16
Para expor aplicação
kubectl expose deployment api-kubectl --type NodePort  --port 80

#### Manifesto

v 1.16
Publicação por manifesto
kubectl apply -f api-kubectl.yaml