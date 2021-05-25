/*
Student
 */
using System;

namespace PersonList
{
	
	public class /*struct*/ Person : IEquatable<Person>
	{
		public string name{get;set;}
		public string date{get;set;}
		public byte number{get;set;}
		public string faculty { get;set;}
		public string group { get; set; }

		public Person()
		{
			number= 0;
			name = date = faculty = group = " ";

		}
		public Person(string name, string date, string group, string faculty, byte number = 0);

		{
			this.name=name;
			this.date=date;
			this.group=group;
			this.faculty=faculty;
			this.number=number;
		}
		public override string ToString()
		{
			return name+ " " + date +" "+ number +" "+ faculty +  " " + group;
		} 
		
		public override bool Equals(object obj)
		{
			if (obj is Person)
				return Equals((Person)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(Person other)
		{
			// add comparisions for all members here
			if(this.name!=other.name)
				return false;
			if(date!=other.date)
				return false;
			if(number!=other.number)
				return false;
			if(faculty!= other.faculty)
				return false;
		    if (group != other.group)
			return false; 
		return true;
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return name.GetHashCode();
		}
		
		public static bool operator ==(Person left, Person right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(Person left, Person right)
		{
			return !left.Equals(right);
		}
	}
}
