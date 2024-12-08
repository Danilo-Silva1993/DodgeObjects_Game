using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float MoveSpeed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstrutions();
    }

    // Update is called once per frame
    void Update()
    {   
        Moveplayer();
        
    }


    void PrintInstrutions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move usen arrow or wasd");
    }

    void Moveplayer(){
        //Movement Variables 
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * MoveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
