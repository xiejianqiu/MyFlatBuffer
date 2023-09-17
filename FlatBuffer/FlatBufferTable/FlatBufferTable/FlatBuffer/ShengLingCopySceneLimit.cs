// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShengLingCopySceneLimit : Table {
  public static FB_ShengLingCopySceneLimit GetRootAsFB_ShengLingCopySceneLimit(ByteBuffer _bb) { return GetRootAsFB_ShengLingCopySceneLimit(_bb, new FB_ShengLingCopySceneLimit()); }
  public static FB_ShengLingCopySceneLimit GetRootAsFB_ShengLingCopySceneLimit(ByteBuffer _bb, FB_ShengLingCopySceneLimit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShengLingCopySceneLimit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsActive { get { int o = __offset(6); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int BossCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockTypeList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockTypeListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockParamList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockParamListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingCopySceneLimit> CreateFB_ShengLingCopySceneLimit(FlatBufferBuilder builder,
      int Id = 0,
      bool IsActive = false,
      int BossCount = -1,
      VectorOffset UnLockTypeList = default(VectorOffset),
      VectorOffset UnLockParamList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_ShengLingCopySceneLimit.AddUnLockParamList(builder, UnLockParamList);
    FB_ShengLingCopySceneLimit.AddUnLockTypeList(builder, UnLockTypeList);
    FB_ShengLingCopySceneLimit.AddBossCount(builder, BossCount);
    FB_ShengLingCopySceneLimit.AddId(builder, Id);
    FB_ShengLingCopySceneLimit.AddIsActive(builder, IsActive);
    return FB_ShengLingCopySceneLimit.EndFB_ShengLingCopySceneLimit(builder);
  }

  public static void StartFB_ShengLingCopySceneLimit(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddIsActive(FlatBufferBuilder builder, bool IsActive) { builder.AddBool(1, IsActive, false); }
  public static void AddBossCount(FlatBufferBuilder builder, int BossCount) { builder.AddInt(2, BossCount, -1); }
  public static void AddUnLockTypeList(FlatBufferBuilder builder, VectorOffset UnLockTypeListOffset) { builder.AddOffset(3, UnLockTypeListOffset.Value, 0); }
  public static VectorOffset CreateUnLockTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockParamList(FlatBufferBuilder builder, VectorOffset UnLockParamListOffset) { builder.AddOffset(4, UnLockParamListOffset.Value, 0); }
  public static VectorOffset CreateUnLockParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingCopySceneLimit> EndFB_ShengLingCopySceneLimit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingCopySceneLimit>(o);
  }
};

public sealed class FB_ShengLingCopySceneLimitContainer : Table {
  public static FB_ShengLingCopySceneLimitContainer GetRootAsFB_ShengLingCopySceneLimitContainer(ByteBuffer _bb) { return GetRootAsFB_ShengLingCopySceneLimitContainer(_bb, new FB_ShengLingCopySceneLimitContainer()); }
  public static FB_ShengLingCopySceneLimitContainer GetRootAsFB_ShengLingCopySceneLimitContainer(ByteBuffer _bb, FB_ShengLingCopySceneLimitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShengLingCopySceneLimitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShengLingCopySceneLimitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShengLingCopySceneLimit GetItems(int j) { return GetItems(new FB_ShengLingCopySceneLimit(), j); }
  public FB_ShengLingCopySceneLimit GetItems(FB_ShengLingCopySceneLimit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingCopySceneLimitContainer> CreateFB_ShengLingCopySceneLimitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShengLingCopySceneLimitContainer.AddItems(builder, items);
    return FB_ShengLingCopySceneLimitContainer.EndFB_ShengLingCopySceneLimitContainer(builder);
  }

  public static void StartFB_ShengLingCopySceneLimitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShengLingCopySceneLimit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingCopySceneLimitContainer> EndFB_ShengLingCopySceneLimitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingCopySceneLimitContainer>(o);
  }
  public static void FinishFB_ShengLingCopySceneLimitContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShengLingCopySceneLimitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
