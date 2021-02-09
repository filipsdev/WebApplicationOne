CREATE TABLE [dbo].[Items](
   [ID]			INT	IDENTITY (1,1) NOT NULL
  ,[Name]        VARCHAR(30) NOT NULL
  ,[Type]        VARCHAR(30) NULL
  ,[Size]        INTEGER  NULL
  ,[Price]       DECIMAL(10,2) NULL
  ,[Description] VARCHAR(200) NULL
  ,PRIMARY KEY CLUSTERED ([ID] ASC)
);
INSERT INTO dbo.Items(Name,Type,Size,Price,Description) VALUES ('Levi�s Jeans','Men',40,'25.00','The best jeans.');
INSERT INTO dbo.Items(Name,Type,Size,Price,Description) VALUES ('Dress','Woman',25,'34.99','Amazing dress.');
INSERT INTO dbo.Items(Name,Type,Size,Price,Description) VALUES ('Tie',NULL,12,'5.00',NULL);
