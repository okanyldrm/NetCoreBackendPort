FROM mcr.microsoft.com/dotnet/sdk:3.1 as build
WORKDIR /app
EXPOSE 80

COPY ["./BlogApp/BlogApp.WebUI/*.csproj","./BlogApp/BlogApp.WebUI"]
COPY *.sln .
RUN dotnet restore
COPY . .
RUN build 
RUN dotnet publish ./*.csproj -c Release -o /publish/

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build /publish .
ENV ASPNETCORE_URLS="http://*:5000"
ENTRYPOINT [ "dotnet","BlogApp.WebUI" ]