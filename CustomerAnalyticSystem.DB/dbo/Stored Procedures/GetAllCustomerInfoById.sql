CREATE PROCEDURE [dbo].[GetAllCustomerInfoById]
  @Id integer
as
  select * from Customer as C
  inner join Contact as Cont
  on C.Id = Cont.CustomerId
  inner join ContactType as CT
  on Cont.ContactTypeId = CT.Id
  inner join Comment as Com
  on C.Id = Com.CustomerId
  where C.Id = @Id
RETURN 0
