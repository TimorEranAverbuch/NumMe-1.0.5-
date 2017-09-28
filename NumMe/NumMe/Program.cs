using System;

namespace NumMe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hey there! Welcome to NumMe® ");
            while (true)
            {
                Console.WriteLine("Choose one of the options below: ");
                Console.WriteLine("1 - PriMe®                 :Check if number is prime, then factor the number ");
                Console.WriteLine("2 - Multiplicatorium®      :Factor two numbers ");
                string Option = Console.ReadLine();
                switch (Option.ToLower())
                {
                    case "prime":
                        PriMe();
                        break;
                    case "1":
                        PriMe();
                        break;

                    case "multiplicatorium":
                        Multiplicatorium();
                        break;
                    case "2":
                        Multiplicatorium();
                        break;

                    default:
                        Console.WriteLine("Invalid Syntax ");
                        break;

                }
            }
        }

        static void PriMe()
        {
            Console.WriteLine("Welcome to PriMe® ");
            int int_num = check();

            if (IsPrime(int_num)){
				Console.WriteLine("Your number is prime");
			}else{
				Console.WriteLine("Your number is not prime");
			}

            multi(int_num);

		}

		public static bool IsPrime(int number)
		{
			if (number == 1) return false;
			if (number == 2) return true;
			if (number % 2 == 0) return false;

			int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
			{
                if (number % i == 0) { return false; }
			}

			return true;
		}

        static void Multiplicatorium()
        {
			Console.WriteLine("Welcome to Multiplicatorium® ");
            bool go = true;
            while (go){
    			int num = check();
                int sum = num;
                Console.WriteLine("Now enter second number ");
                int i = check();
                if (i == 0 || i == 1 || num == 0 || num == 1)
                {
                    Console.WriteLine("Sorry, but 0 and 1 are not exepted ");
                }
                else
                {
                    go = false;
                    int mul = i;
                    Console.WriteLine();
                    Console.Write(Convert.ToString(i));
                    mul = mul * i;
                    while (num >= mul)
                    {
                        Console.Write(" x " + Convert.ToString(i));
                        mul = mul * i;
                    }
                    Console.Write(" + " + Convert.ToString(num - (mul / i)) + " = " + num);
                    /*
        						mul = i;
        						Console.Write("( ");
        						int numi = (mul / i);
        						while (numi >= mul)
        						{
        							Console.Write(" x " + Convert.ToString(i));
        							mul = mul * i;
        						}
        						Console.Write(" + " + Convert.ToString(numi - (mul / i)));
        						Console.Write(" )");
        			*/
                    Console.WriteLine(" ");
                    Console.WriteLine();
                }
            }
        }

        static void multi(int num){
            int sum = num;
            int mul;
            Console.WriteLine("And here is the multiplicators: ");
            for (int i = 2; i < num; i++){
                mul = i;
                if((num % i) == 0){
                    Console.Write(Convert.ToString(i) + " : ");
                    while (sum > i){
                        Console.Write(Convert.ToString(i) + " + ");
                        sum = sum - i;
                    }
                    Console.Write(Convert.ToString(i) + " = " + Convert.ToString(num));

                    Console.WriteLine();
                    Console.Write(Convert.ToString(i));
                    mul = mul * i;
					while (num >= mul)
					{
						Console.Write(" x " + Convert.ToString(i));
						mul = mul*i;
					}
                    Console.Write(" + " + Convert.ToString(num - (mul / i)) + " = " + num);

					/*					mul = i;
										Console.Write("( ");
										int numi = (mul / i);
										while (numi >= mul)
										{
											Console.Write(" x " + Convert.ToString(i));
											mul = mul * i;
										}
										Console.Write(" + " + Convert.ToString(numi - (mul / i)));
										Console.Write(" )");
					*/
					Console.WriteLine(" ");
					Console.WriteLine();
                }
                sum = num;
            }
        }

        static int check(){
			string str_num = "word";
			int check = 0;
			bool invaid_syn = false;
			while (invaid_syn == false)
			{
				invaid_syn = true;
				Console.Write("Please enter a vaid number : ");
				str_num = Console.ReadLine();
				char[] char_num = str_num.ToCharArray();
				char[] valid_chars = "1234567890".ToCharArray();
				//foreach (var item in char_num) { Console.WriteLine(item.ToString()); }
				//foreach (var item in vaid_chars) { Console.WriteLine(item.ToString()); }

				foreach (char chr in char_num)
				{
					check = 0;
					foreach (char good in valid_chars)
					{
						if (chr != good)
						{
							check++;
						}
					}
					if (check != 9)
					{
						invaid_syn = false;
					}
				}
			}
            int int_num = Convert.ToInt32(str_num);
            return int_num;
        }
	}
}
