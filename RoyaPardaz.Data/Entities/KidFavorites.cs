namespace RoyaPardaz.Data.Entities
{
    public class KidFavorites : BaseEntity
    {
        public Favorites Favorite { get; set; }
        public FavoritesProp FavoriteProp { get; set; }
        public KidInformation Kid { get; set; }
        public short Priority { get; set; }
    }
}
