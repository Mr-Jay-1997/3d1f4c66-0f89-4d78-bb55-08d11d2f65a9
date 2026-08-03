# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["src/LIS.Api/LIS.Api.csproj", "src/LIS.Api/"]
COPY ["src/LIS.Application/LIS.Application.csproj", "src/LIS.Application/"]
COPY ["src/LIS.Domain/LIS.Domain.csproj", "src/LIS.Domain/"]

RUN dotnet restore "src/LIS.Api/LIS.Api.csproj"

COPY . .

WORKDIR "/src/src/LIS.Api"

RUN dotnet publish "LIS.Api.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false


# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "LIS.Api.dll"]