using UnityEngine;

public class TriggerProj : MonoBehaviour
{

    //GEt Progectile
    [SerializeField] GameObject projectile;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            projectile.SetActive(true);

            Destroy(gameObject);
        }
    }
}
