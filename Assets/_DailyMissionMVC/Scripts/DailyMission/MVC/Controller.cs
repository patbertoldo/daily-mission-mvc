using UnityEngine;
using DailyMission.Controllers;

namespace DailyMission.MVC
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] private DailyMissionController dailyMissionController;
        public DailyMissionController DailyMissionController => dailyMissionController;
    }
}
