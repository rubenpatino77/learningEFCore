using System;
namespace learningEFCore.Models
{
    public partial class Customer
    {
        public string FirstLast
        {
            get => $"{FirstName} {LastName}";
        }
    }
}

