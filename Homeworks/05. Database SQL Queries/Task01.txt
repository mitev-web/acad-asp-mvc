//Write a SQL statement to create a table Users. 
//Users should have username, password, full name and last login time. 
//Choose appropriate data types for the table fields. 
//Define a primary key column with a primary key constraint. 
//Define the primary key column as identity to facilitate inserting records. 
//Define unique constraint to avoid repeating usernames.
// Define a check constraint to ensure the password is at least 5 characters long.

CREATE DATABASE Lesson5
use Lesson5
CREATE TABLE Users (
  ID INT NOT NULL IDENTITY (1, 1),
  UserName VARCHAR(40),
  Password VARCHAR(40),
  FirstName VARCHAR(80),
  LastName VARCHAR(80),
  LastLogin DATETIME
  PRIMARY KEY (ID),
  UNIQUE (UserName)
)

ALTER TABLE Users ADD CONSTRAINT CK_Password CHECK (LEN(Password) > 5)
GO
