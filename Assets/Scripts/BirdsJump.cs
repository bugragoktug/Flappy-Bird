using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsJump : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2d;
    public GameManager managerGame;
	public GameObject DeathScreen;

    public bool isDead;

	private void Start()
	{
		Time.timeScale = 1f;
	}
	void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * velocity* 3;
        } 
    }


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "ScoreArea")
		{
            managerGame.UpdateScore();
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "DeathArea")
		{
			isDead = true;
			Time.timeScale = 0;
			DeathScreen.SetActive(true);
		}
	}
}
