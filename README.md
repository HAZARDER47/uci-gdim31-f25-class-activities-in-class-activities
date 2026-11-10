# in-class-activities
## Devlogs
### W1
If you move the Camera off the Cat GameObject, you will get a second-person perspective similar to a monitor view.
### W2
1. The r, g, and b variables are floats because color values can have decimals between 0.0 and 1.0.

2. The _bounce variable is an int because it counts the number of bounces, and the number of bounces should be a whole number.

3. The error told me that the line was missing a semicolon. In C#, a statement usually needs a semicolon at the end.
### W3
#Table 11
Activity 1:
1. Parameters (Input): An `int` for the player's current friendship level, and a `bool` flag for whether the player knows the character's secret.
Return Type (Output)**: A `string` representing the character's text response.
2. Parameters (Input): A `float` representing the player's current sanity level (from 0.0 to 1.0 or 0 to 100).
Return Type (Output): `void` (no output needed, since the method directly modifies the room's lights).
3. Parameters (Input): A `float` representing the exact time the player pressed the key.
Return Type (Output): A `bool` (true or false) indicating whether the player accurately hit the beat.

Activity 2:
Metaphor: Think of a Class as a blueprint or an instruction manual for building a specific type of robot. A Component is the actual, physical robot that has been built from that blueprint and attached to a specific workstation (the GameObject).
Member Variables: These are the physical specifications and traits of that specific robot (e.g., its current battery level, its color, or its speed limit).
Methods: These are the specific actions the robot is programmed to perform on command (e.g., move forward, jump, or shut down).

Activity 3:
The balls get extremely bright because of the GetColorMultiplier method logic combined with the color multiplication in Step 9. Every time a ball bounces and its average speed exceeds the _speedThreshold, the method returns a multiplier of 1.5. The script then takes the current RGB color values of the SpriteRenderer and multiplies them by 1.5. In Unity, standard color values are clamped between 0 and 1. By continuously multiplying the color by a number greater than 1, the RGB values stack and quickly exceed standard bounds. This causes the sprite's material to render the values as overexposed or "blown out," resulting in that extreme, glowing white "super-saiyan" effect.

### W4
Table number : #8
1. Collider Activity

I added a Capsule Collider and Rigidbody to the Cat, a Sphere Collider and Rigidbody to the SoccerBall, and a Box Collider to the Goal. I enabled Is Trigger only on the Goal so the ball could pass through it and still detect a goal. I also adjusted the colliders to fit the objects and used Freeze Rotation to prevent them from falling over.

2. Problems and Solutions

At first, I had trouble connecting the Rigidbody to the Cat script, but I fixed it by assigning the correct component in the Inspector. I also noticed that the soccer ball sometimes fell off the map when I changed the Bounce Force.

3. What I Completed

I added collision detection using OnTriggerEnter and used CompareTag to check whether the ball entered the Goal. I also created a MadeGoal method to play the celebration effect, update the points, and reset the timer after each goal.

### W6
Plan for the DeerW5 Class

For this activity, I plan to create a DeerW5 class that makes the deer walk toward a target using Unity’s NavMesh system.

What member variables does this class need?

A Transform variable named target to reference the object the deer will walk toward. I will use [SerializeField] so I can assign the target in the Inspector.

A NavMeshAgent variable named agent to store the deer’s navigation component.

What methods does this class need?

I will use Unity’s Start() method because the deer only needs to receive its destination when the game begins. For a stationary target, I do not need to update the destination every frame.

What should the method do?

In Start(), I will use GetComponent<NavMeshAgent>() to get the navigation component attached to the Deer GameObject. Then, if a target has been assigned, I will call agent.SetDestination(target.position) to make the deer walk toward it.

Testing Plan

I will attach the DeerW5 script to the Deer GameObject and assign Mushroom_red as its target in the Inspector. Then I will enter Play mode and check whether the deer moves toward the mushroom.
### W7

**Activity 1: Class Resource Guide**

My assigned category was Other Tools. I focused on GitHub and YouTube, including how GitHub works and useful tips.

Google Doc: https://docs.google.com/document/d/1iBZihNlx92b16mfK2TXGr1CYtdDQOOh7vAeKN-P9YfU

**Activity 2: Pair Programming**

**Planning Notes:**

- Member variables: speed, player Transform, and a boolean to control chasing.
- Methods: Update(), ChasePlayer(), and StopChasingPlayer().
- Update() moves the bat toward the player when chasing is enabled.
- ChasePlayer() enables chasing, while StopChasingPlayer() disables it.

**Implementation:**

I created the BatW6 class to control bat movement. I also completed the BatManager script using arrays and for loops to manage multiple bats, check their distance from the player, and display random messages when they get close.

**What I Learned:**

I learned how to use arrays and for loops to manage multiple GameObjects. I also practiced using public methods to communicate between scripts and Time.deltaTime to make movement frame-rate independent.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 