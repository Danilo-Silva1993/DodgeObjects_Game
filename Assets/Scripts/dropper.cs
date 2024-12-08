using System.IO.Compression;
using UnityEngine;

public class dropper : MonoBehaviour
{
    float timetoWait = 3f;

    MeshRenderer mymeshrend ;
    Rigidbody myRigBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mymeshrend = GetComponent<MeshRenderer> ();
        mymeshrend.enabled = false;

        myRigBody = GetComponent<Rigidbody>();
        myRigBody.useGravity = false;

       
    }   

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);

        if (Time.time > timetoWait) 
        {
            mymeshrend.enabled = true;
            myRigBody.useGravity= true;
        }
    }
}
