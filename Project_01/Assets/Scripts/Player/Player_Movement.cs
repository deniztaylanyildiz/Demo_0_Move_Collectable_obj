using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Vector2 _rotation;
    [SerializeField]
    private float _vertical;
    [SerializeField]
    private float _horizontal;

    protected void Move()
    {
        _vertical = Input.GetAxis("Vertical");
        _horizontal = Input.GetAxis("Horizontal");
        _rotation = new Vector2(_horizontal, _vertical);
        transform.Translate(_rotation * _speed * Time.deltaTime);

    }



}
