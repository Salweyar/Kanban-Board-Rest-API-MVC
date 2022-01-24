CREATE PROCEDURE [dbo].[spList_Get]
	@Id int
AS
begin
	SELECT Id, BoardId, Title, Description
	FROM dbo.[Lists]
	WHERE Id = @Id;
end