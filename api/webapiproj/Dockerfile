FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
 WORKDIR /api/webapiproj
EXPOSE 80
EXPOSE 5115

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["webapiproj.csproj", ""]
RUN dotnet restore "./webapiproj.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "webapiproj.csproj" -c Release -o /app/build
 
FROM build AS publish
RUN dotnet publish "webapiproj.csproj" -c Release -o /app/publish
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webapiproj.dll"]