namespace EU4RandomCountryPicker.Structs
{
    public struct Country
    {
        public string Name;
        public string Tag;
        public string GeneralLocation;
        public string Exclusive;

        public Country(string name, 
                        string tag, 
                        string generalLocation, 
                        string exclusive)
        {
            Name = name;
            Tag = tag;
            GeneralLocation = generalLocation;
            Exclusive = exclusive;
        }

        public override string ToString()
        {
            return $"Name:{Name}, \nTag: {Tag}, \nRegion: {GeneralLocation}\n\n{Exclusive.Remove(0, 1)}";
        }
    }
}
