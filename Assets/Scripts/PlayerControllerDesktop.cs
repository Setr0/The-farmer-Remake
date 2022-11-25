using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerDesktop : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource gameoverAudioSource;
    public AudioSource soundtrack;
    public float speed;
    public GameObject gameoverObject;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameoverAudioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            soundtrack.mute = true;
            gameoverAudioSource.Play();

            var objects = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < objects.Length; i++)
            {
                Destroy(objects[i]);
            }

            gameoverObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
