using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Location
    {
        public Location(int x, int y, string name, string description, string imageName)
        {
            this.XCoordinate = x;
            this.YCoordinate = y;
            this.Name = name;
            this.Description = description;
            this.ImageName = imageName;
        }

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageName { get; set; }
    }
}
