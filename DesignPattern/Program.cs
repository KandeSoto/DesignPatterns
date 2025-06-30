
//using DesignPattern.Singleton;

//var log = Log.Instance;
//log.Save("a");
//log.Save("b");

//var a = Singleton.Instance;
//var b = Singleton.Instance;

//Console.WriteLine(a == b);

//using DesignPattern.Factory;

//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//SaleFactory internetSaleFactory = new InterntSaleFactory(2);

//ISale sale1 = storeSaleFactory.GetSale();
//sale1.Sell(15);

//ISale sale2 = internetSaleFactory.GetSale();
//sale2.Sell(15);

//using DesignPattern.DependencyInjection;

//var beer = new Beer("CaosFee", "IPA");
//var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
//drinkWithBeer.build();

//using DesignPattern.Models;
//using DesignPattern.Repository;

//using var context = new DesignPatternsContext();
//var beerRepository = new BeerRepository(context);

//var beer = new Beer();
//beer.Name = "Corona";
//beer.Style = "Pilsner";

//beerRepository.Add(beer);
//beerRepository.Save();

//foreach (var item in beerRepository.Get())
//{
//    Console.WriteLine(item.Name);
//}

//using DesignPattern.Models;
//using DesignPattern.Repository;

//using var context = new DesignPatternsContext();
//var beerRepository = new Repository<Beer>(context);
////var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };
////beerRepository.Add(beer);
//beerRepository.Delete(4);
//beerRepository.Save();

//foreach (var b in beerRepository.Get())
//{
//    Console.WriteLine($"{b.BeerId} {b.Name}");
//}

//var brandRepository = new Repository<Brand>(context);
//var brand = new Brand();
//brand.Name = "Fuller";
//brandRepository.Add(brand);
//brandRepository.Save();

//foreach (var br in brandRepository.Get())
//{
//    Console.WriteLine(br.Name);
//}

//using DesignPattern.Models;
//using DesignPattern.Repository;
//using DesignPattern.UnitOfWork;

//using var context = new DesignPatternsContext();

//var unitOfWork = new UnitOfWork(context);

//var beers = unitOfWork.Beers;
//var beer = new Beer
//{
//    Name = "fuller",
//    Style = "Porter"
//};

//beers.Add(beer);

//var brands = unitOfWork.Brands;
//var brand = new Brand()
//{
//    Name = "Indio",
//};

//brands.Add(brand);

//unitOfWork.Save();

//using DesignPattern.Strategy;

//var context = new Context(new CarStrategy());
//context.Run();
//context.Strategy = new MotoStrategy();
//context.Run();
//context.Strategy = new BicycleStrategy();
//context.Run();

//using DesignPattern.Builder;

//var builder = new PreparedAlcoholicDrinkConcreteBuilder();
//var barmanDirector = new BarmanDirector(builder);

//barmanDirector.PreparedPiñaColada();

//var preparedDrink = builder.GetPreparedDrink();

//Console.WriteLine(preparedDrink.Result);

using DesignPattern.State;

var customerContext = new CustomerContext();
Console.WriteLine(customerContext.GetState());
customerContext.Request(100);
Console.WriteLine(customerContext.GetState());

customerContext.Request(50);
Console.WriteLine(customerContext.GetState());

customerContext.Request(100);
Console.WriteLine(customerContext.GetState());

customerContext.Request(50);
Console.WriteLine(customerContext.GetState());

customerContext.Request(50);
Console.WriteLine(customerContext.GetState());