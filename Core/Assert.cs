using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Assert
    {
        public static DomainNotification Lenght(string text, int min, int max, string key, string value)
        {
            if (text.Length < min || text.Length > max)
                return new DomainNotification(key, value);

            return null;
        }        
    }
}
