## Medico

### Database setup

Install local MySQL8.0 server and make sure it is running. Create "medico" database with
```sh
CREATE SCHEMA medico DEFAULT CHARACTER SET utf8 DEFAULT COLLATE utf8_unicode_ci;
```
To create a migration, open terminal in **Medico.Library** project and execute command
```sh
dotnet ef migrations add <migration_name> --startup-project ../HciMedico.App/HciMedico.App.csproj
```

To apply pending migration(s), repeat the previous step but with the command
```sh
dotnet ef database update --startup-project ../HciMedico.App/HciMedico.App.csproj
```