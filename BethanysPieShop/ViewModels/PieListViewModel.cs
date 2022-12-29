using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels;

// this class combines pies and current Category
public class PieListViewModel
{
    public IEnumerable<Pie> Pies { get; }
    public string? CurrentCategory {get;}

    public PieListViewModel(IEnumerable<Pie> pies, string? currentCategory)
    {
        Pies = pies;
        CurrentCategory = currentCategory;
    }
}