CREATE PROCEDURE [dbo].[spBoard_Get]
	@Id int
AS
begin
	SELECT Id, Title, Description
	FROM dbo.[Boards]
	WHERE Id = @Id;
end
