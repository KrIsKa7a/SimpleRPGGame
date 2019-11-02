using System.IO;

using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World world = new World();

            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "/../../../Engine/Images/Locations";

            world.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them.",
                $"{currentPath}/Field.png");

            world.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                $"{currentPath}/Farmhouse.png");

            world.AddLocation(0, -1, "Home",
                "This is your home",
                $"{currentPath}/Home.png");

            world.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                $"{currentPath}/shop.png");

            world.AddLocation(0, 0, "Town square",
                "You see a fountain here.",
                $"{currentPath}/TownSquare.png");

            world.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                $"{currentPath}/TownGate.png");

            world.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
                $"{currentPath}/forest.png");

            world.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                $"{currentPath}/Hut.png");

            world.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                $"{currentPath}/HerbsGarden.png");

            return world;
        }
    }
}
