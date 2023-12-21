# daily-mission-mvc
Re-visiting my system for providing daily missions/tasks for a game, this time using a Model View Controller implementation.
I only have two nights to prepare this sample code for presentation, so I've skipped branching in this repository. Sorry!
This is my first attempt at a MVC pattern, any feedback would be greatly appreciated.

Purpose:
MMO and mobile games often have daily missions for the player to complete for currency or item rewards. The player is offered 3 missions to complete within the next 24 hours and are shown the rewards for each mission, respectively. Once missions are selected at random, they are set until the next reset time. Progress is updated in the View until it is in a claimable state.
I have implemented this feature for Wild Life: Puzzle Story which went as far as pooling missions into difficulty categories and randomly selecting missions with a weight system so that generally easier missions would be chosen, and harder missions were less frequent but had better rewards. Harder missions also had multiple requirements.

Progress (night 1):
* Missions are created as Serialized Objects.
* Setup basic MVC hierarchy and scripts.
* Wrote most of the Controller.

Progress (night 2):
* Models, Views and Controllers are now interfaced.
* Application feeds the Model and View to the Controller.
* Controller can select 3 different missions at random and update the view.
* Missions are saved when selected.
* Setup the UI for the View.

Features to be done:
* Load the missions from the previous session.
* Add a timer so that the missions reset in a 24 hour window.
* Add access to the controller so the mission progress can be triggered.
* Unit tests: validate Serialized Objects have the data they need; send test data through the UpdateView() function; test loading and saving; test getting new missions.

Things I would change:
* Calling the project "Daily Missions" is a bit confusing with the namespacing, as Daily Missions is really a feature for a wider project.
* I'm not sure how Views in this pattern normally get updated, so I'm just passing in an object to be cast inside the View.

Things I have learned:
MVC is an interesting pattern to follow in Unity. I can see that Application script holds all the power for starting each controller and passes them their dependencies, which is great.
It seems to force a level of abstraction and use of interfaces, Single Responsibility principle - which we love.
