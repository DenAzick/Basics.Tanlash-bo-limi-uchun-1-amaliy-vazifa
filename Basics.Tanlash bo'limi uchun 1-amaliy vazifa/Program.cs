


Console.WriteLine("Basics.Tanlash bo’limi uchun 1-amaliy vazifa");

Console.WriteLine("1. String ustida amallar");


Console.Write("\nbiror so'z kiriting:");
string str = Console.ReadLine();

Console.Write("son kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());


if (str.Length > son)
{
    str = str.ToLower();
}
else
{
    str = str.ToUpper();
}
Console.WriteLine(str);


Console.WriteLine("/////////////////////////////////////////////////////////");

Console.WriteLine("\n2. Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.");

Console.Write("x sonini kiriting: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y sonini kiriting: ");
int y = Convert.ToInt32(Console.ReadLine());

string result;

if (x > y)
{
    result = "x is greater than y";
}
else if (y > x)
{
    result = "x is less than y";
}
else if (x == y)
{
    result = "x is equal to y";
}
else
{
    result = "x and y are not comparable";
}
Console.WriteLine(result);


Console.WriteLine("/////////////////////////////////////////////////////////");

Console.WriteLine("\n3. Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib, natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!");

Console.WriteLine("\n\nhafta kunlarini birini tanlang raqami bo'yicha tanlang: \n1.Dushanba\n2.Seshanba\n3.Chorshanba\n4.Payshanba\n5.Juma\n6.Shanba\n7.Yakshanba");

int kun = Convert.ToInt32(Console.ReadLine());
string day;
if (kun <= 7 && kun > 0)
{
	switch (kun)
	{
		case 1: day = "Monday"; Console.WriteLine($"kunning ingliz tilidagi nomi: " + day); break;
        case 2: day = "Tuesday"; Console.WriteLine($"kunning ingliz tilidagi nomi: " + day); break;
        case 3: day = "Wednesday"; Console.WriteLine($"kunning ingliz tilidagi nomi: " + day); break;
        case 4: day = "Thursday"; Console.WriteLine($"kunning ingliz tilidagi nomi: " + day); break;
        case 5: day = "Friday"; Console.WriteLine($"kunning ingliz tilidagi nomi: " +day); break;
        case 6: day = "Saturday"; Console.WriteLine($"kunning ingliz tilidagi nomi: " + day); break;
        case 7: day = "Sunday"; Console.WriteLine($"kunning ingliz tilidagi nomi: " + day); break;
        default:
			break;

	}

}
else
{
    Console.WriteLine("Ro'yxatda bunday kun yo'q");
}