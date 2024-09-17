using PhoneBook.Models;
using PhoneBook.Services;

namespace PhoneBook
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            FileService fileService = new FileService();
            IContactService contactService = new ContactService(fileService);
            Contact contact = new Contact();

            contact.Id = Guid.NewGuid();
            contact.Name = "wqweqwe";
            contact.Phone = "1234567890";

            await contactService.AddContactAsync(contact);

        }

        

        
    }
}
