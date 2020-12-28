FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#NEW
FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build-env
WORKDIR /app
# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

FROM base AS final
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "liminal-webapi.dll"]