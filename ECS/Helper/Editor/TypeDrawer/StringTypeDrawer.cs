#if UNITY_EDITOR
using System;
using UnityEditor;

public class StringTypeDrawer : ITypeDrawer
{
    public bool HandlesType(Type type)
    {
        return type == typeof(string);
    }

    public object DrawAndGetNewValue(Type memberType, string memberName, object value, object target)
    {
        return EditorGUILayout.TextField(memberName, (string) value);
    }
}
#endif
