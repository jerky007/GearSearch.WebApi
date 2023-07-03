#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GearSearch.WebApi/GearSearch.WebApi.csproj", "GearSearch.WebApi/"]
RUN dotnet restore "GearSearch.WebApi/GearSearch.WebApi.csproj"
COPY . .
WORKDIR "/src/GearSearch.WebApi"
RUN dotnet build "GearSearch.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GearSearch.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GearSearch.WebApi.dll"]