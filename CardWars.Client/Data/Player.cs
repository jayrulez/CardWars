using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars.Client.Data
{
    public class Player
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }

        public IList<Unit> Units { get; set; }

        public Player()
        {
            Units = new List<Unit>();
        }
    }
}
