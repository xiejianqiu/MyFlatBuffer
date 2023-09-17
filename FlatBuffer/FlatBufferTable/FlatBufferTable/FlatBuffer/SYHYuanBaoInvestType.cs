// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHYuanBaoInvestType : Table {
  public static FB_SYHYuanBaoInvestType GetRootAsFB_SYHYuanBaoInvestType(ByteBuffer _bb) { return GetRootAsFB_SYHYuanBaoInvestType(_bb, new FB_SYHYuanBaoInvestType()); }
  public static FB_SYHYuanBaoInvestType GetRootAsFB_SYHYuanBaoInvestType(ByteBuffer _bb, FB_SYHYuanBaoInvestType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHYuanBaoInvestType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyConsum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHYuanBaoInvestType> CreateFB_SYHYuanBaoInvestType(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyNum = -1,
      int MoneyConsum = -1,
      int Type = -1) {
    builder.StartObject(4);
    FB_SYHYuanBaoInvestType.AddType(builder, Type);
    FB_SYHYuanBaoInvestType.AddMoneyConsum(builder, MoneyConsum);
    FB_SYHYuanBaoInvestType.AddMoneyNum(builder, MoneyNum);
    FB_SYHYuanBaoInvestType.AddID(builder, ID);
    return FB_SYHYuanBaoInvestType.EndFB_SYHYuanBaoInvestType(builder);
  }

  public static void StartFB_SYHYuanBaoInvestType(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(1, MoneyNum, -1); }
  public static void AddMoneyConsum(FlatBufferBuilder builder, int MoneyConsum) { builder.AddInt(2, MoneyConsum, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static Offset<FB_SYHYuanBaoInvestType> EndFB_SYHYuanBaoInvestType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHYuanBaoInvestType>(o);
  }
};

public sealed class FB_SYHYuanBaoInvestTypeContainer : Table {
  public static FB_SYHYuanBaoInvestTypeContainer GetRootAsFB_SYHYuanBaoInvestTypeContainer(ByteBuffer _bb) { return GetRootAsFB_SYHYuanBaoInvestTypeContainer(_bb, new FB_SYHYuanBaoInvestTypeContainer()); }
  public static FB_SYHYuanBaoInvestTypeContainer GetRootAsFB_SYHYuanBaoInvestTypeContainer(ByteBuffer _bb, FB_SYHYuanBaoInvestTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHYuanBaoInvestTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHYuanBaoInvestTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHYuanBaoInvestType GetItems(int j) { return GetItems(new FB_SYHYuanBaoInvestType(), j); }
  public FB_SYHYuanBaoInvestType GetItems(FB_SYHYuanBaoInvestType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHYuanBaoInvestTypeContainer> CreateFB_SYHYuanBaoInvestTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHYuanBaoInvestTypeContainer.AddItems(builder, items);
    return FB_SYHYuanBaoInvestTypeContainer.EndFB_SYHYuanBaoInvestTypeContainer(builder);
  }

  public static void StartFB_SYHYuanBaoInvestTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHYuanBaoInvestType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHYuanBaoInvestTypeContainer> EndFB_SYHYuanBaoInvestTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHYuanBaoInvestTypeContainer>(o);
  }
  public static void FinishFB_SYHYuanBaoInvestTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHYuanBaoInvestTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
