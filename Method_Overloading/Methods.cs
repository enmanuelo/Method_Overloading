using System;
namespace Method_Overloading
{
	public class Methods
	{
		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static decimal Add(decimal a, decimal b)
		{
			return a + b;
		}

		public static string Add(int a, int b, bool c)
		{         
            if (c == true)
            {
				if (a + b != 1)
                {
					return $"{a + b} dollars";
                }
                else
                {
					return $"{a + b} dollar";

				}
            }
            else
            {
				return "";
            }
		}

	}
}

