CREATE PROCEDURE [dbo].[spBoard_Add]
	@Title nvarchar(50),
	@Description nvarchar(50)
AS
begin
	INSERT INTO dbo.[Boards] (Title, Description)
	VALUES (@Title, @Description);	
end
