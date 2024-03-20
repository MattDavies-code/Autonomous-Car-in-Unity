# Autonomous-Car-in-Unity
### Table of Contents
Designing and implementing an autonomous vehicle within the Unity framework from inception utilizing neural network architectures and genetic algorithms.

1. [Project Motivation](#motivation)
2. [File Descriptions](#files)
3. [Licensing, Authors, and Acknowledgements](#licensing)

## Project Motivation<a name="motivation"></a>
The project is driven by a desire to learn C#, OOP, genetic algorithms, and the intricacies of self-driving challenges. It offers an opportunity to dive into these areas through hands-on experience, providing a deeper understanding of software development, algorithm optimization, and autonomous systems.

## File Descriptions <a name="files"></a>
CarController.cs is a script that provides the inputs to the neural networks, calculates the fitness function for the genetic algorithm and does the most important job of moving the car itself.  
machineController.cs: This file likely serves as the main controller for the self-driving vehicle within the Unity environment. It would contain code to manage the vehicle's behavior, interactions with the environment, and integration with neural networks and genetic algorithms.  
NeuralNetwork.cs: This file contains the implementation of a neural network, which is essential for processing sensor data and making decisions in the self-driving car. It would include functions for forward propagation, backpropagation, and training the network using techniques like gradient descent or backpropagation.  
GeneticManager.cs: This file is responsible for managing the genetic algorithm that optimizes the neural network's parameters for improved performance. It would include functions for creating initial populations, performing selection, crossover, mutation, and evaluating fitness.  
CameraController.cs: This file controls the behavior of the camera(s) used in the Unity environment. It likely includes functions to adjust camera position, orientation, and field of view to provide different perspectives for the self-driving car or other elements in the simulation.  
CharacterNavigationController.cs: This file manages the navigation behavior for non-player characters (NPCs) or pedestrians within the Unity environment. It would include functions to calculate paths, avoid obstacles, and move NPCs or pedestrians to their destinations.  
PedestrianSpawner.cs: This file handles the spawning of pedestrians or other dynamic elements in the simulation. It would include functions to instantiate NPCs or pedestrians at specified locations and manage their behavior once spawned.  
WaypointNavigator.cs: This file contains the logic for navigating between waypoints in the environment. It would include functions to calculate paths, follow waypoints, and make decisions based on environmental cues.  
Waypoint.cs: This file represents a single waypoint in the environment. It would include data such as position, orientation, and possibly metadata used for navigation or other purposes.  
WaypointEditor.cs: This file provides custom editor functionality for manipulating waypoints within the Unity editor. It would include functions to visualize waypoints, adjust their properties, and update the environment accordingly.  
WaypointManagerWindow.cs: This file defines a custom editor window for managing waypoints and their properties. It would include functions to create, delete, and modify waypoints, as well as other management tasks within the Unity editor interface.  

## Licensing, Authors, Acknowledgements<a name="licensing"></a>
Matthew Davies
