namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class License
    {
        // Field
        private ICollection<Resource> resources;

        // Constructor
        public License()
        {
            this.resources = new HashSet<Resource>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

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
    }
}