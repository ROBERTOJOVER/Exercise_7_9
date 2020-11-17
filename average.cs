using System;

public class Average /* calculates the average of a set of marks, until 
the user types “end”.*/
{
	public static void Main()
	{
		double sum = 0, b, count = 0, d;
		string mark;
		
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();	// we read the mark as string to check the word "end"	
		 
		while(mark!="end")
		{  // if the mark isn't an end then we pass it to double to work with it
			b = Convert.ToDouble(mark);
			count++;   //counter of numbers
			sum += b;  // sum of all the notes
			
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}
		
		if(count!=0)
		{
			d=sum/count;  //calculate the average
			
			Console.WriteLine("The average is {0}.",d);
		}
	}
}
