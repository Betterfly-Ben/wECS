#if UNITY_EDITOR
using System;
using UnityEditor;

public class DoubleTypeDrawer : ITypeDrawer
{
    public bool HandlesType(Type type)
    {
        return type == typeof(double);
    }

    public object DrawAndGetNewValue(Type memberType, string memberName, object value, object target)
    {
        return EditorGUILayout.DoubleField(memberName, (double) value);
    }
}
#endif
