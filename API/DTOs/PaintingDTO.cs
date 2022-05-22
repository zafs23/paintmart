namespace API.DTOs
{
    public class PaintingDTO
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public bool IsProfile { get; set; }

        public DateTime PaintingCreateDate { get; set; }
        
    }
}