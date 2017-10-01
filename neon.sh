#!/bin/sh

DIR=`pwd`/`dirname $0`
dotnet build -f netstandard1.6 -c Release ${DIR}/Neo.Ecosystem/src/neo-devpack-dotnet/Neo.SmartContract.Framework/Neo.SmartContract.Framework.csproj
cp ${DIR}/Neo.Ecosystem/src/neo-devpack-dotnet/Neo.SmartContract.Framework/bin/Release/netstandard1.6/Neo.SmartContract.Framework.dll ./
dotnet run -p ${DIR}/Neo.Ecosystem/src/neo-compiler/neon/neon.csproj -c Release $1
