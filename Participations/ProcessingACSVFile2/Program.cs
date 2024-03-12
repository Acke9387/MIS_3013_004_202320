/*
 * 
 * @Author Professor Ackerman
 * Sample Code: File.ReadAllLines();
 */


//         0            1      2         3         4     5      6       7           8              9          10        11
//Transaction_date, Product, Price, Payment_Type, Name, City, State, Country, Account_Created, Last_Login, Latitude, Longitude


string[] linesOfFile = File.ReadAllLines("SalesJan2009.csv");

List<string> names = new List<string>();
List<string> transactionDates = new List<string>();
List<double> prices = new List<double>();
List<string> countries = new List<string>();

for (int i = 1; i < linesOfFile.Length; i++)
{
    string line = linesOfFile[i];
    string[] piecesOfLine = line.Split(',');

    //string name = piecesOfLine[4];
    //string transactionDate = piecesOfLine[0];
    //string country = piecesOfLine[7];
    //double price = Convert.ToDouble(piecesOfLine[2].Replace("\"", ""));
    //Console.WriteLine($"{name} made a purchase on {transactionDate} in {country} for {price.ToString("C")}");

    string name = piecesOfLine[4];
    string transactionDate = piecesOfLine[0];
    string country = piecesOfLine[7];
    string paymentType = piecesOfLine[3];
    double price = Convert.ToDouble(piecesOfLine[2].Replace("\"", ""));
    if (country == "United States" && paymentType == "Visa")
    {
        names.Add(name);
        transactionDates.Add(transactionDate);
        prices.Add(price);
        countries.Add(country); 
    }

}

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{names[i]} made a purchase on {transactionDates[i]} for {prices[i].ToString("C")}");
}
