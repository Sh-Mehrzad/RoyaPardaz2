namespace RoyaPardaz.Data.Entities
{
    public class ContactsInfo : BaseEntity
    {
        public Country Country { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string FatherPhone { get; set; }
        public string MotherPhone { get; set; }
        public KidInformation Kid { get; set; }
    }
}
