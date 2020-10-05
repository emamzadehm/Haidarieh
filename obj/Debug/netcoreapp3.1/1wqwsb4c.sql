IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Tbl_Ceremonies] (
    [Id] bigint NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [CeremonyDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Tbl_Ceremonies] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200901062459_initDB', N'3.1.7');

GO

ALTER TABLE [Tbl_Ceremonies] ADD [Status] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200901075928_addStatus', N'3.1.7');

GO

