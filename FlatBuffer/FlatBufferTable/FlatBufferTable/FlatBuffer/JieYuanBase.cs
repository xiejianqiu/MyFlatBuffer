// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JieYuanBase : Table {
  public static FB_JieYuanBase GetRootAsFB_JieYuanBase(ByteBuffer _bb) { return GetRootAsFB_JieYuanBase(_bb, new FB_JieYuanBase()); }
  public static FB_JieYuanBase GetRootAsFB_JieYuanBase(ByteBuffer _bb, FB_JieYuanBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JieYuanBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SpecialSymbol { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SuitId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockLevel { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Decompose { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetBaseAttrIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBaseAttrValueList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrValueListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSpecialAttrIdList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpecialAttrIdListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSpecialAttrValueList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpecialAttrValueListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPathId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Describe { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DropModle { get { int o = __offset(34); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SystemRemind { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_JieYuanBase> CreateFB_JieYuanBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Quality = 0,
      int SpecialSymbol = -1,
      int Component = -1,
      int SuitId = -1,
      int UnLockLevel = 0,
      int Decompose = 0,
      VectorOffset BaseAttrIdList = default(VectorOffset),
      VectorOffset BaseAttrValueList = default(VectorOffset),
      VectorOffset SpecialAttrIdList = default(VectorOffset),
      VectorOffset SpecialAttrValueList = default(VectorOffset),
      int GetPathId = 0,
      StringOffset Describe = default(StringOffset),
      StringOffset DropModle = default(StringOffset),
      int SystemRemind = -1) {
    builder.StartObject(17);
    FB_JieYuanBase.AddSystemRemind(builder, SystemRemind);
    FB_JieYuanBase.AddDropModle(builder, DropModle);
    FB_JieYuanBase.AddDescribe(builder, Describe);
    FB_JieYuanBase.AddGetPathId(builder, GetPathId);
    FB_JieYuanBase.AddSpecialAttrValueList(builder, SpecialAttrValueList);
    FB_JieYuanBase.AddSpecialAttrIdList(builder, SpecialAttrIdList);
    FB_JieYuanBase.AddBaseAttrValueList(builder, BaseAttrValueList);
    FB_JieYuanBase.AddBaseAttrIdList(builder, BaseAttrIdList);
    FB_JieYuanBase.AddDecompose(builder, Decompose);
    FB_JieYuanBase.AddUnLockLevel(builder, UnLockLevel);
    FB_JieYuanBase.AddSuitId(builder, SuitId);
    FB_JieYuanBase.AddComponent(builder, Component);
    FB_JieYuanBase.AddSpecialSymbol(builder, SpecialSymbol);
    FB_JieYuanBase.AddQuality(builder, Quality);
    FB_JieYuanBase.AddIcon(builder, Icon);
    FB_JieYuanBase.AddName(builder, Name);
    FB_JieYuanBase.AddID(builder, ID);
    return FB_JieYuanBase.EndFB_JieYuanBase(builder);
  }

  public static void StartFB_JieYuanBase(FlatBufferBuilder builder) { builder.StartObject(17); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(3, Quality, 0); }
  public static void AddSpecialSymbol(FlatBufferBuilder builder, int SpecialSymbol) { builder.AddInt(4, SpecialSymbol, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(5, Component, -1); }
  public static void AddSuitId(FlatBufferBuilder builder, int SuitId) { builder.AddInt(6, SuitId, -1); }
  public static void AddUnLockLevel(FlatBufferBuilder builder, int UnLockLevel) { builder.AddInt(7, UnLockLevel, 0); }
  public static void AddDecompose(FlatBufferBuilder builder, int Decompose) { builder.AddInt(8, Decompose, 0); }
  public static void AddBaseAttrIdList(FlatBufferBuilder builder, VectorOffset BaseAttrIdListOffset) { builder.AddOffset(9, BaseAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBaseAttrValueList(FlatBufferBuilder builder, VectorOffset BaseAttrValueListOffset) { builder.AddOffset(10, BaseAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpecialAttrIdList(FlatBufferBuilder builder, VectorOffset SpecialAttrIdListOffset) { builder.AddOffset(11, SpecialAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateSpecialAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpecialAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpecialAttrValueList(FlatBufferBuilder builder, VectorOffset SpecialAttrValueListOffset) { builder.AddOffset(12, SpecialAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateSpecialAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpecialAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGetPathId(FlatBufferBuilder builder, int GetPathId) { builder.AddInt(13, GetPathId, 0); }
  public static void AddDescribe(FlatBufferBuilder builder, StringOffset DescribeOffset) { builder.AddOffset(14, DescribeOffset.Value, 0); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(15, DropModleOffset.Value, 0); }
  public static void AddSystemRemind(FlatBufferBuilder builder, int SystemRemind) { builder.AddInt(16, SystemRemind, -1); }
  public static Offset<FB_JieYuanBase> EndFB_JieYuanBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanBase>(o);
  }
};

public sealed class FB_JieYuanBaseContainer : Table {
  public static FB_JieYuanBaseContainer GetRootAsFB_JieYuanBaseContainer(ByteBuffer _bb) { return GetRootAsFB_JieYuanBaseContainer(_bb, new FB_JieYuanBaseContainer()); }
  public static FB_JieYuanBaseContainer GetRootAsFB_JieYuanBaseContainer(ByteBuffer _bb, FB_JieYuanBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JieYuanBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JieYuanBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JieYuanBase GetItems(int j) { return GetItems(new FB_JieYuanBase(), j); }
  public FB_JieYuanBase GetItems(FB_JieYuanBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanBaseContainer> CreateFB_JieYuanBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JieYuanBaseContainer.AddItems(builder, items);
    return FB_JieYuanBaseContainer.EndFB_JieYuanBaseContainer(builder);
  }

  public static void StartFB_JieYuanBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JieYuanBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanBaseContainer> EndFB_JieYuanBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanBaseContainer>(o);
  }
  public static void FinishFB_JieYuanBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_JieYuanBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
