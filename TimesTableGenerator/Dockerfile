FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TimesTableGenerator/TimesTableGenerator.csproj", "TimesTableGenerator/"]
RUN dotnet restore "TimesTableGenerator/TimesTableGenerator.csproj"
COPY . .
WORKDIR "/src/TimesTableGenerator"
RUN dotnet build "TimesTableGenerator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TimesTableGenerator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TimesTableGenerator.dll"]
