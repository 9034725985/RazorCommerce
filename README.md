RazorCommerce

## User Secrets

Add user secrets to your project

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your-local-server-name-here; Database=new-database-name-here; User ID=user-name-here; Password=password-here;"
  }
}
```

```pwsh
Each package is licensed to you by its owner. NuGet is not responsible for, nor does it grant any licenses to, third-party packages. Some packages may include dependencies which are governed by additional licenses. Follow the package source (feed) URL to determine any dependencies.

Package Manager Console Host Version 6.0.1.1

Type 'get-help NuGet' to see all available NuGet commands.

PM> Update-Database
Build started...
Build succeeded.
Microsoft.EntityFrameworkCore.Model.Validation[30000]
      No store type was specified for the decimal property 'Price' on entity type 'Movie'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType', specify precision and scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.1 initialized 'ApplicationDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.1' with options: None
Microsoft.EntityFrameworkCore.Model.Validation[30000]
      No store type was specified for the decimal property 'Price' on entity type 'Movie'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType', specify precision and scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
No store type was specified for the decimal property 'Price' on entity type 'Movie'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType', specify precision and scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (469ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      CREATE DATABASE [RazorCommerce001];
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (175ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      IF SERVERPROPERTY('EngineEdition') <> 5
      BEGIN
          ALTER DATABASE [RazorCommerce001] SET READ_COMMITTED_SNAPSHOT ON;
      END;
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (14ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (11ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [__EFMigrationsHistory] (
          [MigrationId] nvarchar(150) NOT NULL,
          [ProductVersion] nvarchar(32) NOT NULL,
          CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (28ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (9ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [MigrationId], [ProductVersion]
      FROM [__EFMigrationsHistory]
      ORDER BY [MigrationId];
Microsoft.EntityFrameworkCore.Migrations[20402]
      Applying migration '00000000000000_CreateIdentitySchema'.
Applying migration '00000000000000_CreateIdentitySchema'.
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (11ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [AspNetRoles] (
          [Id] nvarchar(450) NOT NULL,
          [Name] nvarchar(256) NULL,
          [NormalizedName] nvarchar(256) NULL,
          [ConcurrencyStamp] nvarchar(max) NULL,
          CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (8ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [AspNetUsers] (
          [Id] nvarchar(450) NOT NULL,
          [UserName] nvarchar(256) NULL,
          [NormalizedUserName] nvarchar(256) NULL,
          [Email] nvarchar(256) NULL,
          [NormalizedEmail] nvarchar(256) NULL,
          [EmailConfirmed] bit NOT NULL,
          [PasswordHash] nvarchar(max) NULL,
          [SecurityStamp] nvarchar(max) NULL,
          [ConcurrencyStamp] nvarchar(max) NULL,
          [PhoneNumber] nvarchar(max) NULL,
          [PhoneNumberConfirmed] bit NOT NULL,
          [TwoFactorEnabled] bit NOT NULL,
          [LockoutEnd] datetimeoffset NULL,
          [LockoutEnabled] bit NOT NULL,
          [AccessFailedCount] int NOT NULL,
          CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (11ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [AspNetRoleClaims] (
          [Id] int NOT NULL IDENTITY,
          [RoleId] nvarchar(450) NOT NULL,
          [ClaimType] nvarchar(max) NULL,
          [ClaimValue] nvarchar(max) NULL,
          CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
          CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (9ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [AspNetUserClaims] (
          [Id] int NOT NULL IDENTITY,
          [UserId] nvarchar(450) NOT NULL,
          [ClaimType] nvarchar(max) NULL,
          [ClaimValue] nvarchar(max) NULL,
          CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
          CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (12ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [AspNetUserLogins] (
          [LoginProvider] nvarchar(128) NOT NULL,
          [ProviderKey] nvarchar(128) NOT NULL,
          [ProviderDisplayName] nvarchar(max) NULL,
          [UserId] nvarchar(450) NOT NULL,
          CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
          CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (9ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [AspNetUserRoles] (
          [UserId] nvarchar(450) NOT NULL,
          [RoleId] nvarchar(450) NOT NULL,
          CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
          CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
          CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (21ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [AspNetUserTokens] (
          [UserId] nvarchar(450) NOT NULL,
          [LoginProvider] nvarchar(128) NOT NULL,
          [Name] nvarchar(128) NOT NULL,
          [Value] nvarchar(max) NULL,
          CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
          CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
      VALUES (N'00000000000000_CreateIdentitySchema', N'6.0.1');
Applying migration '20211217220717_CreateMoviePageFromTutorial'.
Microsoft.EntityFrameworkCore.Migrations[20402]
      Applying migration '20211217220717_CreateMoviePageFromTutorial'.
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [Movie] (
          [ID] int NOT NULL IDENTITY,
          [Title] nvarchar(max) NOT NULL,
          [ReleaseDate] datetime2 NOT NULL,
          [Genre] nvarchar(max) NOT NULL,
          [Price] decimal(18,2) NOT NULL,
          CONSTRAINT [PK_Movie] PRIMARY KEY ([ID])
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
      VALUES (N'20211217220717_CreateMoviePageFromTutorial', N'6.0.1');
Done.
PM> Add-Migration Rating
Build started...
Build succeeded.
Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.1 initialized 'ApplicationDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.1' with options: None
To undo this action, use Remove-Migration.
PM> Update-Database
Build started...
Build succeeded.
Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.1 initialized 'ApplicationDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.1' with options: None
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (32ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (27ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [MigrationId], [ProductVersion]
      FROM [__EFMigrationsHistory]
      ORDER BY [MigrationId];
Microsoft.EntityFrameworkCore.Migrations[20402]
      Applying migration '20211221001253_Rating'.
Applying migration '20211221001253_Rating'.
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (23ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      ALTER TABLE [Movie] ADD [Rating] nvarchar(max) NOT NULL DEFAULT N'';
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
      VALUES (N'20211221001253_Rating', N'6.0.1');
Done.
PM> Add-Migration AddValidation
Build started...
Build failed.
PM> Add-Migration AddValidation
Build started...
Build succeeded.
Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.1 initialized 'ApplicationDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.1' with options: None
An operation was scaffolded that may result in the loss of data. Please review the migration for accuracy.
To undo this action, use Remove-Migration.
PM> Update-Database
Build started...
Build succeeded.
Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.1 initialized 'ApplicationDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.1' with options: None
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (36ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (27ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [MigrationId], [ProductVersion]
      FROM [__EFMigrationsHistory]
      ORDER BY [MigrationId];
Microsoft.EntityFrameworkCore.Migrations[20402]
      Applying migration '20211221001700_AddValidation'.
Applying migration '20211221001700_AddValidation'.
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (40ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      DECLARE @var0 sysname;
      SELECT @var0 = [d].[name]
      FROM [sys].[default_constraints] [d]
      INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
      WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movie]') AND [c].[name] = N'Title');
      IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Movie] DROP CONSTRAINT [' + @var0 + '];');
      ALTER TABLE [Movie] ALTER COLUMN [Title] nvarchar(60) NOT NULL;
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (29ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      DECLARE @var1 sysname;
      SELECT @var1 = [d].[name]
      FROM [sys].[default_constraints] [d]
      INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
      WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movie]') AND [c].[name] = N'Rating');
      IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Movie] DROP CONSTRAINT [' + @var1 + '];');
      ALTER TABLE [Movie] ALTER COLUMN [Rating] nvarchar(5) NOT NULL;
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (21ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      DECLARE @var2 sysname;
      SELECT @var2 = [d].[name]
      FROM [sys].[default_constraints] [d]
      INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
      WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movie]') AND [c].[name] = N'Genre');
      IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Movie] DROP CONSTRAINT [' + @var2 + '];');
      ALTER TABLE [Movie] ALTER COLUMN [Genre] nvarchar(30) NOT NULL;
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
      VALUES (N'20211221001700_AddValidation', N'6.0.1');
Done.
PM> 
```