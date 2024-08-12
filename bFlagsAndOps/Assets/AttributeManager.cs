using System;
using UnityEngine;
using UnityEngine.UI;

public class AttributeManager : MonoBehaviour
{
    static public int MAGIC = 16;
    static public int INTELLIGENCE = 8;
    static public int CHARISMA = 4;
    static public int FLY = 2;
    static public int INVISIBLE = 1;

    public Text attributeDisplay;
    int attributes = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0');
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("MAGIC"))
        {
            attributes |= MAGIC;
        }
        if(other.gameObject.CompareTag("INTELLIGENCE"))
        {
            attributes |= INTELLIGENCE;
        }
        if(other.gameObject.CompareTag("CHARISMA"))
        {
            attributes |= CHARISMA;
        }
        if(other.gameObject.CompareTag("FLY"))
        {
            attributes |= FLY;
        }
        if(other.gameObject.CompareTag("INVISIBLE"))
        {
            attributes |= INVISIBLE;
        }
        if(other.gameObject.CompareTag("ANTIMAGIC"))
        {
            attributes &= ~MAGIC;
        }
        if(other.gameObject.CompareTag("ADDINTMAGCHAR"))
        {
            attributes |= (INTELLIGENCE | MAGIC | CHARISMA);
        }
        if(other.gameObject.CompareTag("REMOVEINTMAG"))
        {
            attributes &= ~(INTELLIGENCE | MAGIC);
        }
        if(other.gameObject.CompareTag("REMOVEALL"))
        {
            attributes = 0;
        }
    }
       
}
