using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace PunIntended.Utility.Editor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(MonoBehaviour), true)]
    public class MonoBehaviourCustomEditor : UnityEditor.Editor
    {
        private const BindingFlags _methodsBindingFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            DrawCustomButtons();
        }

        // TODO(berend): check for performance problem in editor?
        private void DrawCustomButtons()
        {
            Type type = target.GetType();
            foreach (MethodInfo method in type.GetMethods(_methodsBindingFlags))
            {
                IEnumerable<ButtonAttribute> attributes = method.GetCustomAttributes<ButtonAttribute>(true);
                if (attributes.Count() > 0)
                {
                    if (GUILayout.Button(method.Name))
                    {
                        // null is passed as we dont support parameters currently
                        method.Invoke(target, parameters: null);
                    }
                }
            }
        }
    }
}