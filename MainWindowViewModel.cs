using KB14261_xamDataGrid_NumericalValues.Infrastructure;
using KB14261_xamDataGrid_NumericalValues.Model;
using System.Collections.ObjectModel;

namespace KB14261_xamDataGrid_NumericalValues
{
    internal class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindowViewModel()
        {
            Products =
            [
                new () { ID = 1, ProductName = "Product 1", Price = 10.0, Length = 1.23, Weight = 52.456 },
                new () { ID = 2, ProductName = "Product 2", Price = 20.0, Length = 2.34, Weight = 53.456 },
                new () { ID = 3, ProductName = "Product 3", Price = 30.0, Length = 3.45, Weight = 54.456 },
                new () { ID = 4, ProductName = "Product 4", Price = 40.0, Length = 4.56, Weight = 55.456 },
                new () { ID = 5, ProductName = "Product 5", Price = 50.0, Length = 5.67, Weight = 56.456 },
                new () { ID = 6, ProductName = "Product 6", Price = 60.0, Length = 6.78, Weight = 57.456 },
                new () { ID = 7, ProductName = "Product 7", Price = 70.0, Length = 7.89, Weight = 58.456 },
                new () { ID = 8, ProductName = "Product 8", Price = 80.0, Length = 8.90, Weight = 59.456 },
                new () { ID = 9, ProductName = "Product 9", Price = 90.0, Length = 9.01, Weight = 60.456 },
                new () { ID = 10, ProductName = "Product 10", Price = 100.0, Length = 10.12, Weight = 61.456 }
            ];
        }
    }
}