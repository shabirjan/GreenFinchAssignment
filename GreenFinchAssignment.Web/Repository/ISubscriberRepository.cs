using System;
using System.Collections.Generic;

using GreenFinchAssignment.Web.Models;

namespace GreenFinchAssignment.Web.Repository
{
    public interface ISubscriberRepository
    {
        SubscribingUserViewModel GetUserByEmail(string email);
        IEnumerable<SubscribingUserViewModel> All { get; }
        SubscribingUserViewModel Find(string id);
        void Insert(SubscribingUserViewModel item);
        void Update(SubscribingUserViewModel item);
        void Delete(string id);
    }
}
