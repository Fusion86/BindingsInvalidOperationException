using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;

namespace BindingsInvalidOperationException.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            int pageCounter = 0;
            AddTabCommand = ReactiveCommand.Create(() =>
            {
                Tabs.Add(new TabPageViewModel($"Tab Page {++pageCounter}"));
            });
        }

        ReactiveCommand<Unit, Unit> AddTabCommand { get; }

        [Reactive] public TabPageViewModel SelectedTab { get; set; }

        public ObservableCollectionExtended<TabPageViewModel> Tabs { get; } = new ObservableCollectionExtended<TabPageViewModel>();
    }
}
