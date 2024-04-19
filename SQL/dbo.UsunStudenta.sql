CREATE PROCEDURE [dbo].[UsunStudenta]
	@id int
AS
	DELETE FROM Studenci WHERE ID = @id
RETURN 0