
string[] allLinesOfFile = File.ReadAllLines("sales_data_sample.csv");

// skips the header row
//for (int i = 1; i < allLinesOfFile.Length; i++)
//{

//}

double salesTotalFor2003 = 0;
double salesTotalFor2004 = 0;
double salesTotalFor2005= 0;

foreach (string line in allLinesOfFile.Skip(1))
{
    //             0             1            2            3          4       5        6      7      8         9       10       11        12         13        14       15           16       17    18    19         20         21          22               23          24
    //line : "ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE"
    string[] piecesOfLine = line.Split(',');

    if (piecesOfLine[6] == "Shipped")
    {
        if (piecesOfLine[9] == "2003")
        {
            salesTotalFor2003 += Convert.ToDouble(piecesOfLine[4]);
        }
    }
}

Console.WriteLine($"The total sales for 2003 was {salesTotalFor2003.ToString("C")}");