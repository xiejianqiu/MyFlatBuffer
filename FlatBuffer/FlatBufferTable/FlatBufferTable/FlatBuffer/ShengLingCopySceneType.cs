// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShengLingCopySceneType : Table {
  public static FB_ShengLingCopySceneType GetRootAsFB_ShengLingCopySceneType(ByteBuffer _bb) { return GetRootAsFB_ShengLingCopySceneType(_bb, new FB_ShengLingCopySceneType()); }
  public static FB_ShengLingCopySceneType GetRootAsFB_ShengLingCopySceneType(ByteBuffer _bb, FB_ShengLingCopySceneType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShengLingCopySceneType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string TypeName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsActive { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int LockStrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockTypeList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockTypeListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockParamList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockParamListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingCopySceneType> CreateFB_ShengLingCopySceneType(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset TypeName = default(StringOffset),
      bool IsActive = false,
      int LockStrId = -1,
      VectorOffset UnLockTypeList = default(VectorOffset),
      VectorOffset UnLockParamList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_ShengLingCopySceneType.AddUnLockParamList(builder, UnLockParamList);
    FB_ShengLingCopySceneType.AddUnLockTypeList(builder, UnLockTypeList);
    FB_ShengLingCopySceneType.AddLockStrId(builder, LockStrId);
    FB_ShengLingCopySceneType.AddTypeName(builder, TypeName);
    FB_ShengLingCopySceneType.AddId(builder, Id);
    FB_ShengLingCopySceneType.AddIsActive(builder, IsActive);
    return FB_ShengLingCopySceneType.EndFB_ShengLingCopySceneType(builder);
  }

  public static void StartFB_ShengLingCopySceneType(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTypeName(FlatBufferBuilder builder, StringOffset TypeNameOffset) { builder.AddOffset(1, TypeNameOffset.Value, 0); }
  public static void AddIsActive(FlatBufferBuilder builder, bool IsActive) { builder.AddBool(2, IsActive, false); }
  public static void AddLockStrId(FlatBufferBuilder builder, int LockStrId) { builder.AddInt(3, LockStrId, -1); }
  public static void AddUnLockTypeList(FlatBufferBuilder builder, VectorOffset UnLockTypeListOffset) { builder.AddOffset(4, UnLockTypeListOffset.Value, 0); }
  public static VectorOffset CreateUnLockTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockParamList(FlatBufferBuilder builder, VectorOffset UnLockParamListOffset) { builder.AddOffset(5, UnLockParamListOffset.Value, 0); }
  public static VectorOffset CreateUnLockParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingCopySceneType> EndFB_ShengLingCopySceneType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingCopySceneType>(o);
  }
};

public sealed class FB_ShengLingCopySceneTypeContainer : Table {
  public static FB_ShengLingCopySceneTypeContainer GetRootAsFB_ShengLingCopySceneTypeContainer(ByteBuffer _bb) { return GetRootAsFB_ShengLingCopySceneTypeContainer(_bb, new FB_ShengLingCopySceneTypeContainer()); }
  public static FB_ShengLingCopySceneTypeContainer GetRootAsFB_ShengLingCopySceneTypeContainer(ByteBuffer _bb, FB_ShengLingCopySceneTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShengLingCopySceneTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShengLingCopySceneTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShengLingCopySceneType GetItems(int j) { return GetItems(new FB_ShengLingCopySceneType(), j); }
  public FB_ShengLingCopySceneType GetItems(FB_ShengLingCopySceneType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingCopySceneTypeContainer> CreateFB_ShengLingCopySceneTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShengLingCopySceneTypeContainer.AddItems(builder, items);
    return FB_ShengLingCopySceneTypeContainer.EndFB_ShengLingCopySceneTypeContainer(builder);
  }

  public static void StartFB_ShengLingCopySceneTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShengLingCopySceneType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingCopySceneTypeContainer> EndFB_ShengLingCopySceneTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingCopySceneTypeContainer>(o);
  }
  public static void FinishFB_ShengLingCopySceneTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShengLingCopySceneTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
