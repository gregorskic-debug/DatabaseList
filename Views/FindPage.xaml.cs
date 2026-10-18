namespace MovieApp.Views;

public partial class FindPage : ContentPage
{
    public FindPage()
    {
        InitializeComponent();
        Title = "List Movies";
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        var movieTemplate = new DataTemplate(typeof(TextCell));
        movieTemplate.SetBinding(TextCell.TextProperty,"Title");
        movieTemplate.SetBinding(TextCell.DetailProperty,"Rating;");

        lstMovies.ItemTemplate = movieTemplate;
        lstMovies.ItemsSource = App.MovieList.GetMovies();
    }
   
}