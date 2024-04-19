CREATE PROCEDURE [dbo].[WyswietlHistorie]
	@LiczbaElementow int = 10,
	@NumerStrony int = 1
AS
	SELECT TOP (@LiczbaElementow) Historie.ID, Imie, Nazwisko, Grupy.Nazwa AS NazwaGrupy, Typ_akcji, Data 
	FROM Historie LEFT JOIN Grupy ON Historie.IdGrupy = Grupy.Id WHERE Historie.ID > (@LiczbaElementow*(@NumerStrony-1));

RETURN 0