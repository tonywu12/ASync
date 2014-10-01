//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ASync
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Main program
    /// </summary>
    class Program
    {
        /// <summary>
        /// random rand
        /// </summary>
        private static Random rand = new Random();

        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">arguments list </param>
        private static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            Task<int> carTask = Task.Factory.StartNew<int>(BookCar);
            Task<int> hotelTask = Task.Factory.StartNew<int>(BookHotel);
            Task<int> planeTask = Task.Factory.StartNew<int>(BookPlane);

            Task hotelFollowupTask = hotelTask.ContinueWith(
                taskPrev => Console.WriteLine("Adding view note for booking {0}", taskPrev.Result));
            hotelFollowupTask.Wait();

           // Task.WaitAll(carTask, hotelTask, planeTask);
            Console.WriteLine(
                "Finished booking : carId = {0} , hotelId={1} , planeId = {2} ",
                carTask.Result, 
                hotelTask.Result, 
                planeTask.Result);

            // int carId = BookCar();
            // int hotelId = BookHotel();
            // int planeId = BookPlane();
            Console.WriteLine("Finished in {0} sec. ", sw.ElapsedMilliseconds / 1000.0);
        }

        /// <summary>
        /// Booking plane 
        /// </summary>
        /// <returns>return integer</returns>
        private static int BookPlane()
        {
            Console.WriteLine("Booking Plane...");
            Thread.Sleep(5000);
            Console.WriteLine("Done booking Plane.");
            return rand.Next(100);
        }

        /// <summary>
        /// Booking hotel
        /// </summary>
        /// <returns>return integer</returns>
        private static int BookHotel()
        {
            Console.WriteLine("Booking Hotel...");
            Thread.Sleep(8000);
            Console.WriteLine("Done booking Hotel.");
            return rand.Next(100);
        }

        /// <summary>
        /// booking car
        /// </summary>
        /// <returns>return integer</returns>
        private static int BookCar()
        {
            Console.WriteLine("Booking Car...");
            Thread.Sleep(3000);
            Console.WriteLine("Done booking Car.");
            return rand.Next(100);
        }
    }
}
