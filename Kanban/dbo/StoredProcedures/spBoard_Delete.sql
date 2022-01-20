CREATE PROCEDURE [dbo].[spBoard_Delete]
	@Id int
AS
begin
	DELETE
	FROM dbo.[Boards]
	WHERE Id = @Id;
end
