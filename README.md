# LibraryManagementSystem
Book Store management system with 3 roles:
only admin can add ,edit and delete Book 
Only admin can View And Add Users And set The Role For the user. 
admin can view The Requests from librarian and EndUser.  
librarian and End Users can Viewbooks and Request Books.

i used DataBase First approach The DB Bak File is included 
-- restore the db bak file
-- build and run the solution 
-- use Email "Admin@Admin.com" for Admin 
-- Password "@Dmin1"
and you can add new user with a role you want to make your own cycle

design Patterns :Repositoy and Unit of Work.
Architecture : Service Oriented Architecture as possible.
there are trigger on book table to set last modified Date for every book.
