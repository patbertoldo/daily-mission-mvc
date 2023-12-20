using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DailyMission.Models;

namespace DailyMission.Views
{
    public class DailyMissionView : MonoBehaviour, IView
    {
        [SerializeField] private DailyMissionSlotView[] missionSlots;

        public void UpdateView(object data)
        {
            var missions = data as DailyMissionData[];

            for (int i = 0; i < missions.Length; i++)
            {
                missionSlots[i].Initialise(missions[i].Description, missions[i].Progress, missions[i].Goal);
            }
        }
    }
}
