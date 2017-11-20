using System;
using System.Collections.Generic;
using System.Linq;

using GreenFinchAssignment.DataStructure;
using GreenFinchAssignment.Web.Models;
using GreenFinchAssignment.Web.Repository;
namespace GreenFinchAssignment.Web.Services
{
    public class SubscriberRepository : ISubscriberRepository
    {
        private readonly GreenFinchContext _context;

        public SubscriberRepository(GreenFinchContext context)
        {
            _context = context;
        }
        public IEnumerable<SubscribingUserViewModel> All => throw new NotImplementedException();

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public SubscribingUserViewModel Find(string id)
        {
            throw new NotImplementedException();
        }

        public SubscribingUserViewModel GetUserByEmail(string email)
        {
            var user = _context.SubscribingUser.Where(e => e.Email == email).FirstOrDefault();
            return user;

        }

        public async void Insert(SubscribingUserViewModel item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
        }



        public void Update(SubscribingUserViewModel item)
        {
            throw new NotImplementedException();
        }
    }
}
