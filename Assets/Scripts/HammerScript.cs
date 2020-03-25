using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerScript : MonoBehaviour
{
    public Texture2D hammer;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(hammer, new Vector2(hammer.width / 2, hammer.height / 2), CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
