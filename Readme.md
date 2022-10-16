# Readme File

## BUILD

> - `dotnet build`

> - `dotnet run --project WebStore.Web/WebStore.Web.csproj` -> front

### **EFC RELATIONS**

> - Its Important in `1:M` to add `ICollection<Example> {get; set;}`

```
// Migrations in DAL
dotnet ef  --project /Users/akjj004/Proj/Zaawansowane_Programowanie_Internetowe_N/WebStore.DAL/ --startup-project /Users/akjj004/Proj/Zaawansowane_Programowanie_Internetowe_N/WebStore.Web/ migrations add Empty
// UPDATE
dotnet ef database update --project ./WebStore.DAL/  --startup-project ./WebStore.Web/
// REMOVE
dotnet ef  --project /Users/akjj004/Proj/Zaawansowane_Programowanie_Internetowe_N/WebStore.DAL/ --startup-project /Users/akjj004/Proj/Zaawansowane_Programowanie_Internetowe_N/WebStore.Web/ migrations remove
```

## IMPRT

WHEN UPDATE DATABASE TARGET MIGRATION ADD LAST ONE NEVER DELETE USED DATABASE ON UPDATE
