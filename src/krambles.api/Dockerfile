FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 5001
ENV ASPNETCORE_URLS=http://*:5000

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["krambles.api/krambles.api.csproj", "krambles.api/"]
RUN dotnet restore "krambles.api/krambles.api.csproj"
COPY . .
WORKDIR "/src/krambles.api"
RUN dotnet build "krambles.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "krambles.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "krambles.api.dll"]
