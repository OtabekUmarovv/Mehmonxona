using AutoMapper;
using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Domain.Entities.Conferences;
using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Domain.Entities.Rooms;
using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.DTOs.Conferences;
using Mehmonxona.Service.DTOs.Employees;
using Mehmonxona.Service.DTOs.Orders;
using Mehmonxona.Service.DTOs.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Room, RoomForCreationDto>();

            CreateMap<Client, ClientForCreationDto>();
            CreateMap<ClientForViewModel, Client>();
            
            CreateMap<Order, OrderForCreationDto>();
            
            CreateMap<Payment, PaymentForCreationDto>();
            
            CreateMap<Employee, EmployeeForCreationDto>();
         
            CreateMap<Conference, ConferenceForCreationDto>();
        }
    }
}
