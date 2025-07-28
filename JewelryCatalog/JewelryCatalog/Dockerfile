# Use ASP.NET Core runtime image (for .NET 8)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use SDK image to build the app (for .NET 8)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only the project file first
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the code
COPY . ./

# IMPORTANT: Clean before publish
RUN dotnet clean
RUN dotnet publish -c Release -o /app/publish --no-restore

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "JewelryCatalog.dll"]
