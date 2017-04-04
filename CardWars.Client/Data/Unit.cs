using CardWars.Client.Data.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars.Client.Data
{
    public class Unit
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public UnitType Type { get; set; }

        public Element Element { get; set; }

        public int Grade { get; set; }

        public int Level { get; set; }

        public int HitPoints { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Speed { get; set; }

        public Skill Skill1 { get; set; }

        public Skill Skill2 { get; set; }

        public Skill Skill3 { get; set; }

        public Skill Skill4 { get; set; }
    }
}
