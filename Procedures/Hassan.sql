Create database Hassan
Go
use Hassan
create table Car(CarNo int not null,Model varchar(50),Year int,Price int,Primary key(CarNo));
Create table SalesMan(SSN int not null,Sname varchar(50) not null,City varchar(50),Primary Key(SSN));
Create table Client(ID int not null,Name varchar(50) not null,City varchar(50),Phone int,Primary Key(ID));
Create table Contract (ClientID int not null,CarNum int not null,SalesSSN int not null,Commission int,foreign key(ClientID) references Client,foreign key(CarNum) references Car,foreign key(SalesSSN) references SalesMan);

Insert into Car values(1,'Toyota',1991,5000);
Insert into Car values(2,'BMW',1995,2500);
Insert into Car values(3,'Matrix',1999,1000);

Insert into SalesMan values(1,'Hassan',null);
Insert into SalesMan values(2,'Osama',null);
Insert into SalesMan values(3,'Eslam',null);

Insert into Client values(1,'A',null,12334);
Insert into Client values(2,'B',null,12334);
Insert into Client values(3,'C',null,12334);
Insert into Client values(4,'D',null,12334);
Insert into Client values(5,'E',null,12334);
Insert into Client values(6,'F',null,12334);

Insert into Contract values(1,1,1,null);
Insert into Contract values(1,2,1,null);
Insert into Contract values(1,3,1,null);
Insert into Contract values(2,1,2,null);
Insert into Contract values(2,2,2,null);




