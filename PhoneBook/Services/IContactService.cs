using PhoneBook.Models;

namespace PhoneBook.Services
{
    public interface IContactService
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task<Contact> UpdateContactAsync(Contact contact);
        Task<Contact> RemoveContactAsync(Contact contact);

    }
}