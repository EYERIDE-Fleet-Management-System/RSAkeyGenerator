#!/bin/sh

cd /app
dotnet /app/RSAkeyGenerator.dll key.xml
/bin/cat /app/key.xml
