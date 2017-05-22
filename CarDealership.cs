using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;

  public Car (string makeModel, int carPrice, int carMiles)
  {
    _makeModel = makeModel;
    _price = carPrice;
    _miles = carMiles;
  }

  public void SetMakeModel(string makeModel)
  {
    _makeModel = makeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetPrice(int carPrice)
  {
    _price = carPrice;
  }
  public int GetCarPrice()
  {
    return _price;
  }

  public void SetMiles(int carMiles)
  {
    _miles = carMiles;
  }
  public int GetCarMiles()
  {
    return _miles;
  }
}

public class Program
{
  public static void Main()
  {


    Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    Car ford = new Car("2011 Ford F450", 55995, 14241);
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string intMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(intMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if ((automobile.GetCarPrice() < maxPrice) && (automobile.GetCarMiles() < maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("No cars meet your search requirements!");
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetCarPrice());
      Console.WriteLine(automobile.GetCarMiles());
    }

  }
}
