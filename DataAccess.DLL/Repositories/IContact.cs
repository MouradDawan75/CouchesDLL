using Core.DLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DLL.Repositories
{
    public interface IContact
    {
        List<ContactDTO> GetAll();
        void Insert(ContactDTO contactDTO);
        void Update(ContactDTO contactDTO);
        void Delete(int id);
    }
}
