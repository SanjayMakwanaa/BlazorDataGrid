using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudblazorDemo.CRUD.Data
{
        public class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
/*
            public int StateId { get; set; }
            public State State { get; set; }
            public int CityId { get; set; }
            public City City { get; set; }*/
        }
}
