using System.Collections.Generic;
using Fwit.Genone.Domain.ValueObjects;

namespace Fwit.Genone.Domain.Entities
{
    public class Person
    {
        private IEnumerable<Person> friends;

        public IEnumerable<Person> Friends
        {
            get { return friends;  }
            set { friends = value; }
        }
    }
}
