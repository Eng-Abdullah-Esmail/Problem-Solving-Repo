using System;
using System.Collections.Generic;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool IsRented { get; set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        IsRented = false;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Make: {0}, Model: {1}, Year: {2}, IsRented: {3}", Make, Model, Year, IsRented);
    }
}

class RentalSystem
{
    private List<Car> cars;

    public RentalSystem()
    {
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
        Console.WriteLine("{0} {1} {2} has been added to the rental system.", car.Make, car.Model, car.Year);
    }

    public void RemoveCar(Car car)
    {
        cars.Remove(car);
        Console.WriteLine("{0} {1} {2} has been removed from the rental system.", car.Make, car.Model, car.Year);
    }

    public void RentCar(Car car)
    {
        if (!car.IsRented)
        {
            car.IsRented = true;
            Console.WriteLine("{0} {1} {2} has been rented.", car.Make, car.Model, car.Year);
        }
        else
        {
            Console.WriteLine("{0} {1} {2} is already rented.", car.Make, car.Model, car.Year);
        }
    }

    public void ReturnCar(Car car)
    {
        if (car.IsRented)
        {
            car.IsRented = false;
            Console.WriteLine("{0} {1} {2} has been returned.", car.Make, car.Model, car.Year);
        }
        else
        {
            Console.WriteLine("{0} {1} {2} is not currently rented.", car.Make, car.Model, car.Year);
        }
    }

    public List<Car> ViewAvailability()
    {
        List<Car> availableCars = new List<Car>();
        foreach (Car car in cars)
        {
            if (!car.IsRented)
            {
                availableCars.Add(car);
            }
        }
        return availableCars;
    }

    public void PrintCars()
    {
        Console.WriteLine("Car Details:");
        foreach (Car car in cars)
        {
            car.PrintDetails();
        }
    }

    public void PrintAvailabilityReport()
    {
        Console.WriteLine("Car Availability Report:");
        Console.WriteLine("-------------------------");

        List<Car> availableCars = ViewAvailability();
        if (availableCars.Count == 0)
        {
            Console.WriteLine("No cars are currently available for rent.");
        }
        else
        {
            foreach (Car car in availableCars)
            {
                Console.WriteLine("{0} {1} {2} is available for rent.", car.Make, car.Model, car.Year);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new rental system object
        RentalSystem rentalSystem = new RentalSystem();

        // Add some cars to the system
        rentalSystem.AddCar(new Car("Ford", "Mustang", 2019));
        rentalSystem.AddCar(new Car("Chevrolet", "Corvette", 2021));
        rentalSystem.AddCar(new Car("Dodge", "Challenger", 2020));

        // Print the car details
        rentalSystem.PrintCars();

        // Rent a car
        Car carToRent = rentalSystem.ViewAvailability()[0];
        rentalSystem.RentCar(carToRent);

        // Print the availability report
        rentalSystem.PrintAvailabilityReport();

        // Return the rented car
        rentalSystem.ReturnCar(carToRent);

        // Print the availability report again
        rentalSystem.PrintAvailabilityReport();

        // Remove a car and print the modified car details
        Car carToRemove = rentalSystem.ViewAvailability()[1];
        rentalSystem.RemoveCar(carToRemove);
        rentalSystem.PrintCars();

        Console.ReadKey();
    }
}