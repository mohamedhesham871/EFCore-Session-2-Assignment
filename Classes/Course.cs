using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_2_Assignment.Classes
{
    internal class Course
    {

        //USing Annotation
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  ID { get; set; }
        [Column(TypeName = "Varchar")]
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(300)]
        public string? Description { get; set; }
        [Range(1,10)]
        public int Duration { get; set; }

        public int  TOPic_ID{ get; set; }

    }
}
