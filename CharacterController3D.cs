
public class CharacterController3D : MonoBehaviour

void Awake() //PreInitialization();
void Start() //Initilization();

void PreInitialization() //Store input manager, camera controller
    // Initialize state machines
    CharacterState -->  ConditionState
    CharacterAction --> MovmentState
    // Get the current input manager
 	SetInputManager();
	// Get the main camera
    // Store components for further use
    health = GetComponent<Health>();
    aiBrain = GetComponent<CharacterBrain>();
    //Abilities GetComponent <CharacterAbility>
    AssignAnimator();
    // Instantiate camera target
void SetPlayerID(){}		// Sets newPlayerID

void SetInputManager() {} 	// Assign input manager matching player ID
void SetInputManager() {} 	// Set new input manager
void ResetInput() {}		// Reset input manager

void AssignAnimator(){} // Binds an animator to this character
void InitializeAnimatorParameters(){}	// Initializes the animator parameters


#region Update
public virtual void Update() 
{
	//ProcessAbilities(){ability.ProcessAbility();}
	//UpadateAnimator()??
	
	//CheckIfGrounded()	// Check ground
	//Handle Friction()
	//DetermineDirection() CurrentDirection = CurrentMovement.normalized;
}
public virtual void FixedUpdate() 
{
	//ApplyImpact()
	//GetMovingPlatformVelocity()	// Gets the current moving platform's velocity
	//AddInput();		// Determines the new velocity based on the slope we're on and the input
	//AddGravity();		// Adds the gravity to the new velocity and any AddedForce we may have
	//MoveWithPlatform();	// Moves and rotates the character controller to follow any moving platform we may be standing on
	//ComputeVelocityDelta();	// Computes the motion vector to apply to the character controller
	//MoveCharacerController();	// Moves the character controller by the computed _motion
	//ComputeNewVelocity();		// Determines the new Velocity value based on our position and our position last frame
	//StickToTheGround();		// Sticks character to the ground
}
public virtual void LateUpdate() 
{
	//ComputeSpeed()
}
#endregion
void ApplyInpact(){}
void Impact(){}
void AddForce(){}	// Add specified force value
void SetMovement(){}	// Set current movement to specified value
void MovePosition(){}	// Moves to specified position




void ResizeCollider(){} 	// Resizes the collider
void ResetColliderSize(){}	// Resetes the collider
void DetectObstacles(){}	// Detect obstacles??
void CollisionsOn(){}		// Enabled collisions
void DisableCollisions(){}	// Collisions off

//Interactions¿?
void OnControllerColliderHit(){}	// Store info to handle push interactions, moving platforms
void HandlePush(){}		// Adds a force to the colliding object at the hit position, to interact with the physics world
void OnTriggerEnter(){}
void OnTriggerStay(){}
void OntriggerExit(){}

//Perceptions
void DetectObstacles(){}

void RespawnAt(){} 	// Character respawn in spawn position and with spawn direction
void Disable(){} 	// Called to disable the character

void Reset() {}	// Called when the Character dies

void OnRevive(){}
void OnHit(){}
void OnDeath(){}

void OnEnable(){}	// Register revive event
void OnDisable(){} 	// Unregister revive event

