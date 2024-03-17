using Microsoft.AspNetCore.Components;

namespace CWEnterprise.Shared.ClientLib.Commons.Abstract;

public abstract class ComponentViewModelBase<TModel> : ComponentBase, IDisposable
    where TModel : ViewModelBase
{

    [Inject]
    public TModel Model { get; private set; } = null!;

    [Inject]
    protected NavigationManager Navigation { get; private set; } = null!;


    public void Dispose()
    {
        Model.PropertyChanged -= HandleChanged;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Model.PropertyChanged += HandleChanged;
    }

    protected void HandleChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        InvokeAsync(StateHasChanged);
    }
}
