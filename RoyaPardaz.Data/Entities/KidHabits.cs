using System;
using System.Collections.Generic;
using System.Text;

namespace RoyaPardaz.Data.Entities
{
    public class KidHabits : BaseEntity
    {
        public HabitGroup HabitGroup { get; set; }
        public string Habit { get; set; }
    }
}
