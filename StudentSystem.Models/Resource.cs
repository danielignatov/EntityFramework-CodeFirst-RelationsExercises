namespace StudentSystem.Models
{
    using Enums;
    using System.ComponentModel.DataAnnotations;

    public class Resource
    {
        // Constructor
        public Resource()
        {

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
    }
}