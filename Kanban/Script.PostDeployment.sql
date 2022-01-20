if not exists (SELECT 1 FROM dbo.[Boards])
begin
	INSERT INTO dbo.[Boards] (Title, Description)
	VALUES ('Planning', 'This is just a planning phase of the project'),
		   ('Development', 'This is just a development phase of the project'),
		   ('Testing', 'This is just a testing phase of the project')
end