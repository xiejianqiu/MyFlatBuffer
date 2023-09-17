// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaEquip : Table {
  public static FB_ShenWangZhanJiaEquip GetRootAsFB_ShenWangZhanJiaEquip(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaEquip(_bb, new FB_ShenWangZhanJiaEquip()); }
  public static FB_ShenWangZhanJiaEquip GetRootAsFB_ShenWangZhanJiaEquip(ByteBuffer _bb, FB_ShenWangZhanJiaEquip obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaEquip __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ExpType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Exp { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Stage { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int PassiveSkill { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Tips { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SellPrice { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SystemRemind { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string DropModle { get { int o = __offset(34); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_ShenWangZhanJiaEquip> CreateFB_ShenWangZhanJiaEquip(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int ExpType = -1,
      int Exp = -1,
      int Quality = -1,
      int Component = -1,
      int Stage = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int PassiveSkill = -1,
      StringOffset Tips = default(StringOffset),
      int SellPrice = -1,
      int GetPathID = -1,
      int SystemRemind = -1,
      StringOffset DropModle = default(StringOffset)) {
    builder.StartObject(16);
    FB_ShenWangZhanJiaEquip.AddDropModle(builder, DropModle);
    FB_ShenWangZhanJiaEquip.AddSystemRemind(builder, SystemRemind);
    FB_ShenWangZhanJiaEquip.AddGetPathID(builder, GetPathID);
    FB_ShenWangZhanJiaEquip.AddSellPrice(builder, SellPrice);
    FB_ShenWangZhanJiaEquip.AddTips(builder, Tips);
    FB_ShenWangZhanJiaEquip.AddPassiveSkill(builder, PassiveSkill);
    FB_ShenWangZhanJiaEquip.AddAttrValueList(builder, AttrValueList);
    FB_ShenWangZhanJiaEquip.AddAttrIdList(builder, AttrIdList);
    FB_ShenWangZhanJiaEquip.AddStage(builder, Stage);
    FB_ShenWangZhanJiaEquip.AddComponent(builder, Component);
    FB_ShenWangZhanJiaEquip.AddQuality(builder, Quality);
    FB_ShenWangZhanJiaEquip.AddExp(builder, Exp);
    FB_ShenWangZhanJiaEquip.AddExpType(builder, ExpType);
    FB_ShenWangZhanJiaEquip.AddIcon(builder, Icon);
    FB_ShenWangZhanJiaEquip.AddName(builder, Name);
    FB_ShenWangZhanJiaEquip.AddID(builder, ID);
    return FB_ShenWangZhanJiaEquip.EndFB_ShenWangZhanJiaEquip(builder);
  }

  public static void StartFB_ShenWangZhanJiaEquip(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddExpType(FlatBufferBuilder builder, int ExpType) { builder.AddInt(3, ExpType, -1); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(4, Exp, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(5, Quality, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(6, Component, -1); }
  public static void AddStage(FlatBufferBuilder builder, int Stage) { builder.AddInt(7, Stage, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(8, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(9, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveSkill(FlatBufferBuilder builder, int PassiveSkill) { builder.AddInt(10, PassiveSkill, -1); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(11, TipsOffset.Value, 0); }
  public static void AddSellPrice(FlatBufferBuilder builder, int SellPrice) { builder.AddInt(12, SellPrice, -1); }
  public static void AddGetPathID(FlatBufferBuilder builder, int GetPathID) { builder.AddInt(13, GetPathID, -1); }
  public static void AddSystemRemind(FlatBufferBuilder builder, int SystemRemind) { builder.AddInt(14, SystemRemind, -1); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(15, DropModleOffset.Value, 0); }
  public static Offset<FB_ShenWangZhanJiaEquip> EndFB_ShenWangZhanJiaEquip(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaEquip>(o);
  }
};

public sealed class FB_ShenWangZhanJiaEquipContainer : Table {
  public static FB_ShenWangZhanJiaEquipContainer GetRootAsFB_ShenWangZhanJiaEquipContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaEquipContainer(_bb, new FB_ShenWangZhanJiaEquipContainer()); }
  public static FB_ShenWangZhanJiaEquipContainer GetRootAsFB_ShenWangZhanJiaEquipContainer(ByteBuffer _bb, FB_ShenWangZhanJiaEquipContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaEquipContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaEquipContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaEquip GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaEquip(), j); }
  public FB_ShenWangZhanJiaEquip GetItems(FB_ShenWangZhanJiaEquip obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaEquipContainer> CreateFB_ShenWangZhanJiaEquipContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaEquipContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaEquipContainer.EndFB_ShenWangZhanJiaEquipContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaEquipContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaEquip>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaEquipContainer> EndFB_ShenWangZhanJiaEquipContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaEquipContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaEquipContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaEquipContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
