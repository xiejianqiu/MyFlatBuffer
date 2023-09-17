// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BenYuanItemBase : Table {
  public static FB_BenYuanItemBase GetRootAsFB_BenYuanItemBase(ByteBuffer _bb) { return GetRootAsFB_BenYuanItemBase(_bb, new FB_BenYuanItemBase()); }
  public static FB_BenYuanItemBase GetRootAsFB_BenYuanItemBase(ByteBuffer _bb, FB_BenYuanItemBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BenYuanItemBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Component { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Step { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StarCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxLevel { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int DoubleCost { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetPathID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ItemDesc { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DropModle { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SellPrice { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_BenYuanItemBase> CreateFB_BenYuanItemBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Quality = 0,
      int Component = 0,
      int Step = 0,
      int StarCount = 0,
      int Exp = 0,
      int MaxLevel = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int DoubleCost = 0,
      int GetPathID = -1,
      StringOffset ItemDesc = default(StringOffset),
      StringOffset DropModle = default(StringOffset),
      int SellPrice = 0) {
    builder.StartObject(16);
    FB_BenYuanItemBase.AddSellPrice(builder, SellPrice);
    FB_BenYuanItemBase.AddDropModle(builder, DropModle);
    FB_BenYuanItemBase.AddItemDesc(builder, ItemDesc);
    FB_BenYuanItemBase.AddGetPathID(builder, GetPathID);
    FB_BenYuanItemBase.AddDoubleCost(builder, DoubleCost);
    FB_BenYuanItemBase.AddAttrValueList(builder, AttrValueList);
    FB_BenYuanItemBase.AddAttrIdList(builder, AttrIdList);
    FB_BenYuanItemBase.AddMaxLevel(builder, MaxLevel);
    FB_BenYuanItemBase.AddExp(builder, Exp);
    FB_BenYuanItemBase.AddStarCount(builder, StarCount);
    FB_BenYuanItemBase.AddStep(builder, Step);
    FB_BenYuanItemBase.AddComponent(builder, Component);
    FB_BenYuanItemBase.AddQuality(builder, Quality);
    FB_BenYuanItemBase.AddIcon(builder, Icon);
    FB_BenYuanItemBase.AddName(builder, Name);
    FB_BenYuanItemBase.AddId(builder, Id);
    return FB_BenYuanItemBase.EndFB_BenYuanItemBase(builder);
  }

  public static void StartFB_BenYuanItemBase(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(3, Quality, 0); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(4, Component, 0); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(5, Step, 0); }
  public static void AddStarCount(FlatBufferBuilder builder, int StarCount) { builder.AddInt(6, StarCount, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(7, Exp, 0); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(8, MaxLevel, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(9, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(10, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDoubleCost(FlatBufferBuilder builder, int DoubleCost) { builder.AddInt(11, DoubleCost, 0); }
  public static void AddGetPathID(FlatBufferBuilder builder, int GetPathID) { builder.AddInt(12, GetPathID, -1); }
  public static void AddItemDesc(FlatBufferBuilder builder, StringOffset ItemDescOffset) { builder.AddOffset(13, ItemDescOffset.Value, 0); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(14, DropModleOffset.Value, 0); }
  public static void AddSellPrice(FlatBufferBuilder builder, int SellPrice) { builder.AddInt(15, SellPrice, 0); }
  public static Offset<FB_BenYuanItemBase> EndFB_BenYuanItemBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BenYuanItemBase>(o);
  }
};

public sealed class FB_BenYuanItemBaseContainer : Table {
  public static FB_BenYuanItemBaseContainer GetRootAsFB_BenYuanItemBaseContainer(ByteBuffer _bb) { return GetRootAsFB_BenYuanItemBaseContainer(_bb, new FB_BenYuanItemBaseContainer()); }
  public static FB_BenYuanItemBaseContainer GetRootAsFB_BenYuanItemBaseContainer(ByteBuffer _bb, FB_BenYuanItemBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BenYuanItemBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BenYuanItemBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BenYuanItemBase GetItems(int j) { return GetItems(new FB_BenYuanItemBase(), j); }
  public FB_BenYuanItemBase GetItems(FB_BenYuanItemBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BenYuanItemBaseContainer> CreateFB_BenYuanItemBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BenYuanItemBaseContainer.AddItems(builder, items);
    return FB_BenYuanItemBaseContainer.EndFB_BenYuanItemBaseContainer(builder);
  }

  public static void StartFB_BenYuanItemBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BenYuanItemBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BenYuanItemBaseContainer> EndFB_BenYuanItemBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BenYuanItemBaseContainer>(o);
  }
  public static void FinishFB_BenYuanItemBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_BenYuanItemBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
