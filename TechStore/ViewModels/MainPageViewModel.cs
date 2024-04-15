
using System.ComponentModel;
using TechStore.DataAccess;
using TechStore.Models;

namespace TechStore.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private readonly TechStoreDbContext _dbContext;
        private List<Category>? _categories;
        private List<Product>? _products;
        private List<Advertisements>? _advertisements;

        public MainPageViewModel(TechStoreDbContext dbContext)
        {
            _dbContext = dbContext;

            LoadData();
        }

        public List<Category> Categories
        {
            get => _categories!;
            set
            {
                _categories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }

        public List<Product> Products
        {
            get => _products!;
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }

        }

        public List<Advertisements> Advertisements
        {
            get => _advertisements!;
            set
            {
                _advertisements = value;
                OnPropertyChanged(nameof(Advertisements));
            }
        }

        private void LoadData()
        {
            try
            {
                Categories = _dbContext.Categories.ToList();
                Products = _dbContext.Products.ToList();
                Advertisements = _dbContext.Advertisements.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}