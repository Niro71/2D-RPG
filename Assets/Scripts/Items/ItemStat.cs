using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatType {
  HEALTH,
  DAMAGE,
  DEFENSE,
  SPEED
}

public enum StatAmountType {
  FLAT,
  PERCENTAGE
}

[System.Serializable]
public class EquippableStat {
  public StatType _type;
  public StatAmountType _amountType;
  public int amount;
}
