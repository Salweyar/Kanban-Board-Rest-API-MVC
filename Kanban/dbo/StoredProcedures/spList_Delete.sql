CREATE PROCEDURE [dbo].[spList_Delete]
	@Id int
AS
begin
	DELETE
	FROM dbo.[Lists]
	WHERE Id = @Id;
end
