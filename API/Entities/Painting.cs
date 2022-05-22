using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Paintings")]
    public class Painting
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public bool IsProfile { get; set; }

        public String PublicId { get; set; }

        public DateTime PaintingCreateDate { get; set; }

        public AppUser AppUser { get; set; }

        public int AppUserId { get; set; }
     
        

    }
}