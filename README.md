# how to create a .net api
1. New Project -> Select ASP.Net Web Application(.net Framework)
2. Give name and select directory
3. Select WEB API in the templates, make sure  that WEB API is clicked and MVC is Clicked
4. After the solution is created, add a database in App_DATA
5. Right click the database you then select Open
6. Add a table under Tables, I Created userslist table with 5 fields. Update your tables with this table
7. Add Model, I added mine called UsersList, I set the model exactly the same as the table
    public class UsersList
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Age { get; set; }
    }
8. Add controller, right click controllers folder, select add, then select Web API Controller with actions, usint entity framework
9. Select the model you created in the model class, I created UsersList, Then add an API Context
10. If you get an error, clean and rebuild the project and redo from step 8
12. Run your application
13. When the app opens with no error open post man and do a post to the api like this
set the body to 'raw', and set the type to json/application and paste this in the body

{

firstname: "Oberyn",
	
lastname: "Martell",
	
dateofBirth: "1996/01/19",
	
age: 99

}


14. Set the post to the URL like this: http://localhost:<your api port>/api/userslists/PostUsersList
15. if you didnt get any error posting try get

