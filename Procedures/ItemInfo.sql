USE [HBO]
GO
/****** Object:  StoredProcedure [dbo].[ItemInfo]    Script Date: 12/16/2017 20:08:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ItemInfo] 
		@id int,
		@t varchar(50)
        
AS
BEGIN
	 
	 if @t = 'Movie' or @t = 'Series' 	
	 select Name,#Purchase,Rate,Price,Poster,Year,A.Fname,A.Lname,D.Fname,D.Lname as DirName
	 from Item , Actors as A,Director as D 
	 where Item.ID = @id  AND D.ID IN (select ID_Director    
	                                   from Movies
	                                   where Movies.ID = @id
	                                   union
	                                   select ID_Director
	                                   from TV_Series as T
	                                   where T.ID = @id
	                                   ) AND A.ID IN (Select ID_Actor
	                                                  from Act
	                                                  where Act.ID_Item = @id
	                                                  );
	
	 
     else if @t = 'Game'
     select Name,#Purchase,Rate,Price,Poster,Year,Studio
     from item , Games
     where Item.ID = @id AND Games.ID = @id;
     
     else
     select I.Name as Name,#Purchase,Rate,Price,Poster,Year,S.Name as Sname	 
	 from Item as I ,Singers as S
	 where I.ID = @id AND S.ID = (Select ID_Singer 
	                               from Songs
	                               where Songs.ID = @id
	                               );
	 
END
