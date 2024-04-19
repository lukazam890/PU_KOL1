CREATE PROCEDURE [dbo].[OdczytGrup]
	@id int
AS
	DECLARE 
	@parentid int = (SELECT ParentID FROM Grupy WHERE Id = @id),
	@nazwa nvarchar(100) = (SELECT Nazwa FROM Grupy WHERE Id = @id)
	IF @parentid IS NOT NULL
		exec OdczytGrup @parentid
	ELSE 
		print @nazwa
RETURN 0