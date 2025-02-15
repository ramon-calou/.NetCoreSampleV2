# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything and build the app
COPY . .
RUN dotnet publish -c Release -o out

# Use the official .NET runtime image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy built app from the previous step
COPY --from=build /app/out .

# Set environment variables
ENV ASPNETCORE_URLS=http://+:5000

# Run the application
CMD ["dotnet", "DotnetCore.Sample.Api.dll"]