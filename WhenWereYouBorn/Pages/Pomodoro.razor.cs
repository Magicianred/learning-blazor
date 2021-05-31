using Microsoft.AspNetCore.Components;
using System;
using Microsoft.JSInterop;

namespace WhenWereYouBorn.Pages
{
    public class PomodoroBase : ComponentBase, IDisposable
    {
    [Inject]
    protected IJSRuntime JSRuntime { get; set; }
    private int _timeLeft = 25 * 60;
    protected bool startButtonDisabled = false;
    protected bool stopButtonDisabled = true;
    private System.Threading.Timer _timer;
    protected string _remaining => TimeSpan.FromSeconds(_timeLeft).ToString(@"mm\:ss");

    protected void Start()
    {
        _timer?.Dispose();
        startButtonDisabled = true;
        stopButtonDisabled = false;
        _timer = new System.Threading.Timer(_ => 
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= 1;
                Console.WriteLine($"timer ticker: Remaining - {_timeLeft}");
                InvokeAsync(StateHasChanged);
                JSRuntime.InvokeVoidAsync("setTitle", _remaining);
            }
        }, null, 0, 1000);
    }
    protected void Stop()
    {
        _timer?.Dispose();
        startButtonDisabled = false;
        stopButtonDisabled = true;
    }

    protected void Reset()
    {
        _timeLeft = 25 * 60;

    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}
    }
