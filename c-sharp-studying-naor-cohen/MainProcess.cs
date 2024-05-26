using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_studying_naor_cohen
{
    public class MainProcess
    {
        public static void Run() 
        {
            Console.WriteLine("Main Process");
            //this.DemoObject();// not working!
            DemoObject();

        }

        public static void DemoObject()
        {
            Console.WriteLine("DemoObject");
            Stock s1 = new Stock("AAPL",189.89,"Apple,INC");
            Stock s2 = new Stock("TSLA", 179.24, "Tesla,INC");
            Stock s3 = new Stock("COKE", 992.75, "Coca-Cola Consolidated,Inc");
            Stock s4;
            Stock[] arr = new Stock[3];
            arr[0] = s1;
            arr[1] = s2;
            arr[2] = s3;
            for(int i=0; i < 3; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
            //TODO - 
            //Do demo method for 3 stocks ( =מנייה)
            //Show start day price, close day price, percent change (=אחוזי שינוי)

            //work on the details of the date: 05/21/2024	
            //those are the details: 
            //https://www.nasdaq.com/market-activity/stocks/aapl/historical
            //https://www.nasdaq.com/market-activity/stocks/tsla/historical
            //https://www.nasdaq.com/market-activity/stocks/coke/historical


            //On each  stock:

            //Do start day (according to the real time above) 
            //Show details
            //Set the price of the stock that was the higher on this day
            //Show details
            //Try to get the percent change and get rejected
            //close the day
            //Show details
            //get the percent change
        }

    }

    public class Stock
    {
        private string stock;
        private double price;
        private string sign;

        public Stock(string stock, double price, string sign)
        {
            this.stock = stock;
            this.price = price;
            this.sign = sign;
        }

        public override string ToString()
        {
            return this.stock +","+this.price +"$"+","+ this.sign;
        }
        //create properties : 
        //Official Name, price, sign (=סמליל) ,starting price , closing price, industry(=תעשייה), exchange (=בורסה)
        // is day active 

        //create methods (פעולות ) 
        //start day - setting the current price and the starting price and day is active
        //finish day - setting the current price and the closing price
        //set price - setting the price
        //Print changes percentage (if the day is still  active it's not return nothing) 
        //Display Price - printing the Sign with the current price. 


        /*- in Stock Create there 3 properties and give them value in the constructor.
         - Create ToString with the values.
         - Create 3 objects.As demand
         - Assign them all into array
         - For on it and print it.*/
    }
}
