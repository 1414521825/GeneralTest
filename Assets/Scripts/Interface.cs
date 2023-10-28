using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKillable
{
    void kill();
}

public interface IDamageable<T>
{
    void Damage(T damageTaken);
}