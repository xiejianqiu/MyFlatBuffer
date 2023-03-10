// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OldGodDiamondBase : Table {
  public static FB_OldGodDiamondBase GetRootAsFB_OldGodDiamondBase(ByteBuffer _bb) { return GetRootAsFB_OldGodDiamondBase(_bb, new FB_OldGodDiamondBase()); }
  public static FB_OldGodDiamondBase GetRootAsFB_OldGodDiamondBase(ByteBuffer _bb, FB_OldGodDiamondBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OldGodDiamondBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GodId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Step { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsBind { get { int o = __offset(18); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanAuction { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int SuitId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Decompose { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetBaseAttrIdList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrIdListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBaseAttrValueList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrValueListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPathId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Describe { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DropModle { get { int o = __offset(34); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SystemRemind { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_OldGodDiamondBase> CreateFB_OldGodDiamondBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int GodId = -1,
      int Type = -1,
      int Step = -1,
      int Quality = 0,
      bool IsBind = false,
      bool CanAuction = false,
      int SuitId = -1,
      int Decompose = 0,
      VectorOffset BaseAttrIdList = default(VectorOffset),
      VectorOffset BaseAttrValueList = default(VectorOffset),
      int GetPathId = 0,
      StringOffset Describe = default(StringOffset),
      StringOffset DropModle = default(StringOffset),
      int SystemRemind = -1) {
    builder.StartObject(17);
    FB_OldGodDiamondBase.AddSystemRemind(builder, SystemRemind);
    FB_OldGodDiamondBase.AddDropModle(builder, DropModle);
    FB_OldGodDiamondBase.AddDescribe(builder, Describe);
    FB_OldGodDiamondBase.AddGetPathId(builder, GetPathId);
    FB_OldGodDiamondBase.AddBaseAttrValueList(builder, BaseAttrValueList);
    FB_OldGodDiamondBase.AddBaseAttrIdList(builder, BaseAttrIdList);
    FB_OldGodDiamondBase.AddDecompose(builder, Decompose);
    FB_OldGodDiamondBase.AddSuitId(builder, SuitId);
    FB_OldGodDiamondBase.AddQuality(builder, Quality);
    FB_OldGodDiamondBase.AddStep(builder, Step);
    FB_OldGodDiamondBase.AddType(builder, Type);
    FB_OldGodDiamondBase.AddGodId(builder, GodId);
    FB_OldGodDiamondBase.AddIcon(builder, Icon);
    FB_OldGodDiamondBase.AddName(builder, Name);
    FB_OldGodDiamondBase.AddID(builder, ID);
    FB_OldGodDiamondBase.AddCanAuction(builder, CanAuction);
    FB_OldGodDiamondBase.AddIsBind(builder, IsBind);
    return FB_OldGodDiamondBase.EndFB_OldGodDiamondBase(builder);
  }

  public static void StartFB_OldGodDiamondBase(FlatBufferBuilder builder) { builder.StartObject(17); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddGodId(FlatBufferBuilder builder, int GodId) { builder.AddInt(3, GodId, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(4, Type, -1); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(5, Step, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(6, Quality, 0); }
  public static void AddIsBind(FlatBufferBuilder builder, bool IsBind) { builder.AddBool(7, IsBind, false); }
  public static void AddCanAuction(FlatBufferBuilder builder, bool CanAuction) { builder.AddBool(8, CanAuction, false); }
  public static void AddSuitId(FlatBufferBuilder builder, int SuitId) { builder.AddInt(9, SuitId, -1); }
  public static void AddDecompose(FlatBufferBuilder builder, int Decompose) { builder.AddInt(10, Decompose, 0); }
  public static void AddBaseAttrIdList(FlatBufferBuilder builder, VectorOffset BaseAttrIdListOffset) { builder.AddOffset(11, BaseAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBaseAttrValueList(FlatBufferBuilder builder, VectorOffset BaseAttrValueListOffset) { builder.AddOffset(12, BaseAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGetPathId(FlatBufferBuilder builder, int GetPathId) { builder.AddInt(13, GetPathId, 0); }
  public static void AddDescribe(FlatBufferBuilder builder, StringOffset DescribeOffset) { builder.AddOffset(14, DescribeOffset.Value, 0); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(15, DropModleOffset.Value, 0); }
  public static void AddSystemRemind(FlatBufferBuilder builder, int SystemRemind) { builder.AddInt(16, SystemRemind, -1); }
  public static Offset<FB_OldGodDiamondBase> EndFB_OldGodDiamondBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodDiamondBase>(o);
  }
};

public sealed class FB_OldGodDiamondBaseContainer : Table {
  public static FB_OldGodDiamondBaseContainer GetRootAsFB_OldGodDiamondBaseContainer(ByteBuffer _bb) { return GetRootAsFB_OldGodDiamondBaseContainer(_bb, new FB_OldGodDiamondBaseContainer()); }
  public static FB_OldGodDiamondBaseContainer GetRootAsFB_OldGodDiamondBaseContainer(ByteBuffer _bb, FB_OldGodDiamondBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OldGodDiamondBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OldGodDiamondBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OldGodDiamondBase GetItems(int j) { return GetItems(new FB_OldGodDiamondBase(), j); }
  public FB_OldGodDiamondBase GetItems(FB_OldGodDiamondBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodDiamondBaseContainer> CreateFB_OldGodDiamondBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OldGodDiamondBaseContainer.AddItems(builder, items);
    return FB_OldGodDiamondBaseContainer.EndFB_OldGodDiamondBaseContainer(builder);
  }

  public static void StartFB_OldGodDiamondBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OldGodDiamondBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodDiamondBaseContainer> EndFB_OldGodDiamondBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodDiamondBaseContainer>(o);
  }
  public static void FinishFB_OldGodDiamondBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_OldGodDiamondBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
