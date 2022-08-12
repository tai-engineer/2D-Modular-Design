using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterPhysic : MonoBehaviour, ICharacterMove
{
    Rigidbody2D _rb2d;
    Vector2 _moveVector;
    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move(_moveVector);
    }
    public void SetMoveVector(Vector2 input) => _moveVector = input;

    public void Move(Vector2 position)
    {
        float speed = 10f;

        _rb2d.MovePosition(_rb2d.position + new Vector2(_moveVector.x * speed * Time.deltaTime, _moveVector.y));
    }
}
