// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BossInvestType : Table {
  public static FB_BossInvestType GetRootAsFB_BossInvestType(ByteBuffer _bb) { return GetRootAsFB_BossInvestType(_bb, new FB_BossInvestType()); }
  public static FB_BossInvestType GetRootAsFB_BossInvestType(ByteBuffer _bb, FB_BossInvestType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BossInvestType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyConsum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BossInvestType> CreateFB_BossInvestType(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyNum = -1,
      int MoneyConsum = -1,
      int Type = -1) {
    builder.StartObject(4);
    FB_BossInvestType.AddType(builder, Type);
    FB_BossInvestType.AddMoneyConsum(builder, MoneyConsum);
    FB_BossInvestType.AddMoneyNum(builder, MoneyNum);
    FB_BossInvestType.AddID(builder, ID);
    return FB_BossInvestType.EndFB_BossInvestType(builder);
  }

  public static void StartFB_BossInvestType(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(1, MoneyNum, -1); }
  public static void AddMoneyConsum(FlatBufferBuilder builder, int MoneyConsum) { builder.AddInt(2, MoneyConsum, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static Offset<FB_BossInvestType> EndFB_BossInvestType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BossInvestType>(o);
  }
};

public sealed class FB_BossInvestTypeContainer : Table {
  public static FB_BossInvestTypeContainer GetRootAsFB_BossInvestTypeContainer(ByteBuffer _bb) { return GetRootAsFB_BossInvestTypeContainer(_bb, new FB_BossInvestTypeContainer()); }
  public static FB_BossInvestTypeContainer GetRootAsFB_BossInvestTypeContainer(ByteBuffer _bb, FB_BossInvestTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BossInvestTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BossInvestTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BossInvestType GetItems(int j) { return GetItems(new FB_BossInvestType(), j); }
  public FB_BossInvestType GetItems(FB_BossInvestType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BossInvestTypeContainer> CreateFB_BossInvestTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BossInvestTypeContainer.AddItems(builder, items);
    return FB_BossInvestTypeContainer.EndFB_BossInvestTypeContainer(builder);
  }

  public static void StartFB_BossInvestTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BossInvestType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BossInvestTypeContainer> EndFB_BossInvestTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BossInvestTypeContainer>(o);
  }
  public static void FinishFB_BossInvestTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_BossInvestTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
