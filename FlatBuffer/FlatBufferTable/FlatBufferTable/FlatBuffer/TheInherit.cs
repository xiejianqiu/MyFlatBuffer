// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TheInherit : Table {
  public static FB_TheInherit GetRootAsFB_TheInherit(ByteBuffer _bb) { return GetRootAsFB_TheInherit(_bb, new FB_TheInherit()); }
  public static FB_TheInherit GetRootAsFB_TheInherit(ByteBuffer _bb, FB_TheInherit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TheInherit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int InheritId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int InheritLevelLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetInheritRewardList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int InheritRewardListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetInheritRewardNumList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int InheritRewardNumListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFakeObjIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FakeObjIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAchievementIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AchievementIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public string GetInheritDesList(int j) { int o = __offset(20); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int InheritDesListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TheInherit> CreateFB_TheInherit(FlatBufferBuilder builder,
      int Id = 0,
      int LevelLimit = -1,
      int InheritId = -1,
      int InheritLevelLimit = -1,
      VectorOffset InheritRewardList = default(VectorOffset),
      VectorOffset InheritRewardNumList = default(VectorOffset),
      VectorOffset FakeObjIDList = default(VectorOffset),
      VectorOffset AchievementIDList = default(VectorOffset),
      VectorOffset InheritDesList = default(VectorOffset)) {
    builder.StartObject(9);
    FB_TheInherit.AddInheritDesList(builder, InheritDesList);
    FB_TheInherit.AddAchievementIDList(builder, AchievementIDList);
    FB_TheInherit.AddFakeObjIDList(builder, FakeObjIDList);
    FB_TheInherit.AddInheritRewardNumList(builder, InheritRewardNumList);
    FB_TheInherit.AddInheritRewardList(builder, InheritRewardList);
    FB_TheInherit.AddInheritLevelLimit(builder, InheritLevelLimit);
    FB_TheInherit.AddInheritId(builder, InheritId);
    FB_TheInherit.AddLevelLimit(builder, LevelLimit);
    FB_TheInherit.AddId(builder, Id);
    return FB_TheInherit.EndFB_TheInherit(builder);
  }

  public static void StartFB_TheInherit(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(1, LevelLimit, -1); }
  public static void AddInheritId(FlatBufferBuilder builder, int InheritId) { builder.AddInt(2, InheritId, -1); }
  public static void AddInheritLevelLimit(FlatBufferBuilder builder, int InheritLevelLimit) { builder.AddInt(3, InheritLevelLimit, -1); }
  public static void AddInheritRewardList(FlatBufferBuilder builder, VectorOffset InheritRewardListOffset) { builder.AddOffset(4, InheritRewardListOffset.Value, 0); }
  public static VectorOffset CreateInheritRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartInheritRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInheritRewardNumList(FlatBufferBuilder builder, VectorOffset InheritRewardNumListOffset) { builder.AddOffset(5, InheritRewardNumListOffset.Value, 0); }
  public static VectorOffset CreateInheritRewardNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartInheritRewardNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFakeObjIDList(FlatBufferBuilder builder, VectorOffset FakeObjIDListOffset) { builder.AddOffset(6, FakeObjIDListOffset.Value, 0); }
  public static VectorOffset CreateFakeObjIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFakeObjIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAchievementIDList(FlatBufferBuilder builder, VectorOffset AchievementIDListOffset) { builder.AddOffset(7, AchievementIDListOffset.Value, 0); }
  public static VectorOffset CreateAchievementIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAchievementIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInheritDesList(FlatBufferBuilder builder, VectorOffset InheritDesListOffset) { builder.AddOffset(8, InheritDesListOffset.Value, 0); }
  public static VectorOffset CreateInheritDesListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartInheritDesListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TheInherit> EndFB_TheInherit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TheInherit>(o);
  }
};

public sealed class FB_TheInheritContainer : Table {
  public static FB_TheInheritContainer GetRootAsFB_TheInheritContainer(ByteBuffer _bb) { return GetRootAsFB_TheInheritContainer(_bb, new FB_TheInheritContainer()); }
  public static FB_TheInheritContainer GetRootAsFB_TheInheritContainer(ByteBuffer _bb, FB_TheInheritContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TheInheritContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TheInheritContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TheInherit GetItems(int j) { return GetItems(new FB_TheInherit(), j); }
  public FB_TheInherit GetItems(FB_TheInherit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TheInheritContainer> CreateFB_TheInheritContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TheInheritContainer.AddItems(builder, items);
    return FB_TheInheritContainer.EndFB_TheInheritContainer(builder);
  }

  public static void StartFB_TheInheritContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TheInherit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TheInheritContainer> EndFB_TheInheritContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TheInheritContainer>(o);
  }
  public static void FinishFB_TheInheritContainerBuffer(FlatBufferBuilder builder, Offset<FB_TheInheritContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
