using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DailyMission.MVC
{
    public class Application : MonoBehaviour
    {
        [SerializeField] private Model model;
        [SerializeField] private Controller controller;
        [SerializeField] private View view;

        public Model Model => model;
        public Controller Controller => controller;
        public View View => view;

        public void Awake()
        {
            // Intro to the application

            // Initialise controllers
            controller.DailyMissionController.Initialise(model.DailyMissionModel, view.DailyMissionView);
        }
    }
}
