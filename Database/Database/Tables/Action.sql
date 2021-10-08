CREATE TABLE [dbo].[Action]
(
	[AttackNumber] INT NOT NULL , 
    [DamageDelt] INT NULL, 
    [HeroID] INT NOT NULL, 
    [VillainID] INT NOT NULL, 
    [GameID] INT NOT NULL, 
    CONSTRAINT [PK_Action] PRIMARY KEY ([AttackNumber], [HeroID], [Villainid], [GameID]), 
    CONSTRAINT [FK_Action_ToHero] FOREIGN KEY ([HeroID]) REFERENCES [Hero]([HeroID]), 
    CONSTRAINT [FK_Action_ToVillain] FOREIGN KEY ([VillainID]) REFERENCES [Villain]([VillainID]), 
    CONSTRAINT [FK_Action_ToGame] FOREIGN KEY ([GameID]) REFERENCES [Game]([GameID]) 
)
