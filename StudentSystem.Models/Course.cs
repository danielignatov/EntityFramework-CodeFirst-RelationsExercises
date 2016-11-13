namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        // Fields
        private ICollection<Resource> resources;
        private ICollection<Student> students;

        // Constructor
        public Course()
        {
            this.resources = new HashSet<Resource>();
            this.students = new HashSet<Student>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Resource> Resources
        {
            get
            {
                return this.resources;
            }
            set
            {
                this.resources = value;
            }
        }

        public virtual ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
    }
}