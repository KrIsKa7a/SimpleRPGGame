using System.ComponentModel;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string name;
        private string characterClass;
        private int hitPoints;
        private int xp;
        private int level;
        private int gold;

        public Player(string name, string characterClass, int hitPoints, int xp, int level, int gold)
        {
            this.Name = name;
            this.CharacterClass = characterClass;
            this.HitPoints = hitPoints;
            this.ExperiencePoints = xp;
            this.Level = level;
            this.Gold = gold;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                this.OnPropertyChanged(nameof(this.Name));
            }
        }

        public string CharacterClass 
        {
            get
            {
                return this.characterClass;
            }
            set
            {
                this.characterClass = value;
                this.OnPropertyChanged(nameof(this.CharacterClass));
            }
        }

        public int HitPoints 
        {
            get
            {
                return this.hitPoints;
            }
            set
            {
                this.hitPoints = value;
                this.OnPropertyChanged(nameof(this.HitPoints));
            }
        }

        public int ExperiencePoints 
        {
            get
            {
                return this.xp;
            }
            set
            {
                this.xp = value;
                this.OnPropertyChanged(nameof(this.ExperiencePoints));
            } 
        }

        public int Level 
        { 
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
                this.OnPropertyChanged(nameof(this.Level));
            }
        }

        public int Gold 
        {
            get
            {
                return this.gold;
            }
            set
            {
                this.gold = value;
                this.OnPropertyChanged(nameof(this.Gold));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
