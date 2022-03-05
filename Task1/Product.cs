namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }
        //Allows to override method with argument type as Object only  
	  	public override bool Equals(object obj)  
	    {
            if (obj == null)
                return false;
            var emp = (Product)obj;  
		  return emp.Name == Name && emp.Price == Price;  
		}
        public override int GetHashCode() => new { Name, Price }.GetHashCode();
    }
}
