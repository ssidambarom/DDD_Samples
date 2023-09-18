// See https://aka.ms/new-console-template for more information

namespace 02_ddd_sample_with_usecases;
Console.WriteLine("Hello, World!");

var socks = new Product(Guid.NewGuid(), "Socks", new Money(30m, new EuroCurrency()));
var shoe = new Product(Guid.NewGuid(), "Shoe", new Money(22m, new EuroCurrency()));
var pant = new Product(Guid.NewGuid(), "Pants", new Money(15m, new EuroCurrency()));
var pin = new Product(Guid.NewGuid(), "Pin", new Money(30m, new EuroCurrency()));
var rings = new Product(Guid.NewGuid(), "Rings", new Money(100m, new EuroCurrency()));

/* BEGIN MANUALLY*/
// var order = new Order(Guid.NewGuid(), DateTime.Now, DateTime.Now.AddDays(2));

// order.AddItem(new Product(Guid.NewGuid(), "Shoe", new Money(22m, new EuroCurrency())), 2);
// order.AddItem(new Product(Guid.NewGuid(), "Pants", new Money(15m, new EuroCurrency())), 1);

// var socks = new Product(Guid.NewGuid(), "Socks", new Money(30m, new EuroCurrency()));

// order.AddItem(socks, 3);
// // Adding more Product
// order.AddItem(socks, 2);

// // Adding Product with negative quantity
// // order.AddItem(new Product(Guid.NewGuid(), "Pin", new Money(30m, new EuroCurrency())), -1);
// // Adding Product that exceeds Order quantity threshold
// order.AddItem(new Product(Guid.NewGuid(), "Rings", new Money(100m, new EuroCurrency())), 12);

/* END MANUALLY*/

/* BEGIN USE CASES*/
var repository = new Repository<Order>();
var createOrderItemsUseCase = new CreateOrderItemsUseCase(repository);

var createdOrder = await createOrderItemsUseCase.Execute(DateTime.Now, DateTime.Now.AddDays(2));

var addOrderItemsUseCase = new AddOrderItemsUseCase(repository);

await addOrderItemsUseCase.Execute(createdOrder.Id,
    new OrderItem(shoe.Id, 2),
    new OrderItem(socks.Id, 2),
    new OrderItem(pant.Id, 1));

// Adding more Product
await addOrderItemsUseCase.Execute(createdOrder.Id,
    new OrderItem(socks.Id, 3));


// Adding Product with negative quantity
// await addOrderItemsUseCase.Execute(createdOrder.Id,
//     new OrderItem(pin, -2));

// Adding Product that exceeds Order quantity threshold
// await addOrderItemsUseCase.Execute(createdOrder.Id,
//     new OrderItem(rings, 12));

/* END USE CASES*/
