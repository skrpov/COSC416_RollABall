using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    public Rigidbody _rigidBody;
    [SerializeField]
    public float _moveSpeed;
    [SerializeField] 
    public float _speedCap;

    void Start()
    {
    }

    void Update()
    {
        var movementUpdate = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W)) 
            movementUpdate += Vector3.forward;
        if (Input.GetKey(KeyCode.S)) 
            movementUpdate -= Vector3.forward;
        if (Input.GetKey(KeyCode.D)) 
            movementUpdate += Vector3.right;
        if (Input.GetKey(KeyCode.A)) 
            movementUpdate -= Vector3.right;

        movementUpdate *= _moveSpeed;

        var speed = _rigidBody.linearVelocity.magnitude;
        if (speed < _speedCap)
            _rigidBody.AddForce(movementUpdate);
    }
}
