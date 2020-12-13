FROM mcr.microsoft.com/dotnet/sdk:3.1

ENV PATH="$HOME/.dotnet/tools:${PATH}"
WORKDIR /code/app

ENTRYPOINT dotnet run --project WebApiCourse.API/WebApiCourse.API.csproj