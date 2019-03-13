using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMLSerializeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F1))
        {
            TestDataClass tdc = new TestDataClass("MyName", "This is a serialised item");

            //Creates an XML serializer for the TestDataClass type
            XmlSerializer x = new XmlSerializer(tdc.GetType());

            //Sets up a file stream that will allow us to write to a file called TestFile.xml
            System.IO.FileStream file = System.IO.File.Create("TestFile.xml");

            //sends the serialized data of our TestDataClass object to the file stream
            x.Serialize(file, tdc);
            file.Close();
        }        if (Input.GetKeyDown(KeyCode.F2))
        {
            TestDataClass tdc = new TestDataClass("", "");
            XmlSerializer x = new XmlSerializer(tdc.GetType());
            System.IO.FileStream file = System.IO.File.OpenRead("TestFile.xml");
            tdc = (TestDataClass)x.Deserialize(file);
            file.Close();
            print(tdc.name + ": " + tdc.description);
        }

    }
}
