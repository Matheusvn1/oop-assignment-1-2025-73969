using System;

namespace oop_assignment_1_2025_73969
{
    public class RentalCar
    {
        public string manufacturer;
        public string model;
        public string bodyType;  
        public string registrationNumber;
        public double price;
        public bool borrowed;

        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price, bool borrowed)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.bodyType = bodyType;
            this.registrationNumber = registrationNumber;
            this.price = price;
            this.borrowed = borrowed;
        }

        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.bodyType = bodyType;
            this.registrationNumber = registrationNumber;
            this.price = price;
            this.borrowed = false;
        }

        public RentalCar(string manufacturer, string model, string bodyType)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.bodyType = bodyType;
            this.registrationNumber = "Pending";
            this.price = 50.00;
            this.borrowed = false;
        }

        public void borrow()
        {
            if (!borrowed)
            {
                borrowed = true;
                Console.WriteLine($"SUCCESS: {manufacturer} {model} has been borrowed!\n");
            }
            else
            {
                Console.WriteLine($"ERROR: {manufacturer} {model} is already on loan.\n");
            }
        }

        public void returnRentalCar()
        {
            borrowed = false;
            Console.WriteLine($"{manufacturer} {model} has been returned.\n");
        }

        public void changePrice(double newPrice)
        {
            if (newPrice > 0)
            {
                price = newPrice;
                Console.WriteLine($"Price updated successfully to ${price:N2}\n");
            }
            else
            {
                Console.WriteLine("ERROR: Price must be greater than zero.\n");
            }
        }

        public double checkPrice()
        {
            return price;
        }

        public bool checkBorrowed()
        {
            return borrowed;
        }

        public void display()
        {
            Console.WriteLine("------");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Body Type: {bodyType}");
            Console.WriteLine($"Registration Number: {registrationNumber}");
            Console.WriteLine($"Price per Day: £{price:N2}");
            Console.WriteLine($"Borrowed: {(borrowed ? "Yes" : "No")}");
        }
    }
}
