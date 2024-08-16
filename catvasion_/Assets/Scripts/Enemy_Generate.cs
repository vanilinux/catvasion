using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Generate : MonoBehaviour
{
    [SerializeField] Rigidbody prefab_enemy;

    void Start()
    {
        var enemy = Instantiate(prefab_enemy, transform.position, transform.rotation);
        enemy.transform.Rotate(new Vector3(-90, 0, -90));
    }
}
