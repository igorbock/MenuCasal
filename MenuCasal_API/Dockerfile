FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY . .
RUN dotnet restore ./MenuCasal_API.csproj
RUN dotnet publish ./MenuCasal_API.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "MenuCasal_API.dll" ]