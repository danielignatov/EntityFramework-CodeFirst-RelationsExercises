namespace StudentSystem.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Data.StudentSystemContext>
    {
        Random rng = new Random();

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
                    Name = "Daniel Ignatov",
                    PhoneNumber = "0881123123",
                    RegistrationDate = new DateTime(2016, 2, 1),
                    BirthDate = new DateTime(1989, 6, 3)

                },
                new Student()
                {
                    Id = 2,
                    Name = "Atanas Tankov",
                    PhoneNumber = "0888123123",
                    RegistrationDate = new DateTime(2016, 2, 1),
                    BirthDate = new DateTime(1990, 10, 3)
                },
                new Student()
                {
                    Id = 3,
                    Name = "Taylor Swift",
                    PhoneNumber = "0888123124",
                    RegistrationDate = new DateTime(2016, 3, 1),
                    BirthDate = new DateTime(1989, 9, 3)
                },
                new Student()
                {
                    Id = 4,
                    Name = "Svetlin Nakov",
                    PhoneNumber = "0888123125",
                    RegistrationDate = new DateTime(2016, 1, 1),
                    BirthDate = new DateTime(1980, 8, 8)
                },
                new Student()
                {
                    Id = 5,
                    Name = "Ariana Grande",
                    PhoneNumber = "0888123126",
                    RegistrationDate = new DateTime(2016, 3, 2),
                    BirthDate = new DateTime(1989, 9, 3)
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
                    StartDate = new DateTime(2016, 9, 1),
                    EndDate = new DateTime(2016, 11, 1),
                    Price = 5.0m
                },
                new Course()
                {
                    Id = 2,
                    Name = "Mathematics",
                    Description = "2 + 2",
                    StartDate = new DateTime(2016, 9, 10),
                    EndDate = new DateTime(2016, 10, 10),
                    Price = 20.0m
                },
                new Course()
                {
                    Id = 3,
                    Name = "Programming Class",
                    Description = "C#",
                    StartDate = new DateTime(2016, 9, 1),
                    EndDate = new DateTime(2016, 9, 20),
                    Price = 1.0m
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
                    Url = "https://www.youtube.com/watch?v=XPBwXKgDTdE",
                    Course = courses[0]
                },
                new Resource()
                {
                    Id = 2,
                    Name = "Science Basics Presentation",
                    ResourceType = Models.Enums.ResourceType.Presentation,
                    Url = "https://www.youtube.com/watch?v=Jb2stN7kH28",
                    Course = courses[1]
                },
                new Resource()
                {
                    Id = 3,
                    Name = "Science Advanced",
                    ResourceType = Models.Enums.ResourceType.Video,
                    Url = "https://www.youtube.com/watch?v=Jb2stN7kH28",
                    Course = courses[1]
                },
                new Resource()
                {
                    Id = 4,
                    Name = "Science - What Einstein Wanted To Say",
                    ResourceType = Models.Enums.ResourceType.Document,
                    Url = "https://www.youtube.com/watch?v=Jb2stN7kH28",
                    Course = courses[1]
                },
                new Resource()
                {
                    Id = 5,
                    Name = "Science Of Things",
                    ResourceType = Models.Enums.ResourceType.Document,
                    Url = "https://www.youtube.com/watch?v=Jb2stN7kH28",
                    Course = courses[1]
                },
                new Resource()
                {
                    Id = 6,
                    Name = "Science - Game Theory",
                    ResourceType = Models.Enums.ResourceType.Other,
                    Url = "https://www.youtube.com/watch?v=Jb2stN7kH28",
                    Course = courses[1]
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
                    ContentType = Models.Enums.ContentType.Zip,
                    Course = courses[0],
                    Student = students[0]
                },
                new Homework()
                {
                    Id = 2,
                    Content = "Math For Dummies Homework",
                    SubmissionDate = DateTime.Now,
                    ContentType = Models.Enums.ContentType.Pdf,
                    Course = courses[1],
                    Student = students[1]
                }
            };
            
            foreach (var homework in homeworks)
            {
                context.Homeworks.AddOrUpdate(homework);
            }

            context.SaveChanges();

            var allStudents = context.Students;
            var allCourses = context.Courses;
            
            foreach (var student in allStudents)
            {
                int courseCount = rng.Next(1, allCourses.Count() + 1);
            
                for (int i = 1; i <= courseCount; i++)
                {
                    student.Courses.Add(allCourses.Find(i));
                }
            }
            
            context.SaveChanges();
        }
    }
}