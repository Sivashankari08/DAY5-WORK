using System;
						
    public class Class3
    {
        public struct employee
        {
            public string empName;
			public int empID;
            public dtObirth Date;
			public string empDept;
        }
        public struct dtObirth
        {
            public int Day;
            public int Month;
            public int Year;
	    }  
        public static void Main(string[] args)
        {
             
            int dd=0, mm=0, yy=0;
			int ID=0;
            int total = 2;
			Console.Write("\n\nCreate a nested structure and store data in an array :\n");
			Console.Write("-------------------------------------------------------\n"); 	
            employee[] emp = new employee[total];
 
            for (int i = 0; i < total; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].empName = nm;
 
                Console.Write("Input day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;
 
                Console.Write("Input month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;
 
                Console.Write("Input year for the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
				
                Console.Write("Dept of the employee : ");
                string dpt = Console.ReadLine();
                emp[i].empDept = dpt;		
                
				Console.Write("Salary of the Employee : ");
                ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].empID = ID;				
 			
            }
        }
    }     

