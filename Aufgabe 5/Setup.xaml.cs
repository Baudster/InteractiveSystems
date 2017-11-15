using System.Windows;

namespace FittsExercise
{
    /// <summary>
    /// Interaction logic for Setup.xaml
    /// </summary>
    public partial class Setup : Window
    {
        public int Id { get; set; }
        public int NumberOfTasks { get; set; }
        public bool ResetMousePosition { get; set; }
        public bool Precuing { get; set; }

        public Setup()
        {
            ResetMousePosition = false;
            Precuing = true;
            NumberOfTasks = 2;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
