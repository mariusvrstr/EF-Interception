
namespace Spike.DataSource.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Base;

    [Table("Books")]
    public class BookEntity : EntityBase
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Author")]
        public Guid AuthorId { get; set; }

        public AuthorEntity Author { get; set; }
    }
}
