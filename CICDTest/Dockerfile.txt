FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Copy published application
COPY bin/Release/net8.0/publish/ .

ENTRYPOINT ["dotnet", "CICDTest.dll"]