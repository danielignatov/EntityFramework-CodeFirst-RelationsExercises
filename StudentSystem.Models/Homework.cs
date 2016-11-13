namespace StudentSystem.Models
{
    using StudentSystem.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

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
    }
}