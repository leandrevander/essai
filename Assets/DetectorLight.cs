using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class DetectorLight : MonoBehaviour
{
    private Transform cibleZombie;
    public GameObject player;
    private float zombieDistance;
    private float distance;
    private IAZombie iaZombie;
    public LayerMask raycastMask;
    
    
    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics2D.queriesHitTriggers = true;  
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("Trigger object: " + other.name + " | Tag: " + other.tag);

        if (other.CompareTag("Zombie"))
        {
            
            
            cibleZombie = other.transform;
            Vector2 direction = (cibleZombie.position - player.transform.position).normalized;
            distance = Vector2.Distance(player.transform.position,cibleZombie.position);
            
            RaycastHit2D hit = Physics2D.Raycast(player.transform.position, direction, distance, raycastMask);
            
            Debug.DrawRay(player.transform.position, direction * distance, Color.red);
            
            if (hit.collider !=null && hit.collider == other) // si les coordonnées du raycast sont bien au meme endroit que celui du zombie alors il se fait attaqué
            {

                iaZombie = cibleZombie.GetComponent<IAZombie>();// on recupere le component du zombie touché par le raycast

                Debug.Log("LE RAYCAST TOUCHE LE ZOMBIE LOL CACA PROUT DIEU MERCI");
                iaZombie.isHitten = true;
            }
               
               
        }
    }

}

   

