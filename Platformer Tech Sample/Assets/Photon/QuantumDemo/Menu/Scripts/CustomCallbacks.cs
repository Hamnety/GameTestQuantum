﻿using Quantum;
using UnityEngine;

public class CustomCallbacks : QuantumCallbacks {

  public RuntimePlayer PlayerData;
  
  public override void OnGameStart(Quantum.QuantumGame game) {
    // paused on Start means waiting for Snapshot
    if (game.Session.IsPaused) return;

    foreach (var localPlayer in game.GetLocalPlayers()) {
      Debug.Log("CustomCallbacks - sending player: " + localPlayer);
      game.SendPlayerData(localPlayer, PlayerData);
    }
  }

  public override void OnGameResync(Quantum.QuantumGame game)
  {
    Debug.Log("Detected Resync. Verified tick: " + game.Frames.Verified.Number);
  }
}

