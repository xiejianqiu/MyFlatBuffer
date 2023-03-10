// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingHunItemBase : Table {
  public static FB_XingHunItemBase GetRootAsFB_XingHunItemBase(ByteBuffer _bb) { return GetRootAsFB_XingHunItemBase(_bb, new FB_XingHunItemBase()); }
  public static FB_XingHunItemBase GetRootAsFB_XingHunItemBase(ByteBuffer _bb, FB_XingHunItemBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingHunItemBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetPathId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Component { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxLevel { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int DoubleCost { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string DropModle { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_XingHunItemBase> CreateFB_XingHunItemBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int GetPathId = -1,
      int Quality = 0,
      int Component = 0,
      int Exp = 0,
      int MaxLevel = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int DoubleCost = 0,
      StringOffset DropModle = default(StringOffset)) {
    builder.StartObject(12);
    FB_XingHunItemBase.AddDropModle(builder, DropModle);
    FB_XingHunItemBase.AddDoubleCost(builder, DoubleCost);
    FB_XingHunItemBase.AddAttrValueList(builder, AttrValueList);
    FB_XingHunItemBase.AddAttrIdList(builder, AttrIdList);
    FB_XingHunItemBase.AddMaxLevel(builder, MaxLevel);
    FB_XingHunItemBase.AddExp(builder, Exp);
    FB_XingHunItemBase.AddComponent(builder, Component);
    FB_XingHunItemBase.AddQuality(builder, Quality);
    FB_XingHunItemBase.AddGetPathId(builder, GetPathId);
    FB_XingHunItemBase.AddIcon(builder, Icon);
    FB_XingHunItemBase.AddName(builder, Name);
    FB_XingHunItemBase.AddId(builder, Id);
    return FB_XingHunItemBase.EndFB_XingHunItemBase(builder);
  }

  public static void StartFB_XingHunItemBase(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddGetPathId(FlatBufferBuilder builder, int GetPathId) { builder.AddInt(3, GetPathId, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(4, Quality, 0); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(5, Component, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(6, Exp, 0); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(7, MaxLevel, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(8, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(9, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDoubleCost(FlatBufferBuilder builder, int DoubleCost) { builder.AddInt(10, DoubleCost, 0); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(11, DropModleOffset.Value, 0); }
  public static Offset<FB_XingHunItemBase> EndFB_XingHunItemBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunItemBase>(o);
  }
};

public sealed class FB_XingHunItemBaseContainer : Table {
  public static FB_XingHunItemBaseContainer GetRootAsFB_XingHunItemBaseContainer(ByteBuffer _bb) { return GetRootAsFB_XingHunItemBaseContainer(_bb, new FB_XingHunItemBaseContainer()); }
  public static FB_XingHunItemBaseContainer GetRootAsFB_XingHunItemBaseContainer(ByteBuffer _bb, FB_XingHunItemBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingHunItemBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingHunItemBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingHunItemBase GetItems(int j) { return GetItems(new FB_XingHunItemBase(), j); }
  public FB_XingHunItemBase GetItems(FB_XingHunItemBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunItemBaseContainer> CreateFB_XingHunItemBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingHunItemBaseContainer.AddItems(builder, items);
    return FB_XingHunItemBaseContainer.EndFB_XingHunItemBaseContainer(builder);
  }

  public static void StartFB_XingHunItemBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingHunItemBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunItemBaseContainer> EndFB_XingHunItemBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunItemBaseContainer>(o);
  }
  public static void FinishFB_XingHunItemBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingHunItemBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
