using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

  private void OnCollisionEnter(Collision other) 
  {
        if (other.gameObject.tag != "Hit"){
            hits++;
            Debug.Log("You hit this many times: " + hits);  
        }

      
  }


}
