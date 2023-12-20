# daily-mission-mvc
Re-visiting my system for providing daily missions/tasks for a game, this time using a Model View Controller implementation.
I only have two nights to prepare this sample code for presentation, so I've skipped branching in this repository. Sorry!
This is my first attempt at a MVC pattern, any feedback would be greatly appreciated.

Progress (night 1):
* Missions are created as Serialized Objects.
* Setup basic MVC hierarchy and scripts.
* Wrote most of the Controller.

Progress (night 2):
* Models, Views and Controllers are now interfaced.
* Application feeds the Model and View to the Controller.
* Controller can select 3 different missions at random and update the view.
* Missions are saved when selected.
* Setup the UI for the view.

Features to be done:
* Load the missions from the previous session.
* Add a timer so that the missions reset in a 24 hour window.
* Add access to the controller so the mission progress can be triggered.

Things I would change:
* Calling the project "Daily Missions" is a bit confusing with the namespacing, as Daily Missions is really a feature for a wider project.
* I'm not sure how views in this pattern normally get updated, so I'm just passing in an object to be cast inside the view.
