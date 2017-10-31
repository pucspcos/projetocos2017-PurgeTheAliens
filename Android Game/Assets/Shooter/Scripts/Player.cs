using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//This script manages the player object
public class Player : Spaceship
{
    float x;
    float y;
    Vector2 direction;

    void Update ()
	{
        //Get our raw inputs
        x = Input.GetAxisRaw("Horizontal");

        y = Input.GetAxisRaw("Vertical");
        //Normalize the inputs
        direction = new Vector2(x, y).normalized;
        //Move the player
        Move(direction);

        SetDirection();
	}
	
	void Move (Vector2 direction)
	{
		//Find the screen limits to the player's movement
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
		//Get the player's current position
		Vector2 pos = transform.position;
		//Calculate the proposed position
		pos += direction  * speed * Time.deltaTime;
		//Ensure that the proposed position isn't outside of the limits
		//pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);
		//Update the player's position
		transform.position = pos;
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		//Get the layer of the collided object
		string layerName = LayerMask.LayerToName(c.gameObject.layer);
		//If the player hit an enemy bullet or ship...
		if( layerName == "Bullet (Enemy)" || layerName == "Enemy")
		{
			DadosPersistentes.NextLevel = "GameOver";
			SceneManager.LoadScene("Loading");

			//...and the object was a bullet...
			if (layerName == "Bullet (Enemy)" )
				//...return the bullet to the pool...
			    ObjectPool.current.PoolObject(c.gameObject) ;
			//...otherwise...
			else
				//...deactivate the enemy ship
				c.gameObject.SetActive(false);

			//Tell the manager that we crashed
			Manager.current.GameOver();
			//Trigger an explosion
			Explode();
			//Deactivate the player
			gameObject.SetActive(false);
		}
	}

    public void OnRight()
    {
        x = 1;
        SetDirection();
    }
    public void OnLeft()
    {
        x = -1;
        SetDirection();
    }
    public void OnUp()
    {
        y = 1;
        SetDirection();
    }
    public void OnDown()
    {
        y = -1;
        SetDirection();
    }
    public void OnNeutral()
    {
        x = 0;y = 0;;
        SetDirection();
    }
   void SetDirection()
    {
        direction.x = x;
        direction.y = y;
        Move(direction);
    }
}