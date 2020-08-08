FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/AmazingInsta.Microservices.IamMicroservice.Admin/AmazingInsta.Microservices.IamMicroservice.Admin.csproj", "src/AmazingInsta.Microservices.IamMicroservice.Admin/"]
COPY ["src/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.Shared/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.Shared.csproj", "src/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.Shared/"]
COPY ["src/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.SqlServer/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.SqlServer.csproj", "src/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.SqlServer/"]
COPY ["src/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.PostgreSQL/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.PostgreSQL.csproj", "src/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.MySql/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.MySql.csproj", "src/AmazingInsta.Microservices.IamMicroservice.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/AmazingInsta.Microservices.IamMicroservice.Admin/AmazingInsta.Microservices.IamMicroservice.Admin.csproj"
COPY . .
WORKDIR "/src/src/AmazingInsta.Microservices.IamMicroservice.Admin"
RUN dotnet build "AmazingInsta.Microservices.IamMicroservice.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AmazingInsta.Microservices.IamMicroservice.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "AmazingInsta.Microservices.IamMicroservice.Admin.dll"]