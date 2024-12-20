// <auto-generated>
// This code was auto-generated by a tool, every time
// the tool executes this code will be reset.
// </auto-generated>

namespace Quantum.Editor {
  using Quantum;
  using UnityEngine;
  using UnityEditor;

  [CustomPropertyDrawer(typeof(AssetRefPlatformConfig))]
  public class AssetRefPlatformConfigPropertyDrawer : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
      AssetRefDrawer.DrawAssetRefSelector(position, property, label, typeof(PlatformConfigAsset));
    }
  }

  [CustomPropertyDrawer(typeof(AssetRefPlatformControllerConfig))]
  public class AssetRefPlatformControllerConfigPropertyDrawer : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
      AssetRefDrawer.DrawAssetRefSelector(position, property, label, typeof(PlatformControllerConfigAsset));
    }
  }

  [CustomPropertyDrawer(typeof(Quantum.Prototypes.InputButtons_Prototype))]
  [CustomPropertyDrawer(typeof(Quantum.Prototypes.PlatformAxis_Prototype))]
  partial class PrototypeDrawer {}
}
