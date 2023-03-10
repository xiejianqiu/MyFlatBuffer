// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MergeTouZiType : Table {
  public static FB_MergeTouZiType GetRootAsFB_MergeTouZiType(ByteBuffer _bb) { return GetRootAsFB_MergeTouZiType(_bb, new FB_MergeTouZiType()); }
  public static FB_MergeTouZiType GetRootAsFB_MergeTouZiType(ByteBuffer _bb, FB_MergeTouZiType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MergeTouZiType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyConsum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MergeTouZiType> CreateFB_MergeTouZiType(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyNum = -1,
      int MoneyConsum = -1) {
    builder.StartObject(3);
    FB_MergeTouZiType.AddMoneyConsum(builder, MoneyConsum);
    FB_MergeTouZiType.AddMoneyNum(builder, MoneyNum);
    FB_MergeTouZiType.AddID(builder, ID);
    return FB_MergeTouZiType.EndFB_MergeTouZiType(builder);
  }

  public static void StartFB_MergeTouZiType(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(1, MoneyNum, -1); }
  public static void AddMoneyConsum(FlatBufferBuilder builder, int MoneyConsum) { builder.AddInt(2, MoneyConsum, -1); }
  public static Offset<FB_MergeTouZiType> EndFB_MergeTouZiType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MergeTouZiType>(o);
  }
};

public sealed class FB_MergeTouZiTypeContainer : Table {
  public static FB_MergeTouZiTypeContainer GetRootAsFB_MergeTouZiTypeContainer(ByteBuffer _bb) { return GetRootAsFB_MergeTouZiTypeContainer(_bb, new FB_MergeTouZiTypeContainer()); }
  public static FB_MergeTouZiTypeContainer GetRootAsFB_MergeTouZiTypeContainer(ByteBuffer _bb, FB_MergeTouZiTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MergeTouZiTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MergeTouZiTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MergeTouZiType GetItems(int j) { return GetItems(new FB_MergeTouZiType(), j); }
  public FB_MergeTouZiType GetItems(FB_MergeTouZiType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MergeTouZiTypeContainer> CreateFB_MergeTouZiTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MergeTouZiTypeContainer.AddItems(builder, items);
    return FB_MergeTouZiTypeContainer.EndFB_MergeTouZiTypeContainer(builder);
  }

  public static void StartFB_MergeTouZiTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MergeTouZiType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MergeTouZiTypeContainer> EndFB_MergeTouZiTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MergeTouZiTypeContainer>(o);
  }
  public static void FinishFB_MergeTouZiTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_MergeTouZiTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
