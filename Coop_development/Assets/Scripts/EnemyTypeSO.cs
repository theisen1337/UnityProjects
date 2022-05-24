using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyTypeSO : ScriptableObject
{
    public Transform prefab;
    public string Text;
    public int health;
    public float speed;
    public int damage;
}
