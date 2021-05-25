/*
Student
 */
using System;

namespace PersonList
{
	public class PersonListItem 
	{
		public Person person {get;set;}
		public PersonListItem next {get;set;}
		public PersonListItem()
		{
			person.number=0;
			person.name="n/d";
			person.group="n/d";
			person.faculty="n/d";
	        person.date="n/d";
		}
		public PersonListItem(byte number,string name,string group , string faculty , srting date)
		{
			person.number=number;
			person.name=name;
			person.group=group;
			person.faculty=faculty;
			person.date=date;


			//next=null;
		}
		public PersonListItem(Person p)
		{
			person=p;
			//next=null;
		}
		
	}
}
