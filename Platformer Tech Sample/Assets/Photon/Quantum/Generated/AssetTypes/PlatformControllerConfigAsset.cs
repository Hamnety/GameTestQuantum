// <auto-generated>
// This code was auto-generated by a tool, every time
// the tool executes this code will be reset.
//
// If you need to extend the classes generated to add
// fields or methods to them, please create partial  
// declarations in another file.
// </auto-generated>

using Quantum;
using UnityEngine;

[CreateAssetMenu(menuName = "Quantum/PlatformControllerConfig", order = Quantum.EditorDefines.AssetMenuPriorityStart + 390)]
public partial class PlatformControllerConfigAsset : AssetBase {
  public Quantum.PlatformControllerConfig Settings;

  public override Quantum.AssetObject AssetObject => Settings;
  
  public override void Reset() {
    if (Settings == null) {
      Settings = new Quantum.PlatformControllerConfig();
    }
    base.Reset();
  }
}

public static partial class PlatformControllerConfigAssetExts {
  public static PlatformControllerConfigAsset GetUnityAsset(this PlatformControllerConfig data) {
    return data == null ? null : UnityDB.FindAsset<PlatformControllerConfigAsset>(data);
  }
}