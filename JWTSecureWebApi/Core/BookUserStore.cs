using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTSecureWebApi.Core
{
    public class BookUserStore: UserStore<IdentityUser>
    {
        public BookUserStore(): base(new BooksContext())
        {

        }
    }
}