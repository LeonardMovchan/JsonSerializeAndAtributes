using Bogus;
namespace SerializationAndAtributes
{

    public class Car
    {
        
        public string Name { get; set; }

       
        public decimal Price { get; set; }
        [MyIgnore]
        public int MaxSpeed { get; set; }
        [MyIgnore]
        public string Type { get; set; }
        
        public string Country { get; set; }

        public Car() { }
        public Car(string name, decimal price, string type, string country, int maxSpeed)
        {
            Name = name;
            Price = price;
            Type = type;
            Country = country;
            MaxSpeed = maxSpeed;
        }

   
        public static Car GenereateNewCar()
        {
            var carBogus = new Faker<Car>()

                  .RuleFor(r => r.Name, f => f.Vehicle.Manufacturer().ToString())
                  .RuleFor(r => r.Type, f => f.Vehicle.Model())
                  .RuleFor(r => r.Price, f => f.Finance.Amount())
                  .RuleFor(r => r.Country, f => f.Address.Country())
                  .RuleFor(r => r.MaxSpeed, f => f.Random.Int(60, 400))
                  ;

            return carBogus;
        }

        public override string ToString()
        {
            return $"Manufacturor: {Name}, Type: {Type},Country: {Country}, Price:  {Price}, Max Speed:  {MaxSpeed}km/hr";
        }

    }
}
