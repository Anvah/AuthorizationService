#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 7202
ENV ASPNETCORE_URLS http://+:7202

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY AuthorizationService.csproj AuthorizationService.csproj
RUN dotnet restore AuthorizationService.csproj
COPY . .
WORKDIR /src
RUN dotnet build AuthorizationService.csproj -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish AuthorizationService.csproj -c Debug -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthorizationService.dll"]