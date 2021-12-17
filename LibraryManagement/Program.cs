// See https://aka.ms/new-console-template for more information

using System;
using LibraryManagement;

// If we use Atham who is admin, we can use any method as we are admin
// If we use something else, we can't use any method which are not accessible for non-admins
//var admin  = new Client("Atham");

//Console.WriteLine("From admin perspective");
//admin.GetBooks();
//admin.AddUser("Alan");
//admin.AddBook("Hello World", "Alan", "2f23f2323f23f");
//admin.GetBooks();

// As there is no any database to save all data,
// any changes made on various clients won't be saved
//Console.WriteLine("From non-admin perspective");
//var user = new Client("Jushkin");
//user.GetBooks();

