// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WingBase : Table {
  public static FB_WingBase GetRootAsFB_WingBase(ByteBuffer _bb) { return GetRootAsFB_WingBase(_bb, new FB_WingBase()); }
  public static FB_WingBase GetRootAsFB_WingBase(ByteBuffer _bb, FB_WingBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WingBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StateLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FloorLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsBreak { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int LevelLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayItemID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayItem { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BreakItemID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BreakItem { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute0ID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute0Value { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute1ID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute1Value { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2ID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2Value { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WingPowerMax { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WingPowerRecover { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float FlySpeed { get { int o = __offset(40); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float QuickenFlySpeed { get { int o = __offset(42); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int AdvancedExp { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_WingBase> CreateFB_WingBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int StateLevel = -1,
      int FloorLevel = -1,
      bool IsBreak = false,
      int LevelLimit = -1,
      int PayItemID = -1,
      int PayItem = -1,
      int BreakItemID = -1,
      int BreakItem = -1,
      int Attribute0ID = -1,
      int Attribute0Value = -1,
      int Attribute1ID = -1,
      int Attribute1Value = -1,
      int Attribute2ID = -1,
      int Attribute2Value = -1,
      int WingPowerMax = -1,
      int WingPowerRecover = -1,
      float FlySpeed = 0,
      float QuickenFlySpeed = 0,
      int AdvancedExp = 0) {
    builder.StartObject(21);
    FB_WingBase.AddAdvancedExp(builder, AdvancedExp);
    FB_WingBase.AddQuickenFlySpeed(builder, QuickenFlySpeed);
    FB_WingBase.AddFlySpeed(builder, FlySpeed);
    FB_WingBase.AddWingPowerRecover(builder, WingPowerRecover);
    FB_WingBase.AddWingPowerMax(builder, WingPowerMax);
    FB_WingBase.AddAttribute2Value(builder, Attribute2Value);
    FB_WingBase.AddAttribute2ID(builder, Attribute2ID);
    FB_WingBase.AddAttribute1Value(builder, Attribute1Value);
    FB_WingBase.AddAttribute1ID(builder, Attribute1ID);
    FB_WingBase.AddAttribute0Value(builder, Attribute0Value);
    FB_WingBase.AddAttribute0ID(builder, Attribute0ID);
    FB_WingBase.AddBreakItem(builder, BreakItem);
    FB_WingBase.AddBreakItemID(builder, BreakItemID);
    FB_WingBase.AddPayItem(builder, PayItem);
    FB_WingBase.AddPayItemID(builder, PayItemID);
    FB_WingBase.AddLevelLimit(builder, LevelLimit);
    FB_WingBase.AddFloorLevel(builder, FloorLevel);
    FB_WingBase.AddStateLevel(builder, StateLevel);
    FB_WingBase.AddName(builder, Name);
    FB_WingBase.AddID(builder, ID);
    FB_WingBase.AddIsBreak(builder, IsBreak);
    return FB_WingBase.EndFB_WingBase(builder);
  }

  public static void StartFB_WingBase(FlatBufferBuilder builder) { builder.StartObject(21); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddStateLevel(FlatBufferBuilder builder, int StateLevel) { builder.AddInt(2, StateLevel, -1); }
  public static void AddFloorLevel(FlatBufferBuilder builder, int FloorLevel) { builder.AddInt(3, FloorLevel, -1); }
  public static void AddIsBreak(FlatBufferBuilder builder, bool IsBreak) { builder.AddBool(4, IsBreak, false); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(5, LevelLimit, -1); }
  public static void AddPayItemID(FlatBufferBuilder builder, int PayItemID) { builder.AddInt(6, PayItemID, -1); }
  public static void AddPayItem(FlatBufferBuilder builder, int PayItem) { builder.AddInt(7, PayItem, -1); }
  public static void AddBreakItemID(FlatBufferBuilder builder, int BreakItemID) { builder.AddInt(8, BreakItemID, -1); }
  public static void AddBreakItem(FlatBufferBuilder builder, int BreakItem) { builder.AddInt(9, BreakItem, -1); }
  public static void AddAttribute0ID(FlatBufferBuilder builder, int Attribute0ID) { builder.AddInt(10, Attribute0ID, -1); }
  public static void AddAttribute0Value(FlatBufferBuilder builder, int Attribute0Value) { builder.AddInt(11, Attribute0Value, -1); }
  public static void AddAttribute1ID(FlatBufferBuilder builder, int Attribute1ID) { builder.AddInt(12, Attribute1ID, -1); }
  public static void AddAttribute1Value(FlatBufferBuilder builder, int Attribute1Value) { builder.AddInt(13, Attribute1Value, -1); }
  public static void AddAttribute2ID(FlatBufferBuilder builder, int Attribute2ID) { builder.AddInt(14, Attribute2ID, -1); }
  public static void AddAttribute2Value(FlatBufferBuilder builder, int Attribute2Value) { builder.AddInt(15, Attribute2Value, -1); }
  public static void AddWingPowerMax(FlatBufferBuilder builder, int WingPowerMax) { builder.AddInt(16, WingPowerMax, -1); }
  public static void AddWingPowerRecover(FlatBufferBuilder builder, int WingPowerRecover) { builder.AddInt(17, WingPowerRecover, -1); }
  public static void AddFlySpeed(FlatBufferBuilder builder, float FlySpeed) { builder.AddFloat(18, FlySpeed, 0); }
  public static void AddQuickenFlySpeed(FlatBufferBuilder builder, float QuickenFlySpeed) { builder.AddFloat(19, QuickenFlySpeed, 0); }
  public static void AddAdvancedExp(FlatBufferBuilder builder, int AdvancedExp) { builder.AddInt(20, AdvancedExp, 0); }
  public static Offset<FB_WingBase> EndFB_WingBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WingBase>(o);
  }
};

public sealed class FB_WingBaseContainer : Table {
  public static FB_WingBaseContainer GetRootAsFB_WingBaseContainer(ByteBuffer _bb) { return GetRootAsFB_WingBaseContainer(_bb, new FB_WingBaseContainer()); }
  public static FB_WingBaseContainer GetRootAsFB_WingBaseContainer(ByteBuffer _bb, FB_WingBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WingBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WingBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WingBase GetItems(int j) { return GetItems(new FB_WingBase(), j); }
  public FB_WingBase GetItems(FB_WingBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WingBaseContainer> CreateFB_WingBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WingBaseContainer.AddItems(builder, items);
    return FB_WingBaseContainer.EndFB_WingBaseContainer(builder);
  }

  public static void StartFB_WingBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WingBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WingBaseContainer> EndFB_WingBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WingBaseContainer>(o);
  }
  public static void FinishFB_WingBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_WingBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
