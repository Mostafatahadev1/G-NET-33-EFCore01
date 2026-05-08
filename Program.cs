using G_NET_33_EFCore01;
using System;
{

    using var context = new bookstoreDbContext();

    context.Database.EnsureCreated();

    Console.WriteLine("Database Ready");

}




