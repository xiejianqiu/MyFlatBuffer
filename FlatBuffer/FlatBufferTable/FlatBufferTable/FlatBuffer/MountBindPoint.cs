// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MountBindPoint : Table {
  public static FB_MountBindPoint GetRootAsFB_MountBindPoint(ByteBuffer _bb) { return GetRootAsFB_MountBindPoint(_bb, new FB_MountBindPoint()); }
  public static FB_MountBindPoint GetRootAsFB_MountBindPoint(ByteBuffer _bb, FB_MountBindPoint obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MountBindPoint __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GetBindPointList(int j) { int o = __offset(6); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int BindPointListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBindPointAniIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BindPointAniIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MountBindPoint> CreateFB_MountBindPoint(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset BindPointList = default(VectorOffset),
      VectorOffset BindPointAniIDList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_MountBindPoint.AddBindPointAniIDList(builder, BindPointAniIDList);
    FB_MountBindPoint.AddBindPointList(builder, BindPointList);
    FB_MountBindPoint.AddId(builder, Id);
    return FB_MountBindPoint.EndFB_MountBindPoint(builder);
  }

  public static void StartFB_MountBindPoint(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddBindPointList(FlatBufferBuilder builder, VectorOffset BindPointListOffset) { builder.AddOffset(1, BindPointListOffset.Value, 0); }
  public static VectorOffset CreateBindPointListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartBindPointListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBindPointAniIDList(FlatBufferBuilder builder, VectorOffset BindPointAniIDListOffset) { builder.AddOffset(2, BindPointAniIDListOffset.Value, 0); }
  public static VectorOffset CreateBindPointAniIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBindPointAniIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MountBindPoint> EndFB_MountBindPoint(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MountBindPoint>(o);
  }
};

public sealed class FB_MountBindPointContainer : Table {
  public static FB_MountBindPointContainer GetRootAsFB_MountBindPointContainer(ByteBuffer _bb) { return GetRootAsFB_MountBindPointContainer(_bb, new FB_MountBindPointContainer()); }
  public static FB_MountBindPointContainer GetRootAsFB_MountBindPointContainer(ByteBuffer _bb, FB_MountBindPointContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MountBindPointContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MountBindPointContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MountBindPoint GetItems(int j) { return GetItems(new FB_MountBindPoint(), j); }
  public FB_MountBindPoint GetItems(FB_MountBindPoint obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MountBindPointContainer> CreateFB_MountBindPointContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MountBindPointContainer.AddItems(builder, items);
    return FB_MountBindPointContainer.EndFB_MountBindPointContainer(builder);
  }

  public static void StartFB_MountBindPointContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MountBindPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MountBindPointContainer> EndFB_MountBindPointContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MountBindPointContainer>(o);
  }
  public static void FinishFB_MountBindPointContainerBuffer(FlatBufferBuilder builder, Offset<FB_MountBindPointContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
