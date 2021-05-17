using AssignmentQuestionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentQuestionProject.Services
{
    public class UserService : IUserRepo<UserModel>
    {
        private readonly AssginmentContext _context;

        public UserService()
        {

        }
        public UserService(AssginmentContext context)
        {
            _context = context;
        }
        public bool Login(UserModel t)
        {
            try
            {
                UserModel user = _context.users.SingleOrDefault(u => u.Username == t.Username);
                if (user.Password == t.Password)
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
            return false;
        }

        public bool Register(UserModel t)
        {
            try
            {
                _context.users.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
