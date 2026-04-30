namespace FootballCards.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Card
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int OvrRating { get; set; }
        public required string CardImage { get; set; }
        public required string Country { get; set; }
        public bool IsIcon { get; set; }

        [NotMapped]
        public int CountryRank { get; set; }
        [NotMapped]
        public int CountryTotalCount { get; set; }
    }
}
