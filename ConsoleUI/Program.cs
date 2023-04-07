using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //dataacces erişim nesneleri
            var carDal = new EfCarDal();
            var userDal = new EfUserDal();
            var rentalDal = new EfRentalDal();

            //Varlığımız üzerinde işlemleri yapmamızı sağlayan nesneler.
            CarManager carManager = new CarManager(carDal);
            UserManager userManager = new UserManager(userDal);
            RentalManager rentalManager = new RentalManager(rentalDal);


            rentalManager.Add(new Rental { CustomerId = 1, CarId = 1, RentDate = DateTime.Now, ReturnDate = null });

            Console.WriteLine("------- USERS -------");
            foreach (var user in userManager.GetAllUsers().Data)
            {
                Console.WriteLine(user.FirstName + " : " + user.Email);
            }
            
            var r = rentalManager.GetAll();


            if (r.Success)
            {
                foreach (var item in r.Data)
                {
                    Console.WriteLine(item.CarId + " : " + item.RentDate);
                }
            }
            else
            {
                Console.WriteLine(rentalManager.GetAll().Message);
            }
        }
    }
}
