## To create tools manifest file

```pwsh
dotnet new tool-manifest
```

## To install tools
```pwsh
dotnet tool restore
``

## To create database migration

```pwsh
dotnet ef migrations add InitialMigration --startup-project Questions.Api --project Questions.Infrastructure --context MigrationContext
```