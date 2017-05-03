using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Command
    {
        public List<DomainNotification> Notifications { get; set; }

        public Command()
        {
            Notifications = new List<DomainNotification>();
        }
    }
}
