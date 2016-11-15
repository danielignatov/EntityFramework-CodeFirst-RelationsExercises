namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Album
    {
        // Fields
        private ICollection<Picture> pictures;
        private ICollection<Tag> tags;

        // Constructor
        public Album()
        {
            this.pictures = new HashSet<Picture>();
            this.tags = new HashSet<Tag>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int OwnerId { get; set; }

        public Student Student { get; set; }

        public virtual ICollection<Picture> Pictures
        {
            get
            {
                return this.pictures;
            }
            set
            {
                this.pictures = value;
            }
        }

        public virtual ICollection<Tag> Tags
        {
            get
            {
                return this.tags;
            }
            set
            {
                this.tags = value;
            }
        }
    }
}