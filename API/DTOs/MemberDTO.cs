using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class MemberDTO
    {
        
        public int Id { get; set; }
        public string UserName { get; set; }

        public string ProfilePhotoUrl { get; set; }

        public int Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set;} 

        public DateTime LastActive { get; set; } 

        public string PaintingType { get; set; }

        public string Motivation { get; set; }

        public string Interested { get; set; }

        public string PersonalInterests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<PaintingDTO> Paintings { get; set; }
        
        
    }
}