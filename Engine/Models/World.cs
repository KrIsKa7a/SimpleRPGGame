using System.Collections.Generic;
using System.Linq;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations;

        public World()
        {
            this.locations = new List<Location>();
        }

        public Location LocationAt(int x, int y)
        {
            return this.locations
                .FirstOrDefault(l => l.XCoordinate == x && l.YCoordinate == y);
        }

        internal void AddLocation(int x, int y, string name, string description, string imageName)
        {
            Location location = new Location(x, y, name, description, imageName);

            this.locations.Add(location);
        }
    }
}
