CREATE PROCEDURE [dbo].[Select]
	@Brand nvarchar (50) = NULL
AS
	BEGIN
		SELECT * FROM [dbo].[Motorcycle] AS a WHERE a.[Brand] = @Brand;
	END