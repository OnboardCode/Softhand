namespace Softhand.Application.ViewModels;

public partial class AVConfigPageViewModel : BaseViewModel
{

    [ObservableProperty]
    private string cancelBtnTxt = string.Empty;

    [ObservableProperty]
    private string okBtnTxt = string.Empty;

    [ObservableProperty]
    private SoftAccountConfigModel accountConfig = default!;
    
    [RelayCommand]
    private async Task Init(SoftConfig inAccCfg = null!)
    {
        await Task.Run(() =>
        {
            OkBtnTxt = "Save";
            CancelBtnTxt = "Cancel";
            Title = "Audio & Video";
            this.AccountConfig = new SoftAccountConfigModel(inAccCfg);
        });
    }
    [RelayCommand]
    private static async Task Save()
    {
        await Task.CompletedTask;
    }
    [RelayCommand]
    private static async Task Cancel()
    {
        await Task.CompletedTask;
    }
}

