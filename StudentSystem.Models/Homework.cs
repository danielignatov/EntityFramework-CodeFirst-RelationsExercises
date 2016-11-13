namespace StudentSystem.Models
{
    using StudentSystem.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        // Constructor
        public Homework()
        {

        }

        // Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public ContentType ContentType { get; set; }

        [Required]
        public DateTime SubmissionDate { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}