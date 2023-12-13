using System;


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        float initialBalance = 143.5f;
        float initialAssetAmount = 0f;
        MarketBuy marketBuy = new MarketBuy("Asset", 100.14f, initialBalance, initialAssetAmount);
        MarketSell marketSell = new MarketSell("Asset", 100.14f, initialBalance, initialAssetAmount);
        LimitBuy limitBuy = new LimitBuy("Asset", initialBalance, initialAssetAmount);
        LimitSell limitSell = new LimitSell("Asset", initialBalance, initialAssetAmount);

        marketBuy.GetOrder();
        marketSell.GetOrder();
        limitBuy.GetOrder();
        limitSell.GetOrder();
        Console.ReadLine();
    }
}
public abstract class Order
{
    private int _id;
    private string _assetName;
    protected float _balance;
    protected float _assetAmount;
    protected float _price;


    public Order(string assetName, int id, float balance = 143.5f, float assetAmount = 0f, float price = 100.14f)
    {
        _id = id;
        _assetName = assetName;
        _balance = balance;
        _assetAmount = assetAmount;
        _price = price;
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

    public float GetPrice()
    {
        return _price;
    }
    public void SetPrice(float price)
    {
        _price = price;
    }
    //whether it be buy or sell
    public abstract void GetOrder();
}
public class MarketBuy : Order
{
    // this is an
    // MarketBuy(buy
    public MarketBuy(string assetName, float price, float balance, float assetAmount)
        : base(assetName, 1, balance, assetAmount)
    {
    }
    public override void GetOrder()
    {
        // do the function of how many you can buy at a price

        // show user total balance before 
        // show user the price of the asset and total balance of the asset
        Console.WriteLine("Buy at market price: {0}", _price);
        float amount = float.Parse(Console.ReadLine());
        _balance -= amount * _price;
        _assetAmount += amount;

        Console.WriteLine("New Balance: {0}", _balance);
        Console.WriteLine("New Asset Amount: {0}", _assetAmount);
    }
}
public class MarketSell : Order
{
    public MarketSell(string assetName, float price, float balance, float assetAmount)
        : base(assetName, 2, balance, assetAmount)
    {
    }
    public override void GetOrder()
    {
        Console.WriteLine("Sell at market price: {0}", _price);
        float amount = float.Parse(Console.ReadLine());
        _balance -= amount * _price;
        _assetAmount += amount;

        Console.WriteLine("New Balance: {0}", _balance);
        Console.WriteLine("New Asset Amount: {0}", _assetAmount);
    }
}
public class LimitBuy : Order
{
    private float _limitPrice;
    public float GetLimitPrice()
    {
        return _limitPrice;
    }
    public void SetLimitPrice(float limitPrice)
    {
        _limitPrice = limitPrice;
    }
    public LimitBuy(string assetName, float balance, float assetAmount)
        : base(assetName, 3, balance, assetAmount)
    {
    }
    public override void GetOrder()
    {
        Console.WriteLine("Enter limit price");
        float userLimitPrice = float.Parse(Console.ReadLine());
        if (userLimitPrice >= _price)
        {
            Console.WriteLine("Limit price is greater than market price.");
            Console.WriteLine("Ordering at market price: {0}", _price);
            Console.WriteLine("New Balance: {0}", _balance);
            Console.WriteLine("New Asset Amount: {0}", _assetAmount);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Limit Buy", _price);
            float amount = float.Parse(Console.ReadLine());

            Console.WriteLine("New Balance: {0}", _balance);
            Console.WriteLine("New Asset Amount: {0}", _assetAmount);
        }
    }

    public static implicit operator LimitBuy(MarketSell v)
    {
        throw new NotImplementedException();
    }
}
public class LimitSell : Order
{
    private float _limitPrice;
    public float GetLimitPrice()
    {
        return _limitPrice;
    }
    public void SetLimitPrice(float limitPrice)
    {
        _limitPrice = limitPrice;
    }
    public LimitSell(string assetName, float balance, float assetAmount)
        : base(assetName, 3, balance, assetAmount)
    {
    }
    public override void GetOrder()
    {
        // do the function of how many you can buy at a price

        // show user total balance before 
        // show user the price of the asset and total balance of the asset

        Console.WriteLine("Enter limit price");
        float userLimitPrice = float.Parse(Console.ReadLine());
        if (userLimitPrice <= _price)
        {
            Console.WriteLine("Limit price is less than market price.");
            Console.WriteLine("Ordering at market price: {0}", _price);
            Console.WriteLine("New Balance: {0}", _balance);
            Console.WriteLine("New Asset Amount: {0}", _assetAmount);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Limit Sell: {0}", _price);
            float amount = float.Parse(Console.ReadLine());

            Console.WriteLine("New Balance: {0}", _balance);
            Console.WriteLine("New Asset Amount: {0}", _assetAmount);
        }
    }

}