using UnityEngine;
using UnityEditor;

namespace PunIntended.Utility.Editor
{
    [CustomPropertyDrawer(typeof(ReadOnlyInSceneInstanceAttribute))]
    public class ReadOnlyInSceneInstanceDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!PropertyDrawerUtility.InPrefabView)
            {
                GUI.enabled = false;
            }

            EditorGUI.PropertyField(position, property, label, true);
            GUI.enabled = true;
        }
    }
}