using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hackathonTeamSearch.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(6)]
        public string Name { get; set; }

    }
}
