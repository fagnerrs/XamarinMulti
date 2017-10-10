using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fwit.Genone.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

		private IEnumerable<Person> friends;

		private IEnumerable<Person> friendshipRequests;

		public Person(long id, string name)
        {
            this.Name = name;
            this.Id = id;
        }

		public IEnumerable<Person> FriendshipRequests
		{
			get { return friendshipRequests; }
			set { friendshipRequests = value; }
		}

        public IEnumerable<Person> Friends
        {
            get { return friends;  }
            set { friends = value; }
        }

        public async Task RequestFriendship(Person person){
            await Task.FromResult(0);
        }

		public async Task RemoveFriend(Person person)
		{
			await Task.FromResult(0);
		}
    }
}
