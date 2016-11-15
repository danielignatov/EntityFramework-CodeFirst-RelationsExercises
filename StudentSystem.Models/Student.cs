namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        // Fields
        private ICollection<Album> albums;
        private ICollection<Course> courses;
        private ICollection<Student> friends;

        // Constructor
        public Student()
        {
            this.albums = new HashSet<Album>();
            this.courses = new HashSet<Course>();
            this.friends = new HashSet<Student>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        [ForeignKey("Picture")]
        public int? PictureId { get; set; }
        
        public Picture Picture { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        public virtual ICollection<Student> Friends
        {
            get
            {
                return this.friends;
            }
            set
            {
                this.friends = value;
            }
        }

        public virtual ICollection<Album> Albums
        {
            get
            {
                return this.albums;
            }
            set
            {
                this.albums = value;
            }
        }
    }
}