using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public GameObject pc;
    public float offSetY;
    // Start is called before the first frame update
    void Start()
    {
        offSetY = 1;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPC();
    }

    private void FollowPC()
    {
        Vector3 pos = new Vector3(
            pc.transform.position.x,
            transform.position.y,
            transform.position.z);

        transform.position = pos;
    }
}
