// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaBase : Table {
  public static FB_ShenWangZhanJiaBase GetRootAsFB_ShenWangZhanJiaBase(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaBase(_bb, new FB_ShenWangZhanJiaBase()); }
  public static FB_ShenWangZhanJiaBase GetRootAsFB_ShenWangZhanJiaBase(ByteBuffer _bb, FB_ShenWangZhanJiaBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Info { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Tag { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StartTime { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EndTime { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrRatio { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_ShenWangZhanJiaBase> CreateFB_ShenWangZhanJiaBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Info = default(StringOffset),
      StringOffset Name = default(StringOffset),
      StringOffset Tag = default(StringOffset),
      int StartTime = 0,
      int EndTime = 0,
      int AttrRatio = 0) {
    builder.StartObject(7);
    FB_ShenWangZhanJiaBase.AddAttrRatio(builder, AttrRatio);
    FB_ShenWangZhanJiaBase.AddEndTime(builder, EndTime);
    FB_ShenWangZhanJiaBase.AddStartTime(builder, StartTime);
    FB_ShenWangZhanJiaBase.AddTag(builder, Tag);
    FB_ShenWangZhanJiaBase.AddName(builder, Name);
    FB_ShenWangZhanJiaBase.AddInfo(builder, Info);
    FB_ShenWangZhanJiaBase.AddId(builder, Id);
    return FB_ShenWangZhanJiaBase.EndFB_ShenWangZhanJiaBase(builder);
  }

  public static void StartFB_ShenWangZhanJiaBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddInfo(FlatBufferBuilder builder, StringOffset InfoOffset) { builder.AddOffset(1, InfoOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddTag(FlatBufferBuilder builder, StringOffset TagOffset) { builder.AddOffset(3, TagOffset.Value, 0); }
  public static void AddStartTime(FlatBufferBuilder builder, int StartTime) { builder.AddInt(4, StartTime, 0); }
  public static void AddEndTime(FlatBufferBuilder builder, int EndTime) { builder.AddInt(5, EndTime, 0); }
  public static void AddAttrRatio(FlatBufferBuilder builder, int AttrRatio) { builder.AddInt(6, AttrRatio, 0); }
  public static Offset<FB_ShenWangZhanJiaBase> EndFB_ShenWangZhanJiaBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaBase>(o);
  }
};

public sealed class FB_ShenWangZhanJiaBaseContainer : Table {
  public static FB_ShenWangZhanJiaBaseContainer GetRootAsFB_ShenWangZhanJiaBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaBaseContainer(_bb, new FB_ShenWangZhanJiaBaseContainer()); }
  public static FB_ShenWangZhanJiaBaseContainer GetRootAsFB_ShenWangZhanJiaBaseContainer(ByteBuffer _bb, FB_ShenWangZhanJiaBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaBase GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaBase(), j); }
  public FB_ShenWangZhanJiaBase GetItems(FB_ShenWangZhanJiaBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaBaseContainer> CreateFB_ShenWangZhanJiaBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaBaseContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaBaseContainer.EndFB_ShenWangZhanJiaBaseContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaBaseContainer> EndFB_ShenWangZhanJiaBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaBaseContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
