// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ServerLevelExpExtra : Table {
  public static FB_ServerLevelExpExtra GetRootAsFB_ServerLevelExpExtra(ByteBuffer _bb) { return GetRootAsFB_ServerLevelExpExtra(_bb, new FB_ServerLevelExpExtra()); }
  public static FB_ServerLevelExpExtra GetRootAsFB_ServerLevelExpExtra(ByteBuffer _bb, FB_ServerLevelExpExtra obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ServerLevelExpExtra __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetServerLevelLimitList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ServerLevelLimitListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetExtarRateList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ExtarRateListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHuaShenServerLevelLimitList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HuaShenServerLevelLimitListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHuaShenExtarRateList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HuaShenExtarRateListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ServerLevelExpExtra> CreateFB_ServerLevelExpExtra(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ServerLevelLimitList = default(VectorOffset),
      VectorOffset ExtarRateList = default(VectorOffset),
      VectorOffset HuaShenServerLevelLimitList = default(VectorOffset),
      VectorOffset HuaShenExtarRateList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_ServerLevelExpExtra.AddHuaShenExtarRateList(builder, HuaShenExtarRateList);
    FB_ServerLevelExpExtra.AddHuaShenServerLevelLimitList(builder, HuaShenServerLevelLimitList);
    FB_ServerLevelExpExtra.AddExtarRateList(builder, ExtarRateList);
    FB_ServerLevelExpExtra.AddServerLevelLimitList(builder, ServerLevelLimitList);
    FB_ServerLevelExpExtra.AddID(builder, ID);
    return FB_ServerLevelExpExtra.EndFB_ServerLevelExpExtra(builder);
  }

  public static void StartFB_ServerLevelExpExtra(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddServerLevelLimitList(FlatBufferBuilder builder, VectorOffset ServerLevelLimitListOffset) { builder.AddOffset(1, ServerLevelLimitListOffset.Value, 0); }
  public static VectorOffset CreateServerLevelLimitListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartServerLevelLimitListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtarRateList(FlatBufferBuilder builder, VectorOffset ExtarRateListOffset) { builder.AddOffset(2, ExtarRateListOffset.Value, 0); }
  public static VectorOffset CreateExtarRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartExtarRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHuaShenServerLevelLimitList(FlatBufferBuilder builder, VectorOffset HuaShenServerLevelLimitListOffset) { builder.AddOffset(3, HuaShenServerLevelLimitListOffset.Value, 0); }
  public static VectorOffset CreateHuaShenServerLevelLimitListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHuaShenServerLevelLimitListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHuaShenExtarRateList(FlatBufferBuilder builder, VectorOffset HuaShenExtarRateListOffset) { builder.AddOffset(4, HuaShenExtarRateListOffset.Value, 0); }
  public static VectorOffset CreateHuaShenExtarRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHuaShenExtarRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ServerLevelExpExtra> EndFB_ServerLevelExpExtra(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ServerLevelExpExtra>(o);
  }
};

public sealed class FB_ServerLevelExpExtraContainer : Table {
  public static FB_ServerLevelExpExtraContainer GetRootAsFB_ServerLevelExpExtraContainer(ByteBuffer _bb) { return GetRootAsFB_ServerLevelExpExtraContainer(_bb, new FB_ServerLevelExpExtraContainer()); }
  public static FB_ServerLevelExpExtraContainer GetRootAsFB_ServerLevelExpExtraContainer(ByteBuffer _bb, FB_ServerLevelExpExtraContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ServerLevelExpExtraContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ServerLevelExpExtraContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ServerLevelExpExtra GetItems(int j) { return GetItems(new FB_ServerLevelExpExtra(), j); }
  public FB_ServerLevelExpExtra GetItems(FB_ServerLevelExpExtra obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ServerLevelExpExtraContainer> CreateFB_ServerLevelExpExtraContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ServerLevelExpExtraContainer.AddItems(builder, items);
    return FB_ServerLevelExpExtraContainer.EndFB_ServerLevelExpExtraContainer(builder);
  }

  public static void StartFB_ServerLevelExpExtraContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ServerLevelExpExtra>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ServerLevelExpExtraContainer> EndFB_ServerLevelExpExtraContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ServerLevelExpExtraContainer>(o);
  }
  public static void FinishFB_ServerLevelExpExtraContainerBuffer(FlatBufferBuilder builder, Offset<FB_ServerLevelExpExtraContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
