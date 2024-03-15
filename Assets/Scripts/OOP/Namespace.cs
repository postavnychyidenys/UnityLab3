using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EditorTools.MapCreation
{
    public class Namespace : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Movement : MonoBehaviour
    {
        void Start()
        {
            float speed = Random.value;
        }
    }

    public class Inventory : MonoBehaviour
    {
        public System.Collections.ArrayList items;
    }
}
