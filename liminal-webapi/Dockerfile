#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /app
#COPY ["liminal-webapi/liminal-webapi.csproj", "liminal-webapi/"]
#RUN dotnet restore "liminal-webapi/liminal-webapi.csproj"
COPY . .
WORKDIR "/app/liminal-webapi"
RUN dotnet build "liminal-webapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "liminal-webapi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "liminal-webapi.dll"]