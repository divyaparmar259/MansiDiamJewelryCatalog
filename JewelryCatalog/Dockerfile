# Use ASP.NET Core runtime image (for .NET 8)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use SDK image to build the app (for .NET 8)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only the project file first
COPY JewelryCatalog.csproj ./
RUN dotnet restore JewelryCatalog.csproj

# Copy the rest of the code
COPY . ./
RUN dotnet publish JewelryCatalog.csproj -c Release -o /app/publish

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "JewelryCatalog.dll"]
