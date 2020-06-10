@echo off
docker run -it -p 1337:1337 -v C:\Users\rico\dotnet\css-website-strapi\strapi:/srv/app strapi/strapi:3.0.1