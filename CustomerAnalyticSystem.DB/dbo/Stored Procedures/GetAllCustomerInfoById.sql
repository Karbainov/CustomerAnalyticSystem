CREATE PROCEDURE [dbo].[GetAllCustomerInfoById]
  @Id integer
as
  select C.Id, C.FirstName, C.LastName, CT.Name, Cont.Value,  null from Customer as C
  inner join Contact as Cont
  on C.Id = Cont.CustomerId
  inner join ContactType as CT
  on Cont.ContactTypeId = CT.Id
  where C.Id = @Id
  union all
  select null, null, null, null, null, Com.Text from Comment as Com
  where Com.CustomerId = @Id
RETURN @Id