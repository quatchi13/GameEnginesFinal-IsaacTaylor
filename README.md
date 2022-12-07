# GameEnginesFinal-IsaacTaylor
Game Engines Final Exam by Isaac Taylor - 100785267

Controls:
LeftShift to spawn new duck from object pool (switches to RightShift if two ducks leav off the top of the screen)
LeftControl to spawn new duck as new object
Space to shoot ducks from the sky

Explinations:

Object Pooling:

     Object pooling was impemented to manage the number of ducks within the game. An existing pool of five identical ducks was created in the heirarchy
     and are avaliable in the game to be spawned. these objects start disabled and are placed at spawn and enabled to "spawn" them. upon reaching either the top of 
     the screen if they fly away, or the bottom of the screen if shot down, they will be deactivated and await being spawned once more.
     
     Spawning ducks without the object pool requires instantiating a new game object, allocating more memory to support it and it remains permanently in the scene
     after deactvation even though it wont be used again.
     
     From data within the Unity Profiler, specifically looking at the additional data within it's memory section, upon begining the game a certain number of
     game objects are present, in this case 18 of them. Spawning ducks through the object pool does not affect this number as those ducks have already been accounted
     for, as have all their resources. Spawning new entities without the object pool will raise this number and increase the total amount of memory that is 
     needed to allocate each instance of attributes like textures meshes and materials that appear on each duck when spawned. This attributes require memory space 
     to hold and therefore the more ducks spawned in this way the more memory is consumed.
     
     On such a small scale the effects are not incredibly noticable but if this game were to grow infinately, using the object pool will never increse the allocated
     memory past what is required intitially where creating new entities outside the object bool will indefinately increase the amount of required memory until
     eventually none is avaliable. Spreading this object pooling across other things in the game such as the score popups or the unique dog sprites that emerge
     from the bush after each wave of ducks in the original could also benifit in this way.

Command:

     The command pattern asked for had to be adapted for my renditon of duck hunt that was created from scratch. Since I do not have the ability to look i could not
     invert a look direction, so rather I chose to rebind the key for spawning ducks via the object bool. To do this I assume the inverse of LeftShift is RightShift.
     Upon a duck being deactivated from leaving off the top of the screen a simple counter is added to trakcing th number of ducks that hav left in this way.
     If this counter reaches 2 the controls are swapped by invoking a specific subclass of ICommand that will return the RightShift KeyCode, and in this case that
     returned KeyCode overwrites the existing keybind to spawn ducks rebinding it to it's inverse.
     
     To see this in the game, simply allow two ducks to escape from the screen without shooting them down and you will see that your ability to spawn ducks from
     the object pool has migrated from LeftShift to RightShift.
     
     Since this function does not translate perfectly into improoving the game and doesnt have much impact on ones gameplay I would like to state how rebinding a
     control after missing two ducks could benefit the game if that function being inverted was actually related to gameplay, such as aiming. Simply, I don't think
     that there is a benefit to doing this, if a player has missed 2 ducks they may juststill be learning the controls of the game and autonomously switching them
     will not allow the player to become comfortable and will force a new way of play on them. What I see being more useful is if the game, after seeing
     repeated instances of failing early rounds, could instead ask the user if they would like to try inverting the controls. This allows users to decide for
     themselves about giving the new control scheme a try or if they simply need to practice more with the control scheme they are already using, instead of forcing
     the change upon them.
