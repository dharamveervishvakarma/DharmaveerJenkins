dotnet new sln --name poc
dotnet new classlib --name product
dotnet new xunit --name product.Test
dotnet new webapi --name productApi
dotnet sln add product/product.csproj
dotnet sln add product.Test/product.Test.csproj
dotnet sln add productApi/productApi.csproj
dotnet add product/product.csproj reference product.Test/product.Test.csproj
dotnet add product.Test/product.Test.csproj reference productApi/productApi.csproj