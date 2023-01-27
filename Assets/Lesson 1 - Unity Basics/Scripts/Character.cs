using UnityEngine;

public class Character : MonoBehaviour
{
    // public variables can be changed in the inspector and are accesible to other classes 
    public string characterName;

    [Range(0.0f, 0.1f)]
    public float deltaPosition;

    // Awake is called first
    // setup the specific character object
    private void Awake()
    {
        Debug.Log(characterName + " called Awake");
        if(characterName == "")
        {
            characterName = this.name;
        }
    }

    // Start is called before the first frame update
    // do any setup that might require other classes
    void Start()
    {
        Debug.Log(characterName + " called Start");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(characterName + " Start method is running a for loop");
        }
    }

    // Update is called once per frame
    // use it for collecting input
    void Update()
    {
        //Debug.Log(characterName + " is calling Update");
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= deltaPosition;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x += deltaPosition;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z += deltaPosition;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z -= deltaPosition;
            this.transform.position = position;
        }
    }

    // FixedUpdate is called once per frame
    // Physics stuff can go here
    void FixedUpdate()
    {
        //Debug.Log(characterName + " calling FixedUpdate");
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // Debug.Log(characterName + " calling LateUpdate");
    }
}


