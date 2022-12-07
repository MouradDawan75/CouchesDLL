using DataAccess.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DLL.Services
{
    public class UserService
    {
        private IContact contactRepository;

        public UserService(IContact contactRepository)
        {
            this.contactRepository = contactRepository;
        }
    }
}
