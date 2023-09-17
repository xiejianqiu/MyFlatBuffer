// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WingExtraModelPoint : Table {
  public static FB_WingExtraModelPoint GetRootAsFB_WingExtraModelPoint(ByteBuffer _bb) { return GetRootAsFB_WingExtraModelPoint(_bb, new FB_WingExtraModelPoint()); }
  public static FB_WingExtraModelPoint GetRootAsFB_WingExtraModelPoint(ByteBuffer _bb, FB_WingExtraModelPoint obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WingExtraModelPoint __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MountModel { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BindPoint { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public float PosX { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotaX { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotaY { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotaZ { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_WingExtraModelPoint> CreateFB_WingExtraModelPoint(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset MountModel = default(StringOffset),
      StringOffset BindPoint = default(StringOffset),
      float PosX = 0,
      float PosY = 0,
      float PosZ = 0,
      float RotaX = 0,
      float RotaY = 0,
      float RotaZ = 0,
      float Scale = 0) {
    builder.StartObject(10);
    FB_WingExtraModelPoint.AddScale(builder, Scale);
    FB_WingExtraModelPoint.AddRotaZ(builder, RotaZ);
    FB_WingExtraModelPoint.AddRotaY(builder, RotaY);
    FB_WingExtraModelPoint.AddRotaX(builder, RotaX);
    FB_WingExtraModelPoint.AddPosZ(builder, PosZ);
    FB_WingExtraModelPoint.AddPosY(builder, PosY);
    FB_WingExtraModelPoint.AddPosX(builder, PosX);
    FB_WingExtraModelPoint.AddBindPoint(builder, BindPoint);
    FB_WingExtraModelPoint.AddMountModel(builder, MountModel);
    FB_WingExtraModelPoint.AddID(builder, ID);
    return FB_WingExtraModelPoint.EndFB_WingExtraModelPoint(builder);
  }

  public static void StartFB_WingExtraModelPoint(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMountModel(FlatBufferBuilder builder, StringOffset MountModelOffset) { builder.AddOffset(1, MountModelOffset.Value, 0); }
  public static void AddBindPoint(FlatBufferBuilder builder, StringOffset BindPointOffset) { builder.AddOffset(2, BindPointOffset.Value, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(3, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(4, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(5, PosZ, 0); }
  public static void AddRotaX(FlatBufferBuilder builder, float RotaX) { builder.AddFloat(6, RotaX, 0); }
  public static void AddRotaY(FlatBufferBuilder builder, float RotaY) { builder.AddFloat(7, RotaY, 0); }
  public static void AddRotaZ(FlatBufferBuilder builder, float RotaZ) { builder.AddFloat(8, RotaZ, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(9, Scale, 0); }
  public static Offset<FB_WingExtraModelPoint> EndFB_WingExtraModelPoint(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WingExtraModelPoint>(o);
  }
};

public sealed class FB_WingExtraModelPointContainer : Table {
  public static FB_WingExtraModelPointContainer GetRootAsFB_WingExtraModelPointContainer(ByteBuffer _bb) { return GetRootAsFB_WingExtraModelPointContainer(_bb, new FB_WingExtraModelPointContainer()); }
  public static FB_WingExtraModelPointContainer GetRootAsFB_WingExtraModelPointContainer(ByteBuffer _bb, FB_WingExtraModelPointContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WingExtraModelPointContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WingExtraModelPointContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WingExtraModelPoint GetItems(int j) { return GetItems(new FB_WingExtraModelPoint(), j); }
  public FB_WingExtraModelPoint GetItems(FB_WingExtraModelPoint obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WingExtraModelPointContainer> CreateFB_WingExtraModelPointContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WingExtraModelPointContainer.AddItems(builder, items);
    return FB_WingExtraModelPointContainer.EndFB_WingExtraModelPointContainer(builder);
  }

  public static void StartFB_WingExtraModelPointContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WingExtraModelPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WingExtraModelPointContainer> EndFB_WingExtraModelPointContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WingExtraModelPointContainer>(o);
  }
  public static void FinishFB_WingExtraModelPointContainerBuffer(FlatBufferBuilder builder, Offset<FB_WingExtraModelPointContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
