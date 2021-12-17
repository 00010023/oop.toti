FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AcademicPerformance/AcademicPerformance.csproj", "AcademicPerformance/"]
RUN dotnet restore "AcademicPerformance/AcademicPerformance.csproj"
COPY . .
WORKDIR "/src/AcademicPerformance"
RUN dotnet build "AcademicPerformance.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AcademicPerformance.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AcademicPerformance.dll"]
