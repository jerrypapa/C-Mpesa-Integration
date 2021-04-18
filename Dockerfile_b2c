#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["B2CMpesaApi/B2CMpesaApi.csproj", "B2CMpesaApi/"]
COPY ["MpesaApi/AuthMpesaApi.csproj", "MpesaApi/"]
RUN dotnet restore "B2CMpesaApi/B2CMpesaApi.csproj"
COPY . .
WORKDIR "/src/B2CMpesaApi"
RUN dotnet build "B2CMpesaApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "B2CMpesaApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "B2CMpesaApi.dll"]