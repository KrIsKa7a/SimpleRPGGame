using System.ComponentModel;

using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private WorldFactory worldFactory;

        private Location currentLocation;

        public GameSession()
        {
            this.worldFactory = new WorldFactory();

            this.CurrentPlayer = new Player("Kristiyan The Great",
                "Magician", 25, 10, 1, 1500);
            this.CurrentWorld = worldFactory.CreateWorld();
            this.CurrentLocation = this.CurrentWorld.LocationAt(0,0);
        }

        public Player CurrentPlayer { get; set; }

        public World CurrentWorld { get; set; }

        public Location CurrentLocation 
        {
            get
            {
                return this.currentLocation;
            }
            private set
            {
                this.currentLocation = value;

                this.OnPropertyChanged(nameof(this.CurrentLocation));
                this.OnPropertyChanged(nameof(this.HasLocationToNorth));
                this.OnPropertyChanged(nameof(this.HasLocationToWest));
                this.OnPropertyChanged(nameof(this.HasLocationToSouth));
                this.OnPropertyChanged(nameof(this.HasLocationToEast));
            }
        }

        public bool HasLocationToNorth =>
            this.CurrentWorld
                .LocationAt(this.CurrentLocation.XCoordinate, this.CurrentLocation.YCoordinate + 1) != null;

        public bool HasLocationToWest =>
            this.CurrentWorld
                .LocationAt(this.CurrentLocation.XCoordinate - 1, this.CurrentLocation.YCoordinate) != null;

        public bool HasLocationToSouth =>
            this.CurrentWorld
                .LocationAt(this.CurrentLocation.XCoordinate, this.CurrentLocation.YCoordinate - 1) != null;

        public bool HasLocationToEast =>
            this.CurrentWorld
                .LocationAt(this.CurrentLocation.XCoordinate + 1, this.CurrentLocation.YCoordinate) != null;

        public void MoveNorth()
        {
            this.CurrentLocation = this.CurrentWorld
                .LocationAt(this.CurrentLocation.XCoordinate, this.CurrentLocation.YCoordinate + 1);
        }

        public void MoveWest()
        {
            this.CurrentLocation = this.CurrentWorld
                .LocationAt(this.CurrentLocation.XCoordinate - 1, this.CurrentLocation.YCoordinate);
        }

        public void MoveSouth()
        {
            this.CurrentLocation = this.CurrentWorld
                .LocationAt(this.CurrentLocation.XCoordinate, this.CurrentLocation.YCoordinate - 1);
        }

        public void MoveEast()
        {
            this.CurrentLocation = this.CurrentWorld
                .LocationAt(this.CurrentLocation.XCoordinate + 1, this.CurrentLocation.YCoordinate);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
