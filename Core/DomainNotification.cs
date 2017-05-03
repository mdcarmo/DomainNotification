using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DomainNotification
    {
        public DomainNotification()
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
        }

        public DomainNotification(string key, string value)
        {
            Id = Guid.NewGuid();
            Key = key;
            Value = value;
            Date = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
    }
}
