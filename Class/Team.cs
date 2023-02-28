using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKU_ESport.Class
{
    public class Team
    {
        public string TeamName { get; set; }
        public List<Player> TeamMembers { get; set; }
        public Team(string TeamName, List<Player> TeamMembers)
        {
            this.TeamName = TeamName;
            this.TeamMembers = TeamMembers;
        }
    }
}
