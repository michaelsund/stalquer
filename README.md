
# Stalquer

### net core

Single api endpoint
https://localhost:5001/badplace

SignalR Hub
https://localhost:5001/badplacehub

### svelte

https://localhost:5001/

### developing

Generate development certs if needed

https://docs.microsoft.com/en-us/dotnet/core/additional-tools/self-signed-certificates-guide

```dotnet dev-certs https```

```dotnet dev-certs https --trust```

Install dependencies

``` dotnet restore ```

``` npm install ```

Both svelte and .net dev with hot reloading for both via rollup

```npm run dev```

To debug .net and hit breakpoints, debug via vscode or visual-studio.

### docker

docker build -t stalquer .

docker run -it --rm -p 5001:5001 --name Stalquer -v /home/myuser/Certs/stalquer/:/https/ -e ASPNETCORE_HTTPS_PORT=5001 -e ASPNETCORE_Kestrel__Certificates__Default__Password="certificatepassword" -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/yourcert.pfx stalquer-server

