// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenShouEquipBase : Table {
  public static FB_ShenShouEquipBase GetRootAsFB_ShenShouEquipBase(ByteBuffer _bb) { return GetRootAsFB_ShenShouEquipBase(_bb, new FB_ShenShouEquipBase()); }
  public static FB_ShenShouEquipBase GetRootAsFB_ShenShouEquipBase(ByteBuffer _bb, FB_ShenShouEquipBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenShouEquipBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Exp { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DoubleCost { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StarCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public string Tips { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DropModle { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SellPrice { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SystemRemind { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShenShouEquipBase> CreateFB_ShenShouEquipBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Exp = -1,
      int DoubleCost = -1,
      int Quality = -1,
      int Component = -1,
      int StarCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      StringOffset Tips = default(StringOffset),
      StringOffset DropModle = default(StringOffset),
      int SellPrice = -1,
      int GetPathID = -1,
      int SystemRemind = -1) {
    builder.StartObject(15);
    FB_ShenShouEquipBase.AddSystemRemind(builder, SystemRemind);
    FB_ShenShouEquipBase.AddGetPathID(builder, GetPathID);
    FB_ShenShouEquipBase.AddSellPrice(builder, SellPrice);
    FB_ShenShouEquipBase.AddDropModle(builder, DropModle);
    FB_ShenShouEquipBase.AddTips(builder, Tips);
    FB_ShenShouEquipBase.AddAttrValueList(builder, AttrValueList);
    FB_ShenShouEquipBase.AddAttrIdList(builder, AttrIdList);
    FB_ShenShouEquipBase.AddStarCount(builder, StarCount);
    FB_ShenShouEquipBase.AddComponent(builder, Component);
    FB_ShenShouEquipBase.AddQuality(builder, Quality);
    FB_ShenShouEquipBase.AddDoubleCost(builder, DoubleCost);
    FB_ShenShouEquipBase.AddExp(builder, Exp);
    FB_ShenShouEquipBase.AddIcon(builder, Icon);
    FB_ShenShouEquipBase.AddName(builder, Name);
    FB_ShenShouEquipBase.AddID(builder, ID);
    return FB_ShenShouEquipBase.EndFB_ShenShouEquipBase(builder);
  }

  public static void StartFB_ShenShouEquipBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(3, Exp, -1); }
  public static void AddDoubleCost(FlatBufferBuilder builder, int DoubleCost) { builder.AddInt(4, DoubleCost, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(5, Quality, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(6, Component, -1); }
  public static void AddStarCount(FlatBufferBuilder builder, int StarCount) { builder.AddInt(7, StarCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(8, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(9, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(10, TipsOffset.Value, 0); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(11, DropModleOffset.Value, 0); }
  public static void AddSellPrice(FlatBufferBuilder builder, int SellPrice) { builder.AddInt(12, SellPrice, -1); }
  public static void AddGetPathID(FlatBufferBuilder builder, int GetPathID) { builder.AddInt(13, GetPathID, -1); }
  public static void AddSystemRemind(FlatBufferBuilder builder, int SystemRemind) { builder.AddInt(14, SystemRemind, -1); }
  public static Offset<FB_ShenShouEquipBase> EndFB_ShenShouEquipBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShouEquipBase>(o);
  }
};

public sealed class FB_ShenShouEquipBaseContainer : Table {
  public static FB_ShenShouEquipBaseContainer GetRootAsFB_ShenShouEquipBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShenShouEquipBaseContainer(_bb, new FB_ShenShouEquipBaseContainer()); }
  public static FB_ShenShouEquipBaseContainer GetRootAsFB_ShenShouEquipBaseContainer(ByteBuffer _bb, FB_ShenShouEquipBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenShouEquipBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenShouEquipBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenShouEquipBase GetItems(int j) { return GetItems(new FB_ShenShouEquipBase(), j); }
  public FB_ShenShouEquipBase GetItems(FB_ShenShouEquipBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShouEquipBaseContainer> CreateFB_ShenShouEquipBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenShouEquipBaseContainer.AddItems(builder, items);
    return FB_ShenShouEquipBaseContainer.EndFB_ShenShouEquipBaseContainer(builder);
  }

  public static void StartFB_ShenShouEquipBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenShouEquipBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShouEquipBaseContainer> EndFB_ShenShouEquipBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShouEquipBaseContainer>(o);
  }
  public static void FinishFB_ShenShouEquipBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenShouEquipBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
