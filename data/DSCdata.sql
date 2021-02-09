CREATE TABLE Items(
   Name        VARCHAR(30) NOT NULL PRIMARY KEY
  ,Type        VARCHAR(30)
  ,Size        INTEGER  NOT NULL
  ,Price       VARCHAR(30) NOT NULL
  ,Description VARCHAR(200)
);
INSERT INTO mytable(Name,Type,Size,Price,Description) VALUES ('Levi�s Jeans','Men',40,'�25.00','The best jeans.');
INSERT INTO mytable(Name,Type,Size,Price,Description) VALUES ('Dress','Woman',25,'�34.99','Amazing dress.');
INSERT INTO mytable(Name,Type,Size,Price,Description) VALUES ('Tie',NULL,12,'�5.00',NULL);
