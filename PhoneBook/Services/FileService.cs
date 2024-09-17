using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PhoneBook.Models;
using STX.EFxceptions.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public class FileService : EFxceptionsContext, IFileService
    {
        private IConfiguration configuration;

        public FileService()
        {
            this.Database.Migrate();
        }
        public DbSet<Contact> contacts { get; set; }
        public async Task<Contact> AddContactAsync(Contact contact)
        {
            FileService fileService = new FileService();
            await fileService.contacts.AddAsync(contact);
            await fileService.SaveChangesAsync();

            return contact;
        }

        public async Task<Contact> UpdateContactAsync(Contact contact)
        {
            FileService fileService = new FileService();
            fileService.contacts.Update(contact);
            await fileService.SaveChangesAsync();

            return contact;
        }

        public async Task<List<Contact>> SelectAllContactAsync()
        {
            FileService files = new FileService();
            return await files.contacts.ToListAsync();
        }

        public async Task<Contact> RemoveContactAsync(Contact contact)
        {
            FileService fileService = new FileService();
            Contact contact1 = new Contact();

            contact1.Id = Guid.Parse("743a033d-9632-4bf7-8ea9-a5fd9ab750c2");

            fileService.contacts.Remove(contact);
            await fileService.SaveChangesAsync();

            return contact1;
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? config = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PhoneBookDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(config);
        }
    }
}
