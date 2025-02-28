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

Console.WriteLine("1.hallo ");
Console.WriteLine("2. Add/Edit/Delete Services");
Console.WriteLine("3. Accept Order for Shipment");
Console.WriteLine("4. Mark Order as Fulfilled");
Console.WriteLine("5. Save and Exit");

Console.WriteLine("\tADMIN MENU\n" +
       "1. statistics\n" +
       "2. CASH REGISTER\n" +
       "3. EMPLOYEES\n" +
       "4. PRICES\n" +
       "5.DELIVERY\n" +);
Console.WriteLine("______________________________");


public class Fuel
{
	// властивості продукта
	public string Type { get; set; }
	public double Capacity { get; set; }
    public string Venelor { get; set; }
    public double Price  { get; set; }




}