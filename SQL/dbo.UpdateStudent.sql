CREATE PROCEDURE [dbo].[UpdateStudent]
	@id int,
	@imie nvarchar(100),
	@nazwisko nvarchar(100),
	@grupaid int
AS
	UPDATE Studenci SET Imie = @imie, Nazwisko = @nazwisko, GrupaID = @grupaid WHERE ID = @id
RETURN 0