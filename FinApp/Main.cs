using System;
using System.Collections.Generic;


namespace FinanceApp
{
    public class Client
    {
        public int AccountNumber { get; set; }				// account number deverá ser um número único (1 acc - n clientes)
        public string ClientName { get; set; }				// 
        public double GlobalPortfolio { get; set; }			// retorna valor total portfolio
        public double LocalPortfolio { get; set; }			// retorna valor total portfolio
        public List<Portfolio> Portfolios { get; set; }		// contagem de portfolios em formato de lista

        public double TotalPosition
        {
            get { return GlobalPortfolio + LocalPortfolio; } //retorna valor total investido
        }

        public int CountPortfolios()
        {
            return Portfolios.Count;  //conta itens na lista
        }

        public Client()
        {
            Portfolios = new List<Portfolio>(); //gera uma lista para um novo cliente 
        }
    }

    public class Portfolio
    {
        public int PortfolioNumber { get; set; } 			//identificador unico
        public int ClientNumber { get; set; }				//identificador do cliente
        public string PortfolioType { get; set; } 			// "Local" or "Global"
        public Dictionary<int, Stock> Stocks { get; set; }	//inicia um dicionario para agregar parametros de 1 ação

        public Portfolio()
        {
            Stocks = new Dictionary<int, Stock>();
        }
    }

    public class Stock
    {
        public string StockName { get; set; }	//cria os atributos básicos de uma ação  
        public int Quantity { get; set; }		//
        public double LastPrice { get; set; }	//
    }



	/** 
	
	Esta classe servirá para listar os atributos de 1 ação,
	conceito: n ações para 1 portfolio
	n portfolios para 1 cliente
	
	**/
    
	public class Grid
    {
        public string StockName { get; set; }			// atributos básicos
        public double LastPrice { get; set; }			//
        public double LastChange { get; set; } 			// valor(es) em formato de porcentagem
        public double LastSixMonths { get; set; } 		// 
        public double LastTwelveMonths { get; set; } 	// 
    }

    public class Simulations
    {
        public double CalculateRisk(Portfolio portfolio)
        {
            // fórmulas de risco
            return 0.0;
        }
    }



    public class Reports
    {
        public double ReturnPerformance(Portfolio portfolio)
        {
            // buscar opcoes de relatorio
            return 0.0; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize client
            Client client = new Client
            {
                AccountNumber = 001,
                ClientName = "Jack",
                LocalPortfolio = 0.00,
                GlobalPortfolio = 0.0
            };

            // inicializa um portfolio
            Portfolio localPortfolio = new Portfolio
            {
                PortfolioNumber = 001,
                ClientNumber = client.AccountNumber,
                PortfolioType = "Local"
            };

            // cria ação para compor portfolio
            Stock stock = new Stock
            {
                StockName = "TSLA",
                Quantity = 5,
                LastPrice = 20.00
            };

            localPortfolio.Stocks.Add(1, stock);

            // Add portfolio
            client.Portfolios.Add(localPortfolio);

            // imprime atributos que foram criados e agregados ao objeto Cliente
            Console.WriteLine($"Client Name: {client.ClientName}");
            Console.WriteLine($"Total Position: USD {client.TotalPosition:N2}");
            Console.WriteLine($"Number of Portfolios: {client.CountPortfolios()} \n");

            double totalStockValue = stock.Quantity * stock.LastPrice;
			
            Console.WriteLine($"Stock: {stock.StockName}");
			Console.WriteLine($"Quantity: {stock.Quantity}");
			Console.WriteLine($"Last Price: USD {stock.LastPrice:N2}");
            Console.WriteLine($"Total in {stock.StockName} Stock Value: USD {totalStockValue:N2} \n");

            // Grid Example
            Grid stockGrid = new Grid
            {
                StockName = "TSLA",
                LastPrice = 20.00,
                LastChange = 2.0,
                LastSixMonths = 5.0,
                LastTwelveMonths = 7.0
            };

            Console.WriteLine($"Stock Performance:");
            Console.WriteLine($"- Last Price: USD {stockGrid.LastPrice:N2}");
            Console.WriteLine($"- Last Change: {stockGrid.LastChange}%");
            Console.WriteLine($"- Last Six Months: {stockGrid.LastSixMonths}%");
            Console.WriteLine($"- Last Twelve Months: {stockGrid.LastTwelveMonths}%");
        }
    }
}
