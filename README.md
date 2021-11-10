# HW4-SpaceInvaders
itch.io link - https://to-gaming.itch.io/omer-spaceinvaders

## Space invaders-
this is the UNITY package of the game.

## Details:
i made some changes in thie game:
* "hit points" to represent the lives of the player (GameOverOnTrigger2D lines 9-10 and update func).
  * when the player spaceship hits the enemy, it loses 1 hit point and spawns in the middle of the screen (GameOverOnTrigger2D lines 25 and 34).

* audio sources and effects to the game (Sound.cs class & audiomanager.cs):
  * laser sound when the laser beam is been shot. 
  * explosion sound when the enemy spaceships are destroyed.
  * applause sounds when the player win the game.
* new level "boss" - bigger enemy spaceship that moves in an oscilator (Osci.cs) like movement and spawns small ones.
