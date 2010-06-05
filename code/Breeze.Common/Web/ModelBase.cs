using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breeze.Common.Web
{
    public abstract class ModelBase<TUser>
    {
        protected ModelBase(TUser loggedInUser)
        {
            LoggedInUser = loggedInUser;
        }


        public TUser LoggedInUser { get; set; }
    }
}
