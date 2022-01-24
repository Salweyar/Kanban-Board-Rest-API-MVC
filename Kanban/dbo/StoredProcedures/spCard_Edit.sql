CREATE PROCEDURE [dbo].[spCard_Edit]
	@Id int,
	@ListId int,
	@Title nvarchar(50),
	@Description nvarchar(50),
	@Status nvarchar(50),
	@StartDate datetime,
	@EndDate datetime,
	@AssigneTo nvarchar(30),
	@ReportTo nvarchar(30),
	@StoryPoints int
AS
begin
	UPDATE dbo.[Cards]
	SET ListId = @ListId,
	Title = @Title, 
	Description = @Description, 
	Status = @Status, 
	StartDate = @StartDate, 
	EndDate = @EndDate, 
	AssigneTo = @AssigneTo,
	ReportTo = @ReportTo,
	StoryPoints = @StoryPoints
	WHERE Id = @Id;
end
