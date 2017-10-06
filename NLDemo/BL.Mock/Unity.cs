using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mock
{
    public class Unity
    {
        DAL.Interfaces.IGeneralRepository<DAL.Interfaces.IUser> _userRepository;

        public Unity(DAL.Interfaces.IGeneralRepository<DAL.Interfaces.IUser> userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(BL.Interfaces.IUser user)
        {
            _userRepository.Add(new DAL.Mock.MockUser() { FirstName = user.FirstName, LastName = user.LastName });
            _userRepository.SaveChanges();
        }
    }
}
