using AnimalClass;
using System.Windows;


namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Animal animal = new Animal("Lion");

        public MainWindow()
        {
            InitializeComponent();            
            lblAnimal.Content = animal.Kind;
        }

        private void btnEat_Clicked(object sender, RoutedEventArgs e)
        {
            lblAnimal.Content = $"Kind: {animal.Kind} \nAction: {animal.Eat()}";
        }

        private void btnWalk_Clicked(object sender, RoutedEventArgs e)
        {
            lblAnimal.Content = $"Kind: {animal.Kind} \nAction: {animal.Walk()}";
        }

        private void btnGrowl_Clicked(object sender, RoutedEventArgs e)
        {
            lblAnimal.Content = $"Kind: {animal.Kind} \nAction: {animal.Growl()}";
        }
    }
}
