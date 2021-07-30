CREATE PROCEDURE [dbo].[spPerson_InsertSet]
 @searchTerm VARCHAR(50)
AS
BEGIN
SET NOCOUNT ON;
SELECT[id],[FirstName],[LastName]
FROM dbo.Person
WHERE FirstName LIKE '%' + @searchTerm + '%'
OR LastName LIKE '%' + @searchTerm + '%';
END