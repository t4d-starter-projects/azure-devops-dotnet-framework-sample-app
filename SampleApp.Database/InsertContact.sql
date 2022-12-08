CREATE PROCEDURE InsertContact
  @FirstName NVARCHAR(MAX),
  @LastName NVARCHAR(MAX)  
AS   
  SET NOCOUNT ON;

  INSERT INTO [dbo].[Contact] ("FirstName", "LastName")
  VALUES (@FirstName, @LastName);

  SELECT "Id", "FirstName", "LastName" FROM [dbo].[Contact] WHERE "Id" = SCOPE_IDENTITY();
