using UnityEngine;

public class FlyatPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    //get Player Positions
    [SerializeField] Transform player;
    Vector3 playerPosition; 

    //come first than start
    void Awake() {
        gameObject.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        playerPosition = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        MovetoPlayer();
        DestroyWhenReach();
    }

    //move to player
    void MovetoPlayer(){
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

    //destroy when go to ground
    void DestroyWhenReach()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
       
    }
}
