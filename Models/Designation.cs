using System;
using System.ComponentModel.DataAnnotations;

namespace APIDWS.Models {
    public class Designation {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength (100)]
        public string Name { get; set; }

        [MaxLength (100)]
        public string? Code { get; set; }

        public string? Description { get; set; }

    }
}