﻿FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base

WORKDIR /app
EXPOSE 80

COPY ./src/teng.kun.Web/bin/Release/netcoreapp2.2/publish /app
ENTRYPOINT ["dotnet", "teng.kun.Web.dll"]