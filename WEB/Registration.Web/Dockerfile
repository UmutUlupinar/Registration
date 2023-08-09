FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WEB/Registration.Web/Registration.Web.csproj", "WEB/Registration.Web/"]
RUN dotnet restore "WEB/Registration.Web/Registration.Web.csproj"
COPY . .
WORKDIR "/src/WEB/Registration.Web"
RUN dotnet build "Registration.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Registration.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Registration.Web.dll"]
