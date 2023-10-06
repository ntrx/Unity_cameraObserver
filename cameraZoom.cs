using UnityEngine;

public class cameraZoom : MonoBehaviour
{
    float oX = 0F;
    float oY = 0F;
    float oZ = 0F;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        // zoom
        if (Input.mouseScrollDelta.y != 0F) {
            zoom();
        }


        // rotate vertical
        if (Input.GetAxis("Vertical") != 0f) {
            oX += Input.GetAxis("Vertical") * 0.5f;
        }
        // rotate horizontal
        if (Input.GetAxis("Horizontal") != 0F) {
            oY += Input.GetAxis("Horizontal") * 0.5f;
        }

        // clamp
        oX %= 360F;
        oY %= 360F;
        // release rotation
        transform.parent.eulerAngles = new Vector3(oX, oY, 0F);
    }

    void zoom () {
        Vector3 npos = Vector3.MoveTowards(transform.position, transform.parent.position, Input.mouseScrollDelta.y);
        if (npos.y <= (transform.parent.position.y + 3f))
            transform.position = npos;
    }
}
