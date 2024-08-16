using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    [SerializeField] AudioSource meow;
    public float speed = 0.5f;
    public float _time = 2f;



    public int count = 0;
    public ParticleSystem ps;

    private void Start()
    {
        StartCoroutine(PerformActions());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ball"))
        {
            FindObjectOfType<PointsSystem>().Score(count);
            ps.Play();
            meow.Play();
        }
    }

    private IEnumerator PerformActions()
    {
        while (true)
        {
            for (float i = 0; i < _time; i += Time.deltaTime)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                yield return null;
            }

            for (float i = 0; i < _time; i += Time.deltaTime)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                yield return null;
            }
        }
    }
}
