using FactoryMethod.Creator;
using FactoryMethod.Product;
using FactoryMethod.ConcreteProduct;

namespace FactoryMethod.ConcreteCreator
{
    public class GoldCardFactory : CardFactory {
      private int _CardLimit;
      private int _AnnualFee;

      public GoldCardFactory (int CardLimit, int AnnualFee) {
        this._CardLimit = CardLimit;
        this._AnnualFee = AnnualFee;
      }

    public override CreditCard SearchCreditCard()
    {
      return new GoldCard(_CardLimit, _AnnualFee);
    }
  }

}