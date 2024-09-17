using PhoneBook.Models;

namespace PhoneBook.Services
{
    public interface IFileService
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task<Contact> RemoveContactAsync(Contact contact);
        Task<List<Contact>> SelectAllContactAsync();
        Task<Contact> UpdateContactAsync(Contact contact);

    }
}