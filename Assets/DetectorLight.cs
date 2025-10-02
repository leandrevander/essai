using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class DetectorLight : MonoBehaviour
{
    private Transform cibleZombie;
    public GameObject player;
    private float zombieDistance;
    public Spawner spawner;
    private float d;
    private IAZombie iaZombie;
    
    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        d = spawner.distance; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            
            cibleZombie = other.transform;
            Vector2 direction = (cibleZombie.position - player.transform.position).normalized;
            RaycastHit2D hit = Physics2D.Raycast(player.transform.position, direction, d);
            Debug.DrawRay(player.transform.position, direction, Color.red);
            {
                iaZombie = cibleZombie.GetComponent<IAZombie>(); // on recupere le component du zombie touché par le raycast
                if (hit.transform == cibleZombie) // si les coordonnées du raycast sont bien au meme endroit que celui du zombie alors il se fait attaqué
                {
                    Debug.Log("TOUCH2");
                    iaZombie.isHitten = true;
                }
            }
        }

    }

   
}
