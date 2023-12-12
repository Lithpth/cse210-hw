using System;


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MarketBuy marketBuy = new MarketBuy("r",11.14f,140f,"buy");

            // Temporary
            marketBuy.GetOrder(150);
            Console.ReadLine();
        }
    }
    public abstract class Order
    {
        private int _id;
        private string _assetName;
        private string _orderType;
        public float _balance;

        public Order(string assetName, string orderType, int id, float balance = 143.5f)
        {
            _assetName = assetName;
            _orderType = orderType;
            _balance = balance;

        }

        protected Order(string assetName)
        {
        }

        // Id
        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }
        // Name
        public string GetAssetName()
        {
            return _assetName;
        }
        public void SetAssetName(string assetName)
        {
            _assetName = assetName;
        }
        public string GetOrderType()
        {
            return _orderType;
        }
        public void SetOrderType(string orderType)
        {
            _orderType = orderType;
        }
        //whether it be buy or sell
        public abstract void GetOrder(float balance);
    }
    public class MarketBuy : Order
    {
        private float _price;
        // this is an
        // MarketBuy(buy
        public MarketBuy(string assetName, float price, float balance, string orderType) : base (assetName)
        {
            _price = price;
            _balance = balance;

        }
        public float GetPrice()
        {
            return _price;
        }
        public void SetPrice(float price)
        {
            _price = price;
        }
        public override void GetOrder(float balance)
        {
            // do the function of how many you can buy at a price

            // show user total balance before 
            // show user the price of the asset and total balance of the asset
            Console.WriteLine("Amount you'd like to buy: ");
            float amount = float.Parse(Console.ReadLine());
            balance = _balance - amount;
            Console.WriteLine(balance);
        }
    }
    public class MarketSell : Order
    {
        public MarketSell(string assetName, string orderType, int id, float balance = 143.5F) : base(assetName, orderType, id, balance)
        {
        }
        public override void GetOrder(float balance)
        {
            // do the function of how many you can buy at a price

            // show user total balance before 
            // show user the price of the asset and total balance of the asset
            Console.WriteLine("Amount you'd like to buy: ");
            float amount = float.Parse(Console.ReadLine());
            balance = _balance + amount;
            Console.WriteLine(balance);
        }
    }
    public class LimitBuy : Order
    {
        public LimitBuy(string assetName, string orderType, int id, float balance = 143.5F) : base(assetName, orderType, id, balance)
        {
        }
        public override void GetOrder(float balance)
        {
            // do the function of how many you can buy at a price

            // show user total balance before 
            // show user the price of the asset and total balance of the asset
            Console.WriteLine("Amount you'd like to buy: ");
            float amount = float.Parse(Console.ReadLine());
            balance = _balance - amount;
            Console.WriteLine(balance);
        }
    }
    public class LimitSell : Order
    {
        public LimitSell(string assetName, string orderType, int id, float balance = 143.5F) : base(assetName, orderType, id, balance)
        {
        }
        public override void GetOrder(float balance)
        {
            // do the function of how many you can buy at a price

            // show user total balance before 
            // show user the price of the asset and total balance of the asset
            Console.WriteLine("Amount you'd like to sell: ");
            float amount = float.Parse(Console.ReadLine());
            balance = _balance + amount;
            Console.WriteLine(balance);
        }

    }