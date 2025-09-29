using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(0, 2, 5); 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
      
    }
}
