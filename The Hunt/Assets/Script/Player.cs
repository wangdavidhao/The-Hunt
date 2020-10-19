using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed = 5;
    Rigidbody2D rb;
    Vector2 dir;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);

        setParam();
    }

    void setParam()
    {
    	//Immobile
    	if(dir.x == 0 && dir.y == 0)
    	{
    		anim.SetInteger("Dir",0);
    	}
    	//Droite
    	else if(dir.x > 0)
    	{
    		anim.SetInteger("Dir",2);
    		GetComponent<SpriteRenderer>().flipX = true;
    	}
    	//Gauche
    	else if(dir.x < 0)
    	{
    		anim.SetInteger("Dir",2);
    		GetComponent<SpriteRenderer>().flipX = false;
    	}
    	//Bas
    	else if(dir.y < 0)
    	{
    		anim.SetInteger("Dir",1);
    	}
    	//Haut
    	else if(dir.y > 0)
    	{
    		anim.SetInteger("Dir",3);
    	}
    }
}
