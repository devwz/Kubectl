FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS image
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_ENVIRONMENT "Development"

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Kubectl/Kubectl.csproj", "Kubectl/"]
COPY ["Kubectl.Core/Kubectl.Core.csproj", "Kubectl.Core/"]
RUN dotnet restore "Kubectl/Kubectl.csproj"
COPY . .
WORKDIR "/src/Kubectl"
RUN dotnet build "Kubectl.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kubectl.csproj" -c Release -o /app/publish

FROM image AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kubectl.dll"]