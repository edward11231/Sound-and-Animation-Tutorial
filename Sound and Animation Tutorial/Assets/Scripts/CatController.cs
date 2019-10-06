using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioClip audioClip1;
    public AudioClip audioClip2;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = audioClip1;
            musicSource.Play();
            animator.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();
            animator.SetInteger("State", 0);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = audioClip2;
            musicSource.Play();
            animator.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
            animator.SetInteger("State", 0);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Game Quit");
        }

    }
}
