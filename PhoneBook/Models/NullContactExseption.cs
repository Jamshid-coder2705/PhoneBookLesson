using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class NullContactExseption : Exception
    {
        public NullContactExseption(string messege) : base(messege)
        {
            
        }
    }
}
