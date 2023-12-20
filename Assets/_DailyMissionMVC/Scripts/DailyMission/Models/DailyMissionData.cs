using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DailyMission.Models
{
    [Serializable]
    [CreateAssetMenu(fileName = "Daily Mission", menuName = "Scriptable Object/Daily Mission", order = 0)]
    public class DailyMissionData : ScriptableObject
    {
        [SerializeField]
        private string description;
        public string Description => description;

        [SerializeField]
        private int goal = 1;
        public int Goal => goal;

        public int Progress { get; set; }
        
        /// <summary>
        /// Note: progress is not capped to the goal.
        /// </summary>
        public void AddProgress(int progress) { progress += progress; }

        public bool IsComplete => Progress >= goal;

        // Making rewards basic for the simplicity of the example, rewards should have their own dedicated system.
        private int rewardAmount;
        public int RewardAmount => rewardAmount;

        private string rewardType;
        public string RewardType => rewardType;

        public bool IsClaimed { get; set; }

        public Dictionary<string, object> GetSaveData()
        {
            return new Dictionary<string, object>()
            {
                { "Progress", Progress.ToString() },
                { "IsClaimed", IsClaimed.ToString() }
            };
        }
    }
}
