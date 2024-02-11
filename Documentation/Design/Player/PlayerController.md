# Player Controller
The Main Controller is made of several features.

The idea being "Create an mainly aerial controller that uses the capabilities that can be expected of a Frog."

## Grounded Movement
The grounded movement applies when Toad is on the ground and player has control.

The Feature would work as follow:
1. 360° movement
2. Move using "Main Movement Inputs" (WASD or Leftjoystick)
3. Move by making small leaps in input direction (Air Control ?)
4. Ground are object with a collider and a tag that considers them as "Ground"

## Aerial Movement
To enter the Aerial Movement State, the player has to first interact with a "Lotus" LD element. [(Reference)](https://youtu.be/suaZBXdQnTo?t=18)

After the Lotus Launching sequence is done, the player will start falling down entering the Aerial movement state.

While falling down player will be able to do the following actions:
- Move 360°: Using movement input he can lean towards direction has he falls down
- Accelerate fall: Fall at a greater speed, he can also stop the acceleration to go back at regular momentum.
- Lock on: When an enemy is at a radius of X from him, player can enable manual lock to change camera movement toward this locked on enemy.
- Croak / Scan: Scan the area to get informations about enemies (highlight them to player)
- Aerial Dash: Can perform aerial dash to gain horizontal momentum for a short duration. 

## Aerial Combat

