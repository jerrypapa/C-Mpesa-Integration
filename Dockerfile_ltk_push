#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["LipaNaMpesaSTKApi/LipaNaMpesaSTKApi.csproj", "LipaNaMpesaSTKApi/"]
COPY ["MpesaApi/AuthMpesaApi.csproj", "MpesaApi/"]
RUN dotnet restore "LipaNaMpesaSTKApi/LipaNaMpesaSTKApi.csproj"
COPY . .
WORKDIR "/src/LipaNaMpesaSTKApi"
RUN dotnet build "LipaNaMpesaSTKApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LipaNaMpesaSTKApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LipaNaMpesaSTKApi.dll"]