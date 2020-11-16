using System;
// Roberto Jover. 1st DAM
class digits /*calculates how many numbers of 1, 2, 3 or more digits are
entered by the user until he/she types “end”.*/
{
	static void Main()
	{
	 
		int oneDigit = 0, twoDigit = 0, threeDigit = 0, moreDigit = 0;
     
		Console.Write("Insert a number: "); 
		string number = Console.ReadLine();
		
		while(number != "end")
		{
			int input = Convert.ToInt32(number);
			
			if(input != 0)
			{
				if(input/10 == 0)
					oneDigit ++;  
				else 
					if (input/100 == 0)
						twoDigit ++;  
					else
						if (input/1000 == 0)
							threeDigit ++;  
						else
							moreDigit++;  
			}
			
			number = Console.ReadLine();
		}

Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigit, threeDigit, moreDigit); 


	}
}

