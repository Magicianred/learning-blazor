using System;
using Microsoft.AspNetCore.Components;

namespace Pomodoro.Pages 
{
    public class TimerBase : ComponentBase, IDisposable // Component base classes are simply C# classes from which your components can inherit.
    {
        public DateTime timerStarted;
        private int _timeLeft = 60 * 25; // 60 seconds in each minute, 25 minutes in a pomodoro session.
        public string TimeLeft => TimeSpan.FromSeconds(_timeLeft).ToString(@"mm\:ss"); // Computed property using a Expression-bodied members use the lambda expression syntax to define methods that contain a single expression._
        private System.Threading.Timer _timer;
        /*
        The protected keyword is an access modifier that makes a member public only to its subclasses, but private to every other class.
        */
        protected void Start()
        {
            // Update started time.
            timerStarted = DateTime.Now;
            // start the timer.
            _timer?.Dispose(); // dispose any timers if they exist, so we don't end up creating multiples.
            _timer = new System.Threading.Timer(_ => { // timer works using a callback function
                if (_timeLeft > 0)
                {
                    _timeLeft -= 1; // each time the timer ticks, we want to remove 1 from _timeLeft
                    InvokeAsync(StateHasChanged); // Signal to blazor that something has changed.
                    // Invoke signals to blazor to swtich to the correct context and execute this alongside all its other work.
                }
            }, null, 0, 1000); // we don't need state data, so null. 0 because we don
        } // each time Start is click, our method will be invoked, the timer will start and _timeleft will be decremented.
        protected void Stop()
        {
            // Stop the timer.
            _timer?.Dispose();
            /* ? = null conditional operator.
                the code to the right of it will only be evaluated if the code to the left of it not null
            */
        }
        protected void Reset()
        {
            // Reset the timer.
            _timeLeft = 60 * 25;
        }
        public void Dispose()
        {
            _timer?.Dispose();
        }

    }
}