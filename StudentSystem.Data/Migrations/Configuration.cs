namespace StudentSystem.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Data.StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "StudentSystem.Data.StudentSystemContext";
        }

        protected override void Seed(StudentSystem.Data.StudentSystemContext context)
        {
            Student[] students = new Student[]
            {
                new Student()
                {
                    Id = 1,
                    Name = "Dani",
                    PhoneNumber = "088123123",
                    RegistrationDate = DateTime.Now,
                    BirthDate = DateTime.Now

                },
                new Student()
                {
                    Id = 2,
                    Name = "Nasko",
                    PhoneNumber = "0888123123",
                    RegistrationDate = DateTime.Now,
                    BirthDate = DateTime.Now
                }
            };

            foreach (var student in students)
            {
                context.Students.AddOrUpdate(student);
            }

            Course[] courses = new Course[]
            {
                new Course()
                {
                    Id = 1,
                    Name = "Science Class",
                    Description = "Wizards",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Price = 5.0m
                },
                new Course()
                {
                    Id = 2,
                    Name = "Mathematics",
                    Description = "2 + 2",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Price = 20.0m
                }
            };

            foreach (var course in courses)
            {
                context.Courses.AddOrUpdate(course);
            }

            Resource[] resources = new Resource[]
            {
                new Resource()
                {
                    Id = 1,
                    Name = "Math For Dummies Video",
                    ResourceType = Models.Enums.ResourceType.Video,
                    Url = "https://www.youtube.com/watch?v=XPBwXKgDTdE"
                },
                new Resource()
                {
                    Id = 2,
                    Name = "Science Basics Presentation",
                    ResourceType = Models.Enums.ResourceType.Presentation,
                    Url = "https://www.youtube.com/watch?v=Jb2stN7kH28"
                }
            };

            foreach (var resource in resources)
            {
                context.Resources.AddOrUpdate(resource);
            }

            Homework[] homeworks = new Homework[]
            {
                new Homework()
                {
                    Id = 1,
                    Content = "Science Basics Homework",
                    SubmissionDate = DateTime.Now,
                    Course = courses[0],
                    Student = students[0]
                },
                new Homework()
                {
                    Id = 2,
                    Content = "Math For Dummies Homework",
                    SubmissionDate = DateTime.Now,
                    Course = courses[1],
                    Student = students[1]
                }
            };
            
            foreach (var homework in homeworks)
            {
                context.Homeworks.AddOrUpdate(homework);
            }
            
            context.SaveChanges();
        }
    }
}