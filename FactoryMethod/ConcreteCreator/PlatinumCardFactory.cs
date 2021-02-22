using FactoryMethod.Creator;
using FactoryMethod.Product;
using FactoryMethod.ConcreteProduct;

namespace FactoryMethod.ConcreteCreator
{
    public class PlatinumCardFactory : CardFactory {
      private int _CardLimit;
      private int _AnnualFee;

      public PlatinumCardFactory (int CardLimit, int AnnualFee) {
        this._CardLimit = CardLimit;
        this._AnnualFee = AnnualFee;
      }

    public override CreditCard SearchCreditCard()
    {
      return new PlatinumCard(_CardLimit, _AnnualFee);
    }
  }

}