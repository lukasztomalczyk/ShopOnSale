using System.ComponentModel;

namespace ShopOnSale.services.Enums
{
    public enum StatusEnum
    {
        [Description("W toku zamówienie")]
        InProgress,
        [Description("Czekam na opłatę")]
        InPayments
    }
}