// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarrySceneInfo : Table {
  public static FB_MarrySceneInfo GetRootAsFB_MarrySceneInfo(ByteBuffer _bb) { return GetRootAsFB_MarrySceneInfo(_bb, new FB_MarrySceneInfo()); }
  public static FB_MarrySceneInfo GetRootAsFB_MarrySceneInfo(ByteBuffer _bb, FB_MarrySceneInfo obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarrySceneInfo __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StartTime { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EndTime { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_MarrySceneInfo> CreateFB_MarrySceneInfo(FlatBufferBuilder builder,
      int ID = 0,
      int StartTime = 0,
      int EndTime = 0) {
    builder.StartObject(3);
    FB_MarrySceneInfo.AddEndTime(builder, EndTime);
    FB_MarrySceneInfo.AddStartTime(builder, StartTime);
    FB_MarrySceneInfo.AddID(builder, ID);
    return FB_MarrySceneInfo.EndFB_MarrySceneInfo(builder);
  }

  public static void StartFB_MarrySceneInfo(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStartTime(FlatBufferBuilder builder, int StartTime) { builder.AddInt(1, StartTime, 0); }
  public static void AddEndTime(FlatBufferBuilder builder, int EndTime) { builder.AddInt(2, EndTime, 0); }
  public static Offset<FB_MarrySceneInfo> EndFB_MarrySceneInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarrySceneInfo>(o);
  }
};

public sealed class FB_MarrySceneInfoContainer : Table {
  public static FB_MarrySceneInfoContainer GetRootAsFB_MarrySceneInfoContainer(ByteBuffer _bb) { return GetRootAsFB_MarrySceneInfoContainer(_bb, new FB_MarrySceneInfoContainer()); }
  public static FB_MarrySceneInfoContainer GetRootAsFB_MarrySceneInfoContainer(ByteBuffer _bb, FB_MarrySceneInfoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarrySceneInfoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarrySceneInfoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarrySceneInfo GetItems(int j) { return GetItems(new FB_MarrySceneInfo(), j); }
  public FB_MarrySceneInfo GetItems(FB_MarrySceneInfo obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarrySceneInfoContainer> CreateFB_MarrySceneInfoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarrySceneInfoContainer.AddItems(builder, items);
    return FB_MarrySceneInfoContainer.EndFB_MarrySceneInfoContainer(builder);
  }

  public static void StartFB_MarrySceneInfoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarrySceneInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarrySceneInfoContainer> EndFB_MarrySceneInfoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarrySceneInfoContainer>(o);
  }
  public static void FinishFB_MarrySceneInfoContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarrySceneInfoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
