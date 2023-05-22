using UnityEngine;

/*
CharacaterContrller3D;
AIBrain
Vitality
    Adrenaline
    Health
    Stamina
 Perception Area
 Movement
 Jump
 Combat
 
 Interaction
 Inventory
 */

public class Test : MonoBehaviour 
{
    public bool isInitalized = false;

    //Storage
    protected int testInt = 0;
    
    #region Initialization
    public virtual void Awake() 
    {
        //Preinitialization
    }
    
    public virtual void Start() 
    {
        //Initialization
        isInitialized = true;
    }
    #endregion

    #region Update
    public virtual void Update() 
    {
        //Every frame
    }
    
    public virtual void FixedUpdate() 
    {
        //Every fixed frame
    }

    public virtual void LateUpdate() 
    {   
        //Every late frame
    }
    #endregion
}
