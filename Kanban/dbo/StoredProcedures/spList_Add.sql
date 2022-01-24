CREATE PROCEDURE [dbo].[spList_Add]
	@BoardId int,
	@Title nvarchar(50),
	@Description nvarchar(50)
AS
begin
	INSERT INTO dbo.[Lists] (BoardId, Title, Description)
	VALUES (@BoardId, @Title, @Description);	
end
