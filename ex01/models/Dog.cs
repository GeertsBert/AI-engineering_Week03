namespace Howest.AiDriven.Ex01.Models
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public override void Describe()
        {
            Console.WriteLine($"This is a {Breed} dog named {Name} who is {Age} years old");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}