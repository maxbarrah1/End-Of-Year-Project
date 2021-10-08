CREATE TABLE [dbo].[Villain]
(
	[VillainID] INT NOT NULL , 
    [VName] NCHAR(10) NULL, 
    [HitPoints] INT NULL, 
    CONSTRAINT [PK_Villain] PRIMARY KEY ([VillainID])
)
