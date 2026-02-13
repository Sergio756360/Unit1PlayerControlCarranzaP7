using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward continuosuly 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
