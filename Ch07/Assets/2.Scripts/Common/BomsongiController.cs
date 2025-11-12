using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomsongiController : MonoBehaviour
{

    public int forwardForce = 2000;
    public int upForce = 800;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, upForce, forwardForce));
        Destroy(gameObject, 10);
    }
    
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        GetComponentInChildren<MeshRenderer>().enabled = false;
        Destroy(gameObject, 1);
    }
}
