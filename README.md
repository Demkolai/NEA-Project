# The Dungeon
A turn-based RPG set in a medieval dungeon. Created with the Unity game engine using C#. Inspired by Pokemon and early Final Fantasy games.

# Notable Algorithms:
## Turn-based Combat
- The combat system uses an FSM which has been implemented using a switch statement with 9 cases (states) in this implementation.
- The combat starts by initialising the player information from the Game Information script and generating an enemey with stats based on enemy type and level.
- The game then waits for player input to choose an action from a list of using a skill, healing, skipping their turn or fleeing which ends the battle. After the player selects an option, the corresponding action is executed (damage dealt or healing done etc.).
- The AI then decides what action the enemy will perform from a list of abilities corresponding to the class of the enemy. The decision was made based on a random number generator. Damage is calculated and the state goes back to player choice.
- After each player or enemy turn there is a check to see if either entity has died. If the player defeats the enemy, they are awarded with XP based on: PlayerLevel * 2 * 100. If the player loses they are awarded XP based on: PlayerLevel * 2 * 15.
- After this the game ends.

Link: https://github.com/PatrykOwczarz/The-Dungeon/blob/master/RPG%20test/Assets/Scripts/Turn%20Based%20Combat/StateMachine.cs

## Battle Calculations:
Algorithm that calculated damage done by the player or enemy based on the respctive stats

Link: https://github.com/PatrykOwczarz/The-Dungeon/blob/master/RPG%20test/Assets/Scripts/Battle%20Calculations/BattleCalculations.cs

## Areas of Improvement:
- UI: This project uses the new Unity UI and the Legacy UI. Recreating and porting the Character creator and BattleUI to the new Unity UI would be a huge improvement.
- Inventory system: Works but is not utilized with character system fully.
- Generation of Items: WIP random item generator that would generate items based on animals such as "of the Bear" would be Stength and Stamina, "of the Owl" would be Intellect and Wisdom etc..
- Save system: Currently the game does not persist after shutdown and going from Free-Roam into combat and back into Free-Roam puts the player back at the start of the level.

# Demo video:
Demo: https://www.youtube.com/watch?v=a_SEyTaseDs
