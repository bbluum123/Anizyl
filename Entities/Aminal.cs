namespace Anizyl.Entities
{
    public class Animal
    {
        public int Id {get; set;}
        public required string Name {get;set;}
        public int Age {get;set;}

        public bool Adopted {get; set;}

        public int AnimalTypeId{get; set;}

        public virtual required AnimalType Type{get; set;}
    }
}