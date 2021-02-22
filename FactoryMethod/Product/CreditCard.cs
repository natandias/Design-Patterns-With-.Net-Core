namespace FactoryMethod.Product {
  public interface CreditCard {
    string CardType { get; }
    int CardLimit { get; set; }
    int AnnualFee { get; set; }
  }
}