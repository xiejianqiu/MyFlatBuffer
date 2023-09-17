// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityBonus : Table {
  public static FB_ActivityBonus GetRootAsFB_ActivityBonus(ByteBuffer _bb) { return GetRootAsFB_ActivityBonus(_bb, new FB_ActivityBonus()); }
  public static FB_ActivityBonus GetRootAsFB_ActivityBonus(ByteBuffer _bb, FB_ActivityBonus obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityBonus __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long GetParamList(int j) { int o = __offset(6); return o != 0 ? bb.GetLong(__vector(o) + j * 8) : (long)0; }
  public int ParamListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityBonus> CreateFB_ActivityBonus(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ParamList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_ActivityBonus.AddParamList(builder, ParamList);
    FB_ActivityBonus.AddID(builder, ID);
    return FB_ActivityBonus.EndFB_ActivityBonus(builder);
  }

  public static void StartFB_ActivityBonus(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(1, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FB_ActivityBonus> EndFB_ActivityBonus(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityBonus>(o);
  }
};

public sealed class FB_ActivityBonusContainer : Table {
  public static FB_ActivityBonusContainer GetRootAsFB_ActivityBonusContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityBonusContainer(_bb, new FB_ActivityBonusContainer()); }
  public static FB_ActivityBonusContainer GetRootAsFB_ActivityBonusContainer(ByteBuffer _bb, FB_ActivityBonusContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityBonusContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityBonusContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityBonus GetItems(int j) { return GetItems(new FB_ActivityBonus(), j); }
  public FB_ActivityBonus GetItems(FB_ActivityBonus obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityBonusContainer> CreateFB_ActivityBonusContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityBonusContainer.AddItems(builder, items);
    return FB_ActivityBonusContainer.EndFB_ActivityBonusContainer(builder);
  }

  public static void StartFB_ActivityBonusContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityBonus>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityBonusContainer> EndFB_ActivityBonusContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityBonusContainer>(o);
  }
  public static void FinishFB_ActivityBonusContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityBonusContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
