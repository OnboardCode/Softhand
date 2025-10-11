namespace Softhand.Infrastructure.Services.Abstract;

public interface ISoftApp
{
    static Endpoint Endpoint { get; set; } = new();
    static SoftCall CurrentCall { get; set; } = null!;
    static SoftAccount Account { get; set; } = null!;
    static SoftConfig CurrentConfig { get; set; } = null!;
    static CallInfo LastCallInfo { get; set; } = null!;
    static SoftLogWriter LogWriter { get; set; } = new();
    EpConfig EpConfig { get; set; }
    TransportConfig SipTpConfig { get; set; }
 
    void Init(ISoftMonitor monitor, string app_path);
    void Deinit();
    void LoadConfig(string filename);
    void SaveConfig(string filename);
    void BuildAccountConfigs();
}
