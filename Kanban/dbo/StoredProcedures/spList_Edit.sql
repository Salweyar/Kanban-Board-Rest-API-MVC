CREATE PROCEDURE [dbo].[spList_Edit]
	@Id int,
	@BoardId int,
	@Title nvarchar(50),
	@Description nvarchar(50)
AS
begin
	UPDATE dbo.[Lists]
	SET BoardId = @BoardId, Title = @Title, Description = @Description
	WHERE Id = @Id;
end
