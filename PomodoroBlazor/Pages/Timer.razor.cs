using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp
{
    public class TimerBase : ComponentBase, IDisposable
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }
        private int timeLeft = 25 * 60;
        protected string remaining => TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");

        protected bool startButtonDisabled = false;
        protected bool stopButtonDisabled = true;
        private System.Threading.Timer timer;

        protected void Start()
        {
            timer?.Dispose();
            startButtonDisabled = true;
            stopButtonDisabled = false;
            timer = new System.Threading.Timer(_ =>
            {
                if (timeLeft > 0)
                {
                    timeLeft -= 1;
                /* 
                 The Invoke call here is necessary because Blazor enforces a single logical 
                 thread of execution for all its work (component lifecycle methods and event 
                 callbacks).Our timer callback is executing on a completely different thread. 
                 If you omit the Invoke call (and directly call StateHasChanged) you'll run 
                 into an error. By calling Invoke you signal to Blazor to switch 
                 to the correct context and execute this alongside all its other work.
                 */
                    Console.WriteLine("Timer ticked");
                    InvokeAsync(StateHasChanged);
                    JSRuntime.InvokeVoidAsync("setTitle", remaining);
                }
            }, null, 0, 1000);

        }
        protected void Stop()
        {
            /* Here we take the timer and call its Dispose method, 
            essentially stopping and disposing of the timer instance we assigned earler.
            The mysterious looking ? in this statement may seem strange if you're not used to it.

            It's called the null conditional operator and essentially means the right hand "operand" 
            (that's the call to the Change() method in this case) will only be evaluated if the 
            first operand (timer) is not null. */

            timer?.Dispose();
            startButtonDisabled = false;
            stopButtonDisabled = true;
        }

        protected void Reset()
        {
            timeLeft = 25 * 60;
            Stop();
         
                startButtonDisabled = false;
                stopButtonDisabled = true;
            
            
            
        }
        public void Dispose()
        {
            //  dispose as soon as you move away from the component.
            timer?.Dispose();
        }

    }
}