// See https://aka.ms/new-console-template for more information

using Logbook.Database;

var db = new EntityDbContext("logbook.db");
db.Database.EnsureCreated();

