using Mehmonxona.Data.Contexts;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Rooms;
using Mehmonxona.Service.Services;
using System;
using System.Threading.Tasks;

namespace Mehmonxona.Tests
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //create
            
            var context = new MehmonxonaDbContext();
            var roomService = new RoomService(context);

            //var room1 = new RoomForCreationDto()
            //{
            //    Sign = "1.1",
            //    Type = RoomType.Ecanom
            //};
            //await roomService.CreateAsync(room1);


            //Update

            var roomForUpdate = new RoomForCreationDto()
            {
                Sign = "1000000",
                Status = RoomStatus.Busy,
                Type = RoomType.Business
            };

            await roomService.UpdateAsync(2, roomForUpdate);




        }
    }
}
