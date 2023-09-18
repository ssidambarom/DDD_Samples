// See https://aka.ms/new-console-template for more information

using ddd_sample;

Console.WriteLine("Hello, World!");

var socks = new Product(Guid.NewGuid(), "Socks", new Money(30m, new EuroCurrency()));
var shoe = new Product(Guid.NewGuid(), "Shoe", new Money(22m, new EuroCurrency()));
var pant = new Product(Guid.NewGuid(), "Pants", new Money(15m, new EuroCurrency()));
var pin = new Product(Guid.NewGuid(), "Pin", new Money(30m, new EuroCurrency()));
var rings = new Product(Guid.NewGuid(), "Rings", new Money(100m, new EuroCurrency()));

/* BEGIN MANUALLY*/
var order = new Order(Guid.NewGuid(), DateTime.Now, DateTime.Now.AddDays(2));

order.AddItem(shoe.Id, 2);
order.AddItem(pant.Id, 1);

order.AddItem(socks.Id, 3);
// Adding more Product
order.AddItem(socks.Id, 2);

// Adding Product with negative quantity
// order.AddItem(new Product(Guid.NewGuid(), "Pin", new Money(30m, new EuroCurrency())), -1);


// Adding Product that exceeds Order quantity threshold
//order.AddItem(rings.Id, 12);

/* END MANUALLY*/
