//We are writing an application for a shipping company to provide
//quotes to vendors to ship their products.
//In order to calculate our quote,
//  we need to know the total weight of the shipment in pounds,
//  the distance in miles and
//  whether or not there are hazardous materials in the shipment (e.g. batteries).
//The calculation for the quote is as follows:
//  Quote = .55 * # of miles + .73 * # of pounds
//
//If there is hazardous materials in the shipment,
//there is an extra cost of .15 * # of pounds
//If the distance for the delivery is less than 150 miles
//and the total weight for the shipment is greater than 500 pounds,
//then there should be a 10% discount off of the total quote

Console.WriteLine("What is the total weight of the shipment, in pounds? >>");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the distance of the shipment, in miles? >>");
string distanceAsString = Console.ReadLine();
double distance = Convert.ToDouble(distanceAsString);

Console.WriteLine("Does the shipment contain hazardous material? yes or no >>");
string hazardousMaterial = Console.ReadLine();

double quote = (.55 * distance) + (.73 * weight);

double hazardousWasteCost;
double discount = 0;
double total;

//Check to see if we need to charge for hazardous waste
if (hazardousMaterial == "yes")
{
    hazardousWasteCost = 0.15 * weight;
}
else
{
    hazardousWasteCost = 0;
}

//Check to see if we need to apply a discount

if (distance < 150 && weight > 500)
{
    discount = quote * .10;
}
// Example of an else if

//else if (distance < 300 && weight > 300)
//{
//    discount = quote * .07;
//}

total = quote + hazardousWasteCost - discount;

Console.WriteLine($"Your standard quote amount is: {quote.ToString("C")}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Discounts:");
Console.WriteLine(discount.ToString("C"));

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Additional Expenses:");
Console.WriteLine(hazardousWasteCost.ToString("C"));

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Total: {total.ToString("C")}");