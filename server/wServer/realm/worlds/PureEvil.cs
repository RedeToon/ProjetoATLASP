using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wServer.realm.worlds
{
    public class PureEvil : World
    {
        public PureEvil()
        {
            Name = "Pure Evil";
            ClientWorldName = "Pure Evil";
            Background = 0;
            AllowTeleport = false;
            Difficulty = 5;
        }

        protected override void Init()
        {
            LoadMap("wServer.realm.worlds.maps.Pure Evil.jm", MapType.Json);
        }
    }
}