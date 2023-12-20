using UnityEngine;

namespace DailyMission.Models
{
    public class DailyMissionModel : MonoBehaviour, IModel
    {
        [SerializeField] private DailyMissionData[] dailyMissionDatabase;
        public DailyMissionData[] DailyMissionDatabase => dailyMissionDatabase;

        private const string missionKey = "DailyMissions/Mission_{0}";

        public void SaveMission(int index, DailyMissionData data)
        {
            SavePref(string.Format(missionKey, index), JsonUtility.ToJson(data));
        }

        private void SavePref(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }

        // load
    }
}
