using CardWars.Client.Data;
using CardWars.Client.Data.Skills;
using CardWars.Client.Data.Skills.Debuffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars.Client.Managers
{
    public class GameStateManager
    {
        public Player GetPlayer()
        {
            return new Player
            {
                Id = Guid.NewGuid(),
                UserName = "Player 1",
                Units = new List<Unit>
                {
                    new Unit
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mihael",
                        Element = Element.Fire,
                        Grade = 3,
                        HitPoints = 300,
                        Attack = 100,
                        Defense = 100,
                        Speed = 100,
                        Level = 1,
                        Skill1 = new Skill
                        {
                            Id = Guid.NewGuid(),
                            Element = Element.Fire,
                            Mode = SkillMode.Active,
                            Name = "God Flames",
                            Description = "Burns the enemy with a powerful flame.",
                            Target = SkillTarget.SingleEnemy,
                            Effects = new List<SkillEffect>
                            {
                                new DotEffect
                                {
                                    Target = SkillTarget.SingleEnemy
                                }
                            }
                        },
                        Skill2 = new Skill(),
                        Skill3 = new Skill(),
                        Skill4 = new Skill()
                    }
                }
            };
        }
    }
}
