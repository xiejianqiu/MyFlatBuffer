// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TitleBase : Table {
  public static FB_TitleBase GetRootAsFB_TitleBase(ByteBuffer _bb) { return GetRootAsFB_TitleBase(_bb, new FB_TitleBase()); }
  public static FB_TitleBase GetRootAsFB_TitleBase(ByteBuffer _bb, FB_TitleBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TitleBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsShowAfterGetting { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsVip { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int AtlasId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string EffectName { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Link { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string DeadLine { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DurationTime { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DescribeStrID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWayStrID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TitleClassID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetOwnAttrIDList(int j) { int o = __offset(34); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int OwnAttrIDListLength { get { int o = __offset(34); return o != 0 ? __vector_len(o) : 0; } }
  public int GetOwnAttrValueList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int OwnAttrValueListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TitleBase> CreateFB_TitleBase(FlatBufferBuilder builder,
      int ID = 0,
      int Type = 0,
      StringOffset Name = default(StringOffset),
      bool IsShowAfterGetting = false,
      bool IsVip = false,
      int AtlasId = 0,
      StringOffset EffectName = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Link = 0,
      StringOffset DeadLine = default(StringOffset),
      int DurationTime = 0,
      int DescribeStrID = -1,
      int GetWayStrID = -1,
      int Quality = -1,
      int TitleClassID = -1,
      VectorOffset OwnAttrIDList = default(VectorOffset),
      VectorOffset OwnAttrValueList = default(VectorOffset)) {
    builder.StartObject(17);
    FB_TitleBase.AddOwnAttrValueList(builder, OwnAttrValueList);
    FB_TitleBase.AddOwnAttrIDList(builder, OwnAttrIDList);
    FB_TitleBase.AddTitleClassID(builder, TitleClassID);
    FB_TitleBase.AddQuality(builder, Quality);
    FB_TitleBase.AddGetWayStrID(builder, GetWayStrID);
    FB_TitleBase.AddDescribeStrID(builder, DescribeStrID);
    FB_TitleBase.AddDurationTime(builder, DurationTime);
    FB_TitleBase.AddDeadLine(builder, DeadLine);
    FB_TitleBase.AddLink(builder, Link);
    FB_TitleBase.AddIcon(builder, Icon);
    FB_TitleBase.AddEffectName(builder, EffectName);
    FB_TitleBase.AddAtlasId(builder, AtlasId);
    FB_TitleBase.AddName(builder, Name);
    FB_TitleBase.AddType(builder, Type);
    FB_TitleBase.AddID(builder, ID);
    FB_TitleBase.AddIsVip(builder, IsVip);
    FB_TitleBase.AddIsShowAfterGetting(builder, IsShowAfterGetting);
    return FB_TitleBase.EndFB_TitleBase(builder);
  }

  public static void StartFB_TitleBase(FlatBufferBuilder builder) { builder.StartObject(17); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddIsShowAfterGetting(FlatBufferBuilder builder, bool IsShowAfterGetting) { builder.AddBool(3, IsShowAfterGetting, false); }
  public static void AddIsVip(FlatBufferBuilder builder, bool IsVip) { builder.AddBool(4, IsVip, false); }
  public static void AddAtlasId(FlatBufferBuilder builder, int AtlasId) { builder.AddInt(5, AtlasId, 0); }
  public static void AddEffectName(FlatBufferBuilder builder, StringOffset EffectNameOffset) { builder.AddOffset(6, EffectNameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(7, IconOffset.Value, 0); }
  public static void AddLink(FlatBufferBuilder builder, int Link) { builder.AddInt(8, Link, 0); }
  public static void AddDeadLine(FlatBufferBuilder builder, StringOffset DeadLineOffset) { builder.AddOffset(9, DeadLineOffset.Value, 0); }
  public static void AddDurationTime(FlatBufferBuilder builder, int DurationTime) { builder.AddInt(10, DurationTime, 0); }
  public static void AddDescribeStrID(FlatBufferBuilder builder, int DescribeStrID) { builder.AddInt(11, DescribeStrID, -1); }
  public static void AddGetWayStrID(FlatBufferBuilder builder, int GetWayStrID) { builder.AddInt(12, GetWayStrID, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(13, Quality, -1); }
  public static void AddTitleClassID(FlatBufferBuilder builder, int TitleClassID) { builder.AddInt(14, TitleClassID, -1); }
  public static void AddOwnAttrIDList(FlatBufferBuilder builder, VectorOffset OwnAttrIDListOffset) { builder.AddOffset(15, OwnAttrIDListOffset.Value, 0); }
  public static VectorOffset CreateOwnAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOwnAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOwnAttrValueList(FlatBufferBuilder builder, VectorOffset OwnAttrValueListOffset) { builder.AddOffset(16, OwnAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateOwnAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOwnAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TitleBase> EndFB_TitleBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TitleBase>(o);
  }
};

public sealed class FB_TitleBaseContainer : Table {
  public static FB_TitleBaseContainer GetRootAsFB_TitleBaseContainer(ByteBuffer _bb) { return GetRootAsFB_TitleBaseContainer(_bb, new FB_TitleBaseContainer()); }
  public static FB_TitleBaseContainer GetRootAsFB_TitleBaseContainer(ByteBuffer _bb, FB_TitleBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TitleBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TitleBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TitleBase GetItems(int j) { return GetItems(new FB_TitleBase(), j); }
  public FB_TitleBase GetItems(FB_TitleBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TitleBaseContainer> CreateFB_TitleBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TitleBaseContainer.AddItems(builder, items);
    return FB_TitleBaseContainer.EndFB_TitleBaseContainer(builder);
  }

  public static void StartFB_TitleBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TitleBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TitleBaseContainer> EndFB_TitleBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TitleBaseContainer>(o);
  }
  public static void FinishFB_TitleBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_TitleBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
