using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class ContactStoreExeption : Exception
    {
        public ContactStoreExeption(Exception innerExeption, string message): base(message, innerExeption)
        {
            
        }



    }
}
