using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DailyMission.Models;

namespace DailyMission.MVC
{
    public class Model : MonoBehaviour
    {
        [SerializeField] private DailyMissionModel dailyMissionModel;
        public DailyMissionModel DailyMissionModel => dailyMissionModel;
    }
}
