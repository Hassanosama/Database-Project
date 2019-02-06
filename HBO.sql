-------------Database creation-------------
--create database HBO
Create database HBO
GO

use HBO
------------Table Creation-----------------
create table Users
(
	ID int IDENTITY(1,1) PRIMARY KEY,   -- Auto Increment for each new user
	Users_name varchar(100) unique not null , 
	Password int not null,
	privilege int not null
); 

create table Item   -- Auto Increment for each new Item
(
ID int IDENTITY(1,1) PRIMARY KEY,
Name varchar(50) not null,
Price int not null,
Year int,
Rate float ,
#Purchase int default 0 ,
Type int not null,
Uploader_ID int not null,
Poster image 
 
)

create table Singers  -- Auto Increment for each new Singer
(
ID int IDENTITY(1,1) PRIMARY KEY,
Name varchar(50) not null,
Age int 

);

create table Concerts  -- Auto Increment for each new concert
(
ID  int IDENTITY(1,1) PRIMARY KEY,
Ticket_price int not null ,
Available_Seats int,
Time_Date varchar(50),
Location Varchar(100),
Phone int

);

create table Songs
(
ID int,
primary key (ID),
ID_Singer int not null,
Album varchar(50),
Duration int not null,

Foreign key (ID_Singer) references Singers on delete cascade on update cascade,
Foreign key (ID) references Item on delete cascade on update cascade,
)

create table Actors -- Auto increment for each new Actor
(
ID int IDENTITY(1,1) PRIMARY KEY,
Name varchar(50) not null,
Age int 

);

create table Act 
(
ID_Actor int ,
ID_Item int,
type int,
primary key(ID_Actor ,ID_Item),
foreign key (ID_Actor) references  Actors on delete cascade on update cascade,
foreign key (ID_Item) references  Item on delete cascade on update cascade
);

create table Purchase
(
ID_Users int not null,
ID_Item int not null,
Type int not null,
primary key(ID_Users,ID_Item),
Foreign key (ID_Users) references Users on delete cascade on update cascade,
Foreign key (ID_Item) references Item on delete cascade on update cascade,
)

create table Games
(
ID int not null,
Studio varchar(50),
primary key (ID),
Foreign key (ID) references Item on delete cascade on update cascade,
)

create table Director -- Auto increment for each new Director
(
ID int IDENTITY(1,1) primary key,
Name varchar(50) not null,
Age int

)

create table Movies
(
ID int primary key,
Duration int not null,
ID_Director int ,

Foreign key (ID_Director) references Director on delete set Null on update cascade,
Foreign key (ID) references Item on delete cascade on update cascade
)

create table TV_Series
(
ID int,
primary key (ID),
#Seasons int,
ID_Director int,

Foreign key (ID_Director) references Director on delete set Null on update cascade,
Foreign key (ID) references Item on delete cascade on update cascade
)

create table Book_Concert
(
ID_Users int,
ID_Concert int,
Movie_Name varchar(50),
primary key (Movie_Name,ID_Users),

Foreign key (ID_Users) references Users on delete cascade on update cascade,
Foreign key (ID_Concert) references Concerts on delete cascade on update cascade
)

create table Cinemas
(
ID int IDENTITY(1,1) primary key,
Location varchar(50) not null,
Name varchar(50) not null,
Phone int
)

create table Show
(
ID_Cinema int,
ID_Movie int,
primary key (ID_Movie,ID_Cinema),
time Time,
Price int,
#Available_Seats int,

Foreign key (ID_Cinema) references Cinemas on delete cascade on update cascade,
Foreign key (ID_Movie) references Movies on delete cascade on update cascade
)

create table Book_Cinema
(
ID_Users int not null,
ID_Cinema int not null,	
primary key(ID_Users,ID_Cinema),
Foreign key (ID_Users) references Users on delete cascade on update cascade,
Foreign key (ID_Cinema) references Cinemas on delete cascade on update cascade,
)

create table Search
(
	ID_Users int ,
	ID_Item int ,
	Priority int not null,
	
	primary key(ID_Users,ID_Item),
	foreign key (ID_Users) references Users on delete cascade on update cascade,
	foreign key (ID_Item) references Item on delete cascade on update cascade
);

create table Favorites
(
	ID_Users int ,
	ID_Item int ,
	Type int ,
	primary key (ID_Users,ID_Item),
	foreign key(ID_Users) references Users on delete cascade on update cascade,
	foreign key (ID_Item) references Item on delete cascade on update cascade
);

create table History
(
	ID_Users int ,
	ID_Item int ,
	Type int ,
	Date_Time datetime,
	primary key(ID_Users,ID_Item),
	foreign key (ID_Users) references Users on delete cascade on update cascade,
	foreign key (ID_Item) references Item on delete cascade on update cascade
);

create table perform
(
	ID_Singer int,
	ID_Concert int,
	primary key(ID_Singer,ID_Concert),
	foreign key (ID_Singer) references Singers on delete cascade on update cascade,
	foreign key (ID_Concert) references Concerts on delete cascade on update cascade
);

create table Genre
(
	ID_Item int ,
	Genre varchar(20) ,
	Type int,
	primary key (ID_Item,Genre),
	foreign key (ID_Item) references Item on delete cascade on update cascade  
); 

create table Reports
( ID_Users int ,
  ID_Item int,
  Comment varchar (100),
  
  primary key(ID_Users,ID_Item),
  foreign key (ID_Users) references Users on delete cascade on update cascade,
  foreign key (ID_Item) references Item on delete cascade on update cascade
);
------------------------------Insertions-----------------------------------
--Users
insert into Users (Users_name,Password,privilege)
values ('Hussein',123465789,1);
insert into Users (Users_name,Password,privilege)
values ('Hassan',123654789,1);
insert into Users (Users_name,Password,privilege)
values ('Talaat',987654321,1);
insert into Users (Users_name,Password,privilege)
values ('Ahmed',123987456,1);

-------------------------------------------
--Directors
insert into Director (Name,Age)
values ('Peter Jackson',56);
insert into Director (Name,Age)
values ('Christopher Nolan',47);
insert into Director (Name,Age)
values ('Denis Villeneuve',50);
insert into Director (Name,Age)
values ('Mel Gibson',50);
insert into Director (Name,Age)
values ('James Cameron',63);
insert into Director (Name,Age)
values ('Marc Webb',43);
insert into Director (Name,Age)
values ('Martin Scorsese',75);
insert into Director (Name,Age)
values ('Zack Snyder',51);
insert into Director (Name,Age)
values ('Gary Halvorson',54);
insert into Director (Name,Age)
values ('Stephen Surjik',57);
insert into Director (Name,Age)
values ('Michael Hirst',65);
insert into Director (Name,Age)
values ('Brian Kirk',49);
insert into Director (Name,Age)
values ('Vince Gilligan',50);
insert into Director (Name,Age)
values ('Jack Bender',68);
insert into Director (Name,Age)
values ('Greg Yaitanes',47);

---------------------------------------------------
--Items ==>ID: 1- Movie , 2- TV-Series , 3- Game , 4- Song
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Lord of the Rings',1,8.8,2001,70,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('King Kong',1,7.2,2005,20,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Hobbit',1,7.9,2012,60,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Dark Knight',1,9,2008,100,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Dunkirk',1,8.3,2017,70,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Inception',1,8.8,2010,90,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Interstellar',1,8.6,2014,80,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Prestige',1,8.5,2007,85,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Arrival',1,8,2016,95,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Enemy',1,6.9,2013,50,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Prisoners',1,8.1,2013,65,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Braveheart',1,8.4,1995,95,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Hacksaw Ridge',1,8.2,2016,90,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Avatar',1,7.8,2009,85,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Titanic',1,7.8,1997,95,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Terminator',1,8,1991,60,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Amazing Spider-Man',1,7,2012,70,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Gifted',1,7.6,2017,90,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Silence',1,7.2,2016,80,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Wolf of Wall Street',1,8.2,2014,105,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Shutter Island',1,8.1,2010,90,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Departed',1,8.5,2006,80,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Batman Vs Superman: Dawn of Justice',1,6.6,2016,50,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('300',1,7.7,2007,55,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Man of Steel',1,7.1,2013,70,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Friends',2,8.9,1994,200,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Punisher',2,9,2017,100,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Vikings',2,8.6,2013,205,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Game of Thrones',2,9.5,2011,300,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Breaking Bad',2,9.5,2008,290,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Lost',2,8.4,2004,180,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('House',2,8.8,2004,200,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Assassins Creed Origins',3,9,2017,200,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Prince of Persia',3,7,2008,150,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Call of Duty World War 2',3,9.1,2017,200,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('BattleField 1',3,8,2016,160,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Dishonored',3,8.5,2016,120,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Middle Earth - Shadow of War',3,9,2017,180,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Far Cry',3,8.2,2016,110,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('FIFA',3,9.5,2017,210,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Metal Gear Solid V',3,8.9,2015,140,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Pro Evolution Soccer 16',3,8,2016,110,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Outlast',3,8.3,2013,100,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Cuphead',3,8.7,2017,130,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Limbo',3,7,2010,130,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Inside',3,8,2016,130,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('The Amazing Spider-Man - The Game',3,7,2012,100,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('King Kong - The Game',3,8.2,2005,50,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Avatar: The Game',3,7.5,2009,100,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Batman Arkham Knight',3,9,2015,150,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Lord of The Rings: The Game',3,6,2002,80,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Hello',4,8,2015,10,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('I Miss You',4,8,2015,10,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Rolling in the Deep',4,9,2011,9,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Someone like You',4,7.9,2011,9,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Lose Your Self',4,8.5,2002,9,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Not Afraid',4,9,2010,9,1);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Born to Die',4,8,2012,9,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('I See Fire',4,8.2,2013,10,3);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Hands of Gold',4,7,2017,6,4);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('Maak Alby',4,7,2016,5,2);
insert into Item (Name,Type,Rate,Year,Price,Uploader_ID)
values('We Meen Ekhtar',4,6,2014,5,2);
----------------------------------------------------
-- Games
insert into Games
values (33,'Ubisoft');
insert into Games
values (34,'Ubisoft');
insert into Games
values (35,'Activision');
insert into Games
values (36,'EA DICE');
insert into Games
values (37,'Arkane');
insert into Games
values (38,'Monolith');
insert into Games
values (39,'Ubisoft');
insert into Games
values (40,'Electronic Arts');
insert into Games
values (41,'KONAMI');
insert into Games
values (42,'KONAMI');
insert into Games
values (43,'Red Barrels');
insert into Games
values (44,'MDHR');
insert into Games
values (45,'Playdead');
insert into Games
values (46,'Playdead');
insert into Games
values (47,'Gameloft');
insert into Games
values (48,'Ubisoft');
insert into Games
values (49,'Ubisoft');
insert into Games
values (50,'Rocksteady');
insert into Games
values (51,'Electronic Arts');
---------------------------------------------------
--Movies ==> Duration in Mins
insert into Movies  
values (1,178,1);  
insert into Movies  
values (2,120,1);  
insert into Movies(ID,Duration,ID_Director)  
values (3,169,1);  
insert into Movies  
values (4,150,2);   
insert into Movies(ID,Duration,ID_Director)  
values (5,120,2);
insert into Movies(ID,Duration,ID_Director)  
values (6,148,2);
insert into Movies(ID,Duration,ID_Director)  
values (7,160,2);
insert into Movies(ID,Duration,ID_Director)  
values (8,130,2);
insert into Movies(ID,Duration,ID_Director)  
values (9,120,3);
insert into Movies(ID,Duration,ID_Director)  
values (10,100,3);
insert into Movies(ID,Duration,ID_Director)  
values (11,150,3);
insert into Movies(ID,Duration,ID_Director)  
values (12,180,4);
insert into Movies(ID,Duration,ID_Director)  
values (13,140,4);
insert into Movies(ID,Duration,ID_Director)  
values (14,160,5);
insert into Movies(ID,Duration,ID_Director) 
values (15,190,5);
insert into Movies(ID,Duration,ID_Director)  
values (16,100,5);
insert into Movies  
values (17,150,6);
insert into Movies(ID,Duration,ID_Director)  
values (18,105,6);
insert into Movies(ID,Duration,ID_Director)  
values (19,161,7);
insert into Movies(ID,Duration,ID_Director)  
values (20,155,7);
insert into Movies(ID,Duration,ID_Director)  
values (21,144,7);
insert into Movies(ID,Duration,ID_Director)  
values (22,140,7);
insert into Movies(ID,Duration,ID_Director)  
values (23,188,8);
insert into Movies(ID,Duration,ID_Director)  
values (24,120,8);
insert into Movies(ID,Duration,ID_Director)  
values (25,145,8);


-----------------------------------------------------
-- TV-Series 
insert into TV_Series
values (26,10,9);
insert into TV_Series
values (27,1,10);
insert into TV_Series
values (28,6,11);
insert into TV_Series
values (29,8,12);
insert into TV_Series
values (30,5,13);
insert into TV_Series
values (31,6,14);
insert into TV_Series
values (32,8,15);

----------------------------------------------------
-- Actors
insert into Actors (Name,Age)
values ('Ian McKellen', 78);
insert into Actors (Name,Age)
values ('Sean Bean', 58);
insert into Actors (Name,Age)
values ('Orlando Bloom', 40);
insert into Actors (Name,Age)
values ('Naomi Watts', 49);
insert into Actors (Name,Age)
values ('Adrien Brody', 44);
insert into Actors (Name,Age)
values ('Christian Bale', 43);
insert into Actors (Name,Age)
values ('Heath Ledger', 30);
insert into Actors (Name,Age)
values ('Morgan Freeman', 80);
insert into Actors (Name,Age)
values ('Cillian Murphy', 41);
insert into Actors (Name,Age)
values ('Tom Hardy', 40);
insert into Actors (Name,Age)
values ('Leonardo DiCaprio', 43);
insert into Actors (Name,Age)
values ('Matthew McConaughey', 48);
insert into Actors (Name,Age)
values ('Anne Hathaway', 35);
insert into Actors (Name,Age)
values ('Michael Caine', 35);
insert into Actors (Name,Age)
values ('Hugh Jackman', 49);
insert into Actors (Name,Age)
values ('Scarlett Johansson', 33);
insert into Actors (Name,Age)
values ('Amy Adams', 43);
insert into Actors (Name,Age)
values ('Jeremy Renner', 46);
insert into Actors (Name,Age)
values ('Jake Gyllenhaal', 36);
insert into Actors (Name,Age)
values ('Mélanie Laurent', 34);
insert into Actors (Name,Age)
values ('Mel Gibson', 61);
insert into Actors (Name,Age)
values ('Andrew Garfield', 34);
insert into Actors (Name,Age)
values ('Sam Worthington', 41);
insert into Actors (Name,Age)
values ('Michelle Rodriguez', 39);
insert into Actors (Name,Age)
values ('Kate Winslet', 42);
insert into Actors (Name,Age)
values ('Arnold Schwarzenegger', 70);
insert into Actors (Name,Age)
values ('Robert Patrick', 59);
insert into Actors (Name,Age)
values ('Emma Stone', 29);
insert into Actors (Name,Age)
values ('Chris Evans', 36);
insert into Actors (Name,Age)
values ('Jenny Slate', 35);
insert into Actors (Name,Age)
values ('Liam Neeson', 65);
insert into Actors (Name,Age)
values ('Margot Robbie', 27);
insert into Actors (Name,Age)
values ('Mark Ruffalo', 50);
insert into Actors (Name,Age)
values ('Matt Damon', 47);
insert into Actors (Name,Age)
values ('Ben Affleck', 45);
insert into Actors (Name,Age)
values ('Gal Gadot', 32);
insert into Actors (Name,Age)
values ('Henry Cavill', 34);
insert into Actors (Name,Age)
values ('Gerard Butler', 48);
insert into Actors (Name,Age)
values ('Lena Headey', 44);
insert into Actors (Name,Age)
values ('Jennifer Aniston', 48);
insert into Actors (Name,Age)
values ('Matt LeBlanc', 50);
insert into Actors (Name,Age)
values ('Lisa Kudrow', 54);
insert into Actors (Name,Age)
values ('David Schwimmer', 51);
insert into Actors (Name,Age)
values ('Jon Bernthal', 41);
insert into Actors (Name,Age)
values ('Ben Barnes', 36);
insert into Actors (Name,Age)
values ('Travis Fimmel', 38);
insert into Actors (Name,Age)
values ('Katheryn Winnick', 39);
insert into Actors (Name,Age)
values ('Alexander Ludwig', 25);
insert into Actors (Name,Age)
values ('Clive Standen', 36);
insert into Actors (Name,Age)
values ('Kit Harington', 30);
insert into Actors (Name,Age)
values ('Peter Dinklage', 48);
insert into Actors (Name,Age)
values ('Bryan Cranston', 61);
insert into Actors (Name,Age)
values ('Aaron Paul', 38);
insert into Actors (Name,Age)
values ('Anna Gunn', 49);
insert into Actors (Name,Age)
values ('Evangeline Lilly', 38);
insert into Actors (Name,Age)
values ('Josh Holloway', 48);
insert into Actors (Name,Age)
values ('Matthew Fox', 51);
insert into Actors (Name,Age)
values ('Hugh Laurie', 58);
insert into Actors (Name,Age)
values ('Lisa Edelstein', 51);
insert into Actors (Name,Age)
values ('Jennifer Morrison', 38);


----------------------------------------------------
----------------------------------------------------
--Act
insert into Act
values (1,1,1);
insert into Act
values (1,3,1);
insert into Act
values (2,1,1);
insert into Act
values (2,29,2);
insert into Act
values (3,1,1);
insert into Act
values (3,3,1);
insert into Act
values (4,2,1);
insert into Act
values (5,2,1);
insert into Act
values (6,4,1);
insert into Act
values (7,4,1);
insert into Act
values (8,4,1);
insert into Act
values (9,4,1);
insert into Act
values (9,5,1);
insert into Act
values (10,5,1);
insert into Act
values (10,6,1);
insert into Act
values (11,6,1);
insert into Act
values (11,15,1);
insert into Act
values (6,8,1);
insert into Act
values (12,7,1);
insert into Act
values (13,7,1);
insert into Act
values (14,7,1);
insert into Act
values (14,4,1);
insert into Act
values (14,8,1);
insert into Act
values (15,8,1);
insert into Act
values (16,8,1);
insert into Act
values (17,9,1);
insert into Act
values (18,9,1);
insert into Act
values (19,10,1);
insert into Act
values (20,10,1);
insert into Act
values (15,11,1);
insert into Act
values (19,11,1);
insert into Act
values (21,12,1);
insert into Act
values (22,13,1);
insert into Act
values (23,13,1);
insert into Act
values (23,14,1);
insert into Act
values (24,14,1);
insert into Act
values (25,15,1);
insert into Act
values (26,16,1);
insert into Act
values (27,16,1);
insert into Act
values (22,17,1);
insert into Act
values (28,17,1);
insert into Act
values (29,18,1);
insert into Act
values (30,18,1);
insert into Act
values (31,19,1);
insert into Act
values (22,19,1);
insert into Act
values (32,20,1);
insert into Act
values (11,20,1);
insert into Act
values (11,21,1);
insert into Act
values (33,21,1);
insert into Act
values (11,22,1);
insert into Act
values (34,22,1);
insert into Act
values (35,23,1);
insert into Act
values (36,23,1);
insert into Act
values (37,23,1);
insert into Act
values (38,24,1);
insert into Act
values (39,24,1);
insert into Act
values (37,25,1);
insert into Act
values (17,25,1);
insert into Act
values (40,26,2);
insert into Act
values (41,26,2);
insert into Act
values (42,26,2);
insert into Act
values (43,26,2);
insert into Act
values (44,27,2);
insert into Act
values (45,27,2);
insert into Act
values (46,28,2);
insert into Act
values (47,28,2);
insert into Act
values (48,28,2);
insert into Act
values (49,28,2);
insert into Act
values (50,29,2);
insert into Act
values (51,29,2);
insert into Act
values (39,29,2);
insert into Act
values (52,30,2);
insert into Act
values (53,30,2);
insert into Act
values (54,30,2);
insert into Act
values (55,3,1);
insert into Act
values (55,31,2);
insert into Act
values (56,31,2);
insert into Act
values (57,31,2);
insert into Act
values (58,32,2);
insert into Act
values (59,32,2);
insert into Act
values (60,32,2);


-------------------------------------
--Cinemas
insert into Cinemas  
values ('Manial','Galaxy',99955);
insert into Cinemas  
values ('Giza','IMAX',11122);
insert into Cinemas 
values ('Cairo','Renaissance',333);
insert into Cinemas 
values ('Cairo','Zawya',945);
insert into Cinemas 
values ('Cairo','Metro',185);

-------------------------------------
--Shows 
insert into Show
values (1,3,CAST('06:30:00' AS Time(7)),60,40);
insert into Show
values (1,4,CAST('09:30:00' AS Time(7)),65,50);
insert into Show
values (1,5,CAST('03:00:00' AS Time(7)),40,30);
insert into Show
values (2,6,CAST('03:00:00' AS Time(7)),50,45);
insert into Show
values (2,7,CAST('06:00:00' AS Time(7)),65,60);
insert into Show
values (2,8,CAST('09:00:00' AS Time(7)),70,70);
insert into Show
values (3,21,CAST('03:20:00'AS Time(7)),40,30);
insert into Show
values (3,22,CAST('05:50:00' AS Time(7)),50,40);
insert into Show
values (3,23,CAST('09:15:00' AS Time(7)),65,45);

-------------------------------------
--Singers
insert into Singers
values ('Adele',29);
insert into Singers
values ('Eminem',45);
insert into Singers
values ('Lana Del Rey',32);
insert into Singers
values ('Ed-Sheeran',26);
insert into Singers
values ('Amr Diab',56);
insert into Singers
values ('Shereen',37);

-------------------------------------
--Songs
insert into Songs
values (52,1,'25',5);
insert into Songs
values (53,1,'25',6);
insert into Songs
values (54,1,'21',4);
insert into Songs
values (55,1,'21',5);
insert into Songs
values (56,2,'8 Mile',5);
insert into Songs
values (57,2,'Recovery',4);
insert into Songs
values (58,3,'Born To Die',5);
insert into Songs
values (59,4,'The Hobbit',5);
insert into Songs
values (60,4,'Game of Thrones',2);
insert into Songs
values (61,5,'Ahla W Ahla',3);
insert into Songs
values (62,6,'Ana Kiteer',5);

---------------------------------------
--Genre
insert into Genre
values (1,'Action',1);
insert into Genre
values (1,'Fantasy',1);
insert into Genre
values (2,'Action',1);
insert into Genre
values (2,'Drama',1);
insert into Genre
values (3,'Fantasy',1);
insert into Genre
values (3,'Adventure',1);
insert into Genre
values (4,'Crime',1);
insert into Genre
values (4,'Thriller',1);
insert into Genre
values (5,'Drama',1);
insert into Genre
values (5,'Thriller',1);
insert into Genre
values (6,'Science-Fiction',1);
insert into Genre
values (7,'Mystery',1);
insert into Genre
values (7,'Science-Fiction',1);
insert into Genre
values (8,'Science-Fiction',1);
insert into Genre
values (8,'Thriller',1);
insert into Genre
values (9,'Mystery',1);
insert into Genre
values (9,'Science-Fiction',1);
insert into Genre
values (10,'Thriller',1);
insert into Genre
values (10,'Mystery',1);
insert into Genre
values (11,'Crime',1);
insert into Genre
values (11,'Thriller',1);
insert into Genre
values (12,'Drama',1);
insert into Genre
values (12,'Action',1);
insert into Genre
values (13,'Drama',1);
insert into Genre
values (13,'History',1);
insert into Genre
values (14,'Fantasy',1);
insert into Genre
values (14,'Science-Fiction',1);
insert into Genre
values (15,'Drama',1);
insert into Genre
values (16,'Fantasy',1);
insert into Genre
values (16,'Science-Fiction',1);
insert into Genre
values (17,'Fantasy',1);
insert into Genre
values (17,'Science-Fiction',1);
insert into Genre
values (18,'Comedy',1);
insert into Genre
values (18,'Drama',1);
insert into Genre
values (19,'History',1);
insert into Genre
values (19,'Drama',1);
insert into Genre
values (20,'Comedy',1);
insert into Genre
values (20,'Drama',1);
insert into Genre
values (21,'Mystery',1);
insert into Genre
values (21,'Drama',1);
insert into Genre
values (22,'Crime',1);
insert into Genre
values (22,'Adventure',1);
insert into Genre
values (23,'Fantasy',1);
insert into Genre
values (23,'Action',1);
insert into Genre
values (24,'Action',1);
insert into Genre
values (24,'Fantasy',1);
insert into Genre
values (25,'Action',1);
insert into Genre
values (25,'Science-Fiction',1);
insert into Genre
values (26,'Comedy',2);
insert into Genre
values (27,'Crime',2);
insert into Genre
values (27,'Action',2);
insert into Genre
values (28,'Adventure',2);
insert into Genre
values (28,'Action',2);
insert into Genre
values (29,'Science-Fiction',2);
insert into Genre
values (29,'Fantasy',2);
insert into Genre
values (30,'Drama',2);
insert into Genre
values (30,'Thriller',2);
insert into Genre
values (31,'Drama',2);
insert into Genre
values (31,'Fantasy',2);
insert into Genre
values (32,'Drama',2);
insert into Genre
values (32,'Mystery',2);
insert into Genre
values (33,'Action',3);
insert into Genre
values (33,'Stealth',3);
insert into Genre
values (34,'Action',3);
insert into Genre
values (35,'History',3);
insert into Genre
values (35,'War',3);
insert into Genre
values (36,'History',3);
insert into Genre
values (36,'War',3);
insert into Genre
values (37,'Action',3);
insert into Genre
values (37,'Stealth',3);
insert into Genre
values (38,'Action',3);
insert into Genre
values (38,'Adventure',3);
insert into Genre
values (39,'Action',3);
insert into Genre
values (39,'Adventure',3);
insert into Genre
values (40,'Sport',3);
insert into Genre
values (41,'Stealth',3);
insert into Genre
values (41,'Action',3);
insert into Genre
values (42,'Sport',3);
insert into Genre
values (43,'Horror',3);
insert into Genre
values (43,'Survival',3);
insert into Genre
values (44,'Adventure',3);
insert into Genre
values (45,'Adventure',3);
insert into Genre
values (45,'Mystery',3);
insert into Genre
values (46,'Adventure',3);
insert into Genre
values (46,'Mystery',3);
insert into Genre
values (47,'Adventure',3);
insert into Genre
values (47,'Science-Fiction',3);
insert into Genre
values (48,'Adventure',3);
insert into Genre
values (48,'Survival',3);
insert into Genre
values (49,'Adventure',3);
insert into Genre
values (50,'Crime',3);
insert into Genre
values (50,'Action',3);
insert into Genre
values (51,'Adventure',3);
insert into Genre
values (51,'Action',3);
insert into Genre
values (52,'Pop',4);
insert into Genre
values (53,'Pop',4);
insert into Genre
values (54,'Pop',4);
insert into Genre
values (55,'Pop',4);
insert into Genre
values (56,'Rap',4);
insert into Genre
values (56,'Pop',4);
insert into Genre
values (57,'Rap',4);
insert into Genre
values (57,'Hip-hop',4);
insert into Genre
values (58,'Pop',4);
insert into Genre
values (58,'Rock',4);
insert into Genre
values (59,'Pop',4);
insert into Genre
values (60,'pop',4);
insert into Genre
values (61,'Pop',4);
insert into Genre
values (62,'Pop',4);


---------------------------------------
--Concerts
insert into Concerts (Ticket_price,Available_Seats,Time_Date,Location,Phone)
values (100,80,'2017-12-05  06:30:00','Alexandria',111);
insert into Concerts (Ticket_price,Available_Seats,Time_Date,Location,Phone)
values (110,90,'2017-12-15  09:30:00','Sharm-El Sheik',122);

---------------------------------------
--Perform
insert into perform
values (5,1);
insert into perform
values (6,2);

---------------------------------------
