namespace OneTechStudentManagerService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OneTechStudentManagerService.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OneTechStudentManagerService.MyContext context)
        {
            for (var i = 1; i < 10; i++)
            {
                context.Students.AddOrUpdate(
                    new Student
                    {
                        Email = "anhdungpham090@gmail.com",
                        FirstName = "Anh Dũng",
                        LastName = "Phạm",
                        PhoneNumber = "0762941097"
                    });
            }
        }
    }
}
