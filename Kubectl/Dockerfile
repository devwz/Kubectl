FROM microsoft/dotnet:2.2-aspnetcore-runtime As base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk As build
WORKDIR /src
COPY Kubectl/Kubectl.csproj Kubectl/
COPY Kubectl.Core/Kubectl.Core.csproj Kubectl.Core/
RUN dotnet restore Kubectl/Kubectl.csproj
COPY . .
WORKDIR /src/Kubectl
RUN dotnet build Kubectl.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Kubectl.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Kubectl.dll"]