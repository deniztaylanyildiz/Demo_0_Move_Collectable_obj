using UnityEditor.Build.Content;
using UnityEngine;

public class Carrot :Collectable
{
    [SerializeField]
    private int _scoreAdding;
  
    
    public override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);

        if (other.tag=="Player")
        {
            ScoreAdd(_scoreAdding);
        }

    }

}



