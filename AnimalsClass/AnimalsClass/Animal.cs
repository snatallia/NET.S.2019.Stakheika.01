namespace AnimalClass
{
    /// <summary>
    /// Animal class - essence aminal
    /// animal can eat, walk, growl
    /// </summary>
    public class Animal
    {
        public string Kind { get; set; }

        public Animal(string kind)
        {
            Kind = kind;
        }

        public string Eat()
        {
            return $"Animal {Kind} eats.";
        }

        public string Walk()
        {
            return $"Animal {Kind} walks.";
        }

        public string Growl()
        {
            return $"Animal {Kind} growls.";
        }
    }
}
