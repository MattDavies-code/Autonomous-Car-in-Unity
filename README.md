# Autonomous-Car-in-Unity
### Table of Contents
Designing and implementing an autonomous vehicle within the Unity framework from inception utilizing neural network architectures and genetic algorithms. The car uses three raycasts at the front of the car as inputs. 

1. [Project Motivation](#motivation)
2. [File Descriptions](#files)
3. [Licensing, Authors, and Acknowledgements](#licensing)

## Project Motivation<a name="motivation"></a>
The project is driven by a desire to learn C#, OOP, genetic algorithms, and the intricacies of self-driving challenges. It offers an opportunity to dive into these areas through hands-on experience, providing a deeper understanding of software development, algorithm optimization, and autonomous systems.
![image](https://github.com/MattDavies-code/Autonomous-Car-in-Unity/assets/54101905/7a7c2cd5-d33e-4520-938c-3e8b68190aca)


## File Descriptions <a name="files"></a>

machineController.cs: This file provides the inputs to the neural networks, calculates the fitness function for the genetic algorithm and does the most important job of moving the car itself. 

NeuralNetwork.cs: This file contains the implementation of a neural network, which is essential for processing sensor data and making decisions in the self-driving car. 

GeneticManager.cs: This file is responsible for managing the genetic algorithm that optimizes the neural network's parameters for improved performance.

CameraController.cs: This file controls the behavior of the camera used in the Unity environment.

CharacterNavigationController.cs: This file manages the navigation behavior for non-player characters (NPCs) or pedestrians within the Unity environment.

PedestrianSpawner.cs: This file handles the spawning of pedestrians or other dynamic elements in the simulation. 

WaypointNavigator.cs: This file contains the logic for navigating between waypoints in the environment. 

Waypoint.cs: This file represents a single waypoint in the environment. 

WaypointEditor.cs: This file provides custom editor functionality for manipulating waypoints within the Unity editor. 

WaypointManagerWindow.cs: This file defines a custom editor window for managing waypoints and their properties. 

## Licensing, Authors, Acknowledgements<a name="licensing"></a>
Matthew Davies
