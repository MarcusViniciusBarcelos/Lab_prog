FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["exercicios/exercicios.csproj", "exercicios/"]
RUN dotnet restore "exercicios/exercicios.csproj"
COPY . .
WORKDIR "/src/exercicios"
RUN dotnet build "exercicios.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "exercicios.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "exercicios.dll"]
