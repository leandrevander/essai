using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class IAZombie : MonoBehaviour
{
    public bool isHitten = false;
    public int pvZombie;
    private GameObject player;
    public NavMeshAgent agent;
    public bool playerHitten = false;
    private PlayerManager playerManager;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        playerManager = player.GetComponent<PlayerManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            agent.destination = player.transform.position;
   
        }
        if (isHitten)
        {
            StartCoroutine(AttaqueZombie(1f)); 
        }
        
    }
    IEnumerator AttaqueZombie(float delai)
    {
        print("zombie se fait attaqué");

        pvZombie--;

        if (pvZombie <= 0)
        {

            Destroy(gameObject);
            
        }
        isHitten = false;

        yield return new WaitForSecondsRealtime(2);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") && playerManager.peutPrendreDesDegats)
        {
            StartCoroutine(playerManager.PertePV());
        }
    }
}
