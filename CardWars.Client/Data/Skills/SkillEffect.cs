using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars.Client.Data.Skills
{
    public abstract class SkillEffect
    {
        public SkillTarget Target { get; set; }
    }
}
