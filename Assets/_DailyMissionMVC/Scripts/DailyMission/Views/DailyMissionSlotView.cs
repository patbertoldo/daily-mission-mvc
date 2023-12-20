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

        public void Initialise(string description, int progress, int goal)
        {
            descriptionText.text = description;
            progressText.text = $"Progress: {progress}/{goal}";
        }
    }
}
