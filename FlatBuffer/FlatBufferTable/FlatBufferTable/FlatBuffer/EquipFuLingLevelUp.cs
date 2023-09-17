// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipFuLingLevelUp : Table {
  public static FB_EquipFuLingLevelUp GetRootAsFB_EquipFuLingLevelUp(ByteBuffer _bb) { return GetRootAsFB_EquipFuLingLevelUp(_bb, new FB_EquipFuLingLevelUp()); }
  public static FB_EquipFuLingLevelUp GetRootAsFB_EquipFuLingLevelUp(ByteBuffer _bb, FB_EquipFuLingLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipFuLingLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Step { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrValue { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipFuLingLevelUp> CreateFB_EquipFuLingLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int Step = -1,
      int ShowLevel = -1,
      int UnLockType = -1,
      int UnlockId = -1,
      int MoneyType = -1,
      int MoneyNum = 0,
      int AttrValue = -1) {
    builder.StartObject(8);
    FB_EquipFuLingLevelUp.AddAttrValue(builder, AttrValue);
    FB_EquipFuLingLevelUp.AddMoneyNum(builder, MoneyNum);
    FB_EquipFuLingLevelUp.AddMoneyType(builder, MoneyType);
    FB_EquipFuLingLevelUp.AddUnlockId(builder, UnlockId);
    FB_EquipFuLingLevelUp.AddUnLockType(builder, UnLockType);
    FB_EquipFuLingLevelUp.AddShowLevel(builder, ShowLevel);
    FB_EquipFuLingLevelUp.AddStep(builder, Step);
    FB_EquipFuLingLevelUp.AddID(builder, ID);
    return FB_EquipFuLingLevelUp.EndFB_EquipFuLingLevelUp(builder);
  }

  public static void StartFB_EquipFuLingLevelUp(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(1, Step, -1); }
  public static void AddShowLevel(FlatBufferBuilder builder, int ShowLevel) { builder.AddInt(2, ShowLevel, -1); }
  public static void AddUnLockType(FlatBufferBuilder builder, int UnLockType) { builder.AddInt(3, UnLockType, -1); }
  public static void AddUnlockId(FlatBufferBuilder builder, int UnlockId) { builder.AddInt(4, UnlockId, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(5, MoneyType, -1); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(6, MoneyNum, 0); }
  public static void AddAttrValue(FlatBufferBuilder builder, int AttrValue) { builder.AddInt(7, AttrValue, -1); }
  public static Offset<FB_EquipFuLingLevelUp> EndFB_EquipFuLingLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFuLingLevelUp>(o);
  }
};

public sealed class FB_EquipFuLingLevelUpContainer : Table {
  public static FB_EquipFuLingLevelUpContainer GetRootAsFB_EquipFuLingLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_EquipFuLingLevelUpContainer(_bb, new FB_EquipFuLingLevelUpContainer()); }
  public static FB_EquipFuLingLevelUpContainer GetRootAsFB_EquipFuLingLevelUpContainer(ByteBuffer _bb, FB_EquipFuLingLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipFuLingLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipFuLingLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipFuLingLevelUp GetItems(int j) { return GetItems(new FB_EquipFuLingLevelUp(), j); }
  public FB_EquipFuLingLevelUp GetItems(FB_EquipFuLingLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipFuLingLevelUpContainer> CreateFB_EquipFuLingLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipFuLingLevelUpContainer.AddItems(builder, items);
    return FB_EquipFuLingLevelUpContainer.EndFB_EquipFuLingLevelUpContainer(builder);
  }

  public static void StartFB_EquipFuLingLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipFuLingLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipFuLingLevelUpContainer> EndFB_EquipFuLingLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFuLingLevelUpContainer>(o);
  }
  public static void FinishFB_EquipFuLingLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipFuLingLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
