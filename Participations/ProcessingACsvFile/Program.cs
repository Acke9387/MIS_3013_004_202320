
using System.Globalization;

string[] allLinesOfFile = File.ReadAllLines("sales_data_sample.csv");

// skips the header row
//for (int i = 1; i < allLinesOfFile.Length; i++)
//{

//}

double salesTotalFor2003 = 0;
double salesTotalFor2004 = 0;
double salesTotalFor2005 = 0;
//double januaryTotal = 0;

double[] salesForMonth = new double[13];

foreach (string line in allLinesOfFile.Skip(1))
{
    //             0             1            2            3          4       5        6      7      8         9       10       11        12         13        14       15           16       17    18    19         20         21          22               23          24
    //line : "ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE"
    string[] piecesOfLine = line.Split(',');
    int monthNum = Convert.ToInt32(piecesOfLine[8]);

    if (piecesOfLine[6] == "Shipped")
    {
        if (piecesOfLine[9] == "2003")
        {
            salesTotalFor2003 += Convert.ToDouble(piecesOfLine[4]);
        }
        else if (piecesOfLine[9] == "2004")
        {
            salesTotalFor2004 += Convert.ToDouble(piecesOfLine[4]);
        }
        else if (piecesOfLine[9] == "2005")
        {
            salesTotalFor2005 += Convert.ToDouble(piecesOfLine[4]);
        }

        salesForMonth[monthNum] += Convert.ToDouble(piecesOfLine[4]);
        //if (monthNum == "1")
        //{
        //    januaryTotal += Convert.ToDouble(piecesOfLine[4]);
        //}
    }
}

Console.WriteLine($"The total sales for 2003 was {salesTotalFor2003.ToString("C")}");
Console.WriteLine($"The total sales for 2004 was {salesTotalFor2004.ToString("C")}");
Console.WriteLine($"The total sales for 2005 was {salesTotalFor2005.ToString("C")}");
Console.WriteLine($"The total sales for all years was {(salesTotalFor2005 + salesTotalFor2003 + salesTotalFor2004).ToString("C")}");

//Console.WriteLine($"The total sales for January was {januaryTotal.ToString("C")}");

for (int i = 1; i < salesForMonth.Length; i++)
{
    string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
    if (i == 1)
    {
        month = "January";
    }
    //... all the way to i == 12 "December"

    Console.WriteLine($"The total sales for {month} was {salesForMonth[i].ToString("C")}");
}