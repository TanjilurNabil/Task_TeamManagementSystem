FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
EXPOSE 80

COPY Task_TeamManage.sln Task_TeamManage.sln
COPY Task_TeamManage.Api/Task_TeamManage.Api.csproj Task_TeamManage.Api/Task_TeamManage.Api.csproj
COPY Task_TeamManage.Application/Task_TeamManage.Application.csproj Task_TeamManage.Application/Task_TeamManage.Application.csproj
COPY Task_TeamManage.Domain/Task_TeamManage.Domain.csproj Task_TeamManage.Domain/Task_TeamManage.Domain.csproj
COPY Task_TeamManage.Infrastructure/Task_TeamManage.Infrastructure.csproj Task_TeamManage.Infrastructure/Task_TeamManage.Infrastructure.csproj
RUN dotnet restore Task_TeamManage.sln

COPY Task_TeamManage.Api/. Task_TeamManage.Api/
COPY Task_TeamManage.Application/. Task_TeamManage.Application/
COPY Task_TeamManage.Domain/. Task_TeamManage.Domain/
COPY Task_TeamManage.Infrastructure/. Task_TeamManage.Infrastructure/

WORKDIR /app/Task_TeamManage.Api
RUN dotnet publish -c Release -o /app/out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Development
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Task_TeamManage.Api.dll"]