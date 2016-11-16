namespace StudentSystem.Client
{
    using Data;
    using Data.Migrations;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();

            // 1. Lists all students and their homework submissions.
            // Select only their names and for each homework - content and content-type.

            //var allStudents = context.Students.ToArray();
            //
            //foreach (var student in allStudents)
            //{
            //    Console.WriteLine(student.Name);
            //    var allHomeworksOfStudent = context.Homeworks.Where(i => i.StudentId == student.Id);
            //
            //    foreach (var homework in allHomeworksOfStudent)
            //    {
            //        Console.WriteLine($"{homework.Content} {homework.ContentType.ToString()}");
            //    }
            //}

            // 2. List all courses with their corresponding resources. 
            // Select the course name and description and everything 
            // for each resource. Order the courses by start date (ascending),
            // then by end date (descending).

            //var allCourses = context.Courses.OrderBy(sd => sd.StartDate).ThenByDescending(ed => ed.EndDate);
            //
            //foreach (var course in allCourses)
            //{
            //    Console.WriteLine($"{course.Name} {Environment.NewLine}{course.Description}{Environment.NewLine}Start Date: {course.StartDate}{Environment.NewLine}End Date: {course.EndDate}");
            //    var allReasources = course.Resources;
            //
            //    foreach (var resourse in allReasources)
            //    {
            //        Console.WriteLine($"{resourse.Name} - {resourse.ResourceType.ToString()}");
            //    }
            //}

            // 3. List all courses with more than 5 resources. 
            // Order them by resources count (descending), then by start date (descending).
            // Select only the course name and the resource count.

            //var allCoursesWithMoreThanFiveResources = context.Courses
            //    .Where(r => r.Resources.Count >= 5)
            //    .OrderBy(rc => rc.Resources.Count)
            //    .ThenByDescending(sd => sd.StartDate);
            //
            //foreach (var course in allCoursesWithMoreThanFiveResources)
            //{
            //    Console.WriteLine($"{course.Name} {course.Resources.Count}");
            //}

            // 4. List all courses which were active on a given date 
            // (choose the date depending on the data seeded to ensure there are results),
            // and for each course count the number of students enrolled. 
            // Select the course name, start and end date, course duration 
            // (difference between end and start date) and number of students enrolled.
            // Order the results by the number of students enrolled(in descending order), 
            // then by duration(descending).

            //var givenDate = new DateTime(2016, 9, 2);
            //var allActiveCoursesOnGivenDate = context.Courses
            //    .Where(d => d.StartDate <= givenDate && d.EndDate >= givenDate)
            //    .OrderByDescending(se => se.Students.Count);
            //
            //foreach (var course in allActiveCoursesOnGivenDate)
            //{
            //    TimeSpan timeBetween = course.EndDate - course.StartDate;
            //
            //    Console.WriteLine($"{course.Name} {Environment.NewLine}" +
            //                      $"{course.StartDate} - {course.EndDate}{Environment.NewLine}" +
            //                      $"{timeBetween.Days} Days {Environment.NewLine}" +
            //                      $"{course.Students.Count}");
            //}

            // 5. For each student, calculate the number of courses he/she has enrolled in,
            // the total price of these courses and the average price per course for the student.
            // Select the student name, number of courses, total price and average price. 
            // Order the results by total price (descending), then by number of courses(descending)
            // and then by the student's name (ascending).

            //var allStudents = context.Students
            //    .OrderByDescending(c => c.Courses.Select(p => p.Price).Sum())
            //    .ThenByDescending(c => c.Courses.Count);
            //
            //foreach (var student in allStudents)
            //{
            //    Console.WriteLine($"{student.Name} {student.Courses.Count} " +
            //                      $"Total sum: {student.Courses.Select(p => p.Price).Sum()} " +
            //                      $"Average sum: {student.Courses.Select(p => p.Price).Average():F2}");
            //}

            // Write a program that receives as an input tags and insert them into the database. 
            // Use the [Tag] attribute and TagTransformer class to make sure only valid attributes are inserted in the database.

            //Console.Write("Add New Tag:");
            //string input = Console.ReadLine();
            //string tag = TagTransofrmer.Transform(input);
            //
            //if (context.Tags.Where(n => n.Name == tag).Count() == 0)
            //{
            //    Tag newTag = new Tag()
            //    {
            //        Name = tag
            //    };
            //
            //    context.Tags.Add(newTag);
            //    context.SaveChanges();
            //
            //    Console.WriteLine($"{newTag.Name} was added to the database!");
            //}
            //else
            //{
            //    Console.WriteLine($"{tag} is already in database!");
            //}
        }
    }
}