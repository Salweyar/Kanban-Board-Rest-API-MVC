CREATE PROCEDURE [dbo].[spBoard_Edit]
	@Id int,
	@Title nvarchar(50),
	@Description nvarchar(50)
AS
begin
	UPDATE dbo.[Boards]
	SET Title = @Title, Description = @Description
	WHERE Id = @Id;
end
