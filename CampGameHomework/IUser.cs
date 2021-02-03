using System;
using System.Collections.Generic;
using System.Text;

namespace CampGameHomework
{
    interface IUser
    {
        int Id { get; set; }
        long NationalityId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int BirthYear { get; set; }
    }
}
