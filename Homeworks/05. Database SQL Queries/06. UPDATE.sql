//Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Users
SET FirstName='Penka', LastName='Ivanova'
WHERE UserName='Peshaka'

UPDATE Groups
SET Name='Nai Dobrata Grupa'
WHERE Name='Purva Grupa'