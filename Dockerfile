# Use official .NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy the application files
COPY . .

# Expose the port (Heroku sets PORT dynamically)
ENV ASPNETCORE_URLS=http://+:5000
CMD ["dotnet", "DotnetCore.Sample.Api.dll"]