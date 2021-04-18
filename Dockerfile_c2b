#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["C2BMpesaAPI/C2BMpesaAPI.csproj", "C2BMpesaAPI/"]
COPY ["MpesaApi/AuthMpesaApi.csproj", "MpesaApi/"]
RUN dotnet restore "C2BMpesaAPI/C2BMpesaAPI.csproj"
COPY . .
WORKDIR "/src/C2BMpesaAPI"
RUN dotnet build "C2BMpesaAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "C2BMpesaAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "C2BMpesaAPI.dll"]