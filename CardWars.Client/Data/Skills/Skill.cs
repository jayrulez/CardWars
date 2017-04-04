using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars.Client.Data.Skills
{
    public class Skill
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Element Element { get; set; }

        public SkillMode Mode { get; set; }

        public SkillTarget Target { get; set; }

        public IList<SkillEffect> Effects { get; set; }
    }
}
