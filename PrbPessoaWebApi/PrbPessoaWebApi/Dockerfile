FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PrbPessoaWebApi/PrbPessoaWebApi.csproj", "PrbPessoaWebApi/"]
COPY ["PrbPessoaWebApi.Infrastruture.CrossCutting.IOC/PrbPessoaWebApi.Infrastruture.CrossCutting.IOC.csproj", "PrbPessoaWebApi.Infrastruture.CrossCutting.IOC/"]
COPY ["PrbPessoaWebApi.Repository/PrbPessoaWebApi.Repository.csproj", "PrbPessoaWebApi.Repository/"]
COPY ["PrbPessoaWebApi.Domain.Core/PrbPessoaWebApi.Domain.Core.csproj", "PrbPessoaWebApi.Domain.Core/"]
COPY ["PrbPessoaWebApi.Domain/PrbPessoaWebApi.Domain.csproj", "PrbPessoaWebApi.Domain/"]
COPY ["PrbPessoaWebApi.Infrastructure.Data/PrbPessoaWebApi.Infrastructure.Data.csproj", "PrbPessoaWebApi.Infrastructure.Data/"]
COPY ["PrbPessoaWebApi.App/PrbPessoaWebApi.App.csproj", "PrbPessoaWebApi.App/"]
COPY ["PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter/PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.csproj", "PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter/"]
COPY ["PrbPessoaWebApi.App.ViewModel/PrbPessoaWebApi.App.ViewModel.csproj", "PrbPessoaWebApi.App.ViewModel/"]
COPY ["PrbPessoaWebApi.Domain.Services/PrbPessoaWebApi.Domain.Services.csproj", "PrbPessoaWebApi.Domain.Services/"]
RUN dotnet restore "PrbPessoaWebApi/PrbPessoaWebApi.csproj"
COPY . .
WORKDIR "/src/PrbPessoaWebApi"
RUN dotnet build "PrbPessoaWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PrbPessoaWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PrbPessoaWebApi.dll"]