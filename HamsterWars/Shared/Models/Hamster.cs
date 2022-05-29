using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars.Shared.Models
{
    public class Hamster
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]       
        public string Name { get; set; } = String.Empty;
        [Required]
        
        public int Age { get; set; } = 0;
        [Required]
        [MaxLength(40)]
        public string FavFood { get; set; } = String.Empty;
        [Required]
        [MaxLength(40)]
        public string Loves { get; set; } = String.Empty;
        
        public string ImgName { get; set; } = String.Empty;
        
        public int Wins { get; set; } = 0;
       
        public int Losses { get; set; } = 0;
        
        public int Games { get; set; } = 0;

    }
}
