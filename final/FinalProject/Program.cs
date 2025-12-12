using System;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Portfolio myPortfolio = new Portfolio(20000);
        Calendar myCalender = new Calendar(12);
        int response = 0;
        while (response != 5)
        {
            myCalender.DisplayDate();
            Console.WriteLine($"Cash: ${myPortfolio.GetCash()}");

            response = myMenu.DisplayGameMenu();
            switch(response)
            {
                case 1:
                    myPortfolio.DisplayInvestments();
                    break;
                case 2:
                    int newResponse;
                    newResponse = myMenu.DisplayInvestmentMenu();
                    switch(newResponse)
                    {
                        case 1:
                            string sector = myMenu.DisplaySectorMenu();
                            myPortfolio.CreateIndexFund(sector);
                            break;
                        case 2: 
                            sector = myMenu.DisplaySectorMenu();
                            myPortfolio.CreateOption(sector);
                            break;
                        case 3:
                            myPortfolio.CreateBond();
                            break;
                    }
                    break;  
                case 3:
                    myPortfolio.SellAsset();
                    break;
                case 4:
                    int timeResponse = myMenu.DisplayTimeMenu();
                    switch(timeResponse)
                    {
                        case 1:
                            myCalender.MoveForward(1);
                            break;
                        case 2:
                            myCalender.MoveForward(4);
                            break;
                        case 3:
                            // Move Forward 3 Months
                            myCalender.MoveForward(12);
                            break;
                        case 4:
                            // Move Forward 6 Months
                            myCalender.MoveForward(36);
                            break;
                        case 5:
                            // Move Forward 1 Year
                            myCalender.MoveForward(48);
                            break;
                        case 6:
                            // Move Forward 10 Years
                            myCalender.MoveForward(480);
                            break;
                    }
                    break;           
            }
        }
    }
 }