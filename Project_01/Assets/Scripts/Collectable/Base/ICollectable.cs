using Unity.VisualScripting;
using UnityEngine;

public interface ICollectable
{
    void ScoreAdd(int _score);


    void Destroy();



    void OnTriggerEnter2D(Collider2D other);
}
