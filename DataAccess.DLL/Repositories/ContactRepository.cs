using Core.DLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DLL.Repositories
{
    public class ContactRepository : IContact
    {
        private MyContext context;

        public ContactRepository(MyContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(ContactDTO contactDTO)
        {
            throw new NotImplementedException();
        }

        public void Update(ContactDTO contactDTO)
        {
            throw new NotImplementedException();
        }
    }
}
