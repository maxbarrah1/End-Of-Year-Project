CREATE TABLE [dbo].[Hero]
(
	[HeroID] INT NOT NULL , 
    [HName] NCHAR(50) NULL, 
    [MinDice] INT NULL, 
    [MaxDice] INT NULL, 
    [Uses] INT NULL, 
    CONSTRAINT [PK_Hero] PRIMARY KEY ([HeroID])
)
