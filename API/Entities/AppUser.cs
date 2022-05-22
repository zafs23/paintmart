using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime BirthDate { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set;} = DateTime.Now;

        public DateTime LastActive { get; set; } = DateTime.Now;

        public string PaintingType { get; set; }

        public string Motivation { get; set; }

        public string Interested { get; set; }

        public string PersonalInterests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<Painting> Paintings { get; set; } // 1 to many 

        //public int GetUserAge()
        //{
        //    return BirthDate.CalculateAge();
        //}

        




    }
}