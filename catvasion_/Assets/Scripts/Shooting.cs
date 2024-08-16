using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Rigidbody prefab_yadro;
    [SerializeField] ParticleSystem boom;
    [SerializeField] AudioSource boom_sound;
    public float force = 5f;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var yadro = Instantiate(prefab_yadro, transform.position, transform.rotation);
            yadro.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
            boom.Play();
            boom_sound.Play();
        }
    }
}
