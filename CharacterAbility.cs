public class CharacterAbility : MonoBehaviour
{
  //CharacterPerception RS
  //Movement LS
  //Interaction LB RB
  //Inventory DPad
  //Jump A
  //Combat X Y B

void PreInitializqation(){}
void Initialization(){}
void BindAnimator(){}
void InitializeAnimatorParamters(){}

#region Update
void ProcessAbility()
{
  HandleInput();
}

void HandleInput(){}
#endregion

void ResetInput(){}
void SetInputManager(){}  // Sets input
void ResetAbility(){}     // Resets ability

//Register animtor parameters to characters list
void RegisterAnimatorParameter(){}
void UpdateAnimator(){}¿?¿?

// Plays the ability start sound effect
protected virtual void PlayAbilityStartSfx()
// Plays the ability used sound effect
protected virtual void PlayAbilityUsedSfx()
// Stops the ability used sound effect
protected virtual void StopAbilityUsedSfx()
// Plays the ability stop sound effect
protected virtual void PlayAbilityStopSfx()

// Plays the ability start feedback
void PlayAbilityStartFeedbacks()
// Stops the ability used feedback
public virtual void StopStartFeedbacks()
// Plays the ability stop feedback
protected virtual void PlayAbilityStopFeedbacks()

  
  // What hapend when character respawn
  void OnRevive(){} //OnRespawn
  // What hapend when takes a hit
  void OnHit(){}
  // What hapend when dies
  void OnDeath(){}
  //Start listening events
  void OnEnable(){}
  //Stop listeening events
  void OnDisable(){}
}

public class CharacterCombat : CharacterAbility
{
    //Attack
    //Feinted Cancell LB,RB
    //guard breakage
    //Parry
    
    //Block
    
    //Deflect A+B
}


public class Area: MonoBehaviour
{ 
  //Cone of vision
  //DamageArea VisionArea AuditionArea
  public float areaRange = 1;
  public float areaAngle = 45,135;
  public float angleOffset = 0;
  public vectro3 positionOffset = Vector3.up;
  public LayerMask targetMask;
  
  public <list> TargetObjects
  list<GameObject> ignoreObjects//IgnoreOwner¿?
  
  public virtual void ScanTargets()
  {
      PhysicsOverlapSphere();
      
  }
  
  public DrawGizmos()
  {
  
  }
}
