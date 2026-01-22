#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:10.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["sample/sample.csproj", "sample/"]
RUN dotnet restore "sample/sample.csproj"
COPY . .
WORKDIR "/src/sample"
RUN dotnet build "sample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "sample.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sample.dll"]
