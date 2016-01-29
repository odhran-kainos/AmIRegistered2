namespace AmIRegistered2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hash")]
    public partial class Hash
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HashId { get; set; }

        [Required]
        [StringLength(64)]
        public string HashValue { get; set; }
    }
}
