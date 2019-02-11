using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public Transform target;

    public Vector3 offset;
    public float smoothSpeed;
    

	void LateUpdate () {

        Vector3 desieredPosition = target.position + offset;
        Vector3 positionMove = Vector3.Lerp(transform.position, desieredPosition, smoothSpeed);
        transform.position = positionMove;

	}
}
