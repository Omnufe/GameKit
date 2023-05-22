
public struct GameKitEvent{}

public struct GameKitPointEvent{}

public class GameManager : PersistentSingleton<GameManger>, EventListener<GameEvent>, EventListener<GameKitEvent>, EventListener<GameKitPointEvent>

Start()
{
  Aplication.targetFrameRate = targetFrameRate;
}

Reset()       // Resets the game manager
LoseLives()   // Decrease number of lives
GainLives()   // Increase number of lives
AddLives()    // Increase max number of lives
ResetLives()  // Reset number of lives to initial value
AddPoints()   // Increase game points
SetPoints()   // Set value to game points
SetActiveInventoryInputManager()  //
Pause()       // Pauses or unpauses the game
Unpause()     // Unpauses the game

StorePoinstOfEntry()  // Stores the level´s points of entry
GetPointsOfEntry()    // Gets the level´s points of entry info
ClearPoinOfEntry()    // Clear the level´s points of entry info
ClearPointsOfEntry()  // Clear all points of entry
  
ResetAllSaves(){}     // Delete all save files

StoreCharacter(){}    // Store selected character for future use
ClearCharacter(){}    // Clear selected character

OnEvent(){}           // Catches game evetns
OnEvent(){}           // Catches game kit evetns
OnEvent(){}           // Catches game kit points evetns
OnEnable(){}          // Start listening events
OnDisable(){}         // Stop listening events
