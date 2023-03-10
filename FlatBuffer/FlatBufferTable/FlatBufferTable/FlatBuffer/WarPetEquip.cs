// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetEquip : Table {
  public static FB_WarPetEquip GetRootAsFB_WarPetEquip(ByteBuffer _bb) { return GetRootAsFB_WarPetEquip(_bb, new FB_WarPetEquip()); }
  public static FB_WarPetEquip GetRootAsFB_WarPetEquip(ByteBuffer _bb, FB_WarPetEquip obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetEquip __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Exp { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Star { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxStar { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public string Tips { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SellPrice { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SystemRemind { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string DropModle { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_WarPetEquip> CreateFB_WarPetEquip(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Exp = -1,
      int Quality = -1,
      int Component = -1,
      int Star = 0,
      int MaxStar = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      StringOffset Tips = default(StringOffset),
      int SellPrice = -1,
      int GetPathID = -1,
      int SystemRemind = -1,
      StringOffset DropModle = default(StringOffset)) {
    builder.StartObject(15);
    FB_WarPetEquip.AddDropModle(builder, DropModle);
    FB_WarPetEquip.AddSystemRemind(builder, SystemRemind);
    FB_WarPetEquip.AddGetPathID(builder, GetPathID);
    FB_WarPetEquip.AddSellPrice(builder, SellPrice);
    FB_WarPetEquip.AddTips(builder, Tips);
    FB_WarPetEquip.AddAttrValueList(builder, AttrValueList);
    FB_WarPetEquip.AddAttrIdList(builder, AttrIdList);
    FB_WarPetEquip.AddMaxStar(builder, MaxStar);
    FB_WarPetEquip.AddStar(builder, Star);
    FB_WarPetEquip.AddComponent(builder, Component);
    FB_WarPetEquip.AddQuality(builder, Quality);
    FB_WarPetEquip.AddExp(builder, Exp);
    FB_WarPetEquip.AddIcon(builder, Icon);
    FB_WarPetEquip.AddName(builder, Name);
    FB_WarPetEquip.AddID(builder, ID);
    return FB_WarPetEquip.EndFB_WarPetEquip(builder);
  }

  public static void StartFB_WarPetEquip(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(3, Exp, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(4, Quality, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(5, Component, -1); }
  public static void AddStar(FlatBufferBuilder builder, int Star) { builder.AddInt(6, Star, 0); }
  public static void AddMaxStar(FlatBufferBuilder builder, int MaxStar) { builder.AddInt(7, MaxStar, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(8, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(9, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(10, TipsOffset.Value, 0); }
  public static void AddSellPrice(FlatBufferBuilder builder, int SellPrice) { builder.AddInt(11, SellPrice, -1); }
  public static void AddGetPathID(FlatBufferBuilder builder, int GetPathID) { builder.AddInt(12, GetPathID, -1); }
  public static void AddSystemRemind(FlatBufferBuilder builder, int SystemRemind) { builder.AddInt(13, SystemRemind, -1); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(14, DropModleOffset.Value, 0); }
  public static Offset<FB_WarPetEquip> EndFB_WarPetEquip(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetEquip>(o);
  }
};

public sealed class FB_WarPetEquipContainer : Table {
  public static FB_WarPetEquipContainer GetRootAsFB_WarPetEquipContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetEquipContainer(_bb, new FB_WarPetEquipContainer()); }
  public static FB_WarPetEquipContainer GetRootAsFB_WarPetEquipContainer(ByteBuffer _bb, FB_WarPetEquipContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetEquipContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetEquipContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetEquip GetItems(int j) { return GetItems(new FB_WarPetEquip(), j); }
  public FB_WarPetEquip GetItems(FB_WarPetEquip obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetEquipContainer> CreateFB_WarPetEquipContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetEquipContainer.AddItems(builder, items);
    return FB_WarPetEquipContainer.EndFB_WarPetEquipContainer(builder);
  }

  public static void StartFB_WarPetEquipContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetEquip>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetEquipContainer> EndFB_WarPetEquipContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetEquipContainer>(o);
  }
  public static void FinishFB_WarPetEquipContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetEquipContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
