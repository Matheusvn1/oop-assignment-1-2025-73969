using System;

namespace oop_assignment_1_2025_73969
{
    internal class RentalCarDriver
    {
        public static void Run(string[] args)
        {
            RentalCar carro1 = new RentalCar("Toyota", "Corolla", "Hatchback", "12dl3221", 90.50, false);
            RentalCar carro2 = new RentalCar("Nissan", "Qashqai", "Normal", "162d203", 120.00);
            RentalCar carro3 = new RentalCar("Fiat", "500", "Normal", "02d789", 60.00);
            RentalCar carro4 = new RentalCar("Audi", "A6", "HatchBack", "09d890", 150.50, true);

            carro1.display();
            carro2.display();
            carro3.display();
            carro4.display();
        }
    }
}
