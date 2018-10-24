
using UnityEngine;

public class CharterController : MonoBehaviour
{
    public Rigidbody RB;
    public float ForwadForce = 2000f;
    public float SideswaysForce = 500f;
    private Vector3 position;
    public float Gravity = 9.81f;
    private float JumpSpeed = 4.0f;

    public object Controller { get; private set; }


    // Update is called once per frame
    void FixedUpdate ()
        {

        {

        RB.AddForce(0, 0, ForwadForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            RB.AddForce(SideswaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") )
        {
            RB.AddForce(-SideswaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        }
    }
}
