CREATE TRIGGER [TriggerDeleteStudent]
	ON [dbo].[Studenci]
	FOR DELETE
	AS
	BEGIN
		SET NOCOUNT ON
		DECLARE 
		@imie nvarchar(100) = (SELECT Imie FROM deleted),
		@nazwisko nvarchar(100) = (SELECT Nazwisko FROM deleted),
		@idgrupy int = (SELECT GrupaID FROM deleted);
		INSERT INTO Historie (Imie, Nazwisko, IdGrupy, Typ_akcji, Data)
		VALUES (@imie, @nazwisko, @idgrupy, 0, (GetDate()));
	END