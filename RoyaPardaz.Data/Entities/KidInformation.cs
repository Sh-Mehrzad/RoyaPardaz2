using System;
using System.Collections.Generic;
using System.Text;

namespace RoyaPardaz.Data.Entities
{
    public class KidInformation : BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public char Gender { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthDateShamsi { get; set; }
        public Country BornCountry { get; set; }
        public City BornCity { get; set; }
        public string NationalCode { get; set; }
        public DateTime InviteDate { get; set; }
        public DateTime ResponseDate { get; set; }
        public bool AcceptResponse { get; set; }
    }
}
