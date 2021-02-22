using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
  public class GoldCard : CreditCard
  {
     private readonly string _CardType;
     private int _CardLimit;
     private int _AnnualFee;

      public GoldCard(int CardLimit, int AnnualFee) {
        this._CardType = "Gold";
        this._CardLimit = CardLimit;
        this._AnnualFee = AnnualFee;
      }

    public string CardType {
      get { return _CardType; }
    }

     public int CardLimit {
      get { return _CardLimit; }
      set { _CardLimit = value; }
    }

     public int AnnualFee {
      get { return _AnnualFee; }
      set { _AnnualFee = value; }
    }
  }
}