// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RuneJieExp : Table {
  public static FB_RuneJieExp GetRootAsFB_RuneJieExp(ByteBuffer _bb) { return GetRootAsFB_RuneJieExp(_bb, new FB_RuneJieExp()); }
  public static FB_RuneJieExp GetRootAsFB_RuneJieExp(ByteBuffer _bb, FB_RuneJieExp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RuneJieExp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_RuneJieExp> CreateFB_RuneJieExp(FlatBufferBuilder builder,
      int ID = 0,
      int ItemNum = -1) {
    builder.StartObject(2);
    FB_RuneJieExp.AddItemNum(builder, ItemNum);
    FB_RuneJieExp.AddID(builder, ID);
    return FB_RuneJieExp.EndFB_RuneJieExp(builder);
  }

  public static void StartFB_RuneJieExp(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(1, ItemNum, -1); }
  public static Offset<FB_RuneJieExp> EndFB_RuneJieExp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RuneJieExp>(o);
  }
};

public sealed class FB_RuneJieExpContainer : Table {
  public static FB_RuneJieExpContainer GetRootAsFB_RuneJieExpContainer(ByteBuffer _bb) { return GetRootAsFB_RuneJieExpContainer(_bb, new FB_RuneJieExpContainer()); }
  public static FB_RuneJieExpContainer GetRootAsFB_RuneJieExpContainer(ByteBuffer _bb, FB_RuneJieExpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RuneJieExpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RuneJieExpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RuneJieExp GetItems(int j) { return GetItems(new FB_RuneJieExp(), j); }
  public FB_RuneJieExp GetItems(FB_RuneJieExp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RuneJieExpContainer> CreateFB_RuneJieExpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RuneJieExpContainer.AddItems(builder, items);
    return FB_RuneJieExpContainer.EndFB_RuneJieExpContainer(builder);
  }

  public static void StartFB_RuneJieExpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RuneJieExp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RuneJieExpContainer> EndFB_RuneJieExpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RuneJieExpContainer>(o);
  }
  public static void FinishFB_RuneJieExpContainerBuffer(FlatBufferBuilder builder, Offset<FB_RuneJieExpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
