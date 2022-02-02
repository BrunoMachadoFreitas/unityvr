using UnityEngine;

public class Codigo_SeguirRato : MonoBehaviour
{
    public bool ShowCursor;
    public float sensivity;

    //public float smoothSpeed = 0.125f;

    private void Start()
    {
        if (ShowCursor == false)
            Cursor.visible = false;
    }

    private void Update()
    {
        float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensivity;
        float newRotationX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * sensivity;

        gameObject.transform.localEulerAngles = new Vector3(newRotationX, newRotationY,0);
    }

}
