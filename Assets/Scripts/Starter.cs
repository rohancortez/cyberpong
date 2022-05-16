using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{

    private GameControllwr gameControllwr;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        gameControllwr = FindObjectOfType<GameControllwr>();
        animator = GetComponent<Animator>();
    }

    public void StartCountdown()
    {
        animator.SetTrigger("StartCountdown");
    }
    public void StartGame()
    {
        gameControllwr.StartGame();
    }
}
