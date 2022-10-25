# Commands required during the lab

## Entity Framework Core

### solution/project compilation
```console
dotnet build
```

### solution/project clean
```console
dotnet clean
```

### solution/project restore
```console
dotnet restore
```

### update Entity Framework Tools to given version
```console
dotnet tool update --global dotnet-ef --version 6.0.9
```

### create migration with name Initial
```console
dotnet ef migrations add Initial --project SchoolRegister.DAL/SchoolRegister.DAL.csproj --startup-project SchoolRegister.Web/SchoolRegister.Web.csproj
```

### remove the newest migration
```console
dotnet ef migrations remove --project SchoolRegister.DAL/SchoolRegister.DAL.csproj --startup-project SchoolRegister.Web/SchoolRegister.Web.csproj
```

### update database to newest migration
```console
dotnet ef database update --project SchoolRegister.DAL/SchoolRegister.DAL.csproj --startup-project SchoolRegister.Web/SchoolRegister.Web.csproj
```

### drop database
```console
dotnet ef database drop --project SchoolRegister.DAL/SchoolRegister.DAL.csproj --startup-project SchoolRegister.Web/SchoolRegister.Web.csproj
```
