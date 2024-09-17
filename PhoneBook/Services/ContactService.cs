using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.Services
{
    public class ContactService : IContactService
    {


        private FileService fileDb;
        public ContactService(FileService fileService)
        {
            fileDb = fileService;
        }



        public async Task<Contact> AddContactAsync(Contact contact)
        {
            try
            {
                if (contact is null)
                {
                    throw new NullContactExseption(" Аник параметирлар киритилмагани кайта киритинг !!! ");
                }
                return await fileDb.AddContactAsync(contact);
            }
            catch (DbUpdateException ex)
            {
                throw new ContactStoreExeption( ex, " БАза ухлади ёзиб бумайди" );
            }
  

        }

        public Task<Contact> RemoveContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
