namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tag
    {
        // Fields
        private ICollection<Album> albums;

        // Constructor
        public Tag()
        {
            this.albums = new HashSet<Album>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [Required]
        [Tag]
        public string Name { get; set; }

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