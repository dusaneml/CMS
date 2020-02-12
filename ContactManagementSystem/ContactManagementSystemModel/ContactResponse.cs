﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManagementSystemModel
{
    public class ContactResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
    }
}
