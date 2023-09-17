// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaPaintingMiss : Table {
  public static FB_ShenWangZhanJiaPaintingMiss GetRootAsFB_ShenWangZhanJiaPaintingMiss(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaPaintingMiss(_bb, new FB_ShenWangZhanJiaPaintingMiss()); }
  public static FB_ShenWangZhanJiaPaintingMiss GetRootAsFB_ShenWangZhanJiaPaintingMiss(ByteBuffer _bb, FB_ShenWangZhanJiaPaintingMiss obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaPaintingMiss __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MissTimeType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MissSpecificType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Desc { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MissNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddExp { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string MissName { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FunctionID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathBaseId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShenWangZhanJiaPaintingMiss> CreateFB_ShenWangZhanJiaPaintingMiss(FlatBufferBuilder builder,
      int ID = 0,
      int MissTimeType = -1,
      int MissSpecificType = -1,
      StringOffset Desc = default(StringOffset),
      int MissNum = -1,
      int AddExp = -1,
      StringOffset MissName = default(StringOffset),
      int FunctionID = -1,
      int GetPathBaseId = -1) {
    builder.StartObject(9);
    FB_ShenWangZhanJiaPaintingMiss.AddGetPathBaseId(builder, GetPathBaseId);
    FB_ShenWangZhanJiaPaintingMiss.AddFunctionID(builder, FunctionID);
    FB_ShenWangZhanJiaPaintingMiss.AddMissName(builder, MissName);
    FB_ShenWangZhanJiaPaintingMiss.AddAddExp(builder, AddExp);
    FB_ShenWangZhanJiaPaintingMiss.AddMissNum(builder, MissNum);
    FB_ShenWangZhanJiaPaintingMiss.AddDesc(builder, Desc);
    FB_ShenWangZhanJiaPaintingMiss.AddMissSpecificType(builder, MissSpecificType);
    FB_ShenWangZhanJiaPaintingMiss.AddMissTimeType(builder, MissTimeType);
    FB_ShenWangZhanJiaPaintingMiss.AddID(builder, ID);
    return FB_ShenWangZhanJiaPaintingMiss.EndFB_ShenWangZhanJiaPaintingMiss(builder);
  }

  public static void StartFB_ShenWangZhanJiaPaintingMiss(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMissTimeType(FlatBufferBuilder builder, int MissTimeType) { builder.AddInt(1, MissTimeType, -1); }
  public static void AddMissSpecificType(FlatBufferBuilder builder, int MissSpecificType) { builder.AddInt(2, MissSpecificType, -1); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset DescOffset) { builder.AddOffset(3, DescOffset.Value, 0); }
  public static void AddMissNum(FlatBufferBuilder builder, int MissNum) { builder.AddInt(4, MissNum, -1); }
  public static void AddAddExp(FlatBufferBuilder builder, int AddExp) { builder.AddInt(5, AddExp, -1); }
  public static void AddMissName(FlatBufferBuilder builder, StringOffset MissNameOffset) { builder.AddOffset(6, MissNameOffset.Value, 0); }
  public static void AddFunctionID(FlatBufferBuilder builder, int FunctionID) { builder.AddInt(7, FunctionID, -1); }
  public static void AddGetPathBaseId(FlatBufferBuilder builder, int GetPathBaseId) { builder.AddInt(8, GetPathBaseId, -1); }
  public static Offset<FB_ShenWangZhanJiaPaintingMiss> EndFB_ShenWangZhanJiaPaintingMiss(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaPaintingMiss>(o);
  }
};

public sealed class FB_ShenWangZhanJiaPaintingMissContainer : Table {
  public static FB_ShenWangZhanJiaPaintingMissContainer GetRootAsFB_ShenWangZhanJiaPaintingMissContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaPaintingMissContainer(_bb, new FB_ShenWangZhanJiaPaintingMissContainer()); }
  public static FB_ShenWangZhanJiaPaintingMissContainer GetRootAsFB_ShenWangZhanJiaPaintingMissContainer(ByteBuffer _bb, FB_ShenWangZhanJiaPaintingMissContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaPaintingMissContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaPaintingMissContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaPaintingMiss GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaPaintingMiss(), j); }
  public FB_ShenWangZhanJiaPaintingMiss GetItems(FB_ShenWangZhanJiaPaintingMiss obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaPaintingMissContainer> CreateFB_ShenWangZhanJiaPaintingMissContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaPaintingMissContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaPaintingMissContainer.EndFB_ShenWangZhanJiaPaintingMissContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaPaintingMissContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaPaintingMiss>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaPaintingMissContainer> EndFB_ShenWangZhanJiaPaintingMissContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaPaintingMissContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaPaintingMissContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaPaintingMissContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
