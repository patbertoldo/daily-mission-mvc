using UnityEngine;
using DailyMission.Views;

namespace DailyMission.MVC
{
    public class View : MonoBehaviour
    {
        [SerializeField] private DailyMissionView dailyMissionView;
        public DailyMissionView DailyMissionView => dailyMissionView;
    }
}
