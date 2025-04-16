/*
int sum_odd=0, sum_even=0;

for (int i = 10; i < 100; i++)
{
	if (i % 2 == 0)
	{
		sum_even += i;
	}
	else {
		sum_odd += i;
		
	}
}

Console.WriteLine("sum odd number is {0} and sum even number is {1}",sum_odd,sum_even);
Console.ReadKey();
*/


/*
int input;
Console.Write("inrer input:");
input =Convert.ToInt32( Console.ReadLine());

for (int i = 0; i <= input; i++)
{
	if (i%2 == 0)
	Console.WriteLine("the pow of num is {0}",Math.Pow(i,2));
}

Console.ReadKey();
*/



/*
Console.Write("inter number:");
int input=Convert.ToInt32(Console.ReadLine());
int number=input;
int length_number =input.ToString().Length;
int sum = 0;


while (input>0)
{
	int digit = input % 10;
	sum += Convert.ToInt32(Math.Pow(digit,length_number));
	input /= 10;
}

if (sum == number)
	Console.WriteLine("{0} is a armesterang number", number);
else
	Console.WriteLine("{0} is not a armesterang number", number);

Console.ReadKey();

*/
/*
int[] input_nam = new int[20];

for (int i = 0; i < input_nam.Length; i++)
{
	int count=i+1;
	Console.Write("input {0} number:",count);
	input_nam[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("the little number is {0}",input_nam.Min());
Console.ReadKey();
*/

/*
int[] input_nam = new int[20];

for (int i = 0; i < input_nam.Length; i++)
{
    int count = i + 1;
    Console.Write("input {0} number:", count);
    input_nam[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("the little number is {0}", input_nam.Max());
Console.ReadKey();
*/

/*
int[] input_nam = new int[20];

for (int i = 0; i < input_nam.Length; i++)
{
    int count = i + 1;
    Console.Write("input {0} number:", count);
    input_nam[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("the little number is {0}", input_nam.Average());
Console.ReadKey();
*/

/*
int[] input_nam = new int[20];

for (int i = 0; i < input_nam.Length; i++)
{
    int count = i + 1;
    Console.Write("input {0} number:", count);
    input_nam[i] = Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < input_nam.Length; j++)
{
	if (input_nam[j] %10==5)
	{
		Console.WriteLine(input_nam[j]);
	}
}

Console.ReadKey();

*/
/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int result=1;
int sum=1;

while (input>=1)
{
	result = input - 1;
	sum*=input;
	input -= 1;
}

Console.WriteLine(sum);
Console.ReadKey();
*/

/*

Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(input.ToString().Length);
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int length_num= input.ToString().Length;
int result;

for (int i = 0; i < length_num; i++)
{
	result = input % 10;
	input /= 10;
	Console.Write(result);
}
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
bool first_num=true;

if (input <= 1)
	first_num = false;
else
{
	for (int i = 2; i < input/2; i++)
	{
		if (input % i == 0)
		{ 
			first_num=false;
			break;
		}
	}
}

if (first_num)
{
    Console.WriteLine(input + "is a first number");
}
else
{
    Console.WriteLine(input + "is not first number");
}

*/




/*
for (int j = 2; j < 1000; j++)
{
    bool first_num = true;
	for (int i = 2; i <= Math.Sqrt(i); i++)
	{
		if (j % i == 0)
		{ 
			first_num = false;
			break;
		}
	}

	if (first_num)
	{
		Console.WriteLine(j+"is a first number");
	}
}
*/


/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
string text="";

for (int i = 1; i <= input; i++)
{
	if (i % 2 == 0)
	{
		text=text+i.ToString()+"-";
	}
	else
	{
        text = text + i.ToString() + "+";
    }
}

text =text.Remove(text.Length-1);
Console.Write(text);
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
double sum =0;

for (int i = 1; i <input; i++)
{ 
	sum += 1 / i;
}

Console.WriteLine(sum);
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <=input ; i++)
{
	if (input % i == 0)
	{
        Console.WriteLine(i);	
		sum+=i;
	}
}
Console.WriteLine(sum);
*/

/*
Console.Write("inter R:");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("inter M:");
int mounth = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(mounth*12+day);

*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int lenght_input = input.ToString().Length;
int sum,resulat=0;

for (int i = 0; i <= lenght_input; i++)
{
	sum = input % 10;
	input /= 10;
	resulat += sum;
}
Console.WriteLine(resulat);
*/

/*
Console.Write("inter name:");
string name = Console.ReadLine();

Console.Write("inter sallery:");
int sallery = Convert.ToInt32(Console.ReadLine());

Console.Write("inter work:");
int work = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0} your sallary is {1}",name,sallery*work);
*/

/*
for (int i = 1; i <= 1000; i++)
{
	if (i%2==0)
	{
        Console.WriteLine(i);
	}
}
*/

/*
for (int i = 1; i <= 1000; i++)
{
    if (i % 9 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int num=input;
int lenght_input = input.ToString().Length;
int sum, resulat=0;

for (int i = 0; i <= lenght_input; i++)
{
    sum = input % 10;
    input /= 10;
    resulat += sum;
}
if (num%resulat==0)
{
    Console.WriteLine("yes");
}
else
    Console.WriteLine("no");
*/

/*
Console.Write("inter number1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("inter number2:");
int num2 = Convert.ToInt32(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
	if (i%3==0)
	{
        Console.WriteLine(i);
	}
}
*/

/*
for (int i = 1000; i <= 9999; i++)
{
	int first = i % 10;
    int second = (i/10) % 10;
    int thirth = (i / 100) % 10;
	int fourth = i / 1000;

	bool first_even= first % 2 == 0;
    bool second_odd = second % 2 == 1;
    bool thirth_odd = thirth % 2 == 0;
    bool fourth_even = fourth % 2 == 1;

    if (first_even && second_odd && thirth_odd && fourth_even)
	{
		Console.WriteLine(i);
	}




}
*/


﻿/*
int sum_odd=0, sum_even=0;

for (int i = 10; i < 100; i++)
{
	if (i % 2 == 0)
	{
		sum_even += i;
	}
	else {
		sum_odd += i;
		
	}
}

Console.WriteLine("sum odd number is {0} and sum even number is {1}",sum_odd,sum_even);
Console.ReadKey();
*/


/*
int input;
Console.Write("inrer input:");
input =Convert.ToInt32( Console.ReadLine());

for (int i = 0; i <= input; i++)
{
	if (i%2 == 0)
	Console.WriteLine("the pow of num is {0}",Math.Pow(i,2));
}

Console.ReadKey();
*/



/*
Console.Write("inter number:");
int input=Convert.ToInt32(Console.ReadLine());
int number=input;
int length_number =input.ToString().Length;
int sum = 0;


while (input>0)
{
	int digit = input % 10;
	sum += Convert.ToInt32(Math.Pow(digit,length_number));
	input /= 10;
}

if (sum == number)
	Console.WriteLine("{0} is a armesterang number", number);
else
	Console.WriteLine("{0} is not a armesterang number", number);

Console.ReadKey();

*/
/*
int[] input_nam = new int[20];

for (int i = 0; i < input_nam.Length; i++)
{
	int count=i+1;
	Console.Write("input {0} number:",count);
	input_nam[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("the little number is {0}",input_nam.Min());
Console.ReadKey();
*/

/*
int[] input_nam = new int[20];

for (int i = 0; i < input_nam.Length; i++)
{
    int count = i + 1;
    Console.Write("input {0} number:", count);
    input_nam[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("the little number is {0}", input_nam.Max());
Console.ReadKey();
*/

/*
int[] input_nam = new int[20];

for (int i = 0; i < input_nam.Length; i++)
{
    int count = i + 1;
    Console.Write("input {0} number:", count);
    input_nam[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("the little number is {0}", input_nam.Average());
Console.ReadKey();
*/

/*
int[] input_nam = new int[20];

for (int i = 0; i < input_nam.Length; i++)
{
    int count = i + 1;
    Console.Write("input {0} number:", count);
    input_nam[i] = Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < input_nam.Length; j++)
{
	if (input_nam[j] %10==5)
	{
		Console.WriteLine(input_nam[j]);
	}
}

Console.ReadKey();

*/
/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int result=1;
int sum=1;

while (input>=1)
{
	result = input - 1;
	sum*=input;
	input -= 1;
}

Console.WriteLine(sum);
Console.ReadKey();
*/

/*

Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(input.ToString().Length);
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int length_num= input.ToString().Length;
int result;

for (int i = 0; i < length_num; i++)
{
	result = input % 10;
	input /= 10;
	Console.Write(result);
}
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
bool first_num=true;

if (input <= 1)
	first_num = false;
else
{
	for (int i = 2; i < input/2; i++)
	{
		if (input % i == 0)
		{ 
			first_num=false;
			break;
		}
	}
}

if (first_num)
{
    Console.WriteLine(input + "is a first number");
}
else
{
    Console.WriteLine(input + "is not first number");
}

*/




/*
for (int j = 2; j < 1000; j++)
{
    bool first_num = true;
	for (int i = 2; i <= Math.Sqrt(i); i++)
	{
		if (j % i == 0)
		{ 
			first_num = false;
			break;
		}
	}

	if (first_num)
	{
		Console.WriteLine(j+"is a first number");
	}
}
*/


/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
string text="";

for (int i = 1; i <= input; i++)
{
	if (i % 2 == 0)
	{
		text=text+i.ToString()+"-";
	}
	else
	{
        text = text + i.ToString() + "+";
    }
}

text =text.Remove(text.Length-1);
Console.Write(text);
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
double sum =0;

for (int i = 1; i <input; i++)
{ 
	sum += 1 / i;
}

Console.WriteLine(sum);
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <=input ; i++)
{
	if (input % i == 0)
	{
        Console.WriteLine(i);	
		sum+=i;
	}
}
Console.WriteLine(sum);
*/

/*
Console.Write("inter R:");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("inter M:");
int mounth = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(mounth*12+day);

*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int lenght_input = input.ToString().Length;
int sum,resulat=0;

for (int i = 0; i <= lenght_input; i++)
{
	sum = input % 10;
	input /= 10;
	resulat += sum;
}
Console.WriteLine(resulat);
*/

/*
Console.Write("inter name:");
string name = Console.ReadLine();

Console.Write("inter sallery:");
int sallery = Convert.ToInt32(Console.ReadLine());

Console.Write("inter work:");
int work = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0} your sallary is {1}",name,sallery*work);
*/

/*
for (int i = 1; i <= 1000; i++)
{
	if (i%2==0)
	{
        Console.WriteLine(i);
	}
}
*/

/*
for (int i = 1; i <= 1000; i++)
{
    if (i % 9 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/*
Console.Write("inter number:");
int input = Convert.ToInt32(Console.ReadLine());
int num=input;
int lenght_input = input.ToString().Length;
int sum, resulat=0;

for (int i = 0; i <= lenght_input; i++)
{
    sum = input % 10;
    input /= 10;
    resulat += sum;
}
if (num%resulat==0)
{
    Console.WriteLine("yes");
}
else
    Console.WriteLine("no");
*/

/*
Console.Write("inter number1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("inter number2:");
int num2 = Convert.ToInt32(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
	if (i%3==0)
	{
        Console.WriteLine(i);
	}
}
*/

/*
for (int i = 1000; i <= 9999; i++)
{
	int first = i % 10;
    int second = (i/10) % 10;
    int thirth = (i / 100) % 10;
	int fourth = i / 1000;

	bool first_even= first % 2 == 0;
    bool second_odd = second % 2 == 1;
    bool thirth_odd = thirth % 2 == 0;
    bool fourth_even = fourth % 2 == 1;

    if (first_even && second_odd && thirth_odd && fourth_even)
	{
		Console.WriteLine(i);
	}




}
*/


/*
        int target = 1000;
        int count = 0;

        for (int s200 = 0; s200 <= target / 200; s200++)
        {
            for (int s100 = 0; s100 <= target / 100; s100++)
            {
                for (int s50 = 0; s50 <= target / 50; s50++)
                {
                    int sum = (s200 * 200) + (s100 * 100) + (s50 * 50);
                    if (sum == target)
                    {
                        count++;
                        Console.WriteLine($"200: {s200}, 100: {s100}, 50 {s50}");
		    }
        }
    }
}
 Console.WriteLine($"\n count of way {count}");
   
*/

/*
        Console.Write("number of row:");
        int rows = int.Parse(Console.ReadLine());

        for (int n = 0; n < rows; n++)
        {
            // فاصله برای زیبایی نمایش مثلث
            Console.Write(new string(' ', (rows - n) * 2));

            for (int k = 0; k <= n; k++)
            {
                Console.Write($"{BinomialCoefficient(n, k),4} ");
            }

            Console.WriteLine();
        }
    

    // تابع محاسبه ترکیب (n از k)
    static long BinomialCoefficient(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    // تابع محاسبه فاکتوریل
    static long Factorial(int num)
    {
        long result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

*/
}


