FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers

COPY *.sln .
COPY PhysicalTherapyProject.Application/*.csproj ./PhysicalTherapyProject.Application/
COPY PhysicalTherapyProject.Domain/*.csproj ./PhysicalTherapyProject.Domain/
COPY PhysicalTherapyProject.Persistance/*.csproj ./PhysicalTherapyProject.Persistance/
COPY PhysicalTherapyProjectV2/*.csproj ./PhysicalTherapyProjectV2/
COPY PhysicalTherapyProjectV2.Tests/*.csproj ./PhysicalTherapyProjectV2.Tests/
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 80/tcp
COPY ./entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh
ENTRYPOINT ["/entrypoint.sh"]
