#!/bin/sh

cd /app
/usr/bin/dotnet RSAkeyGenerator.dll key.xml
/bin/cat key.xml
