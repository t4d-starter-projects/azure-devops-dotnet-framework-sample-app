CREATE PROCEDURE DeleteContact
  @Id INT
AS   
  SET NOCOUNT ON;

  DELETE [dbo].[Contact] WHERE Id = @Id;