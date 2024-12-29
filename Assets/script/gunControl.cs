using UnityEngine;

public class gunControl : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sens = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sens;
        vertical = Input.GetAxis("Mouse Y");

        transform.Rotate(0, horizontal, 0);
        transform.Rotate(0, 0, vertical);

    }
}
