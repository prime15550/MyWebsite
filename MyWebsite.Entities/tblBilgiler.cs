using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebsite.Entities
{
    [Table("tblBilgiler")]
    public  class tblBilgiler
  {
      [Required]
       public int id { get; set; }
       [Required]
        public string linkedinUrl { get; set; }
        [Required]
        public string instagramUrl { get; set; }
        [Required]
        public string githubUrl { get; set; }
        [Required]
        public string cvUrl { get; set; }
        [Required]
        public string mailUrl { get; set; }
        [Required]
        public string cgpa { get; set; }
        [Required]
        public string ecpa { get; set; }

    }
}
