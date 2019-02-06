use Library
------------------------
create table Book_Loans(Book_id int not null,Branch_id int not null,Card_id int not null,Date_out varchar(50),Duration int not null,foreign key(Book_id) references Book,foreign key(Branch_id) references Library_Branch,foreign key (Card_id) references Borrower);
insert into Book values(1,'exapmle1','Unkown');
insert into Book values(2,'exapmle2','Unkown');
insert into Book values(3,'exapmle3','Unkown');
insert into Book values(4,'exapmle4','Unkown');
insert into Book values(5,'exapmle5','Unkown');
insert into Library_Branch values(1,'branch1','Unkown');
insert into Library_Branch values(2,'branch2','Unkown');
insert into Borrower values(1,'B1','Unkown',123);
insert into Borrower values(2,'B2','Unkown',1234);
insert into Book_Loans values(1,1,1,'1-2-2017',3);
insert into Book_Loans values(2,1,1,'3-2-2017',5);
insert into Book_Loans values(4,1,1,'1-1-2017',4);
insert into Book_Loans values(5,2,2,'15-3-201',4);
insert into Book_Loans values(3,1,1,'17-5-2017',5);
insert into Book_Loans values(1,2,2,'13-10-2017',10);


