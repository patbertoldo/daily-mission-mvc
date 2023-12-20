using DailyMission.Models;
using DailyMission.Views;

namespace DailyMission.Controllers
{
    public interface IController
    {
        public abstract void Initialise(IModel model, IView view);
    }
}
