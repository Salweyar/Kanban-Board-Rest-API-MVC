CREATE PROCEDURE [dbo].[spBoard_GetAll]	
AS
begin
	SELECT Id, Title, Description
	FROM dbo.[Boards];
end
