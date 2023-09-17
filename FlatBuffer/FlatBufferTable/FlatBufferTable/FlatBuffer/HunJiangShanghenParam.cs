// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangShanghenParam : Table {
  public static FB_HunJiangShanghenParam GetRootAsFB_HunJiangShanghenParam(ByteBuffer _bb) { return GetRootAsFB_HunJiangShanghenParam(_bb, new FB_HunJiangShanghenParam()); }
  public static FB_HunJiangShanghenParam GetRootAsFB_HunJiangShanghenParam(ByteBuffer _bb, FB_HunJiangShanghenParam obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangShanghenParam __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ShangZhenID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HunJIangID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ScaleX { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ScaleY { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ScaleZ { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_HunJiangShanghenParam> CreateFB_HunJiangShanghenParam(FlatBufferBuilder builder,
      int Id = 0,
      int ShangZhenID = 0,
      int HunJIangID = 0,
      float PosX = 0,
      float PosY = 0,
      float PosZ = 0,
      float ScaleX = 0,
      float ScaleY = 0,
      float ScaleZ = 0) {
    builder.StartObject(9);
    FB_HunJiangShanghenParam.AddScaleZ(builder, ScaleZ);
    FB_HunJiangShanghenParam.AddScaleY(builder, ScaleY);
    FB_HunJiangShanghenParam.AddScaleX(builder, ScaleX);
    FB_HunJiangShanghenParam.AddPosZ(builder, PosZ);
    FB_HunJiangShanghenParam.AddPosY(builder, PosY);
    FB_HunJiangShanghenParam.AddPosX(builder, PosX);
    FB_HunJiangShanghenParam.AddHunJIangID(builder, HunJIangID);
    FB_HunJiangShanghenParam.AddShangZhenID(builder, ShangZhenID);
    FB_HunJiangShanghenParam.AddId(builder, Id);
    return FB_HunJiangShanghenParam.EndFB_HunJiangShanghenParam(builder);
  }

  public static void StartFB_HunJiangShanghenParam(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddShangZhenID(FlatBufferBuilder builder, int ShangZhenID) { builder.AddInt(1, ShangZhenID, 0); }
  public static void AddHunJIangID(FlatBufferBuilder builder, int HunJIangID) { builder.AddInt(2, HunJIangID, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(3, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(4, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(5, PosZ, 0); }
  public static void AddScaleX(FlatBufferBuilder builder, float ScaleX) { builder.AddFloat(6, ScaleX, 0); }
  public static void AddScaleY(FlatBufferBuilder builder, float ScaleY) { builder.AddFloat(7, ScaleY, 0); }
  public static void AddScaleZ(FlatBufferBuilder builder, float ScaleZ) { builder.AddFloat(8, ScaleZ, 0); }
  public static Offset<FB_HunJiangShanghenParam> EndFB_HunJiangShanghenParam(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangShanghenParam>(o);
  }
};

public sealed class FB_HunJiangShanghenParamContainer : Table {
  public static FB_HunJiangShanghenParamContainer GetRootAsFB_HunJiangShanghenParamContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangShanghenParamContainer(_bb, new FB_HunJiangShanghenParamContainer()); }
  public static FB_HunJiangShanghenParamContainer GetRootAsFB_HunJiangShanghenParamContainer(ByteBuffer _bb, FB_HunJiangShanghenParamContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangShanghenParamContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangShanghenParamContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangShanghenParam GetItems(int j) { return GetItems(new FB_HunJiangShanghenParam(), j); }
  public FB_HunJiangShanghenParam GetItems(FB_HunJiangShanghenParam obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangShanghenParamContainer> CreateFB_HunJiangShanghenParamContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangShanghenParamContainer.AddItems(builder, items);
    return FB_HunJiangShanghenParamContainer.EndFB_HunJiangShanghenParamContainer(builder);
  }

  public static void StartFB_HunJiangShanghenParamContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangShanghenParam>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangShanghenParamContainer> EndFB_HunJiangShanghenParamContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangShanghenParamContainer>(o);
  }
  public static void FinishFB_HunJiangShanghenParamContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangShanghenParamContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
