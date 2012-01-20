//Write a SQL statement to create a view that displays the users from the
// Users table that have been in the system today. Test if the view works correctly.


CREATE VIEW UsersLoggedToday
AS
Select * from Users
Where LastLogin = Convert(datetime, Convert(int, GetDate()))