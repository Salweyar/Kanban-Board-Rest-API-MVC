CREATE PROCEDURE [dbo].[spCard_Add]
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
	INSERT INTO dbo.[Cards] (ListId, Title, Description, Status, StartDate, EndDate, AssigneTo, ReportTo, StoryPoints)
	VALUES (@ListId, @Title, @Description, @Status, @StartDate, @EndDate, @AssigneTo, @ReportTo, @StoryPoints);	
end
