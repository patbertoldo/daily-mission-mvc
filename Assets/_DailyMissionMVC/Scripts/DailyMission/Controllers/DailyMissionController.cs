using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DailyMission.Models;
using DailyMission.Views;
using System.Linq;

namespace DailyMission.Controllers
{
    /// <summary>
    /// Controls which daily missions are active.
    /// Saves and loads from <see cref ="DailyMissionModel"/>.
    /// </summary>
    public class DailyMissionController : MonoBehaviour, IController
    {
        private List<Models.DailyMissionData> activeDailyMissions = new ();
        private const int maximumMissionCount = 3;

        private DailyMissionModel dailyMissionModel;
        private DailyMissionView dailyMissionView;

        public void Initialise(IModel model, IView view)
        {
            dailyMissionModel = model as DailyMissionModel;

            while (activeDailyMissions.Count < maximumMissionCount)
            {
                SelectNewMission();
            }

            dailyMissionView.UpdateView(activeDailyMissions);
        }

        private void SelectNewMission()
        {
            var selectableMissions = dailyMissionModel.DailyMissionDatabase.ToList();

            // Remove active missions from selectableMissions so we can't select duplicates
            foreach (var selectedMission in selectableMissions)
            {
                foreach (var activeMission in activeDailyMissions)
                {
                    if (selectedMission == activeMission)
                    {
                        selectableMissions.Remove(selectedMission);
                        break;
                    }
                }
            }

            // Pick a new mission index at random
            int randomIndex = Random.Range(0, selectableMissions.Count);

            // Make a new instance of the Serialized Object so we're not editing the original
            var newActiveMission = Instantiate<DailyMissionData>(selectableMissions[randomIndex]);
            activeDailyMissions.Add(newActiveMission);

            // Save as selected
            dailyMissionModel.SaveMission(activeDailyMissions.Count - 1, newActiveMission);
        }
    }
}
