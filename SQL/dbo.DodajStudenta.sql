CREATE PROCEDURE [dbo].[DodajStudenta]
	@imie nvarchar(100),
	@nazwisko nvarchar(100),
	@grupaid int
AS
	INSERT INTO Studenci (Imie, Nazwisko, GrupaID) VALUES (@imie, @nazwisko, @grupaid);
RETURN 0