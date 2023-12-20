using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DailyMission.Views
{
    public class DailyMissionSlotView : MonoBehaviour
    {
        [SerializeField] Text descriptionText;
        [SerializeField] Text progressText;
        [SerializeField] Text rewardText;

        public void Initialise(string description, int progress, int goal, int rewardAmount, string rewardType)
        {
            descriptionText.text = description;
            progressText.text = $"Progress: {progress}/{goal}";
            rewardText.text = $"{rewardAmount.ToString()} {rewardType}";
        }
    }
}
