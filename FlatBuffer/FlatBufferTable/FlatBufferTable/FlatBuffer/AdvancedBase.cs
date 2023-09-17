// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AdvancedBase : Table {
  public static FB_AdvancedBase GetRootAsFB_AdvancedBase(ByteBuffer _bb) { return GetRootAsFB_AdvancedBase(_bb, new FB_AdvancedBase()); }
  public static FB_AdvancedBase GetRootAsFB_AdvancedBase(ByteBuffer _bb, FB_AdvancedBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AdvancedBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IconSpecial { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int IconTipsDictID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvancedLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayItem { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvanceDescCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string GetAdvancedDescIDList(int j) { int o = __offset(20); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int AdvancedDescIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int LevelLimit { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAddAttrTypeList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AddAttrTypeListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAddAttrList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AddAttrListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int PowerLimit { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }
  public string LableColor { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SectionID { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string GetLevelSpList(int j) { int o = __offset(36); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int LevelSpListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AdvancedBase> CreateFB_AdvancedBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      bool IconSpecial = false,
      int IconTipsDictID = -1,
      int AdvancedLevel = -1,
      int ItemID = -1,
      int PayItem = -1,
      int AdvanceDescCount = -1,
      VectorOffset AdvancedDescIDList = default(VectorOffset),
      int LevelLimit = -1,
      VectorOffset AddAttrTypeList = default(VectorOffset),
      VectorOffset AddAttrList = default(VectorOffset),
      int PowerLimit = -1,
      StringOffset Icon = default(StringOffset),
      StringOffset LableColor = default(StringOffset),
      int SectionID = -1,
      VectorOffset LevelSpList = default(VectorOffset)) {
    builder.StartObject(17);
    FB_AdvancedBase.AddLevelSpList(builder, LevelSpList);
    FB_AdvancedBase.AddSectionID(builder, SectionID);
    FB_AdvancedBase.AddLableColor(builder, LableColor);
    FB_AdvancedBase.AddIcon(builder, Icon);
    FB_AdvancedBase.AddPowerLimit(builder, PowerLimit);
    FB_AdvancedBase.AddAddAttrList(builder, AddAttrList);
    FB_AdvancedBase.AddAddAttrTypeList(builder, AddAttrTypeList);
    FB_AdvancedBase.AddLevelLimit(builder, LevelLimit);
    FB_AdvancedBase.AddAdvancedDescIDList(builder, AdvancedDescIDList);
    FB_AdvancedBase.AddAdvanceDescCount(builder, AdvanceDescCount);
    FB_AdvancedBase.AddPayItem(builder, PayItem);
    FB_AdvancedBase.AddItemID(builder, ItemID);
    FB_AdvancedBase.AddAdvancedLevel(builder, AdvancedLevel);
    FB_AdvancedBase.AddIconTipsDictID(builder, IconTipsDictID);
    FB_AdvancedBase.AddName(builder, Name);
    FB_AdvancedBase.AddID(builder, ID);
    FB_AdvancedBase.AddIconSpecial(builder, IconSpecial);
    return FB_AdvancedBase.EndFB_AdvancedBase(builder);
  }

  public static void StartFB_AdvancedBase(FlatBufferBuilder builder) { builder.StartObject(17); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIconSpecial(FlatBufferBuilder builder, bool IconSpecial) { builder.AddBool(2, IconSpecial, false); }
  public static void AddIconTipsDictID(FlatBufferBuilder builder, int IconTipsDictID) { builder.AddInt(3, IconTipsDictID, -1); }
  public static void AddAdvancedLevel(FlatBufferBuilder builder, int AdvancedLevel) { builder.AddInt(4, AdvancedLevel, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(5, ItemID, -1); }
  public static void AddPayItem(FlatBufferBuilder builder, int PayItem) { builder.AddInt(6, PayItem, -1); }
  public static void AddAdvanceDescCount(FlatBufferBuilder builder, int AdvanceDescCount) { builder.AddInt(7, AdvanceDescCount, -1); }
  public static void AddAdvancedDescIDList(FlatBufferBuilder builder, VectorOffset AdvancedDescIDListOffset) { builder.AddOffset(8, AdvancedDescIDListOffset.Value, 0); }
  public static VectorOffset CreateAdvancedDescIDListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartAdvancedDescIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(9, LevelLimit, -1); }
  public static void AddAddAttrTypeList(FlatBufferBuilder builder, VectorOffset AddAttrTypeListOffset) { builder.AddOffset(10, AddAttrTypeListOffset.Value, 0); }
  public static VectorOffset CreateAddAttrTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAddAttrTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAddAttrList(FlatBufferBuilder builder, VectorOffset AddAttrListOffset) { builder.AddOffset(11, AddAttrListOffset.Value, 0); }
  public static VectorOffset CreateAddAttrListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAddAttrListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPowerLimit(FlatBufferBuilder builder, int PowerLimit) { builder.AddInt(12, PowerLimit, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(13, IconOffset.Value, 0); }
  public static void AddLableColor(FlatBufferBuilder builder, StringOffset LableColorOffset) { builder.AddOffset(14, LableColorOffset.Value, 0); }
  public static void AddSectionID(FlatBufferBuilder builder, int SectionID) { builder.AddInt(15, SectionID, -1); }
  public static void AddLevelSpList(FlatBufferBuilder builder, VectorOffset LevelSpListOffset) { builder.AddOffset(16, LevelSpListOffset.Value, 0); }
  public static VectorOffset CreateLevelSpListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartLevelSpListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AdvancedBase> EndFB_AdvancedBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AdvancedBase>(o);
  }
};

public sealed class FB_AdvancedBaseContainer : Table {
  public static FB_AdvancedBaseContainer GetRootAsFB_AdvancedBaseContainer(ByteBuffer _bb) { return GetRootAsFB_AdvancedBaseContainer(_bb, new FB_AdvancedBaseContainer()); }
  public static FB_AdvancedBaseContainer GetRootAsFB_AdvancedBaseContainer(ByteBuffer _bb, FB_AdvancedBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AdvancedBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AdvancedBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AdvancedBase GetItems(int j) { return GetItems(new FB_AdvancedBase(), j); }
  public FB_AdvancedBase GetItems(FB_AdvancedBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AdvancedBaseContainer> CreateFB_AdvancedBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AdvancedBaseContainer.AddItems(builder, items);
    return FB_AdvancedBaseContainer.EndFB_AdvancedBaseContainer(builder);
  }

  public static void StartFB_AdvancedBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AdvancedBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AdvancedBaseContainer> EndFB_AdvancedBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AdvancedBaseContainer>(o);
  }
  public static void FinishFB_AdvancedBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_AdvancedBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
