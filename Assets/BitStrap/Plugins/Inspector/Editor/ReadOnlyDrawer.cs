﻿using UnityEditor;
using UnityEngine;

namespace BitStrap
{
	[CustomPropertyDrawer( typeof( ReadOnlyAttribute ) )]
	public sealed class ReadOnlyDrawer : PropertyDrawer
	{
		public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
		{
			var readOnlyAttribute = attribute as ReadOnlyAttribute;

			EditorGUI.BeginDisabledGroup( !readOnlyAttribute.onlyInPlaymode || EditorApplication.isPlayingOrWillChangePlaymode );
			EditorGUI.PropertyField( position, property, label, true );
			EditorGUI.EndDisabledGroup();
		}
	}
}