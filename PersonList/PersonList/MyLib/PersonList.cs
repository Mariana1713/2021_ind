/*
Student
 */
using System;
using System.Text;

namespace PersonList
{
	
	public class PersonList
	{
		private PersonListItem first;
		private PersonListItem last;
		private uint numElements;
		public uint Count
		{
			get
			{
				return numElements;
			}
		}
		public PersonList()
		{
			numElements=0;
			first=last=null;
		}
		public PersonList(Person p)
		{
			first=new PersonListItem(p);
			last=first;
			++numElements;
		}
		
		public void AddPerson(Person p)
		{
			if(first==null)
			{
				first=new PersonListItem(p);
			    last=first;
			}
			else
			{
				last.next=new PersonListItem(p);
				last=last.next;
			}
			++numElements;
		}
		
		public override string ToString()
		{
			StringBuilder strB=new StringBuilder(100);
			PersonListItem item=first;
			while(item!=null)
			{
				strB.AppendLine("Node: "+item.person.ToString());
				item=item.next;
			}
			return strB.ToString();
		}
		public Person FindPerson(string firstName)
		{
			Person result;
			PersonListItem item=first;
			while(item!=null)
			{
				if(name==item.person.name)
				{
					return item.person;
					//break;
				}
				item=item.next;
			}
			throw new System.NullReferenceException();
		}
		public PersonList FindAllPerson(string name)
		{
			PersonList list=new PersonList();
			PersonListItem item=first;
			while(item!=null)
			{
				if(name==item.person.name)
				{
					list.AddPerson(item.person);
				}
				item=item.next;
			}
			return list;
		}
		
	}
}
