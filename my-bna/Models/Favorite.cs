using System;

namespace my_bna.Models
{
    public class Favorite
    {
        public int Favorite_Id { get; set; }
        public int User_Id { get; set; }
        public int PlaceId { get; set; }
        public DateTime SavedDate { get; set; }
    }
}