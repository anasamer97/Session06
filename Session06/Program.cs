namespace Session06
{
	internal class Program
	{
		

		enum Weekdays
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}


		enum Season
		{
			Spring,
			Summer,
			Autumn,
			Winter
		}

		[Flags]
		enum Permission
		{
			None = 0, Read = 1, Write = 2, Delete = 4, Execute = 8

		}

		enum Colors
		{
			Red,
			Green,
			Blue
		}

		public struct Point
		{
			public double X { get; set; }
			public double Y { get; set; }

			public Point(double x, double y)
			{
				X = x;
				Y = y;
			}
		}


		static void Main(string[] args)
		{
			#region Assignment 06
			#region Q1

			// Enum.GetValues(typeof(WeekDays)) // Returns array of values of the enum WeekDays[]
			/*foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
			{
				Console.WriteLine(day);
			}*/
			#endregion
			#region Q2
			/* 2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
			 */
			/*Console.WriteLine("Enter a season name:");
			string seasonInput = Console.ReadLine();
			bool isValidEnum = Enum.TryParse(seasonInput, true, out Season season);
			while(!isValidEnum)
			{
				Console.WriteLine("Invalid season name, please enter a valid season name:");
				seasonInput = Console.ReadLine();
				isValidEnum = Enum.TryParse(seasonInput, true, out season);
			}



			switch (season)
			{
				case Season.Spring:
					Console.WriteLine("March to May");
					break;
				case Season.Summer:
					Console.WriteLine("June to August");
					break;
				case Season.Autumn:
					Console.WriteLine("September to November");
					break;
				case Season.Winter:
					Console.WriteLine("December to February");
					break;
				default:
					Console.WriteLine("Invalid season name");
					break;
			}*/
			#endregion

			#region Q3
			/*
			 3.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
			Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside
			variable
			 */
			/*Permission permissions = Permission.None;

			// Adding permissions
			permissions |= Permission.Read;
			permissions |= Permission.Write;


			// Removing permissions
			permissions &= ~Permission.Write;


			// Cheking if permission exists
			bool hasRead = (permissions & Permission.Read) == Permission.Read;
			bool hasWrite = (permissions & Permission.Write) == Permission.Write;
			bool hasDelete = (permissions & Permission.Delete) == Permission.Delete;
			bool hasExecute = (permissions & Permission.Execute) == Permission.Execute;


			// Printing permissions
			Console.WriteLine($"Read permission: {hasRead}");
			Console.WriteLine($"Write permission: {hasWrite}");
			Console.WriteLine($"Delete permission: {hasDelete}");
			Console.WriteLine($"Execute permission: {hasExecute}");*/

			#endregion

			#region Q4
			/*Console.WriteLine("Enter a color name:");
			string inputColor = Console.ReadLine();

			bool isValidEnum = Enum.TryParse(inputColor, true, out Colors color);

			if (isValidEnum)
			{
				Console.WriteLine($"{inputColor} is a primary color.");
			}


			else
			{
				Console.WriteLine($"{inputColor} is not a primary color.");

			}*/

			#endregion

			#region Q5
			// Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them
			// Input for the first point
			double x1 = GetValidDouble("Enter the X coordinate for the first point:");
			double y1 = GetValidDouble("Enter the Y coordinate for the first point:");

			// Create the first point
			Point point1 = new Point(x1, y1);

			// Input for the second point
			double x2 = GetValidDouble("Enter the X coordinate for the second point:");
			double y2 = GetValidDouble("Enter the Y coordinate for the second point:");

			// Create the second point
			Point point2 = new Point(x2, y2);

			// Calculate the distance
			double distance = CalculateDistance(point1, point2);

			// Output the result
			Console.WriteLine($"The distance between the two points is: {distance}");




			#endregion
			#endregion

			#region Demo
			#region Exception Handling
			//Try Catch => Last Defence Line
			//static void DoSomeCode()
			//{
			//    try
			//    {//UnExpected
			//        int x, y, z;  
			// String => int === Unboxing
			//        x = int.Parse(Console.ReadLine());
			//        y = int.Parse(Console.ReadLine());
			//        z = x / y;

			//        int[] arr = { 1, 2, 3 };
			//        arr[100] = 90;
			//    }
			//    catch (Exception ex)//Class 
			//    {
			//        Console.WriteLine(ex.Message);
			//    }
			//    //Exceotion 
			//    //System Exception 
			//    //1)Format Exception
			//    //2)Index out Of Range Exception
			//    //3) Null Exception 
			//    //4) Arthamtic Exception 
			//    //Application Exception => Hardware 
			//}

			static void DoSomeProtectiveCode()
			{

				//UnExpected
				int x, y, z;
				bool flag = false;
				do
				{
					flag = int.TryParse(Console.ReadLine(), out x);

				} while (!flag);

				do
				{
					flag = int.TryParse(Console.ReadLine(), out y);

				} while (!flag || y == 0);
				z = x / y;
				//Console.WriteLine(z);

				int[] arr = { 1, 2, 3 };
				if (arr?.Length >= 100)
				{
					arr[100] = 90;
				}
			}


			//Exceotion 
			//System Exception 
			//1)Format Exception
			//2)Index out Of Range Exception
			//3) Null Exception 
			//4) Arthamtic Exception 
			//Application Exception => Hardware 

			#endregion
			#region Enum
			// Grades Grade = Grades.A;
			//Grades Grade =(Grades)1;//RunTime => Explicit Casting
			//Console.WriteLine(Grade);
			//if(Grade == Grades.A)
			//    Console.WriteLine(":)");
			//else
			//    Console.WriteLine(":(");
			//Employee employee = new Employee();
			//employee.id = 1;
			//employee.name = "Ahmed";
			//employee.gender = Gender.Male;//1

			//Branches branches = (Branches)3;
			#endregion

			#region Access Modifires ->C# keywords => 6 
			//Private 
			//Private Protected
			//Protected
			//Internal 
			//Internal Protected
			//Public 
			//TypeA typeA = new TypeA();  
			//typeA.x
			//typeA.x
			#endregion

			#region Struct 
			//ValueType 
			//Struct 
			//Class
			//-->Attributes => Variables
			//-->Methods [Constructor  - Getter/Setter -User Defined]
			//--->Property [Full Prop -Autamatic Prop - Indexer]
			//Point P1;//CLR Generated Object at Stack
			//P1 = new Point(3,5);//Built In
			////Console.WriteLine(P1.z);

			//Console.WriteLine(P1.ToString());//P1
			#endregion
			#endregion
		}
		static double CalculateDistance(Point p1, Point p2)
		{
			double dx = p2.X - p1.X; double dy = p2.Y - p1.Y; return Math.Sqrt(dx * dx + dy * dy);
		}

		static double GetValidDouble(string prompt)
		{
			double value;
			bool success;

			do
			{
				Console.WriteLine(prompt);
				string input = Console.ReadLine();
				success = double.TryParse(input, out value);

				if (!success)
				{
					Console.WriteLine("Invalid input. Please enter a valid number.");
				}

			} while (!success);

			return value;
		}

	}
}
