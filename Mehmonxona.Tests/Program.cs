using Mehmonxona.Data.Contexts;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.DTOs.Rooms;
using Mehmonxona.Service.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Mehmonxona.Tests
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var context = new MehmonxonaDbContext();

            var roomService = new RoomService(context);
            var clientService = new ClientService(context);
            
            //create
            

            //var room1 = new RoomForCreationDto()
            //{
            //    Sign = "1.1",
            //    Type = RoomType.Ecanom
            //};
            //await roomService.CreateAsync(room1);


            //Update

            //var roomForUpdate = new RoomForCreationDto()
            //{
            //    Sign = "1000000",
            //    Status = RoomStatus.Busy,
            //    Type = RoomType.Business
            //};

            //await roomService.UpdateAsync(2, roomForUpdate);

            //var user = new ClientForCreationDto()
            //{
            //    FirstName = "Samid",
            //    LastName = "Dasanbayev",
            //    Email = "Dastanbayev@gmail.com",
            //    Gender = (Gender)1,
            //    Passport = "987456",
            //    Password = "asdf2468",
            //    Phone = "97 012 34 56"

            //};

            //await clientService.CreateAsync(user);
            var clients = (await clientService.GetAllAsync()).ToList();
            foreach(var client in clients)
                Console.WriteLine(client.FirstName);
        }
    }
}
