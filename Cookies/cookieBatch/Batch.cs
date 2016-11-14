using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
        class batch
        {

            private List<cookies> cookiebatch;
            public List<cookies> cookie
            {
                get
                {
                    return cookiebatch;
                }
            }
            public int cookieCount
            {
                get
                {
                    return cookiebatch.Count;
                }
            }
            public batch()
            {
                cookiebatch = new List<cookies>();
            }
            public void createCookies(string Count, string Type, string Shape)
            {
                cookies newcookie = new cookies();
                newcookie.cookieCount = Count;
                newcookie.cookieType = Type;
                newcookie.cookieShape = Shape;

                cookiebatch.Add(newcookie);
            }
        }
    }
