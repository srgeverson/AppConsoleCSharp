# Projetos AppConsoleCSharp
Este é um projeto console em C#.

## 📌 Instruções utilizadas durante a criação

```bash

# Criando app
$ dotnet new console --framework net7.0

# Executar
$ dotnet run

# Compilando 
$ dotnet build --configuration Release --runtime ubuntu.18.04-x64

# Publicando
$ dotnet publish --configuration Release --version-suffix 1 --output bin/output/

# Publicando no docker
$ docker build -t app-console -f Dockerfile .

# Criando Container
$ docker create --name app-console-container app-console

# Executando container
$ docker start app-console-container

# Baixar as imagems e executar os containers em modo não iterativo(deve ser utilizado na primeira execução)
$ docker-compose up -d

# Apagar as imagems e parar os containers (deve ser utilizado quando precisar recriar as imagens)
$ docker-compose down

```

## 📌 Dependências utilizadas nesse projeto

```bash

# Biblioteca de requisições HTTP
$ dotnet add package RestSharp

```
		
```bash
# Nuget.Org
$ https://api.nuget.org/v3/index.json

# Windows Temp
$ C:\Windows\Temp

# SDKs
$ C:\Program Files (x86)\Microsoft SDKs\NuGetPackages\

# Packages
$ C:\Users\geverson\.nuget\packages
```

## 👨‍💻 Equipe de Desenvolvimento

* **Geverson Souza** - [Geverson Souza](https://www.linkedin.com/in/srgeverson/)

## ✒️ Autor

* **Geverson Souza** - [Geverson Souza](https://www.linkedin.com/in/srgeverson/)