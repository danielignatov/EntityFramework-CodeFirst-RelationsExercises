namespace StudentSystem.Models
{
    using Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Resource
    {
        // Fields
        private ICollection<License> licenses;

        // Constructor
        public Resource()
        {
            this.licenses = new HashSet<License>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ResourceType ResourceType { get; set; }

        [Required]
        public string Url { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        public virtual ICollection<License> Licenses
        {
            get
            {
                return this.licenses;
            }
            set
            {
                this.licenses = value;
            }
        }
    }
}