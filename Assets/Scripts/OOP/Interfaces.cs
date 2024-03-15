using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces
{
    using UnityEngine;

    public interface IScalable
    {
        void Scale(float scaleFactor);
    }

    public class Resizer : MonoBehaviour
    {
        public float scaleAmount = 2f;

        void Start()
        {
            // We find all the objects in the scene that implement the IScalable interface
            IScalable[] scalableObjects = FindObjectsOfType<MonoBehaviour>() as IScalable[];

            // We increase the scale of all found objects
            foreach (IScalable obj in scalableObjects)
            {
                obj.Scale(scaleAmount);
            }
        }
    }

    public class Cube : MonoBehaviour, IScalable
    {
        public void Scale(float scaleFactor)
        {
            transform.localScale *= scaleFactor;
        }
    }

    public class Sphere : MonoBehaviour, IScalable
    {
        public void Scale(float scaleFactor)
        {
            transform.localScale *= scaleFactor;
        }
    }

}
