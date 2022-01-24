CREATE PROCEDURE [dbo].[spCard_Delete]
	@Id int
AS
begin
	DELETE
	FROM dbo.[Cards]
	WHERE Id = @Id;
end
