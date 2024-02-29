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

### Camera Grounded Movement Behavior TBD
TBD

## Aerial Movement
To enter the Aerial Movement State, the player has to first interact with a "Lotus" LD element. [(Reference)](https://youtu.be/suaZBXdQnTo?t=18)

After the Lotus Launching sequence is done, the player will start falling down entering the Aerial movement state.

While falling down player will be able to do the following actions:
- **Move 360°**: Using movement input he can lean towards direction has he falls down [(Reference)](https://youtu.be/l24TVfGq3Zk?t=144)

- **Accelerate fall**: Fall at a greater speed (Speed = X), can also be cancelled to go back at regular momentum. [(Reference)](https://youtu.be/8LWTKFSqkbU?t=19)

- **Lock on**: When an enemy is at a radius of X from the player, it can enable manual lock to change camera movement toward this locked on enemy. **(See Camera Lock behavior)**

- **Croak / Scan**: Scan the area to get informations about enemies. Highlight enemies  + allows lock on from ***Lock on radius + X*** [(Reference)](https://youtu.be/mIyE8j6wGIU?t=14)

- **Aerial Dash**: Can perform aerial dash to gain horizontal momentum for a short duration. Dash over a distance of X in movement input direction. Cooldown of X seconds between dashes.

### Camera Aerial Movement Behavior
As the player free falls, the camera will behave as follows:
- View appear as a top down view of the player free falling
- Player is centered on the screen
- Player can be off centered a bit by doing Dash or Accelerate fall actions
- FOV of camera will adapt to current action (Accelerate fall FOV != Default FOV)
- Camera can be rotated around player (Y axis only)
- [Reference](https://youtu.be/l24TVfGq3Zk?t=144)

## Aerial Combat

Player can enable Aerial Combat state only when an enemy is **Locked on**

During this state player can perform several actions:
- **Aerial Dashes**: The player dashes toward the enemy at a speed of X for a duration of X. Cooldown of X seconds between dashes.

- **Sonic Lashes**: Long distance rapid attack dealing constant damage to the enemy. 10 base damage / 0.2 hit tick cooldown, during the Sonic Lashes, the player stays in the air at it's current position

- **Grappling Hook**: Long distance grapple attack allowing the player to attach to an enemy and retract the tongue to close the distance rapidly. This enable the **grappling combat** state of the player which implies specific behaviors depending on the enemy grappled. *(See Grappling Combat section)*

- **More Actions (TBD)** 

### Camera Lock On behavior
During Lock on, the camera behaves as follows:
- Camera angle will set toward the enemy [(Reference)](https://youtu.be/rOmy50Dck50?t=24)
- The camera will be offset so that the player appears either on the left or the right of the screen.
- Player can switch target if several valid target are within range of lock on (By pressing input)
- If the enemy leaves the lock on range OR dies, the camera will follow this behavior:
    - If there is a valid target whitin lock on range in camera view: camera will lock onto this new enemy.

    - If there is a valid target within lock on range out of camera view: camera will lock onto this new enemy over 1.5 additional seconds. (Smoothing)

    - If there is no valid target whitin lock range: the camera will automatically cancel the lock on and switch to the new valid camera behavior over 2 seconds. (Smoothing)

## Grappling Combat TBD
