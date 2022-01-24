CREATE PROCEDURE [dbo].[spCard_Get]
	@Id int
AS
begin
	SELECT Id, ListId, Title, Description, Status, StartDate, EndDate, AssigneTo, ReportTo, StoryPoints
	FROM dbo.[Cards]
	WHERE Id = @Id;
end