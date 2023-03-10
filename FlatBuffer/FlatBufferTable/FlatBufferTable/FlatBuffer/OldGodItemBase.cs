// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OldGodItemBase : Table {
  public static FB_OldGodItemBase GetRootAsFB_OldGodItemBase(ByteBuffer _bb) { return GetRootAsFB_OldGodItemBase(_bb, new FB_OldGodItemBase()); }
  public static FB_OldGodItemBase GetRootAsFB_OldGodItemBase(ByteBuffer _bb, FB_OldGodItemBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OldGodItemBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GodId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Quality { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StarCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DecomposeCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetBaseAttrIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBaseAttrValueList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrValueListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPathID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ItemDesc { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DropModel { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SystemRemind { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_OldGodItemBase> CreateFB_OldGodItemBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int GodId = -1,
      int Component = 0,
      int Quality = 0,
      int StarCount = -1,
      int DecomposeCount = 0,
      int PassiveSkillId = 0,
      VectorOffset BaseAttrIdList = default(VectorOffset),
      VectorOffset BaseAttrValueList = default(VectorOffset),
      int GetPathID = -1,
      StringOffset ItemDesc = default(StringOffset),
      StringOffset DropModel = default(StringOffset),
      int SystemRemind = -1) {
    builder.StartObject(15);
    FB_OldGodItemBase.AddSystemRemind(builder, SystemRemind);
    FB_OldGodItemBase.AddDropModel(builder, DropModel);
    FB_OldGodItemBase.AddItemDesc(builder, ItemDesc);
    FB_OldGodItemBase.AddGetPathID(builder, GetPathID);
    FB_OldGodItemBase.AddBaseAttrValueList(builder, BaseAttrValueList);
    FB_OldGodItemBase.AddBaseAttrIdList(builder, BaseAttrIdList);
    FB_OldGodItemBase.AddPassiveSkillId(builder, PassiveSkillId);
    FB_OldGodItemBase.AddDecomposeCount(builder, DecomposeCount);
    FB_OldGodItemBase.AddStarCount(builder, StarCount);
    FB_OldGodItemBase.AddQuality(builder, Quality);
    FB_OldGodItemBase.AddComponent(builder, Component);
    FB_OldGodItemBase.AddGodId(builder, GodId);
    FB_OldGodItemBase.AddIcon(builder, Icon);
    FB_OldGodItemBase.AddName(builder, Name);
    FB_OldGodItemBase.AddId(builder, Id);
    return FB_OldGodItemBase.EndFB_OldGodItemBase(builder);
  }

  public static void StartFB_OldGodItemBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddGodId(FlatBufferBuilder builder, int GodId) { builder.AddInt(3, GodId, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(4, Component, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(5, Quality, 0); }
  public static void AddStarCount(FlatBufferBuilder builder, int StarCount) { builder.AddInt(6, StarCount, -1); }
  public static void AddDecomposeCount(FlatBufferBuilder builder, int DecomposeCount) { builder.AddInt(7, DecomposeCount, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(8, PassiveSkillId, 0); }
  public static void AddBaseAttrIdList(FlatBufferBuilder builder, VectorOffset BaseAttrIdListOffset) { builder.AddOffset(9, BaseAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBaseAttrValueList(FlatBufferBuilder builder, VectorOffset BaseAttrValueListOffset) { builder.AddOffset(10, BaseAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGetPathID(FlatBufferBuilder builder, int GetPathID) { builder.AddInt(11, GetPathID, -1); }
  public static void AddItemDesc(FlatBufferBuilder builder, StringOffset ItemDescOffset) { builder.AddOffset(12, ItemDescOffset.Value, 0); }
  public static void AddDropModel(FlatBufferBuilder builder, StringOffset DropModelOffset) { builder.AddOffset(13, DropModelOffset.Value, 0); }
  public static void AddSystemRemind(FlatBufferBuilder builder, int SystemRemind) { builder.AddInt(14, SystemRemind, -1); }
  public static Offset<FB_OldGodItemBase> EndFB_OldGodItemBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodItemBase>(o);
  }
};

public sealed class FB_OldGodItemBaseContainer : Table {
  public static FB_OldGodItemBaseContainer GetRootAsFB_OldGodItemBaseContainer(ByteBuffer _bb) { return GetRootAsFB_OldGodItemBaseContainer(_bb, new FB_OldGodItemBaseContainer()); }
  public static FB_OldGodItemBaseContainer GetRootAsFB_OldGodItemBaseContainer(ByteBuffer _bb, FB_OldGodItemBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OldGodItemBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OldGodItemBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OldGodItemBase GetItems(int j) { return GetItems(new FB_OldGodItemBase(), j); }
  public FB_OldGodItemBase GetItems(FB_OldGodItemBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodItemBaseContainer> CreateFB_OldGodItemBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OldGodItemBaseContainer.AddItems(builder, items);
    return FB_OldGodItemBaseContainer.EndFB_OldGodItemBaseContainer(builder);
  }

  public static void StartFB_OldGodItemBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OldGodItemBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodItemBaseContainer> EndFB_OldGodItemBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodItemBaseContainer>(o);
  }
  public static void FinishFB_OldGodItemBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_OldGodItemBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
