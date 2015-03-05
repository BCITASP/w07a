namespace StudentAPI.Migrations.Students
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAPI.Models.StudentAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Students";
        }

        protected override void Seed(StudentAPI.Models.StudentAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Students.AddOrUpdate(
                p => p.StudentId,
                new Students { StudentId = "A00111111", FirstName = "John", LastName = "Archer", Program = "CIT" },
                new Students { StudentId = "A00222222", FirstName = "Jane", LastName = "Baker", Program = "CST" },
                new Students { StudentId = "A00333333", FirstName = "Bill", LastName = "Carter", Program = "BTECH" },
                new Students { StudentId = "A00444444", FirstName = "Judy", LastName = "Fisher", Program = "Nursing" }
                );
        }
    }
}
