using System.ComponentModel;

namespace HeadHunter.Enums
{
    public enum Category
    {
        [Description("Удалённая работа")]
        RemoteJob = 0,
        [Description("Подработка")]
        PartTimeJob = 1,
        [Description("Продавец")]
        Seller = 2,
        [Description("Кассир")]
        Cashier = 3,
        [Description("Водитель")]
        Driver = 4,
        [Description("Курьер")]
        Courier = 5,
        [Description("Администратор")]
        Administrator = 6,
        [Description("Опрератор")]
        Operator = 7,
        [Description("Программист")]
        Programmer = 8,
        [Description("Менеджер")]
        Manager = 9
    }
}
