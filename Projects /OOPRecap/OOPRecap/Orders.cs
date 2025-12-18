using System;
namespace OOPRecap
{
    public class Orders

    {


        //objects
        private string orderID;
        private string custName;
        private int noOfBurgers;
        private int noOfDrinks;



        /* -- how to gain access to get these objects
             * method 1 --> gets and sets
             * method 2 --> constructor
             * constructors -- 2 kinds
             *              -- Default
             *              -- Paramatized
             * output -- string output
             * built in methods --> ToString
             * 
             * [quick action and refraction] 
             */

        /*public OOPRecap()
		{
            // this is the defult constructor



		}*/

        public Orders(string orderID, string custName, int noOfBurgers, int noOfDrinks)
        {
            this.orderID = orderID;
            this.custName = custName;
            this.noOfBurgers = noOfBurgers;
            this.noOfDrinks = noOfDrinks;
        }

        //gets and sets
        public string OrderID { get => orderID; set => orderID = value; }
        public string CustName { get => custName; set => custName = value; }
        public int NoOfBurgers { get => noOfBurgers; set => noOfBurgers = value; }
        public int NoOfDrinks { get => noOfDrinks; set => noOfDrinks = value; }

        public override string? ToString()
        {
            Console.WriteLine("Your order details are >>>");
            return this.orderID + "\n" +
                this.custName + "\n" +
                this.noOfBurgers + "\n" +
                this.noOfDrinks;
        }



    }
}





