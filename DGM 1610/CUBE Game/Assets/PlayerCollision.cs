
using UnityEngine;

public class PlayerCollision : MonoBehaviour {


    public CharacterController movment; 
    private void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.name == "Obstacle")
        {
            movment.enabled = false;
          }

    }

}
