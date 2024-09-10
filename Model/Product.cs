using KB14261_xamDataGrid_NumericalValues.Infrastructure;

namespace KB14261_xamDataGrid_NumericalValues.Model
{
    internal class Product : ObservableObject
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        private String _productName = String.Empty;
        public String ProductName
        {
            get { return _productName; }
            set { _productName = value; OnPropertyChanged(); }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged(); }
        }

        private double _length;
        public double Length
        {
            get { return _length; }
            set { _length = value; OnPropertyChanged(); }
        }

        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; OnPropertyChanged(); }
        }

        public Product()
        {
        }
    }
}