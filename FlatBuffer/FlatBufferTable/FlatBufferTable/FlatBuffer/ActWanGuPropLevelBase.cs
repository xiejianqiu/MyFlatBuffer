// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActWanGuPropLevelBase : Table {
  public static FB_ActWanGuPropLevelBase GetRootAsFB_ActWanGuPropLevelBase(ByteBuffer _bb) { return GetRootAsFB_ActWanGuPropLevelBase(_bb, new FB_ActWanGuPropLevelBase()); }
  public static FB_ActWanGuPropLevelBase GetRootAsFB_ActWanGuPropLevelBase(ByteBuffer _bb, FB_ActWanGuPropLevelBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActWanGuPropLevelBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int Exp { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int QuickItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActWanGuId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetLevelLimitList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LevelLimitListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLevelRewardList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LevelRewardListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActWanGuPropLevelBase> CreateFB_ActWanGuPropLevelBase(FlatBufferBuilder builder,
      int Id = 0,
      int Level = 1,
      int Exp = -1,
      int QuickItemCount = -1,
      int ActWanGuId = -1,
      VectorOffset LevelLimitList = default(VectorOffset),
      VectorOffset LevelRewardList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_ActWanGuPropLevelBase.AddLevelRewardList(builder, LevelRewardList);
    FB_ActWanGuPropLevelBase.AddLevelLimitList(builder, LevelLimitList);
    FB_ActWanGuPropLevelBase.AddActWanGuId(builder, ActWanGuId);
    FB_ActWanGuPropLevelBase.AddQuickItemCount(builder, QuickItemCount);
    FB_ActWanGuPropLevelBase.AddExp(builder, Exp);
    FB_ActWanGuPropLevelBase.AddLevel(builder, Level);
    FB_ActWanGuPropLevelBase.AddId(builder, Id);
    return FB_ActWanGuPropLevelBase.EndFB_ActWanGuPropLevelBase(builder);
  }

  public static void StartFB_ActWanGuPropLevelBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, 1); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(2, Exp, -1); }
  public static void AddQuickItemCount(FlatBufferBuilder builder, int QuickItemCount) { builder.AddInt(3, QuickItemCount, -1); }
  public static void AddActWanGuId(FlatBufferBuilder builder, int ActWanGuId) { builder.AddInt(4, ActWanGuId, -1); }
  public static void AddLevelLimitList(FlatBufferBuilder builder, VectorOffset LevelLimitListOffset) { builder.AddOffset(5, LevelLimitListOffset.Value, 0); }
  public static VectorOffset CreateLevelLimitListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLevelLimitListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelRewardList(FlatBufferBuilder builder, VectorOffset LevelRewardListOffset) { builder.AddOffset(6, LevelRewardListOffset.Value, 0); }
  public static VectorOffset CreateLevelRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLevelRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActWanGuPropLevelBase> EndFB_ActWanGuPropLevelBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuPropLevelBase>(o);
  }
};

public sealed class FB_ActWanGuPropLevelBaseContainer : Table {
  public static FB_ActWanGuPropLevelBaseContainer GetRootAsFB_ActWanGuPropLevelBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ActWanGuPropLevelBaseContainer(_bb, new FB_ActWanGuPropLevelBaseContainer()); }
  public static FB_ActWanGuPropLevelBaseContainer GetRootAsFB_ActWanGuPropLevelBaseContainer(ByteBuffer _bb, FB_ActWanGuPropLevelBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActWanGuPropLevelBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActWanGuPropLevelBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActWanGuPropLevelBase GetItems(int j) { return GetItems(new FB_ActWanGuPropLevelBase(), j); }
  public FB_ActWanGuPropLevelBase GetItems(FB_ActWanGuPropLevelBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActWanGuPropLevelBaseContainer> CreateFB_ActWanGuPropLevelBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActWanGuPropLevelBaseContainer.AddItems(builder, items);
    return FB_ActWanGuPropLevelBaseContainer.EndFB_ActWanGuPropLevelBaseContainer(builder);
  }

  public static void StartFB_ActWanGuPropLevelBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActWanGuPropLevelBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActWanGuPropLevelBaseContainer> EndFB_ActWanGuPropLevelBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuPropLevelBaseContainer>(o);
  }
  public static void FinishFB_ActWanGuPropLevelBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActWanGuPropLevelBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
