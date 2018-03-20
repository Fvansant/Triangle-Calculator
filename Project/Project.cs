/*
Author: Frank Van Sant
Date: 3/17/2017
Purposed: Display the many measurements of a triangle
*/
using System;

public class TriangleProject
{
	public static void Main()
	{
		double sideA = 0.00, sideB = 0.00, sideC = 0.00;
		
		int  choice = 0;
		bool done = false;
		double calc = 0.00;
		
		
		Console.Write("This program will calculate measurements of a triangle.\n");
		Console.Write("The measurement of the sides will be input by you, the user, in inches.\n");
		Console.Write("-----------------------------------------------------------------------\n\n");
		/*
		 * the next several lines are asking for the three side lengths of a triangle
		 * the do while loops are for 0 length protection
		*/	
		do
		{
			Console.Write("Please enter the length of side A: ");
			sideA = Convert.ToDouble(Console.ReadLine());
		}
		while(sideA == 0.00);
		
		do
		{
			Console.Write("Please enter the length of side B: ");
			sideB = Convert.ToDouble(Console.ReadLine());
		}
		while(sideB == 0.00);
		do
		{
			Console.Write("Please enter the length of side C: ");
			sideC = Convert.ToDouble(Console.ReadLine());
		}
		while(sideC == 0.00);	
		while(sideA + sideB <= sideC || sideB + sideC <= sideA  || sideA + sideC <= sideB)// this checks the inequality therom to determine if the sides make a triangle
		{
			Console.WriteLine("I'm sorry those lenghts cannot create a triangle, please try again.");// force re-tries until the correct lengths are entered
			
			do
			{
				Console.Write("Please enter the length of side A: ");
				sideA = Convert.ToDouble(Console.ReadLine());
			}
			while(sideA == 0.00);
			
			do
			{
				Console.Write("Please enter the length of side B: ");
				sideB = Convert.ToDouble(Console.ReadLine());
			}
			while(sideB == 0.00);
			do
			{
				Console.Write("Please enter the length ofside C: ");
				sideC = Convert.ToDouble(Console.ReadLine());
			}
			while(sideC == 0.00);	
		}
		/*
		 * switch selection list
		 */ 
		
		Console.WriteLine("Which calculation would you like to know?");
		Console.WriteLine("1 - Degree of Angle A");
		Console.WriteLine("2 - Degree of Angle B");
		Console.WriteLine("3 - Degree of Angle C");
		Console.WriteLine("4 - Area of the Triangle");
		Console.WriteLine("5 - Perimeter of the Triangle");
		Console.WriteLine("6 - Height of Angle A");
		Console.WriteLine("7 - Height of Angle B");
		Console.WriteLine("8 - Height of Angle C");
		Console.WriteLine("9 - Angle Bisector of A");
		Console.WriteLine("10 - Angle Bisector of B");
		Console.WriteLine("11 - Angle Bisector of C");
		Console.WriteLine("12 - Median of A");
		Console.WriteLine("13 - Median of B");
		Console.WriteLine("14 - Median of C");
		Console.WriteLine("15 - Inscribed Circle Radius");
		Console.WriteLine("16 - Circumscribed Circle of Radius");
		Console.WriteLine("0 - EXIT");
		choice = Convert.ToInt32(Console.ReadLine());
		
		while(!done)// keeps you in the switch until you manually leave
		{	
			switch (choice)
			{
					//a case for every calculations 16 in all each case calls the appropriate method
				case 0:
					Console.Write("\nHave a nice day.\n\n");
					done = true;
					break;
				case 1:
					calc = AngleADegree(sideA, sideB, sideC);
					Console.WriteLine("The angle is {0}\u00B0", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 2:
					calc = AngleBDegree(sideA, sideB, sideC);
					Console.WriteLine("The angle is {0}\u00B0", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 3:
					calc = AngleCDegree(sideA, sideB, sideC);
					Console.WriteLine("The angle is {0}\u00B0", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 4:
					calc = Area(sideA, sideB, sideC);
					Console.WriteLine("The Area of the triangle is {0} In\u00B2", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 5:
					calc = Perimeter(sideA, sideB, sideC);
					Console.WriteLine("The perimeter of the triangle is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 6:
					calc = HeightOfAngleA(sideA, sideB, sideC);
					Console.WriteLine("The height of angle A is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 7:
					calc = HeightOfAngleB(sideA, sideB, sideC);
					Console.WriteLine("The height of angle B is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 8:
					calc = HeightOfAngleC(sideA, sideB, sideC);
					Console.WriteLine("The height of angle C is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 9:
					calc = AngleBisectorA(sideA, sideB, sideC);
					Console.WriteLine("The bisector of angle A is {0}", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 10:
					calc = AngleBisectorB(sideA, sideB, sideC);
					Console.WriteLine("The bisector of angle B is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 11:
					calc = AngleBisectorC(sideA, sideB, sideC);
					Console.WriteLine("The bisector of angle C is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 12:
					calc = MedianOfA(sideA, sideB, sideC);
					Console.WriteLine("The median of side a is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 13:
					calc = MedianOfB(sideA, sideB, sideC);
					Console.WriteLine("The median of side b is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 14:
					calc = MedianOfC(sideA, sideB, sideC);
					Console.WriteLine("The median of side c is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 15:
					calc = InscribedCircleRadius(sideA, sideB, sideC);
					Console.WriteLine("The inscribed circle radius is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				case 16:
					calc = CircumscribedCircleRadius(sideA, sideB, sideC);
					Console.WriteLine("The circumscribed circle radius is {0} In", calc.ToString("F2"));
					Console.Write("Please make another choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
				default:
					Console.Write("That choice is invalid, please choose again: ");
					choice = Convert.ToInt32(Console.ReadLine());
					break;
			}
			
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
	/*For the most part i have broken down the equations used into several parts
	 I found doing it this way made it easier to test the accuracy of the math.*/
	public static double AngleADegree(double A, double B, double C)// calculates angle A of a triangle
	{
		double angleA;
		
		angleA = ((B * B) + (C * C) - (A * A)) / (2 * B * C);
		
		angleA = Math.Acos(angleA);// Math.Acos is the inverse of Cosine
		angleA = 180 * angleA / Math.PI;// converts radians to degree
		return angleA;
		
	}
	public static double AngleBDegree(double A, double B, double C)//calculates angle B of a triangle
	{
		double angleB;
		
		
		angleB = ((A * A) + (C * C) - (B * B)) / (2 * A * C);
		
		angleB = Math.Acos(angleB);
		angleB = 180 * angleB / Math.PI;
		return angleB;
	}
	public static double AngleCDegree(double A, double B, double C)// calculates angle C of a triangle
	{
		double angleC;
		
		angleC = ((A * A) + (B * B) - (C * C)) / (2 * A * B);
		
		angleC = Math.Acos(angleC);
		angleC = 180 * angleC / Math.PI;
		return angleC;
	}
	public static double Area(double A, double B, double C)//calculates the area of the triangle
	{
		double area;
		double s = (A + B + C)/2;
		area = (s * (s - A) * (s - B) * (s - C));
		area = Math.Sqrt(area);// square root of area
		
		return area;
	}
	public static double Perimeter(double a, double b, double c)//calculates the perimeter of a triangle
	{
		double perimeter;
		perimeter = a + b + c;
		return perimeter;
	}
	public static double HeightOfAngleA(double A, double B, double C)// determines the height os angle A
	{
		double height;
		
		height = AngleADegree(A, B, C);// sends the sides to the angle method
		height = Math.PI * height / 180;//converts degrees to radians
		height = Math.Sin(height);// using Sine to calc height
		height = height * B;
		
		return height;
		
	}
	public static double HeightOfAngleB(double A, double B, double C)// determines the height of angle B
	{
		double height;
		
		height = AngleBDegree(A, B, C);
		height = Math.PI * height / 180;
		height = Math.Sin(height);
		//height = 180 * height / Math.PI;
		height = height * C;
		
		return height;	
	}
	public static double HeightOfAngleC(double A, double B, double C)//determines the height of angle C
	{
		double height;
		
		height = AngleCDegree(A, B, C);
		height = Math.PI * height / 180;
		height = Math.Sin(height);
		height = height * A;
		
		return height;
	}
	public static double AngleBisectorA(double A, double B, double C)//calculates the bisector of angle A
	{
		double bisector;
		
		bisector = AngleADegree(A, B, C);
		bisector = Math.PI * bisector / 180;
		bisector = Math.Cos(bisector/2);//cosine one half the angle
		bisector = 2 * B * C * bisector / (B + C);
		
		return bisector;
	}
	public static double AngleBisectorB(double A, double B, double C)//calculates the bisector of angle B
	{
		double bisector;
		
		bisector = AngleBDegree(A, B, C);
		bisector = Math.PI * bisector / 180;
		bisector = Math.Cos(bisector/2);
		bisector = 2 * A * C * bisector / (A + C);
		
		return bisector;
	}
	public static double AngleBisectorC(double A, double B, double C)//calculates the bisector of angle C
	{
		double bisector;
		
		bisector = AngleCDegree(A, B, C);
		bisector = Math.PI * bisector / 180;
		bisector = Math.Cos(bisector/2);
		bisector = 2 * A * B * bisector / (B + A);
		
		return bisector;
	}
	public static double MedianOfA(double A, double B, double C)// calculates the median of angle A
	{
		double median;
		
		median = Math.Sqrt((2 * (B * B) + 2 * (C * C) - (A * A)) / 4);
		
		return median;
	}
	public static double MedianOfB(double A, double B, double C)// calculates teh median of angle B
	{
		double median;
		
		median = Math.Sqrt((2 * (A * A) + 2 * (C * C) - (B * B)) / 4);
		
		return median;
	}
	public static double MedianOfC(double A, double B, double C)// calculates the median of angle C
	{
		double median;
		
		median = Math.Sqrt((2 * (A * A) + 2 * (B * B) - (C * C)) / 4);
		
		return median;
	}
	public static double InscribedCircleRadius(double A, double B, double C)// calculates the radius of the inscribed circle
	{
		double inscribed;
		double angleA, angleB, angleC;
		
		angleA = AngleADegree(A, B, C);// using methods to determine angles
		angleA = Math.PI * angleA / 180;//and converting them to radians
		angleA = Math.Cos(angleA / 2);
		angleB = AngleBDegree(A, B, C);
		angleB = Math.PI * angleB / 180;
		angleB = Math.Sin(angleB / 2);
		angleC = AngleCDegree(A, B, C);
		angleC = Math.PI * angleC / 180;
		angleC = Math.Sin(angleC / 2);
		
		inscribed = A * angleC * angleB / angleA;
		
		return inscribed;
	}
	public static double CircumscribedCircleRadius(double A, double B, double C)// calculates the radius of the circumscribed circle
	{
		double circum;
		
		circum = AngleADegree(A, B, C);//only one angle is needed
		circum = Math.PI * circum / 180;
		circum = Math.Sin(circum);
		circum = A / (2 * circum);
		
		return circum;
	}
}