/*
Student
 */
using System;

namespace PersonList
{
	class Program
	{
		public static bool Add(int x, int y, out int z)
		{
			z=x+y;
			return true;
		}
		public static void Main(string[] args)
		{
			PersonList list=new PersonList(new Person("Іванов Іван Іванович","24 жовтня 2003","№12356789" ,"ФІПТ", "Б20_Д_113"));
			list.AddPerson(new Person("Ков Дмитро Іванович","2 вересня 2003","№12876789" ,"ФІПТ", "Б20_Д_113"));
			list.AddPerson(new Person("Гуль Марія Леонідівна","4 жовтня 2003","№12356733" ,"ФІПТ", "Б20_Д_113"));
			list.AddPerson(new Person("Дмитришин Сергій Дмитрович","24 серпня 2003","№16256789" ,"ФІПТ", "Б20_Д_113"));
			list.AddPerson(new Person("Мудренко Ася Валеріївна","5 квітня 2003","№32656789" ,"ФІПТ", "Б20_Д_113"));
			list.AddPerson(new Person("Антонович Наталія Вадимівна","13 серпня 2003","№12569789" ,"ФІПТ", "Б20_Д_113"));
			Console.WriteLine(list);
			Person res=list.FindPerson("Іванов Іван Іванович");
			Console.WriteLine(res);
			
            PersonList resList=list.FindAllPerson("Б20_Д_113");
			Console.WriteLine(resList);			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}