using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Bond myBond = new Bond(100);
        IndexFund myIndexFund = new IndexFund(100, "General");
        Option myOption = new Option(100, "Tech", DateTime.Now);
        Portfolio myPortfolio = new Portfolio();

        myPortfolio.AddInvestment(myBond);
        myPortfolio.AddInvestment(myIndexFund);
        myPortfolio.AddInvestment(myOption);        




    }
}