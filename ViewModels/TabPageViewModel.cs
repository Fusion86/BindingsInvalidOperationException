namespace BindingsInvalidOperationException.ViewModels
{
    public class TabPageViewModel : ViewModelBase
    {
        public TabPageViewModel(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
