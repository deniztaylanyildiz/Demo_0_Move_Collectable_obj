using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : Player_Movement
{
   


  public int Score;
    

    public static Player Instance { get; private set; }

    private void Awake()
    {
    

        if (Instance != null && Instance != this)
        { 
            Destroy(this);
            return;
        }
        Instance = this;
    
    }



    private void Update()
    {
       
        Move();
    }



}
