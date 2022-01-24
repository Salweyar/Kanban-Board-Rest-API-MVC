CREATE PROCEDURE [dbo].[spCard_GetAll]
AS
begin
	SELECT Id, ListId, Title, Description, Status, StartDate, EndDate, AssigneTo, ReportTo, StoryPoints
	FROM dbo.[Cards];
end
