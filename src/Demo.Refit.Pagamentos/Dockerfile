#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Demo.Refit.Pagamentos/Demo.Refit.Pagamentos.csproj", "src/Demo.Refit.Pagamentos/"]
RUN dotnet restore "src/Demo.Refit.Pagamentos/Demo.Refit.Pagamentos.csproj"
COPY . .
WORKDIR "/src/src/Demo.Refit.Pagamentos"
RUN dotnet build "Demo.Refit.Pagamentos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Demo.Refit.Pagamentos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Demo.Refit.Pagamentos.dll"]