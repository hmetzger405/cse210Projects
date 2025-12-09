using System;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Portfolio myPortfolio = new Portfolio(20000);
        int response = 0;
        while (response != 4)
        {
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
            }
        }

    }
 }