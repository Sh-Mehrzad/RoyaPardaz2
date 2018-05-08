namespace RoyaPardaz.Data.Entities
{
    public class KidOriginality : BaseEntity
    {
        public KidInformation Kid { get; set; }
        public Originality Originality { get; set; }
    }
}
