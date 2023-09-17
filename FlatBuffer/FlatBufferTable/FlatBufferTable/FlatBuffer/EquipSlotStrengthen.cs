// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipSlotStrengthen : Table {
  public static FB_EquipSlotStrengthen GetRootAsFB_EquipSlotStrengthen(ByteBuffer _bb) { return GetRootAsFB_EquipSlotStrengthen(_bb, new FB_EquipSlotStrengthen()); }
  public static FB_EquipSlotStrengthen GetRootAsFB_EquipSlotStrengthen(ByteBuffer _bb, FB_EquipSlotStrengthen obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipSlotStrengthen __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExpByTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExpNeed { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowEquipNeedLevel { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighEquipNeedLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int ShenZhuangNeedLevel { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipSlotStrengthen> CreateFB_EquipSlotStrengthen(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyType = -1,
      int MoneyNum = -1,
      int ExpByTime = -1,
      int ExpNeed = -1,
      int LowEquipNeedLevel = -1,
      int HighEquipNeedLevel = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int ShenZhuangNeedLevel = -1) {
    builder.StartObject(10);
    FB_EquipSlotStrengthen.AddShenZhuangNeedLevel(builder, ShenZhuangNeedLevel);
    FB_EquipSlotStrengthen.AddAttrValueList(builder, AttrValueList);
    FB_EquipSlotStrengthen.AddAttrIDList(builder, AttrIDList);
    FB_EquipSlotStrengthen.AddHighEquipNeedLevel(builder, HighEquipNeedLevel);
    FB_EquipSlotStrengthen.AddLowEquipNeedLevel(builder, LowEquipNeedLevel);
    FB_EquipSlotStrengthen.AddExpNeed(builder, ExpNeed);
    FB_EquipSlotStrengthen.AddExpByTime(builder, ExpByTime);
    FB_EquipSlotStrengthen.AddMoneyNum(builder, MoneyNum);
    FB_EquipSlotStrengthen.AddMoneyType(builder, MoneyType);
    FB_EquipSlotStrengthen.AddID(builder, ID);
    return FB_EquipSlotStrengthen.EndFB_EquipSlotStrengthen(builder);
  }

  public static void StartFB_EquipSlotStrengthen(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, -1); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(2, MoneyNum, -1); }
  public static void AddExpByTime(FlatBufferBuilder builder, int ExpByTime) { builder.AddInt(3, ExpByTime, -1); }
  public static void AddExpNeed(FlatBufferBuilder builder, int ExpNeed) { builder.AddInt(4, ExpNeed, -1); }
  public static void AddLowEquipNeedLevel(FlatBufferBuilder builder, int LowEquipNeedLevel) { builder.AddInt(5, LowEquipNeedLevel, -1); }
  public static void AddHighEquipNeedLevel(FlatBufferBuilder builder, int HighEquipNeedLevel) { builder.AddInt(6, HighEquipNeedLevel, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(7, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(8, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShenZhuangNeedLevel(FlatBufferBuilder builder, int ShenZhuangNeedLevel) { builder.AddInt(9, ShenZhuangNeedLevel, -1); }
  public static Offset<FB_EquipSlotStrengthen> EndFB_EquipSlotStrengthen(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSlotStrengthen>(o);
  }
};

public sealed class FB_EquipSlotStrengthenContainer : Table {
  public static FB_EquipSlotStrengthenContainer GetRootAsFB_EquipSlotStrengthenContainer(ByteBuffer _bb) { return GetRootAsFB_EquipSlotStrengthenContainer(_bb, new FB_EquipSlotStrengthenContainer()); }
  public static FB_EquipSlotStrengthenContainer GetRootAsFB_EquipSlotStrengthenContainer(ByteBuffer _bb, FB_EquipSlotStrengthenContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipSlotStrengthenContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipSlotStrengthenContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipSlotStrengthen GetItems(int j) { return GetItems(new FB_EquipSlotStrengthen(), j); }
  public FB_EquipSlotStrengthen GetItems(FB_EquipSlotStrengthen obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipSlotStrengthenContainer> CreateFB_EquipSlotStrengthenContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipSlotStrengthenContainer.AddItems(builder, items);
    return FB_EquipSlotStrengthenContainer.EndFB_EquipSlotStrengthenContainer(builder);
  }

  public static void StartFB_EquipSlotStrengthenContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipSlotStrengthen>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipSlotStrengthenContainer> EndFB_EquipSlotStrengthenContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSlotStrengthenContainer>(o);
  }
  public static void FinishFB_EquipSlotStrengthenContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipSlotStrengthenContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
