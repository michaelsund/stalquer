FROM node:14 AS frontend
WORKDIR /build
COPY package.json .             
COPY package-lock.json .
RUN npm install
COPY rollup.config.js .
COPY Client ./Client
RUN npm run build

FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS backend
WORKDIR /build
COPY stalquer-server.csproj .
RUN dotnet restore stalquer-server.csproj
COPY . .
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine
WORKDIR /app
COPY --from=frontend /build/wwwroot ./wwwroot
COPY --from=backend /publish .
ENV ASPNETCORE_URLS=https://+:5001
ENTRYPOINT /app/stalquer-server
