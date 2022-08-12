using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterMove
{
    void Move(Vector2 position);
    void SetMoveVector(Vector2 input);
}
