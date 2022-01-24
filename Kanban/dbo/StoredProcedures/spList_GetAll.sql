CREATE PROCEDURE [dbo].[spList_GetAll]
AS
begin
	SELECT Id, BoardId, Title, Description
	FROM dbo.[Lists];
end
