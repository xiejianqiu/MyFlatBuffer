// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryWuNvBase : Table {
  public static FB_MarryWuNvBase GetRootAsFB_MarryWuNvBase(ByteBuffer _bb) { return GetRootAsFB_MarryWuNvBase(_bb, new FB_MarryWuNvBase()); }
  public static FB_MarryWuNvBase GetRootAsFB_MarryWuNvBase(ByteBuffer _bb, FB_MarryWuNvBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryWuNvBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Value { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Num { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_MarryWuNvBase> CreateFB_MarryWuNvBase(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyType = 0,
      int MoneyNum = 0,
      int value = 0,
      int Num = 0) {
    builder.StartObject(5);
    FB_MarryWuNvBase.AddNum(builder, Num);
    FB_MarryWuNvBase.AddValue(builder, value);
    FB_MarryWuNvBase.AddMoneyNum(builder, MoneyNum);
    FB_MarryWuNvBase.AddMoneyType(builder, MoneyType);
    FB_MarryWuNvBase.AddID(builder, ID);
    return FB_MarryWuNvBase.EndFB_MarryWuNvBase(builder);
  }

  public static void StartFB_MarryWuNvBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, 0); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(2, MoneyNum, 0); }
  public static void AddValue(FlatBufferBuilder builder, int value) { builder.AddInt(3, value, 0); }
  public static void AddNum(FlatBufferBuilder builder, int Num) { builder.AddInt(4, Num, 0); }
  public static Offset<FB_MarryWuNvBase> EndFB_MarryWuNvBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryWuNvBase>(o);
  }
};

public sealed class FB_MarryWuNvBaseContainer : Table {
  public static FB_MarryWuNvBaseContainer GetRootAsFB_MarryWuNvBaseContainer(ByteBuffer _bb) { return GetRootAsFB_MarryWuNvBaseContainer(_bb, new FB_MarryWuNvBaseContainer()); }
  public static FB_MarryWuNvBaseContainer GetRootAsFB_MarryWuNvBaseContainer(ByteBuffer _bb, FB_MarryWuNvBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryWuNvBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryWuNvBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryWuNvBase GetItems(int j) { return GetItems(new FB_MarryWuNvBase(), j); }
  public FB_MarryWuNvBase GetItems(FB_MarryWuNvBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryWuNvBaseContainer> CreateFB_MarryWuNvBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryWuNvBaseContainer.AddItems(builder, items);
    return FB_MarryWuNvBaseContainer.EndFB_MarryWuNvBaseContainer(builder);
  }

  public static void StartFB_MarryWuNvBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryWuNvBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryWuNvBaseContainer> EndFB_MarryWuNvBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryWuNvBaseContainer>(o);
  }
  public static void FinishFB_MarryWuNvBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryWuNvBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
