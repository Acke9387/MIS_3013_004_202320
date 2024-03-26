
string[] allLinesOfFile = File.ReadAllLines("product_information.txt");

List<string> names = new List<string>();
List<double> salesPrices = new List<double>();
List<double> msrps = new List<double>();
List<string> manufacturers = new List<string>();
List<string> categories = new List<string>();
List<string> colors = new List<string>();
List<double> weights = new List<double>();

for (int i = 1; i < allLinesOfFile.Length; i++)
{
    //      0           1      2        3              4                 5            6
    //product_name|sale_price|msrp|manufacturer|product_category|product_color|product_weight

    string[] piecesOfLine = allLinesOfFile[i].Split('|');
    names.Add(piecesOfLine[0]);
    salesPrices.Add(Convert.ToDouble(piecesOfLine[1]));
    msrps.Add(Convert.ToDouble(piecesOfLine[2]));
    manufacturers.Add(piecesOfLine[3]);
    categories.Add(piecesOfLine[4]);
    colors.Add(piecesOfLine[5]);
    weights.Add(Convert.ToDouble(piecesOfLine[6]));
}

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine("".PadLeft(25, '*'));

    Console.WriteLine($"Product Name: \t{names[i]}");
    Console.WriteLine($"Sales Price: \t{salesPrices[i].ToString("C")}");
    Console.WriteLine($"MSRP: \t{msrps[i].ToString("C")}");
    Console.WriteLine($"Manufacturer: \t{manufacturers[i]}");
    Console.WriteLine($"Category: \t{categories[i]}");
    Console.WriteLine($"Color: \t{colors[i]}");
    Console.WriteLine($"Weight: \t{weights[i].ToString("N")}");

    Console.WriteLine("".PadLeft(25, '*'));
    Console.WriteLine();
}

double msrpAverage = CalculateAverage(msrps);
Console.WriteLine($"The average msrp is {msrpAverage.ToString("C")}");

double salesPriceAverage = CalculateAverage(salesPrices);
Console.WriteLine($"The average sales price is {salesPriceAverage.ToString("C")}");

double avg = CalculateAverage(new List<double>() { 0, 5, 10 });
Console.WriteLine($"The average of avg is {avg.ToString("C")}");


// {RETURN TYPE} {Function Name} ( {(Optional) Parameters, separated by ','} )
///<summary>This calculates an average from a list of doubles</summary>
double CalculateAverage(List<double> values)
{
    double average = 0;

    double total = 0;
    foreach (double value in values)
    {
        total += value;
    }

    average = total / values.Count;
    return average;
}


//double salesTotal = 0;
//foreach (double salesPrice in salesPrices)
//{
//    salesTotal += salesPrice;
//}

//double salesAverage = salesTotal / salesPrices.Count;

//double msrpTotal = 0;
//foreach (double msrp in msrps)
//{
//    msrpTotal += msrp;
//}

//double msrpAverage = msrpTotal / msrps.Count;