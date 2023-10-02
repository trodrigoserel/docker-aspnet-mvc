FROM mcr.microsoft.com/dotnet/aspnet:7.0
LABEL version="1.0.2" description="Aplicação ASP .NET Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","mvc1.dll"]