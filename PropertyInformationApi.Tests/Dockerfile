FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./PropertyInformationApi.sln ./
COPY ./PropertyInformationApi/PropertyInformationApi.csproj ./PropertyInformationApi/
COPY ./PropertyInformationApi.Tests/PropertyInformationApi.Tests.csproj ./PropertyInformationApi.Tests/

RUN dotnet restore ./PropertyInformationApi/PropertyInformationApi.csproj
RUN dotnet restore ./PropertyInformationApi.Tests/PropertyInformationApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out PropertyInformationApi.Tests/PropertyInformationApi.Tests.csproj

CMD dotnet test
