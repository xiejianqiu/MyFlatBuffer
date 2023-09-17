// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangItemBase : Table {
  public static FB_HunJiangItemBase GetRootAsFB_HunJiangItemBase(ByteBuffer _bb) { return GetRootAsFB_HunJiangItemBase(_bb, new FB_HunJiangItemBase()); }
  public static FB_HunJiangItemBase GetRootAsFB_HunJiangItemBase(ByteBuffer _bb, FB_HunJiangItemBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangItemBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Component { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StarCount { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int SellPrice { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetPathID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SystemRemind { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ItemDesc { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DropModle { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_HunJiangItemBase> CreateFB_HunJiangItemBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Quality = 0,
      int Component = 0,
      int StarCount = 0,
      int Exp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int SellPrice = 0,
      int GetPathID = -1,
      int SystemRemind = -1,
      StringOffset ItemDesc = default(StringOffset),
      StringOffset DropModle = default(StringOffset)) {
    builder.StartObject(14);
    FB_HunJiangItemBase.AddDropModle(builder, DropModle);
    FB_HunJiangItemBase.AddItemDesc(builder, ItemDesc);
    FB_HunJiangItemBase.AddSystemRemind(builder, SystemRemind);
    FB_HunJiangItemBase.AddGetPathID(builder, GetPathID);
    FB_HunJiangItemBase.AddSellPrice(builder, SellPrice);
    FB_HunJiangItemBase.AddAttrValueList(builder, AttrValueList);
    FB_HunJiangItemBase.AddAttrIdList(builder, AttrIdList);
    FB_HunJiangItemBase.AddExp(builder, Exp);
    FB_HunJiangItemBase.AddStarCount(builder, StarCount);
    FB_HunJiangItemBase.AddComponent(builder, Component);
    FB_HunJiangItemBase.AddQuality(builder, Quality);
    FB_HunJiangItemBase.AddIcon(builder, Icon);
    FB_HunJiangItemBase.AddName(builder, Name);
    FB_HunJiangItemBase.AddId(builder, Id);
    return FB_HunJiangItemBase.EndFB_HunJiangItemBase(builder);
  }

  public static void StartFB_HunJiangItemBase(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(3, Quality, 0); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(4, Component, 0); }
  public static void AddStarCount(FlatBufferBuilder builder, int StarCount) { builder.AddInt(5, StarCount, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(6, Exp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(7, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(8, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSellPrice(FlatBufferBuilder builder, int SellPrice) { builder.AddInt(9, SellPrice, 0); }
  public static void AddGetPathID(FlatBufferBuilder builder, int GetPathID) { builder.AddInt(10, GetPathID, -1); }
  public static void AddSystemRemind(FlatBufferBuilder builder, int SystemRemind) { builder.AddInt(11, SystemRemind, -1); }
  public static void AddItemDesc(FlatBufferBuilder builder, StringOffset ItemDescOffset) { builder.AddOffset(12, ItemDescOffset.Value, 0); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(13, DropModleOffset.Value, 0); }
  public static Offset<FB_HunJiangItemBase> EndFB_HunJiangItemBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangItemBase>(o);
  }
};

public sealed class FB_HunJiangItemBaseContainer : Table {
  public static FB_HunJiangItemBaseContainer GetRootAsFB_HunJiangItemBaseContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangItemBaseContainer(_bb, new FB_HunJiangItemBaseContainer()); }
  public static FB_HunJiangItemBaseContainer GetRootAsFB_HunJiangItemBaseContainer(ByteBuffer _bb, FB_HunJiangItemBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangItemBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangItemBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangItemBase GetItems(int j) { return GetItems(new FB_HunJiangItemBase(), j); }
  public FB_HunJiangItemBase GetItems(FB_HunJiangItemBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangItemBaseContainer> CreateFB_HunJiangItemBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangItemBaseContainer.AddItems(builder, items);
    return FB_HunJiangItemBaseContainer.EndFB_HunJiangItemBaseContainer(builder);
  }

  public static void StartFB_HunJiangItemBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangItemBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangItemBaseContainer> EndFB_HunJiangItemBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangItemBaseContainer>(o);
  }
  public static void FinishFB_HunJiangItemBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangItemBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
