CREATE PROCEDURE [dbo].[GetAllCustomer]
as
	select C.Id, C.FirstName, C.LastName, C.TypeId from Customer as C