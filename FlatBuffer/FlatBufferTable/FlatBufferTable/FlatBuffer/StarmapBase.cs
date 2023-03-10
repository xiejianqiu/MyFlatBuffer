// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarmapBase : Table {
  public static FB_StarmapBase GetRootAsFB_StarmapBase(ByteBuffer _bb) { return GetRootAsFB_StarmapBase(_bb, new FB_StarmapBase()); }
  public static FB_StarmapBase GetRootAsFB_StarmapBase(ByteBuffer _bb, FB_StarmapBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarmapBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Tips { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SectionID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RequireNum { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRequireIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RequireIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int Attribute1ID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute1Value { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute1MinValue { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute1PowerValue { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute1MaxValue { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2ID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2Value { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2MinValue { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2PowerValue { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2MaxValue { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NormalRandomID { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PowerRandomID { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PowerMax { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsDoubleAttr { get { int o = __offset(44); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsBattle { get { int o = __offset(46); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int BattleID { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvancedExp { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_StarmapBase> CreateFB_StarmapBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Tips = default(StringOffset),
      int Quality = -1,
      int SectionID = -1,
      int RequireNum = -1,
      VectorOffset RequireIDList = default(VectorOffset),
      int Attribute1ID = -1,
      int Attribute1Value = -1,
      int Attribute1MinValue = -1,
      int Attribute1PowerValue = -1,
      int Attribute1MaxValue = -1,
      int Attribute2ID = -1,
      int Attribute2Value = -1,
      int Attribute2MinValue = -1,
      int Attribute2PowerValue = -1,
      int Attribute2MaxValue = -1,
      int NormalRandomID = -1,
      int PowerRandomID = -1,
      int PowerMax = -1,
      bool IsDoubleAttr = false,
      bool IsBattle = false,
      int BattleID = -1,
      int AdvancedExp = 0) {
    builder.StartObject(24);
    FB_StarmapBase.AddAdvancedExp(builder, AdvancedExp);
    FB_StarmapBase.AddBattleID(builder, BattleID);
    FB_StarmapBase.AddPowerMax(builder, PowerMax);
    FB_StarmapBase.AddPowerRandomID(builder, PowerRandomID);
    FB_StarmapBase.AddNormalRandomID(builder, NormalRandomID);
    FB_StarmapBase.AddAttribute2MaxValue(builder, Attribute2MaxValue);
    FB_StarmapBase.AddAttribute2PowerValue(builder, Attribute2PowerValue);
    FB_StarmapBase.AddAttribute2MinValue(builder, Attribute2MinValue);
    FB_StarmapBase.AddAttribute2Value(builder, Attribute2Value);
    FB_StarmapBase.AddAttribute2ID(builder, Attribute2ID);
    FB_StarmapBase.AddAttribute1MaxValue(builder, Attribute1MaxValue);
    FB_StarmapBase.AddAttribute1PowerValue(builder, Attribute1PowerValue);
    FB_StarmapBase.AddAttribute1MinValue(builder, Attribute1MinValue);
    FB_StarmapBase.AddAttribute1Value(builder, Attribute1Value);
    FB_StarmapBase.AddAttribute1ID(builder, Attribute1ID);
    FB_StarmapBase.AddRequireIDList(builder, RequireIDList);
    FB_StarmapBase.AddRequireNum(builder, RequireNum);
    FB_StarmapBase.AddSectionID(builder, SectionID);
    FB_StarmapBase.AddQuality(builder, Quality);
    FB_StarmapBase.AddTips(builder, Tips);
    FB_StarmapBase.AddName(builder, Name);
    FB_StarmapBase.AddID(builder, ID);
    FB_StarmapBase.AddIsBattle(builder, IsBattle);
    FB_StarmapBase.AddIsDoubleAttr(builder, IsDoubleAttr);
    return FB_StarmapBase.EndFB_StarmapBase(builder);
  }

  public static void StartFB_StarmapBase(FlatBufferBuilder builder) { builder.StartObject(24); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(2, TipsOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(3, Quality, -1); }
  public static void AddSectionID(FlatBufferBuilder builder, int SectionID) { builder.AddInt(4, SectionID, -1); }
  public static void AddRequireNum(FlatBufferBuilder builder, int RequireNum) { builder.AddInt(5, RequireNum, -1); }
  public static void AddRequireIDList(FlatBufferBuilder builder, VectorOffset RequireIDListOffset) { builder.AddOffset(6, RequireIDListOffset.Value, 0); }
  public static VectorOffset CreateRequireIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRequireIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttribute1ID(FlatBufferBuilder builder, int Attribute1ID) { builder.AddInt(7, Attribute1ID, -1); }
  public static void AddAttribute1Value(FlatBufferBuilder builder, int Attribute1Value) { builder.AddInt(8, Attribute1Value, -1); }
  public static void AddAttribute1MinValue(FlatBufferBuilder builder, int Attribute1MinValue) { builder.AddInt(9, Attribute1MinValue, -1); }
  public static void AddAttribute1PowerValue(FlatBufferBuilder builder, int Attribute1PowerValue) { builder.AddInt(10, Attribute1PowerValue, -1); }
  public static void AddAttribute1MaxValue(FlatBufferBuilder builder, int Attribute1MaxValue) { builder.AddInt(11, Attribute1MaxValue, -1); }
  public static void AddAttribute2ID(FlatBufferBuilder builder, int Attribute2ID) { builder.AddInt(12, Attribute2ID, -1); }
  public static void AddAttribute2Value(FlatBufferBuilder builder, int Attribute2Value) { builder.AddInt(13, Attribute2Value, -1); }
  public static void AddAttribute2MinValue(FlatBufferBuilder builder, int Attribute2MinValue) { builder.AddInt(14, Attribute2MinValue, -1); }
  public static void AddAttribute2PowerValue(FlatBufferBuilder builder, int Attribute2PowerValue) { builder.AddInt(15, Attribute2PowerValue, -1); }
  public static void AddAttribute2MaxValue(FlatBufferBuilder builder, int Attribute2MaxValue) { builder.AddInt(16, Attribute2MaxValue, -1); }
  public static void AddNormalRandomID(FlatBufferBuilder builder, int NormalRandomID) { builder.AddInt(17, NormalRandomID, -1); }
  public static void AddPowerRandomID(FlatBufferBuilder builder, int PowerRandomID) { builder.AddInt(18, PowerRandomID, -1); }
  public static void AddPowerMax(FlatBufferBuilder builder, int PowerMax) { builder.AddInt(19, PowerMax, -1); }
  public static void AddIsDoubleAttr(FlatBufferBuilder builder, bool IsDoubleAttr) { builder.AddBool(20, IsDoubleAttr, false); }
  public static void AddIsBattle(FlatBufferBuilder builder, bool IsBattle) { builder.AddBool(21, IsBattle, false); }
  public static void AddBattleID(FlatBufferBuilder builder, int BattleID) { builder.AddInt(22, BattleID, -1); }
  public static void AddAdvancedExp(FlatBufferBuilder builder, int AdvancedExp) { builder.AddInt(23, AdvancedExp, 0); }
  public static Offset<FB_StarmapBase> EndFB_StarmapBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarmapBase>(o);
  }
};

public sealed class FB_StarmapBaseContainer : Table {
  public static FB_StarmapBaseContainer GetRootAsFB_StarmapBaseContainer(ByteBuffer _bb) { return GetRootAsFB_StarmapBaseContainer(_bb, new FB_StarmapBaseContainer()); }
  public static FB_StarmapBaseContainer GetRootAsFB_StarmapBaseContainer(ByteBuffer _bb, FB_StarmapBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarmapBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarmapBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarmapBase GetItems(int j) { return GetItems(new FB_StarmapBase(), j); }
  public FB_StarmapBase GetItems(FB_StarmapBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarmapBaseContainer> CreateFB_StarmapBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarmapBaseContainer.AddItems(builder, items);
    return FB_StarmapBaseContainer.EndFB_StarmapBaseContainer(builder);
  }

  public static void StartFB_StarmapBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarmapBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarmapBaseContainer> EndFB_StarmapBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarmapBaseContainer>(o);
  }
  public static void FinishFB_StarmapBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarmapBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
