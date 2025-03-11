//Автозаправка(заправка + кавовий автомат) 
/*Створити програму для роботи Автозаправки у  режимах адмін та користувач
У режимі адміна передбачити 	
	Поповнення заправки   пальним відповідного типу 
	Перегляд наявного пального кожного типу
	Зміна цін на пальне
	заправка кавового автомату
	Вилучення кешу(за пальне, за каву)
	Вивід статистики про продажі пального у літрах та грн.
	Вивід зароблених коштів(кожна  категорія окремо та сумарно)
У режимі користувача передбачити 		
	Заправка авто потрібним пальним( з видачею талона по оплаті)
		-на певну суму
		- певну кількість літрів
	замовлення кави
*/

using System.Xml.Linq;

Console.WriteLine("1.hallo ");
Console.WriteLine("2. Add/Edit/Delete Services");
Console.WriteLine("3. Accept Order for Shipment");
Console.WriteLine("4. Mark Order as Fulfilled");
Console.WriteLine("5. Save and Exit");

Console.WriteLine("\tADMIN MENU\n" +
       "1. Refilling the gas station with fuel\n" +
       "2. View available fuel\n" +
       "3. Change in fuel prices\n" +
       "4. withdrawal of money\n" +
       "5.Withdrawal of earned funds\n" +);
Console.WriteLine("______________________________");


Console.Write("Your choice: ");
int choice = int.Parse(Console.ReadLine());


switch (choice)
{
	case 1:
    var item = new Fuel();
    item.Type = Console.ReadLine();
    item.Price = double.Parse(Console.ReadLine();
    item.Capacity = double.Parse(Console.ReadLine());
    item.Vendor = (Console.ReadLine());
    break;
}


public class Fuel 
{
	// властивості продукта
	public string Type { get; set; }
	public double Capacity { get; set; }
    public string Vendor { get; set; }
    public double Price  { get; set; }

    public void ReadFromConsole()
    {
        Console.Write("Enter name: ");
        Type = Console.ReadLine();
        Console.Write("Enter price: ");
        Capacity = double.Parse(Console.ReadLine());
        Description = Console.ReadLine();
        Vendor = int.Parse(Console.ReadLine());
        Price = int.Parse(Console.ReadLine());
        Category = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}$");
        Console.WriteLine($"Quantity: {Quantity}$");
        Console.WriteLine($"Discount: {Discount}%");
        Console.WriteLine($"Category: {Category}");
    }



}