using UnityEngine;

public abstract class Collectable : MonoBehaviour, ICollectable
{
    
   
   

    public void Destroy()
    {
     Destroy(gameObject);
    }

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Player")
        {
            Destroy();
        }
       
    }

    public virtual void ScoreAdd(int scoreAdd)
    {
       Player.Instance.Score += scoreAdd;
       
    }


    public virtual void BadObj()
    {

        //kill or Damage on Player


    }

}
