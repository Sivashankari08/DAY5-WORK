using System;
					
namespace Day5
{
    public class Class3
    {
        public static void Main( )
        {
			DateTime dt = new DateTime(2021,4,27,3,20,6);
			Console.WriteLine(String.Format("{0:ddd, MMM d, yyyy}", dt));
			
			DateTime dr= DateTime.Now;
			Console.WriteLine(String.Format("{0:yyyy:MMMM:d:ddd}", dr));
			Console.ReadLine();
		}
	 }
}