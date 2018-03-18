
namespace Spike.DataSource.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Base;

    [Table("Authors")]
    public class AuthorEntity : EntityBase
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [MaxLength(150)]
        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }
    }
}
