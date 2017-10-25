using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerMovement movement; // public variable for the PLayerMovement component of unity named movement to be accessed from outside this script

    void OnCollisionEnter(Collision collisionInfo) // private void method OnCollisionEnter it is called when the collider/rigidbody has begun touching another rigidbody/collider. its parameters are the Collision Class which contains information about contact points, impact velocity etc. if the function doesnt use collisionInfo paramater its best to remove it to avoid uneccessary calculations,collision events are only sent if one of the colliders also has a non-kinematic rigidbody attached, Collision events will be sent to disabled MonoBehaviours, to allow enabling behaviours in response to collisions.
    {
        if (collisionInfo.collider.tag == "Obstacle") // if statement is false by default, With a created Obstacle tag in unity applied to our Objects we wants as obstacles, this if statements checks if the collisionInfo.collider.tag is equal to the string "Obstacle" then when the player collides into an object(the collider) with the Obstacle tag in unity the if statement is true and runs the code below.
        {
            movement.enabled = false; // Once its true that our player has collided we access the PlayerMovement component of unity with our movement variable access its .enabled component and set it to false to stop the player moving from there on out.
            FindObjectOfType<GameManager>().EndGame(); // after the Player movement is disabled the FindObjectType function is called and selects our GameManager.cs GameManager() class gameObject and calls its EndGame public void member from GameManager.cs to end the current game and reload the scene
        }
    }
}
