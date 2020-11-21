using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests

    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }
        [TestMethod]
        public void VehicleTest()
        {
            Vehicle car = new Vehicle();
            car.TypeOFVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                TypeOFVehicle = VehicleType.Motorcyle, 
                Make = "Honda",
                Model = "civic"
            };
        }
    }
}
