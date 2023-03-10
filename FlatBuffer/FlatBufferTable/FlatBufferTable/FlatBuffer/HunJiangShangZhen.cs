// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangShangZhen : Table {
  public static FB_HunJiangShangZhen GetRootAsFB_HunJiangShangZhen(ByteBuffer _bb) { return GetRootAsFB_HunJiangShangZhen(_bb, new FB_HunJiangShangZhen()); }
  public static FB_HunJiangShangZhen GetRootAsFB_HunJiangShangZhen(ByteBuffer _bb, FB_HunJiangShangZhen obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangShangZhen __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnLockType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockParamList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockParamListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public float ShangZhenAttrmultiple { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_HunJiangShangZhen> CreateFB_HunJiangShangZhen(FlatBufferBuilder builder,
      int ID = 0,
      int UnLockType = -1,
      VectorOffset UnLockParamList = default(VectorOffset),
      float ShangZhenAttrmultiple = 0) {
    builder.StartObject(4);
    FB_HunJiangShangZhen.AddShangZhenAttrmultiple(builder, ShangZhenAttrmultiple);
    FB_HunJiangShangZhen.AddUnLockParamList(builder, UnLockParamList);
    FB_HunJiangShangZhen.AddUnLockType(builder, UnLockType);
    FB_HunJiangShangZhen.AddID(builder, ID);
    return FB_HunJiangShangZhen.EndFB_HunJiangShangZhen(builder);
  }

  public static void StartFB_HunJiangShangZhen(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddUnLockType(FlatBufferBuilder builder, int UnLockType) { builder.AddInt(1, UnLockType, -1); }
  public static void AddUnLockParamList(FlatBufferBuilder builder, VectorOffset UnLockParamListOffset) { builder.AddOffset(2, UnLockParamListOffset.Value, 0); }
  public static VectorOffset CreateUnLockParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShangZhenAttrmultiple(FlatBufferBuilder builder, float ShangZhenAttrmultiple) { builder.AddFloat(3, ShangZhenAttrmultiple, 0); }
  public static Offset<FB_HunJiangShangZhen> EndFB_HunJiangShangZhen(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangShangZhen>(o);
  }
};

public sealed class FB_HunJiangShangZhenContainer : Table {
  public static FB_HunJiangShangZhenContainer GetRootAsFB_HunJiangShangZhenContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangShangZhenContainer(_bb, new FB_HunJiangShangZhenContainer()); }
  public static FB_HunJiangShangZhenContainer GetRootAsFB_HunJiangShangZhenContainer(ByteBuffer _bb, FB_HunJiangShangZhenContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangShangZhenContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangShangZhenContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangShangZhen GetItems(int j) { return GetItems(new FB_HunJiangShangZhen(), j); }
  public FB_HunJiangShangZhen GetItems(FB_HunJiangShangZhen obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangShangZhenContainer> CreateFB_HunJiangShangZhenContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangShangZhenContainer.AddItems(builder, items);
    return FB_HunJiangShangZhenContainer.EndFB_HunJiangShangZhenContainer(builder);
  }

  public static void StartFB_HunJiangShangZhenContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangShangZhen>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangShangZhenContainer> EndFB_HunJiangShangZhenContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangShangZhenContainer>(o);
  }
  public static void FinishFB_HunJiangShangZhenContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangShangZhenContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
