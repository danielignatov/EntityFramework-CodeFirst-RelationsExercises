namespace StudentSystem.Client
{
    using Data;
    using Data.Migrations;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();

            int count = context.Homeworks.Count();

            context.SaveChanges();
        }
    }
}