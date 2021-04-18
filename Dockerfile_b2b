#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["B2BMpesaApi/B2BMpesaApi.csproj", "B2BMpesaApi/"]
COPY ["MpesaApi/AuthMpesaApi.csproj", "MpesaApi/"]
RUN dotnet restore "B2BMpesaApi/B2BMpesaApi.csproj"
COPY . .
WORKDIR "/src/B2BMpesaApi"
RUN dotnet build "B2BMpesaApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "B2BMpesaApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "B2BMpesaApi.dll"]