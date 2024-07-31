CREATE TABLE [dbo].[Coach] (
    [Coach_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Coach_name] NVARCHAR(50) NOT NULL, 
    [Coach_birth] DATETIME NOT NULL, 
    [Team_id] INT NOT NULL 
);

