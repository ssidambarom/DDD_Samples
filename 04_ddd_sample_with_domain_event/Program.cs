// See https://aka.ms/new-console-template for more information

using ddd_sample_04_with_domain_event;

Console.WriteLine("Hello, World!");

var socks = new Product(Guid.NewGuid(), "Socks", new Money(30m, new EuroCurrency()));
var shoe = new Product(Guid.NewGuid(), "Shoe", new Money(22m, new EuroCurrency()));
var pant = new Product(Guid.NewGuid(), "Pants", new Money(15m, new EuroCurrency()));
var pin = new Product(Guid.NewGuid(), "Pin", new Money(30m, new EuroCurrency()));
var rings = new Product(Guid.NewGuid(), "Rings", new Money(100m, new EuroCurrency()));

var repository = new Repository<Order>();
var createOrderItemsUseCase = new CreateOrderItemsUseCase(repository);

var createdOrder = await createOrderItemsUseCase.Execute(DateTime.Now, DateTime.Now.AddDays(2));

var addOrderItemsUseCase = new AddOrderItemsUseCase(repository);

await addOrderItemsUseCase.Execute(createdOrder.Id,
    OrderItem.Create(shoe.Id, 2),
    OrderItem.Create(socks.Id, 2),
    OrderItem.Create(pant.Id, 1));

// Adding more Product
await addOrderItemsUseCase.Execute(createdOrder.Id,
    OrderItem.Create(socks.Id, 3));


// Adding Product with negative quantity
// await addOrderItemsUseCase.Execute(createdOrder.Id,
//     new OrderItem(pin, -2));

// Adding Product that exceeds Order quantity threshold
// await addOrderItemsUseCase.Execute(createdOrder.Id,
//     new OrderItem(rings, 12));
